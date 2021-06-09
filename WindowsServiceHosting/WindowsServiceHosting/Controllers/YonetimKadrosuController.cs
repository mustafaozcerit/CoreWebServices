using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;
namespace WindowsServiceHosting.Controllers
{
    public class YonetimKadrosuController
    {



        WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();

        public void GetYonetimKadrosu(DateTime dateTime)
        {
            List<Models.test3.YonetimKadrosu> yonetimKadrosus = testDB.YonetimKadrosu.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi>dateTime).ToList();
            writeToFiles.WriteToFile("YonetimKadrosu Atılıyor Toplam Sayı: " + yonetimKadrosus.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in yonetimKadrosus)
            {
                try
                {
                    if (webDB.YonetimKadrosu.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.YonetimKadrosu yonetimKadrosu = webDB.YonetimKadrosu.Where(x => x.Oid == item.Oid).FirstOrDefault();
                        yonetimKadrosu.Adi = item.Adi;
                        yonetimKadrosu.Fotograf = item.Fotograf;
                        yonetimKadrosu.Gcrecord = item.Gcrecord;
                        yonetimKadrosu.Görevi = item.Görevi;
                        yonetimKadrosu.GöreviEng = item.GöreviEng;
                        yonetimKadrosu.Hakkimizda = item.Hakkimizda;
                        //yonetimKadrosu.HakkimizdaNavigation=item.HakkimizdaNavigation;
                        yonetimKadrosu.Index = item.Index;
                        yonetimKadrosu.Oid = item.Oid;
                        yonetimKadrosu.OptimisticLockField = item.OptimisticLockField;
                        yonetimKadrosu.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        webDB.YonetimKadrosu.Update(yonetimKadrosu);
                        writeToFiles.WriteToFile("YonetimKadrosu Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.YonetimKadrosu yonetimKadrosu = new Models.LandeWeb.YonetimKadrosu();
                        yonetimKadrosu.Adi = item.Adi;
                        yonetimKadrosu.Fotograf = item.Fotograf;
                        yonetimKadrosu.Gcrecord = item.Gcrecord;
                        yonetimKadrosu.Görevi = item.Görevi;
                        yonetimKadrosu.GöreviEng = item.GöreviEng;
                        yonetimKadrosu.Hakkimizda = item.Hakkimizda;
                        //yonetimKadrosu.HakkimizdaNavigation=item.HakkimizdaNavigation;
                        yonetimKadrosu.Index = item.Index;
                        yonetimKadrosu.Oid = item.Oid;
                        yonetimKadrosu.OptimisticLockField = item.OptimisticLockField;
                        yonetimKadrosu.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        webDB.YonetimKadrosu.Add(yonetimKadrosu);
                        writeToFiles.WriteToFile("YonetimKadrosu Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("YonetimKadrosu Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("YonetimKadrosu Successfull", yonetimKadrosus.Count, add, update, error);
        }
    }
}
