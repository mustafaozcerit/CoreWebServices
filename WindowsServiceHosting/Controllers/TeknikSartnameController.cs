using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;
namespace WindowsServiceHosting.Controllers
{
    public class TeknikSartnameController
    {
    WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();

    public void GetTeknikSartname(DateTime dateTime)
    {
        List<Models.test3.TeknikSartname> teknikSartnames = testDB.TeknikSartname.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
        writeToFiles.WriteToFile("TeknikSartname Atılıyor Toplam Sayı: " + teknikSartnames.Count + "  Tarih: " + DateTime.Now);
        int add = 0;
        int update = 0;
        int error = 0;
        foreach (var item in teknikSartnames)
        {
            try
            {
                if (webDB.TeknikSartname.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                {
                    Models.LandeWeb.TeknikSartname teknikSartname = webDB.TeknikSartname.Where(x => x.Oid == item.Oid ).FirstOrDefault();
                        teknikSartname.Aksesuar = item.Aksesuar;
                        teknikSartname.DokumanAdi = item.DokumanAdi;
                        teknikSartname.DokumanType = item.DokumanType;
                        teknikSartname.DokumanUzanti = item.DokumanUzanti;
                        teknikSartname.EngWeb = item.EngWeb;
                        teknikSartname.EngWebDokumanAdi = item.EngWebDokumanAdi;
                        teknikSartname.File = item.File;
                        teknikSartname.Gcrecord = item.Gcrecord;
                        teknikSartname.GenelSayfadaGoster = item.GenelSayfadaGoster;
                        teknikSartname.Oid = item.Oid;
                        teknikSartname.OcrText = item.OcrText;
                        teknikSartname.OlusturanKisi = item.OlusturanKisi;
                        teknikSartname.OlusturmaTarihi = item.OlusturmaTarihi;
                        teknikSartname.Onay = item.Onay;
                        teknikSartname.OptimisticLockField = item.OptimisticLockField;
                        teknikSartname.Red = item.Red;
                        teknikSartname.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        teknikSartname.UrunAilesi = item.UrunAilesi;
                        teknikSartname.UrunGrubu = item.UrunGrubu;
                        teknikSartname.Urunler = item.Urunler;
                        teknikSartname.UrunSerisi = item.UrunSerisi;
                        teknikSartname.Web = item.Web;
                        teknikSartname.WebDokumanAdi = item.WebDokumanAdi;
                        webDB.TeknikSartname.Update(teknikSartname);
                    writeToFiles.WriteToFile("TeknikSartname Güncellendi    "+item.Oid);
                    update++;
                }
                else
                {
                    Models.LandeWeb.TeknikSartname teknikSartname = new Models.LandeWeb.TeknikSartname();
                        teknikSartname.Aksesuar = item.Aksesuar;
                        teknikSartname.DokumanAdi = item.DokumanAdi;
                        teknikSartname.DokumanType = item.DokumanType;
                        teknikSartname.DokumanUzanti = item.DokumanUzanti;
                        teknikSartname.EngWeb = item.EngWeb;
                        teknikSartname.EngWebDokumanAdi = item.EngWebDokumanAdi;
                        teknikSartname.File = item.File;
                        teknikSartname.Gcrecord = item.Gcrecord;
                        teknikSartname.GenelSayfadaGoster = item.GenelSayfadaGoster;
                        teknikSartname.Oid = item.Oid;
                        teknikSartname.OcrText = item.OcrText;
                        teknikSartname.OlusturanKisi = item.OlusturanKisi;
                        teknikSartname.OlusturmaTarihi = item.OlusturmaTarihi;
                        teknikSartname.Onay = item.Onay;
                        teknikSartname.OptimisticLockField = item.OptimisticLockField;
                        teknikSartname.Red = item.Red;
                        teknikSartname.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        teknikSartname.UrunAilesi = item.UrunAilesi;
                        teknikSartname.UrunGrubu = item.UrunGrubu;
                        teknikSartname.Urunler = item.Urunler;
                        teknikSartname.UrunSerisi = item.UrunSerisi;
                        teknikSartname.Web = item.Web;
                        teknikSartname.WebDokumanAdi = item.WebDokumanAdi;
                        webDB.TeknikSartname.Add(teknikSartname);
                    writeToFiles.WriteToFile("TeknikSartname Eklendi    "+item.Oid);
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
        writeToFiles.WriteToFile("TeknikSartname Successfull " + "Tarih: " + DateTime.Now);
        writeToFiles.Control("TeknikSartname Successfull", teknikSartnames.Count, add, update, error);
    }
}
}
