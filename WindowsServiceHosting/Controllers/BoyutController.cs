using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;
namespace WindowsServiceHosting.Controllers
{
    public class BoyutController
    {
        WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();
        public void GetBoyut(DateTime dateTime)
        {
            List<Models.test3.Boyut> boyuts = testDB.Boyut.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
            writeToFiles.WriteToFile("Boyut Atılıyor Toplam Sayı: " + boyuts.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in boyuts)
            {
                try
                {
                    if (webDB.Boyut.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.Boyut boyut = webDB.Boyut.Where(x => x.Oid == item.Oid ).FirstOrDefault();

                        //boyut.Aksesuar = item.Aksesuar;
                        boyut.Derinlik = item.Derinlik;
                        boyut.Gcrecord = item.Gcrecord;
                        boyut.Genislik = item.Genislik;
                        boyut.Oid = item.Oid;
                        boyut.OptimisticLockField = item.OptimisticLockField;
                        boyut.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        //boyut.Urunler = item.Urunler;
                        boyut.Web = item.Web;
                        webDB.Boyut.Update(boyut);
                        writeToFiles.WriteToFile("Boyut Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.Boyut boyut = new Models.LandeWeb.Boyut();
                        //boyut.Aksesuar = item.Aksesuar;
                        boyut.Derinlik = item.Derinlik;
                        boyut.Gcrecord = item.Gcrecord;
                        boyut.Genislik = item.Genislik;
                        boyut.Oid = item.Oid;
                        boyut.OptimisticLockField = item.OptimisticLockField;
                        boyut.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        //boyut.Urunler = item.Urunler;
                        boyut.Web = item.Web;
                        webDB.Boyut.Add(boyut);
                        writeToFiles.WriteToFile("Boyut Eklendi    "+item.Oid);
                        add++;
                    }
                }
                catch (Exception e)
                {
                    writeToFiles.WriteToFile("Hata: " + " Oid: " + item.Oid + "  " + e.Message.ToString());
                    writeToFiles.Error(e.Message.ToString());

                    error++;
                }
                webDB.SaveChanges();
            }
            writeToFiles.WriteToFile("Boyut Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("Boyut Successfull", boyuts.Count, add, update, error);
        }
    }
}
