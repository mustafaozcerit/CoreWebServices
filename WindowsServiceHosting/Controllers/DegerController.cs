using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;
namespace WindowsServiceHosting.Controllers
{
    public class DegerController
    {

        WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();
        public void GetDegerTipleri(DateTime dateTime)
        {
            List<Models.test3.DegerTipleri> degerTipleris = testDB.DegerTipleri.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
            writeToFiles.WriteToFile("DegerTipleri Atılıyor Toplam Sayı: " + degerTipleris.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in degerTipleris)
            {
                try
                {
                    if (webDB.DegerTipleri.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.DegerTipleri degerTipleri = webDB.DegerTipleri.Where(x => x.Oid == item.Oid ).FirstOrDefault();
                        degerTipleri.DegerTipi = item.DegerTipi;
                        degerTipleri.EngDegerTipi = item.EngDegerTipi;
                        degerTipleri.EngWeb = item.EngWeb;
                        degerTipleri.Gcrecord = item.Gcrecord;
                        degerTipleri.Oid = item.Oid;
                        degerTipleri.OlusturanKisi = item.OlusturanKisi;
                        degerTipleri.OlusturmaTarihi = item.OlusturmaTarihi;
                        degerTipleri.OptimisticLockField = item.OptimisticLockField;
                        degerTipleri.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        degerTipleri.Web = item.Web;
                        webDB.DegerTipleri.Update(degerTipleri);
                        writeToFiles.WriteToFile("DegerTipleri Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.DegerTipleri degerTipleri = new Models.LandeWeb.DegerTipleri();
                        degerTipleri.DegerTipi = item.DegerTipi;
                        degerTipleri.EngDegerTipi = item.EngDegerTipi;
                        degerTipleri.EngWeb = item.EngWeb;
                        degerTipleri.Gcrecord = item.Gcrecord;
                        degerTipleri.Oid = item.Oid;
                        degerTipleri.OlusturanKisi = item.OlusturanKisi;
                        degerTipleri.OlusturmaTarihi = item.OlusturmaTarihi;
                        degerTipleri.OptimisticLockField = item.OptimisticLockField;
                        degerTipleri.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        degerTipleri.Web = item.Web;
                        webDB.DegerTipleri.Add(degerTipleri);
                        writeToFiles.WriteToFile("DegerTipleri Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("DegerTipleri Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("DegerTipleri Successfull", degerTipleris.Count, add, update, error);
        }


        public void GetDegerler(DateTime dateTime)
        {
            List<Models.test3.Degerler> degerlers = testDB.Degerler.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
            writeToFiles.WriteToFile("Degerler Atılıyor Toplam Sayı: " + degerlers.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in degerlers)
            {
                try
                {
                    if (webDB.Degerler.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.Degerler degerler = webDB.Degerler.Where(x => x.Oid == item.Oid ).FirstOrDefault();

                        //degerler.AksesuarDeger = item.AksesuarDeger;
                        degerler.Deger = item.Deger;
                        degerler.DegerAdi = item.DegerAdi;
                        degerler.DegerTipi = item.DegerTipi;
                        //degerler.DegerTipiNavigation = item.DegerTipiNavigation;
                        degerler.EngDegerAdi = item.EngDegerAdi;
                        degerler.EngWeb = item.EngWeb;
                        degerler.Gcrecord = item.Gcrecord;
                        degerler.Oid = item.Oid;
                        degerler.OlusturanKisi = item.OlusturanKisi;
                        degerler.OlusturmaTarihi = item.OlusturmaTarihi;
                        degerler.OptimisticLockField = item.OptimisticLockField;
                        degerler.Ozellikler = item.Ozellikler;
                        //degerler.OzelliklerNavigation = item.OzelliklerNavigation;
                        degerler.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        //degerler.UrunDegerler = item.UrunDegerler;
                        degerler.Urunler = item.Urunler;
                        //degerler.UrunlerNavigation = item.UrunlerNavigation;
                        degerler.Web = item.Web;
                        webDB.Degerler.Update(degerler);
                        writeToFiles.WriteToFile("Degerler Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.Degerler degerler = new Models.LandeWeb.Degerler();
                        //degerler.AksesuarDeger = item.AksesuarDeger;
                        degerler.Deger = item.Deger;
                        degerler.DegerAdi = item.DegerAdi;
                        degerler.DegerTipi = item.DegerTipi;
                        //degerler.DegerTipiNavigation = item.DegerTipiNavigation;
                        degerler.EngDegerAdi = item.EngDegerAdi;
                        degerler.EngWeb = item.EngWeb;
                        degerler.Gcrecord = item.Gcrecord;
                        degerler.Oid = item.Oid;
                        degerler.OlusturanKisi = item.OlusturanKisi;
                        degerler.OlusturmaTarihi = item.OlusturmaTarihi;
                        degerler.OptimisticLockField = item.OptimisticLockField;
                        degerler.Ozellikler = item.Ozellikler;
                        //degerler.OzelliklerNavigation = item.OzelliklerNavigation;
                        degerler.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        //degerler.UrunDegerler = item.UrunDegerler;
                        degerler.Urunler = item.Urunler;
                        //degerler.UrunlerNavigation = item.UrunlerNavigation;
                        degerler.Web = item.Web;
                        webDB.Degerler.Add(degerler);
                        writeToFiles.WriteToFile("Degerler Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("Degerler Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("Degerler Successfull", degerlers.Count, add, update, error);
        }
    }
}
