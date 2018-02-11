using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Dapper;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.IO;
using System.Data.SqlClient;

namespace База_данных_на_WinwdowsForm
{
    class ClassFunction
    {
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