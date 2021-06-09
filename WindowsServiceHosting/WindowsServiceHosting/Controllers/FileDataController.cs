using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;

namespace WindowsServiceHosting.Controllers
{
    public class FileDataController
    {
        WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();
        public void GetFileData(DateTime dateTime)
        {
            List<Models.test3.FileData> fileDatas = testDB.FileData.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi>dateTime).ToList();
            writeToFiles.WriteToFile("Toplam Sayı: " + fileDatas.Count);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in fileDatas)
            {
                try
                {
                    if (webDB.FileData.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.FileData fileData = webDB.FileData.Where(x => x.Oid == item.Oid).FirstOrDefault();
                        fileData.Content = item.Content;
                        fileData.FileName = item.FileName;
                        fileData.Gcrecord = item.Gcrecord;
                        fileData.Oid = item.Oid;
                        fileData.OptimisticLockField = item.OptimisticLockField;
                        fileData.Size = item.Size;
                        webDB.FileData.Update(fileData);
                        writeToFiles.WriteToFile("File Data Başarıyla Güncellendi    "+item.Oid);
                        update++;

                    }
                    else
                    {
                        Models.LandeWeb.FileData fileData = new Models.LandeWeb.FileData();
                        fileData.Content = item.Content;
                        fileData.FileName = item.FileName;
                        fileData.Gcrecord = item.Gcrecord;
                        fileData.Oid = item.Oid;
                        fileData.OptimisticLockField = item.OptimisticLockField;
                        fileData.Size = item.Size;
                        webDB.FileData.Add(fileData);
                        writeToFiles.WriteToFile("File Data Başarıyla Eklendi    "+item.Oid);
                        add++;
                    }
                }
                catch (Exception e)
                {
                    writeToFiles.WriteToFile("Hata: " + e.Message.ToString());
                    writeToFiles.Error(e.Message.ToString());
                    error++;
                }
                    webDB.SaveChanges();
            }
            writeToFiles.WriteToFile("File Data Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("DigerDokumanlar Successfull", fileDatas.Count, add, update, error);
        }


    }
}
