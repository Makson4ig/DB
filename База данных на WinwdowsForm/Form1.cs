using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.OleDb;
using System.IO;

namespace База_данных_на_WinwdowsForm
{
    public partial class fMain : Form  
    {
        private string provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";

        fParam fp = new fParam();
        ClassCOPY LinkCopyClass = new ClassCOPY();
        public fMain()
        {
            InitializeComponent();
        }

        private void Performance_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ConnectOUT = new OleDbConnection(provider + fp.FileName_OUT))
                {
                    using (var ConnectIN = new OleDbConnection(provider + fp.FileName_IN))
                    {
                        ConnectIN.Execute(@"INSERT INTO [" + fp.FileName_OUT + "].dbDou(DBPath,id,image_path,F1) " + "SELECT '" + fp.FileName_IN + "',id,fip,F1 FROM [" + fp.FileName_IN + "].main where F1 <> '' and F1 is not NULL");
                        MessageBox.Show("Выполнено");
                    }
                }
            }
            catch (Exception)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                string message = "Добавьте ссылку на БД IN или OUT или ошибка в запросе!", caption = "Ссылка";
                MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Error);
            }
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            fp.ShowDialog();
        }

        private void BtnCOPY_Click(object sender, EventArgs e)
        {
            try
            {
                var dirs = File.ReadAllLines(fp.FileName_TXT, Encoding.GetEncoding(Properties.Settings.Default.EncodeCode));
                foreach (var dir in dirs)
                {
                    try
                    {
                        var dirArr = dir.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                        LinkCopyClass.WriteLog("Копирование " + dirArr[0] + " --> " + dirArr[1]);
                        if (Path.GetExtension(dirArr[0]) != "" || Path.GetExtension(dirArr[1]) != "")
                        {
                            LinkCopyClass.CopyFile(dirArr[0], dirArr[1]);
                        }
                        else
                        {
                            LinkCopyClass.DirectoryCopy(dirArr[0], dirArr[1], true);
                        }
                    }
                    catch (Exception ex)
                    {
                        LinkCopyClass.WriteLog(ex.ToString());
                    }
                }

            }
            catch (Exception)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                string message = "Добавьте ссылку на Файл копирования", caption = "Ссылка";
                MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExecuteQueries_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ConnectOUT = new OleDbConnection(provider + fp.FileName_OUT))
                {
                    ConnectOUT.Execute(@"update dbDOU set dir_path = left(image_path,INSTRREV(Image_path,'\')-1)");
                    if (fp.CounterChk[0] == true)
                    {

                        ConnectOUT.Execute(@"update dbDOU set deal = right(dir_path,len(dir_path)-INSTRREV(dir_path,'\'))"); // ОШИБКИ!!! С ЗАПИСЬЮ В НЕ ПУСТУЮ СТРОКУ В БД
                        MessageBox.Show("Запрос DEAL Выполнен");

                    } //Deal
                    if (fp.CounterChk[1] == true)
                    {
                        ConnectOUT.Execute(@"update dbDOU set [Image] = right(image_path,len(image_path)-INSTRREV(image_path,'\'))");
                        MessageBox.Show("Запрос IMAGE Выполнен");

                    } //Image
                    if (fp.CounterChk[2] == true)
                    {

                        ConnectOUT.Open();
                        var F1 = ConnectOUT.Query<String>("select f1 from [dbDOU]");
                        foreach (string elements in F1)
                        {
                            if (elements != null)
                            {
                                break;
                                MessageBox.Show("Поле F_Path заполнено");
                            }
                            else
                            {
                                ConnectOUT.Execute(@"Update [dbDOU] set f_path = '" + ClassFunction.GetPathFromF1(elements) + "' where  f1 = '" + elements + "'");
                            }
                        }
                        ConnectOUT.Close();
                        MessageBox.Show("Запрос F_PATH Выполнен");

                    } //F_path
                    if (fp.CounterChk[3] == true)
                    {
                        ConnectOUT.Execute(@"update dbDOU set Transfer = left(right(dir_path,len(dir_path)-INSTRREV(dir_path,'Передача')+1),INSTRREV(right(dir_path,len(dir_path)-INSTRREV(dir_path,'Передача')+1),'\')-1)");
                        MessageBox.Show("Запрос TRANSFER Выполнен");

                    } //Transfer

                }
            }
            catch (Exception)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                string message = "Добавьте ссылку на БД OUT", caption = "Ссылка";
                MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Error);
            }
           
        }
  
    }
}
