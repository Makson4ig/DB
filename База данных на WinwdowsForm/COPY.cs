using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace COPY
{
    class Program
    {
        static readonly string _logPath = Properties.Settings.Default.LogPath;

        static void Maain(string[] args)
        {
            var dirs = File.ReadAllLines(Properties.Settings.Default.FilePathes, Encoding.GetEncoding(Properties.Settings.Default.EncodeCode));
            foreach (var dir in dirs)
            {
                try
                {
                    var dirArr = dir.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    WriteLog("Копирование " + dirArr[0] + " --> " + dirArr[1]);
                    if (Path.GetExtension(dirArr[0])!=""|| Path.GetExtension(dirArr[1]) != "")
                    {
                        CopyFile(dirArr[0], dirArr[1]);
                    }
                    else
                    {
                        DirectoryCopy(dirArr[0], dirArr[1], true);
                    }
                }
                catch (Exception ex)
                {
                    WriteLog(ex.ToString());
                }
            }
        }

        static void WriteLog(string message)
        {
            Console.WriteLine(message);
            try
            {
                File.AppendAllText(_logPath, "\n" + DateTime.Now + ": " + message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        static void CopyFile(string srcFilePath,string dstFilePath)
        {
            if (Path.GetExtension(srcFilePath) == "" || Path.GetExtension(dstFilePath) == "")
            {
                throw new IOException($"Один из путей не имеет расширения : {srcFilePath} -> {dstFilePath}");
            }
            else
            {
                if (!File.Exists(dstFilePath))
                {
                    var targetDir = Path.GetDirectoryName(dstFilePath);
                    if (!Directory.Exists(targetDir))
                    {
                        Directory.CreateDirectory(targetDir);
                    }
                    File.Copy(srcFilePath, dstFilePath, false);
                }
                else
                {
                    WriteLog("ФАЙЛ УЖЕ СУЩЕСТВУЕТ: " + dstFilePath);
                }
            }
        }
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
 
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // Если целевой каталог не существует, создайте его.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Получить файлы в каталоге и скопировать их в новое место
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                if (!File.Exists(temppath))
                {
                    try
                    {
                        file.CopyTo(temppath, false);
                        Console.WriteLine("Копирую " + temppath);
                    }
                    catch (Exception ex)
                    {
                        WriteLog(ex.ToString());
                    }
                }
                else
                {
                    WriteLog("ФАЙЛ УЖЕ СУЩЕСТВУЕТ: " + temppath);
                }
            }

            // Если вы копируете подкаталоги, скопируйте их и их содержимое в новое место.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
    }
}
