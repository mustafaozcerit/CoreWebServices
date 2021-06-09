using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;

namespace WindowsServiceHosting.Controllers
{
    public class KataloglarController
    {
        WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();
        public void GetKataloglarSayfasi(DateTime dateTime)
        {
            List<Models.test3.KataloglarSayfasi> kataloglarSayfasis = testDB.KataloglarSayfasi.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
            writeToFiles.WriteToFile("KataloglarSayfasi Atılıyor Toplam Sayı: " + kataloglarSayfasis.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in kataloglarSayfasis)
            {
                try
                {
                    if (webDB.KataloglarSayfasi.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.KataloglarSayfasi kataloglarSayfasi = webDB.KataloglarSayfasi.Where(x => x.Oid == item.Oid).FirstOrDefault();

                        kataloglarSayfasi.Baslik = item.Baslik;
                        kataloglarSayfasi.BaslikEng =item.BaslikEng;
                        kataloglarSayfasi.EngWeb=item.EngWeb;
                        kataloglarSayfasi.Gcrecord=item.Gcrecord;
                        kataloglarSayfasi.Index=item.Index;
                        kataloglarSayfasi.Oid=item.Oid;
                        kataloglarSayfasi.OlusturanKisi=item.OlusturanKisi;
                        kataloglarSayfasi.OlusturmaTarihi=item.OlusturmaTarihi;
                        kataloglarSayfasi.OptimisticLockField=item.OptimisticLockField;
                        kataloglarSayfasi.SonGuncellemeTarihi=item.SonGuncellemeTarihi;
                        kataloglarSayfasi.Web=item.Web;
                        webDB.KataloglarSayfasi.Update(kataloglarSayfasi);
                        writeToFiles.WriteToFile("KataloglarSayfasi Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.KataloglarSayfasi kataloglarSayfasi = new Models.LandeWeb.KataloglarSayfasi();
                        kataloglarSayfasi.Baslik = item.Baslik;
                        kataloglarSayfasi.BaslikEng = item.BaslikEng;
                        kataloglarSayfasi.EngWeb = item.EngWeb;
                        kataloglarSayfasi.Gcrecord = item.Gcrecord;
                        kataloglarSayfasi.Index = item.Index;
                        kataloglarSayfasi.Oid = item.Oid;
                        kataloglarSayfasi.OlusturanKisi = item.OlusturanKisi;
                        kataloglarSayfasi.OlusturmaTarihi = item.OlusturmaTarihi;
                        kataloglarSayfasi.OptimisticLockField = item.OptimisticLockField;
                        kataloglarSayfasi.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        kataloglarSayfasi.Web = item.Web;
                        webDB.KataloglarSayfasi.Add(kataloglarSayfasi);
                        writeToFiles.WriteToFile("KataloglarSayfasi Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("KataloglarSayfasi Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("KataloglarSayfasi Successfull", kataloglarSayfasis.Count, add, update, error);
        }

        public void GetKataloglar(DateTime dateTime)
        {
            List<Models.test3.Kataloglar> kataloglars = testDB.Kataloglar.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
            writeToFiles.WriteToFile("Kataloglar Atılıyor Toplam Sayı: " + kataloglars.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in kataloglars)
            {
                try
                {
                    if (webDB.Kataloglar.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.Kataloglar kataloglar = webDB.Kataloglar.Where(x => x.Oid == item.Oid ).FirstOrDefault();
                        kataloglar.Aksesuar = item.Aksesuar;
                        kataloglar.AksesuarGrubu = item.AksesuarGrubu;
                        kataloglar.EngLandeGenelKatalog = item.EngLandeGenelKatalog;
                        kataloglar.EngLklk = item.EngLklk;
                        kataloglar.EngWeb = item.EngWeb;
                        kataloglar.EngWebDokumanAdi = item.EngWebDokumanAdi;
                        kataloglar.File = item.File;
                        kataloglar.Fotograf = item.Fotograf;
                        kataloglar.Gcrecord = item.Gcrecord;
                        kataloglar.Index = item.Index;
                        kataloglar.KatalogAdi = item.KatalogAdi;
                        kataloglar.KataloglarSayfa = item.KataloglarSayfa;
                        kataloglar.KataloglarSayfasi = item.KataloglarSayfasi;
                        kataloglar.LandeGenelKatalog = item.LandeGenelKatalog;
                        kataloglar.Lklk = item.Lklk;
                        kataloglar.Oid = item.Oid;
                        kataloglar.OptimisticLockField = item.OptimisticLockField;
                        kataloglar.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        kataloglar.UrunAilesi = item.UrunAilesi;
                        kataloglar.UrunGrubu = item.UrunGrubu;
                        kataloglar.Urunler = item.Urunler;
                        kataloglar.UrunSerisi = item.UrunSerisi;
                        kataloglar.Web = item.Web;
                        kataloglar.WebDokumanAdi = item.WebDokumanAdi;
                        webDB.Kataloglar.Update(kataloglar);
                        writeToFiles.WriteToFile("Kataloglar Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.Kataloglar kataloglar = new Models.LandeWeb.Kataloglar();
                        kataloglar.Aksesuar = item.Aksesuar;
                        kataloglar.AksesuarGrubu = item.AksesuarGrubu;
                        kataloglar.EngLandeGenelKatalog = item.EngLandeGenelKatalog;
                        kataloglar.EngLklk = item.EngLklk;
                        kataloglar.EngWeb = item.EngWeb;
                        kataloglar.EngWebDokumanAdi = item.EngWebDokumanAdi;
                        kataloglar.File = item.File;
                        kataloglar.Fotograf = item.Fotograf;
                        kataloglar.Gcrecord = item.Gcrecord;
                        kataloglar.Index = item.Index;
                        kataloglar.KatalogAdi = item.KatalogAdi;
                        kataloglar.KataloglarSayfa = item.KataloglarSayfa;
                        kataloglar.KataloglarSayfasi = item.KataloglarSayfasi;
                        kataloglar.LandeGenelKatalog = item.LandeGenelKatalog;
                        kataloglar.Lklk = item.Lklk;
                        kataloglar.Oid = item.Oid;
                        kataloglar.OptimisticLockField = item.OptimisticLockField;
                        kataloglar.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        kataloglar.UrunAilesi = item.UrunAilesi;
                        kataloglar.UrunGrubu = item.UrunGrubu;
                        kataloglar.Urunler = item.Urunler;
                        kataloglar.UrunSerisi = item.UrunSerisi;
                        kataloglar.Web = item.Web;
                        kataloglar.WebDokumanAdi = item.WebDokumanAdi;
                        webDB.Kataloglar.Add(kataloglar);
                        writeToFiles.WriteToFile("Kataloglar Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("Kataloglar Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("Kataloglar Successfull", kataloglars.Count, add, update, error);
        }

    }
}
