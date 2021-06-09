using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;
namespace WindowsServiceHosting.Controllers
{
    public class KaliteDokumanlariController
    {

    WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();

    public void GetKaliteDokumanlari(DateTime dateTime)
    {
        List<Models.test3.KaliteDokumanlari> kaliteDokumanlaris = testDB.KaliteDokumanlari.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
        writeToFiles.WriteToFile("KaliteDokumanlari Atılıyor Toplam Sayı: " + kaliteDokumanlaris.Count + "  Tarih: " + DateTime.Now);
        int add = 0;
        int update = 0;
        int error = 0;
        foreach (var item in kaliteDokumanlaris)
        {
            try
            {
                if (webDB.KaliteDokumanlari.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                {
                    Models.LandeWeb.KaliteDokumanlari kaliteDokumanlari = webDB.KaliteDokumanlari.Where(x => x.Oid == item.Oid).FirstOrDefault();
                        kaliteDokumanlari.Aksesuar = item.Aksesuar;
                        kaliteDokumanlari.AksesuarGrubu = item.AksesuarGrubu;
                        kaliteDokumanlari.ConString = item.ConString;
                        kaliteDokumanlari.DokumanAdi = item.DokumanAdi;
                        kaliteDokumanlari.DokumanType = item.DokumanType;
                        kaliteDokumanlari.DokumanUzanti = item.DokumanUzanti;
                        kaliteDokumanlari.EngWebDokumanAdi = item.EngWebDokumanAdi;
                        kaliteDokumanlari.EngWeb = item.EngWeb;
                        kaliteDokumanlari.File = item.File;
                        kaliteDokumanlari.Fotograf = item.Fotograf;
                        kaliteDokumanlari.Gcrecord = item.Gcrecord;
                        kaliteDokumanlari.GenelSayfadaGoster = item.GenelSayfadaGoster;
                        kaliteDokumanlari.OcrText = item.OcrText;
                        kaliteDokumanlari.Oid = item.Oid;
                        kaliteDokumanlari.OlusturanKisi = item.OlusturanKisi;
                        kaliteDokumanlari.OlusturmaTarihi = item.OlusturmaTarihi;
                        kaliteDokumanlari.Onay = item.Onay;
                        kaliteDokumanlari.OptimisticLockField = item.OptimisticLockField;
                        kaliteDokumanlari.Red = item.Red;
                        kaliteDokumanlari.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        kaliteDokumanlari.UrunAilesi = item.UrunAilesi;
                        kaliteDokumanlari.UrunGrubu = item.UrunGrubu;
                        kaliteDokumanlari.Urunler = item.Urunler;
                        kaliteDokumanlari.UrunSerisi = item.UrunSerisi;
                        kaliteDokumanlari.Web = item.Web;
                        kaliteDokumanlari.WebDokumanAdi = item.WebDokumanAdi;
                        webDB.KaliteDokumanlari.Update(kaliteDokumanlari);
                    writeToFiles.WriteToFile("KaliteDokumanlari Güncellendi    "+item.Oid);
                    update++;
                }
                else
                {
                    Models.LandeWeb.KaliteDokumanlari kaliteDokumanlari = new Models.LandeWeb.KaliteDokumanlari();
                        kaliteDokumanlari.Aksesuar = item.Aksesuar;
                        kaliteDokumanlari.AksesuarGrubu = item.AksesuarGrubu;
                        kaliteDokumanlari.ConString = item.ConString;
                        kaliteDokumanlari.DokumanAdi = item.DokumanAdi;
                        kaliteDokumanlari.DokumanType = item.DokumanType;
                        kaliteDokumanlari.DokumanUzanti = item.DokumanUzanti;
                        kaliteDokumanlari.EngWebDokumanAdi = item.EngWebDokumanAdi;
                        kaliteDokumanlari.EngWeb = item.EngWeb;
                        kaliteDokumanlari.File = item.File;
                        kaliteDokumanlari.Fotograf = item.Fotograf;
                        kaliteDokumanlari.Gcrecord = item.Gcrecord;
                        kaliteDokumanlari.GenelSayfadaGoster = item.GenelSayfadaGoster;
                        kaliteDokumanlari.OcrText = item.OcrText;
                        kaliteDokumanlari.Oid = item.Oid;
                        kaliteDokumanlari.OlusturanKisi = item.OlusturanKisi;
                        kaliteDokumanlari.OlusturmaTarihi = item.OlusturmaTarihi;
                        kaliteDokumanlari.Onay = item.Onay;
                        kaliteDokumanlari.OptimisticLockField = item.OptimisticLockField;
                        kaliteDokumanlari.Red = item.Red;
                        kaliteDokumanlari.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        kaliteDokumanlari.UrunAilesi = item.UrunAilesi;
                        kaliteDokumanlari.UrunGrubu = item.UrunGrubu;
                        kaliteDokumanlari.Urunler = item.Urunler;
                        kaliteDokumanlari.UrunSerisi = item.UrunSerisi;
                        kaliteDokumanlari.Web = item.Web;
                        kaliteDokumanlari.WebDokumanAdi = item.WebDokumanAdi;
                        webDB.KaliteDokumanlari.Add(kaliteDokumanlari);
                    writeToFiles.WriteToFile("KaliteDokumanlari Eklendi    "+item.Oid);
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
        writeToFiles.WriteToFile("KaliteDokumanlari Successfull " + "Tarih: " + DateTime.Now);
        writeToFiles.Control("KaliteDokumanlari Successfull", kaliteDokumanlaris.Count, add, update, error);
    }
}
}
