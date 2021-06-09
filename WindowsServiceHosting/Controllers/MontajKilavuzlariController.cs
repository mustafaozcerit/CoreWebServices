using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.test3;
using WindowsServiceHosting.Models.LandeWeb;
namespace WindowsServiceHosting.Controllers
{
    public class MontajKilavuzlariController
    {

        WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();
        public void GetMontajKilavuzlari(DateTime dateTime)
        {
            List<Models.test3.MontajKlavuzlari> montajKlavuzlaris = testDB.MontajKlavuzlari.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
            writeToFiles.WriteToFile("MontajKlavuzlari Atılıyor Toplam Sayı: " + montajKlavuzlaris.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in montajKlavuzlaris)
            {

                try
                {
                    if (webDB.MontajKlavuzlari.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.MontajKlavuzlari montajKlavuzlari = webDB.MontajKlavuzlari.Where(x => x.Oid == item.Oid ).FirstOrDefault();
                        montajKlavuzlari.Aksesuar = item.Aksesuar;
                        montajKlavuzlari.AksesuarGrubu = item.AksesuarGrubu;
                        montajKlavuzlari.DokumanAdi = item.DokumanAdi;
                        montajKlavuzlari.DokumanType = item.DokumanType;
                        montajKlavuzlari.DokumanUzanti = item.DokumanUzanti;
                        montajKlavuzlari.EngWeb = item.EngWeb;
                        montajKlavuzlari.EngWebDokumanAdi = item.EngWebDokumanAdi;
                        montajKlavuzlari.File = item.File;
                        montajKlavuzlari.Gcrecord = item.Gcrecord;
                        montajKlavuzlari.OcrText = item.OcrText;
                        montajKlavuzlari.Oid = item.Oid;
                        montajKlavuzlari.OlusturanKisi = item.OlusturanKisi;
                        montajKlavuzlari.OlusturmaTarihi = item.OlusturmaTarihi;
                        montajKlavuzlari.Onay = item.Onay;
                        montajKlavuzlari.OptimisticLockField = item.OptimisticLockField;
                        montajKlavuzlari.Red = item.Red;
                        montajKlavuzlari.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        montajKlavuzlari.UrunAilesi = item.UrunAilesi;
                        montajKlavuzlari.UrunGrubu = item.UrunGrubu;
                        montajKlavuzlari.Urunler = item.Urunler;
                        montajKlavuzlari.UrunSerisi = item.UrunSerisi;
                        montajKlavuzlari.Web = item.Web;
                        montajKlavuzlari.WebDokumanAdi = item.WebDokumanAdi;
                        webDB.MontajKlavuzlari.Update(montajKlavuzlari);
                        writeToFiles.WriteToFile("MontajKlavuzlari Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.MontajKlavuzlari montajKlavuzlari = new Models.LandeWeb.MontajKlavuzlari();
                        montajKlavuzlari.Aksesuar = item.Aksesuar;
                        montajKlavuzlari.AksesuarGrubu = item.AksesuarGrubu;
                        montajKlavuzlari.DokumanAdi = item.DokumanAdi;
                        montajKlavuzlari.DokumanType = item.DokumanType;
                        montajKlavuzlari.DokumanUzanti = item.DokumanUzanti;
                        montajKlavuzlari.EngWeb = item.EngWeb;
                        montajKlavuzlari.EngWebDokumanAdi = item.EngWebDokumanAdi;
                        montajKlavuzlari.File = item.File;
                        montajKlavuzlari.Gcrecord = item.Gcrecord;
                        montajKlavuzlari.OcrText = item.OcrText;
                        montajKlavuzlari.Oid = item.Oid;
                        montajKlavuzlari.OlusturanKisi = item.OlusturanKisi;
                        montajKlavuzlari.OlusturmaTarihi = item.OlusturmaTarihi;
                        montajKlavuzlari.Onay = item.Onay;
                        montajKlavuzlari.OptimisticLockField = item.OptimisticLockField;
                        montajKlavuzlari.Red = item.Red;
                        montajKlavuzlari.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        montajKlavuzlari.UrunAilesi = item.UrunAilesi;
                        montajKlavuzlari.UrunGrubu = item.UrunGrubu;
                        montajKlavuzlari.Urunler = item.Urunler;
                        montajKlavuzlari.UrunSerisi = item.UrunSerisi;
                        montajKlavuzlari.Web = item.Web;
                        montajKlavuzlari.WebDokumanAdi = item.WebDokumanAdi;
                        webDB.MontajKlavuzlari.Update(montajKlavuzlari);
                        writeToFiles.WriteToFile("MontajKlavuzlari Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("MontajKlavuzlari Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("MontajKlavuzlari Successfull", montajKlavuzlaris.Count, add, update, error);
        }

    }
}
