using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Dapper;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.IO;
using System.Data.SqlClient;
namespace ConsoleApp1
{

    public class TEST
    {
        static void Min()
        {
            Compound();
            Queries();
        }

        public static void Compound()
        {
            int i = 1;
            Console.Write("Число БД слияния:");
            int counter = Console.Read();
            Console.ReadLine();

            do
            {
                string provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
                Console.Write("Введите Ссылку на БД откуда брать:");
                string OUT = Console.ReadLine();
                if (OUT == "GO")
                {
                    break;
                }
                else
                {
                    using (var ConnectOUT = new OleDbConnection(provider + OUT))
                    {
                        Console.Write("Введите Ссылку на итоговую БД:");
                        string IN = Console.ReadLine();
                        using (var ConnectIN = new OleDbConnection(provider + IN))
                        {
                            ConnectIN.Execute(@"INSERT INTO [" + IN + "].dbDou(DBPath,id,image_path,F1) " + "SELECT '" + OUT + "',id,fip,F1 FROM [" + OUT + "].main where F1 <> '' and F1 is not NULL");
                            Console.WriteLine("№ - {0}", i);
                            OUT = null;
                        }
                    }
                    i++;
                }
            }
            while (i == counter);
        }
        public static void Queries()
        {
            string provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
            Console.WriteLine("Выполение Запросов");
            Console.Write("Введите Ссылку на итоговую БД:");
            string IN_Z = Console.ReadLine();

            using (var ConnectIN_Z = new OleDbConnection(provider + IN_Z))
            {
                ConnectIN_Z.Execute(@"update dbDOU set dir_path = left(image_path,INSTRREV(Image_path,'\')-1)");
                //Console.WriteLine("Dirpath");

                //ConnectIN_Z.Execute(@"update dbDOU set deal = right(dir_path,len(dir_path)-INSTRREV(dir_path,'\'))");
                //Console.WriteLine("Deal");

                //ConnectIN_Z.Execute(@"update dbDOU set Transfer = left(right(dir_path,len(dir_path)-INSTRREV(dir_path,'Передача')+1),INSTRREV(right(dir_path,len(dir_path)-INSTRREV(dir_path,'Передача')+1),'\')-1)");
                //Console.WriteLine("Transfer");

                //ConnectIN_Z.Execute(@"update dbDOU set [Image] = right(image_path,len(image_path)-INSTRREV(image_path,'\'))");
                //Console.WriteLine("image");


                

                //ConnectIN_Z.Execute(@"update dbDOU set f_path = left(f_path,INSTRREV(f_path,'\')-1)");
                //Console.WriteLine("f_path");

                //ConnectIN_Z.Execute(@" INSERT INTO tmp SELECT distinct dir_path,f_path,ROB,size,check from dbDOU");
                //Console.WriteLine("TMP");

                ConnectIN_Z.Open();
                var Check = ConnectIN_Z.Query<String>(@"select [dir_path],[check],[Код] from [TMP]");

                foreach (string e in Check)
                {
                    string s = @"Update [TMP] set [check] = " + CheckFolders(e) + " where Код = '" + e + "'";
                    ConnectIN_Z.Execute(@"Update [TMP] set [check] = " + CheckFolders(e) + " where [check] код '" + e + "'");
                }
                ConnectIN_Z.Close();
                Console.WriteLine("Check");

                //ConnectIN_Z.Open();
                //var size = ConnectIN_Z.Query<string>(@"select [dir_path],[size] from [TMP]");
                //{
                //    foreach(string siz in size)
                //    {
                //        ConnectIN_Z.Execute(@"update [TMP] set  [size] =" +GetFoldersSize(siz)+ " where [size] is null");
                //    }
                //}
                //ConnectIN_Z.Close();
                ////ConnectIN_Z.Execute(@"UPDATE TMP SET ROB = ROBOCOPY(dir_path,f_path,image)");
                //     //ROB

            }
            Console.WriteLine("Готово");
            Console.ReadKey();
        }

        public static string GetPathFromF1(string f1)
        {
            string Pattern = @"src="".+?""";
            string res;
            Regex regEx = new Regex(Pattern);
            Match rez = Regex.Match(f1, Pattern);
            res = rez.Value;
            res = Regex.Replace(Regex.Replace(Regex.Replace(res, @"src=", @""), @"""", @""), @"/", @"\");
            return res;
        }
        public static bool CheckFolders(string path)
        {
            bool result = Directory.Exists(path);
            return result;
        }

        public static long GetFoldersSize(string directory)
        {
            directory += "\\";
            long res = 0;
            foreach (string file in Directory.GetFiles(directory, "*", SearchOption.AllDirectories))
            {
                FileInfo f = new FileInfo(file);
                res += f.Length;
            }
            return res;
        }
    }
}

