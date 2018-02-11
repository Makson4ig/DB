using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using Dapper;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.IO;
using System.Data.SqlClient;

namespace База_данных_на_WinwdowsForm
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fMain());
        }
     
    }
}
