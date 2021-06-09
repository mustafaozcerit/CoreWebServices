using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;
namespace WindowsServiceHosting.Controllers
{
    public class DigerDokumanlarController
    {


    WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();

    public void GetDigerDokumanlar(DateTime dateTime)
    {
        List<Models.test3.DigerDokumanlar> digerDokumanlars = testDB.DigerDokumanlar.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
        writeToFiles.WriteToFile("DigerDokumanlar Atılıyor Toplam Sayı: " + digerDokumanlars.Count + "  Tarih: " + DateTime.Now);
        int add = 0;
        int update = 0;
        int error = 0;
        foreach (var item in digerDokumanlars)
        {
            try
            {
                if (webDB.DigerDokumanlar.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                {
                    Models.LandeWeb.DigerDokumanlar digerDokumanlar = webDB.DigerDokumanlar.Where(x => x.Oid == item.Oid).FirstOrDefault();
                        digerDokumanlar.Aksesuar = item.Aksesuar;
                        digerDokumanlar.DigerDokumanlarSayfasi = item.DigerDokumanlarSayfasi;
                        digerDokumanlar.DokumanAdi = item.DokumanAdi;
                        digerDokumanlar.DokumanType = item.DokumanType;
                        digerDokumanlar.DokumanUzanti = item.DokumanUzanti;
                        digerDokumanlar.EngWeb = item.EngWeb;
                        digerDokumanlar.EngWebDokumanAdi = item.EngWebDokumanAdi;
                        digerDokumanlar.File = item.File;
                        digerDokumanlar.Fotograf = item.Fotograf;
                        digerDokumanlar.Gcrecord = item.Gcrecord;
                        digerDokumanlar.OcrText = item.OcrText;
                        digerDokumanlar.Oid = item.Oid;
                        digerDokumanlar.OlusturanKisi = item.OlusturanKisi;
                        digerDokumanlar.OlusturmaTarihi = item.OlusturmaTarihi;
                        digerDokumanlar.Onay = item.Onay;
                        digerDokumanlar.OptimisticLockField = item.OptimisticLockField;
                        digerDokumanlar.Red = item.Red;
                        digerDokumanlar.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        digerDokumanlar.UrunAilesi = item.UrunAilesi;
                        digerDokumanlar.UrunGrubu = item.UrunGrubu;
                        digerDokumanlar.Urunler = item.Urunler;
                        digerDokumanlar.UrunSerisi = item.UrunSerisi;
                        digerDokumanlar.Web = item.Web;
                        digerDokumanlar.WebDokumanAdi = item.WebDokumanAdi;
                        webDB.DigerDokumanlar.Update(digerDokumanlar);
                    writeToFiles.WriteToFile("DigerDokumanlar Güncellendi    "+item.Oid);
                    update++;
                }
                else
                {
                    Models.LandeWeb.DigerDokumanlar digerDokumanlar = new Models.LandeWeb.DigerDokumanlar();
                        digerDokumanlar.Aksesuar = item.Aksesuar;
                        digerDokumanlar.DigerDokumanlarSayfasi = item.DigerDokumanlarSayfasi;
                        digerDokumanlar.DokumanAdi = item.DokumanAdi;
                        digerDokumanlar.DokumanType = item.DokumanType;
                        digerDokumanlar.DokumanUzanti = item.DokumanUzanti;
                        digerDokumanlar.EngWeb = item.EngWeb;
                        digerDokumanlar.EngWebDokumanAdi = item.EngWebDokumanAdi;
                        digerDokumanlar.File = item.File;
                        digerDokumanlar.Fotograf = item.Fotograf;
                        digerDokumanlar.Gcrecord = item.Gcrecord;
                        digerDokumanlar.OcrText = item.OcrText;
                        digerDokumanlar.Oid = item.Oid;
                        digerDokumanlar.OlusturanKisi = item.OlusturanKisi;
                        digerDokumanlar.OlusturmaTarihi = item.OlusturmaTarihi;
                        digerDokumanlar.Onay = item.Onay;
                        digerDokumanlar.OptimisticLockField = item.OptimisticLockField;
                        digerDokumanlar.Red = item.Red;
                        digerDokumanlar.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        digerDokumanlar.UrunAilesi = item.UrunAilesi;
                        digerDokumanlar.UrunGrubu = item.UrunGrubu;
                        digerDokumanlar.Urunler = item.Urunler;
                        digerDokumanlar.UrunSerisi = item.UrunSerisi;
                        digerDokumanlar.Web = item.Web;
                        digerDokumanlar.WebDokumanAdi = item.WebDokumanAdi;
                        webDB.DigerDokumanlar.Add(digerDokumanlar);
                    writeToFiles.WriteToFile("DigerDokumanlar Eklendi    "+item.Oid);
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
        writeToFiles.WriteToFile("DigerDokumanlar Successfull " + "Tarih: " + DateTime.Now);
        writeToFiles.Control("DigerDokumanlar Successfull", digerDokumanlars.Count, add, update, error);
    }
}
}
