using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PP_Z10_WinForms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string info(DirectoryInfo directory, FileInfo K1_file1, FileInfo K1_file2, FileInfo K2_file1)
        {
            string rez1 = "";
            rez1 += "4.(8.) Директория " + "'" + directory.Name + "'\n";
            rez1 += $"       Полный путь к файлу/каталогу: {directory.FullName}\n" +
                                $"       Имя файла/каталога: {directory.Name}\n" +
                                $"       Корневой каталог: {directory.Root}\n" +
                                $"       Время создания файла/каталога: {directory.CreationTime}\n" +
                                $"       Ассоциативный атрибут: {directory.Attributes}\n" + "\n";
            rez1 += "       Файл 't1.txt'\n";
            rez1 += $"       Полный путь к файлу/каталогу: {K1_file1.FullName}\n" +
                                $"       Имя файла/каталога: {K1_file1.Name}\n" +
                                $"       Расширение файла:{K1_file1.Extension}\n" +
                                $"       Время создания файла/каталога: {K1_file1.CreationTime}\n" +
                                $"       Ассоциативный атрибут: {K1_file1.Attributes}\n" + "\n";
            rez1 += "       Файл 't2.txt'\n";
            rez1 += $"       Полный путь к файлу/каталогу: {K1_file2.FullName}\n" +
                                $"       Имя файла/каталога: {K1_file2.Name}\n" +
                                $"       Расширение файла:{K1_file2.Extension}\n" +
                                $"       Время создания файла/каталога: {K1_file2.CreationTime}\n" +
                                $"       Ассоциативный атрибут: {K1_file2.Attributes}\n" + "\n";
            rez1 += "       Файл 't3.txt'\n";
            rez1 += $"       Полный путь к файлу/каталогу: {K2_file1.FullName}\n" +
                                $"       Имя файла/каталога: {K2_file1.Name}\n" +
                                $"       Расширение файла:{K2_file1.Extension}\n" +
                                $"       Время создания файла/каталога: {K2_file1.CreationTime}\n" +
                                $"       Ассоциативный атрибут: {K2_file1.Attributes}\n" + "\n";
            return rez1;
        }

        private void Result_Click(object sender, EventArgs e)
        {
            string rez = "";
            DirectoryInfo directory = new DirectoryInfo(@"C:\temp");
            directory.Create();
            rez += "       Папка 'temp' создана\n" + "\n";
            directory.CreateSubdirectory("K1");
            rez += "  1.   Папка 'K1' создана\n";
            directory.CreateSubdirectory("K2");
            rez += "       Папка 'K2' создана\n" + "\n";
            FileInfo K1_file1 = new FileInfo(@"C:\temp\K1\t1.txt");
            rez += "  2.a) Файл 't1.txt' создан\n";
            using (StreamWriter sw = K1_file1.CreateText())
            {
                sw.WriteLine("Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
            }
            rez += "       Строка записала в файл 't1.txt'\n" + "\n";
            FileInfo K1_file2 = new FileInfo(@"C:\temp\K1\t2.txt");
            rez += "  2.b) Файл 't2.txt' создан\n";
            using (StreamWriter sw = K1_file2.CreateText())
            {
                sw.WriteLine("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
            }
            rez += "       Строка записана в файл 't2.txt'\n" + "\n";
            FileInfo K2_file1 = new FileInfo(@"C:\temp\K2\t3.txt");
            rez += "  3.   Файл 't3.txt' создан\n";
            string str = "", str2 = "";
            using (StreamReader sr = K1_file1.OpenText())
            {
                var s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    str += s;
                }
            }
            using (StreamReader sr = K1_file2.OpenText())
            {
                var s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    str2 += s;
                }
            }
            using (StreamWriter sw = K2_file1.CreateText())
            {
                sw.WriteLine(str + "\n" + str2);
            }
            rez += "       Строки записаны в файл 't3.txt'\n" + "\n";
            info(directory, K1_file1, K1_file2, K2_file1);
            string rez2 = "";
            try
            {

                File.Move(@"C:\temp\K1\t2.txt", @"C:\temp\K2\t2.txt");
                rez2 += "  5.   Файл 't2.txt' перенесён в папку 'K2'\n" + "\n";
                K1_file1.CopyTo(@"C:\temp\K2\t1.txt");
                rez2 += "  6.   Файл 't1.txt' скопирован в папку 'K2'\n" + "\n";
                Directory.Move(@"C:\temp\K2", @"C:\temp\All");
                rez2 += "  7.   Папка 'K2' переименована в 'All'\n";
                Directory.Delete(@"C:\temp\K1", true);
                rez2 += "       Папка 'K1' удалена\n" + "\n";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            DirectoryInfo AllDirectory = new DirectoryInfo(@"C:\temp\All");
            info(AllDirectory, K1_file1, K1_file2, K2_file1);
            information.Text = rez.ToString()+info(directory, K1_file1, K1_file2, K2_file1).ToString()+rez2.ToString()+ info(AllDirectory, K1_file1, K1_file2, K2_file1).ToString();
        }
    }
}
