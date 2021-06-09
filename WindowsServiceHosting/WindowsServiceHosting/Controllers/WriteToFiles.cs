using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceHosting.Controllers
{
    class WriteToFiles
    {
        public void WriteToFile(string Message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string file = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\"+DateTime.Today.ToShortDateString().Replace('/','_');
            if (!Directory.Exists(file))
            {
                Directory.CreateDirectory(file);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\"+DateTime.Today.ToShortDateString().Replace('/', '_') + "\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + "_Detail.txt";
            if (!File.Exists(filepath))
            {
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
        }
        public void Control(string Message, int temp, int add, int update, int error)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string file = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\" + DateTime.Today.ToShortDateString().Replace('/', '_');
            if (!Directory.Exists(file))
            {
                Directory.CreateDirectory(file);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\" + DateTime.Today.ToShortDateString().Replace('/', '_') + "\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + "_Control.txt";
            if (!File.Exists(filepath))
            {
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(Message + " Toplam Sayı: " + temp + " Güncellenen Sayısı: " + update + " Eklenen sayısı: " + add + " Hata Sayısı: " + error);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(Message + " Toplam Sayı: " + temp + " Güncellenen Sayısı: " + update + " Eklenen sayısı: " + add + " Hata Sayısı: " + error);
                }
            }
        }

        public void Error(string Message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string file = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\" + DateTime.Today.ToShortDateString().Replace('/', '_');
            if (!Directory.Exists(file))
            {
                Directory.CreateDirectory(file);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\" + DateTime.Today.ToShortDateString().Replace('/', '_') + "\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + "_Error.txt";
            if (!File.Exists(filepath))
            {
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
        }

        public void Success()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string file = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\" + DateTime.Today.ToShortDateString().Replace('/', '_');
            if (!Directory.Exists(file))
            {
                Directory.CreateDirectory(file);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\" + DateTime.Today.ToShortDateString().Replace('/', '_') + "\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + "_Control.txt";
            if (!File.Exists(filepath))
            {
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine("Güncellenme başarılı bir şekilde tamamlandı     "+DateTime.Now);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine("Güncellenme başarılı bir şekilde tamamlandı     " + DateTime.Now);
                }
            }
        }


    }


}
