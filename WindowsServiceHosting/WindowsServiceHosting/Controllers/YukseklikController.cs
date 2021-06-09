using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;

namespace WindowsServiceHosting.Controllers
{
    public class YukseklikController
    {

        WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();
        public void GetYukseklik(DateTime dateTime)
        {
            List<Models.test3.Yukseklik> yuksekliks = testDB.Yukseklik.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi>dateTime).ToList();
            writeToFiles.WriteToFile("Yukseklik Atılıyor Toplam Sayı: " + yuksekliks.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in yuksekliks)
            {
                try
                {
                    if (webDB.Yukseklik.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.Yukseklik yukseklik = webDB.Yukseklik.Where(x => x.Oid == item.Oid).FirstOrDefault();
                        yukseklik.Web = item.Web;
                        //Aksesuar = item.Aksesuar;
                        yukseklik.Gcrecord = item.Gcrecord;
                        yukseklik.Oid = item.Oid;
                        yukseklik.OptimisticLockField = item.OptimisticLockField;
                        yukseklik.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        //Urunler = item.Urunler;
                        yukseklik.Yuksek = item.Yuksek;
                        webDB.Yukseklik.Update(yukseklik);
                        writeToFiles.WriteToFile("Yukseklik Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.Yukseklik yukseklik = new Models.LandeWeb.Yukseklik();
                        yukseklik.Web = item.Web;
                        //Aksesuar = item.Aksesuar;
                        yukseklik.Gcrecord = item.Gcrecord;
                        yukseklik.Oid = item.Oid;
                        yukseklik.OptimisticLockField = item.OptimisticLockField;
                        yukseklik.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        //Urunler = item.Urunler;
                        yukseklik.Yuksek = item.Yuksek;
                        webDB.Yukseklik.Add(yukseklik);
                        writeToFiles.WriteToFile("Yukseklik Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("Yukseklik Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("Yukseklik Successfull", yuksekliks.Count, add, update, error);
        }
    }

}
