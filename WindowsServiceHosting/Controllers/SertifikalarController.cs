using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;
namespace WindowsServiceHosting.Controllers
{
    public class SertifikalarController
    { 

    WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();

    public void GetSertifikalar(DateTime dateTime)
    {
        List<Models.test3.Sertifikalar> sertifikalars = testDB.Sertifikalar.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
        writeToFiles.WriteToFile("Sertifikalar Atılıyor Toplam Sayı: " + sertifikalars.Count + "  Tarih: " + DateTime.Now);
        int add = 0;
        int update = 0;
        int error = 0;
        foreach (var item in sertifikalars)
        {
            try
            {
                if (webDB.Sertifikalar.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                {
                    Models.LandeWeb.Sertifikalar sertifikalar = webDB.Sertifikalar.Where(x => x.Oid == item.Oid ).FirstOrDefault();
                        sertifikalar.Aksesuar = item.Aksesuar;
                        sertifikalar.AksesuarGrubu = item.AksesuarGrubu;
                        sertifikalar.DokumanAdi = item.DokumanAdi;
                        sertifikalar.DokumanType = item.DokumanType;
                        sertifikalar.DokumanUzanti = item.DokumanUzanti;
                        sertifikalar.EngWeb = item.EngWeb;
                        sertifikalar.EngWebDokumanAdi = item.EngWebDokumanAdi;
                        sertifikalar.File = item.File;
                        sertifikalar.Fotograf = item.Fotograf;
                        sertifikalar.Gcrecord = item.Gcrecord;
                        sertifikalar.GenelSayfadaGoster = item.GenelSayfadaGoster;
                        sertifikalar.Lklk = item.Lklk;
                        sertifikalar.OcrText = item.OcrText;
                        sertifikalar.Oid = item.Oid;
                        sertifikalar.OlusturanKisi = item.OlusturanKisi;
                        sertifikalar.OlusturmaTarihi = item.OlusturmaTarihi;
                        sertifikalar.Onay = item.Onay;
                        sertifikalar.OptimisticLockField = item.OptimisticLockField;
                        //sertifikalar.Parcalar = item.Parcalar;
                        sertifikalar.Red = item.Red;
                        sertifikalar.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        sertifikalar.UrunAilesi = item.UrunAilesi;
                        sertifikalar.UrunGrubu = item.UrunGrubu;
                        sertifikalar.Urunler = item.Urunler;
                        sertifikalar.UrunSerisi = item.UrunSerisi;
                        sertifikalar.Web = item.Web;
                        sertifikalar.WebDokumanAdi = item.WebDokumanAdi;
                        webDB.Sertifikalar.Update(sertifikalar);
                    writeToFiles.WriteToFile("Sertifikalar Güncellendi    "+item.Oid);
                    update++;
                }
                else
                {
                    Models.LandeWeb.Sertifikalar sertifikalar = new Models.LandeWeb.Sertifikalar();
                        sertifikalar.Aksesuar = item.Aksesuar;
                        sertifikalar.AksesuarGrubu = item.AksesuarGrubu;
                        sertifikalar.DokumanAdi = item.DokumanAdi;
                        sertifikalar.DokumanType = item.DokumanType;
                        sertifikalar.DokumanUzanti = item.DokumanUzanti;
                        sertifikalar.EngWeb = item.EngWeb;
                        sertifikalar.EngWebDokumanAdi = item.EngWebDokumanAdi;
                        sertifikalar.File = item.File;
                        sertifikalar.Fotograf = item.Fotograf;
                        sertifikalar.Gcrecord = item.Gcrecord;
                        sertifikalar.GenelSayfadaGoster = item.GenelSayfadaGoster;
                        sertifikalar.Lklk = item.Lklk;
                        sertifikalar.OcrText = item.OcrText;
                        sertifikalar.Oid = item.Oid;
                        sertifikalar.OlusturanKisi = item.OlusturanKisi;
                        sertifikalar.OlusturmaTarihi = item.OlusturmaTarihi;
                        sertifikalar.Onay = item.Onay;
                        sertifikalar.OptimisticLockField = item.OptimisticLockField;
                        //sertifikalar.Parcalar = item.Parcalar;
                        sertifikalar.Red = item.Red;
                        sertifikalar.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        sertifikalar.UrunAilesi = item.UrunAilesi;
                        sertifikalar.UrunGrubu = item.UrunGrubu;
                        sertifikalar.Urunler = item.Urunler;
                        sertifikalar.UrunSerisi = item.UrunSerisi;
                        sertifikalar.Web = item.Web;
                        sertifikalar.WebDokumanAdi = item.WebDokumanAdi;
                        webDB.Sertifikalar.Add(sertifikalar);
                    writeToFiles.WriteToFile("Sertifikalar Eklendi    "+item.Oid);
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
        writeToFiles.WriteToFile("Sertifikalar Successfull " + "Tarih: " + DateTime.Now);
        writeToFiles.Control("Sertifikalar Successfull", sertifikalars.Count, add, update, error);
    }


}
}
