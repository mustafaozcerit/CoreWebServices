using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;
namespace WindowsServiceHosting.Controllers
{
    public class TeknikCizimlerController
    { 

    WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();

    public void GetTeknikCizimler(DateTime dateTime)
    {
        List<Models.test3.TeknikCizimler> teknikCizimlers = testDB.TeknikCizimler.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
        writeToFiles.WriteToFile("TeknikCizimler Atılıyor Toplam Sayı: " + teknikCizimlers.Count + "  Tarih: " + DateTime.Now);
        int add = 0;
        int update = 0;
        int error = 0;
        foreach (var item in teknikCizimlers)
        {
            try
            {
                if (webDB.TeknikCizimler.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                {
                    Models.LandeWeb.TeknikCizimler teknikCizimler = webDB.TeknikCizimler.Where(x => x.Oid == item.Oid ).FirstOrDefault();
                        teknikCizimler.Aksesuar = item.Aksesuar;
                        teknikCizimler.AksesuarGrubu = item.AksesuarGrubu;
                        teknikCizimler.DokumanAdi = item.DokumanAdi;
                        teknikCizimler.DokumanType = item.DokumanType;
                        teknikCizimler.DokumanUzanti = item.DokumanUzanti;
                        teknikCizimler.EngWeb = item.EngWeb;
                        teknikCizimler.EngWebDokumanAdi = item.EngWebDokumanAdi;
                        teknikCizimler.File = item.File;
                        teknikCizimler.Gcrecord = item.Gcrecord;
                        teknikCizimler.OcrText = item.OcrText;
                        teknikCizimler.Oid = item.Oid;
                        teknikCizimler.OlusturanKisi = item.OlusturanKisi;
                        teknikCizimler.OlusturmaTarihi = item.OlusturmaTarihi;
                        teknikCizimler.Onay = item.Onay;
                        teknikCizimler.OptimisticLockField = item.OptimisticLockField;
                        teknikCizimler.Red = item.Red;
                        teknikCizimler.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        teknikCizimler.UrunAilesi = item.UrunAilesi;
                        teknikCizimler.UrunGrubu = item.UrunGrubu;
                        teknikCizimler.Urunler = item.Urunler;
                        teknikCizimler.UrunSerisi = item.UrunSerisi;
                        teknikCizimler.Web = item.Web;
                        teknikCizimler.WebDokumanAdi = item.WebDokumanAdi;
                        webDB.TeknikCizimler.Update(teknikCizimler);
                    writeToFiles.WriteToFile("TeknikCizimler Güncellendi    "+item.Oid);
                    update++;
                }
                else
                {
                    Models.LandeWeb.TeknikCizimler teknikCizimler = new Models.LandeWeb.TeknikCizimler();
                        teknikCizimler.Aksesuar = item.Aksesuar;
                        teknikCizimler.AksesuarGrubu = item.AksesuarGrubu;
                        teknikCizimler.DokumanAdi = item.DokumanAdi;
                        teknikCizimler.DokumanType = item.DokumanType;
                        teknikCizimler.DokumanUzanti = item.DokumanUzanti;
                        teknikCizimler.EngWeb = item.EngWeb;
                        teknikCizimler.EngWebDokumanAdi = item.EngWebDokumanAdi;
                        teknikCizimler.File = item.File;
                        teknikCizimler.Gcrecord = item.Gcrecord;
                        teknikCizimler.OcrText = item.OcrText;
                        teknikCizimler.Oid = item.Oid;
                        teknikCizimler.OlusturanKisi = item.OlusturanKisi;
                        teknikCizimler.OlusturmaTarihi = item.OlusturmaTarihi;
                        teknikCizimler.Onay = item.Onay;
                        teknikCizimler.OptimisticLockField = item.OptimisticLockField;
                        teknikCizimler.Red = item.Red;
                        teknikCizimler.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        teknikCizimler.UrunAilesi = item.UrunAilesi;
                        teknikCizimler.UrunGrubu = item.UrunGrubu;
                        teknikCizimler.Urunler = item.Urunler;
                        teknikCizimler.UrunSerisi = item.UrunSerisi;
                        teknikCizimler.Web = item.Web;
                        teknikCizimler.WebDokumanAdi = item.WebDokumanAdi;
                        webDB.TeknikCizimler.Add(teknikCizimler);
                    writeToFiles.WriteToFile("TeknikCizimler Eklendi    "+item.Oid);
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
        writeToFiles.WriteToFile("TeknikCizimler Successfull " + "Tarih: " + DateTime.Now);
        writeToFiles.Control("TeknikCizimler Successfull", teknikCizimlers.Count, add, update, error);
    }


}
}
