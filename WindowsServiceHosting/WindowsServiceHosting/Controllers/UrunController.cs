using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;
namespace WindowsServiceHosting.Controllers
{

    public class UrunController
    {
        WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();
        public void GetUrunAilesi(DateTime dateTime)
        {
            List<Models.test3.UrunAilesi> urunailesis = testDB.UrunAilesi.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
            writeToFiles.WriteToFile("UrunAilesi Atılıyor Toplam Sayı: " + urunailesis.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in urunailesis)
            {
                try
                {
                    if (webDB.UrunAilesi.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.UrunAilesi urunAilesi = webDB.UrunAilesi.Where(x => x.Oid == item.Oid ).FirstOrDefault();
                        urunAilesi.Aciklama = item.Aciklama;
                        urunAilesi.EngUrunAilesiAdi = item.EngUrunAilesiAdi;
                        urunAilesi.EngWeb = item.EngWeb;
                        urunAilesi.EngWebUrl = item.EngWebUrl;
                        urunAilesi.Gcrecord = item.Gcrecord;
                        urunAilesi.Index = item.Index;
                        urunAilesi.Oid = item.Oid;
                        urunAilesi.OlusturanKisi = item.OlusturanKisi;
                        urunAilesi.OlusturmaTarihi = item.OlusturmaTarihi;
                        urunAilesi.OptimisticLockField = item.OptimisticLockField;
                        urunAilesi.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        urunAilesi.UrunAilesiAdi = item.UrunAilesiAdi;
                        urunAilesi.WebUrl = item.WebUrl;
                        webDB.UrunAilesi.Update(urunAilesi);
                        writeToFiles.WriteToFile("UrunAilesi Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.UrunAilesi urunAilesi = new Models.LandeWeb.UrunAilesi();
                        urunAilesi.Aciklama = item.Aciklama;
                        urunAilesi.EngAciklama = item.EngAciklama;
                        urunAilesi.EngUrunAilesiAdi = item.EngUrunAilesiAdi;
                        urunAilesi.EngWeb = item.EngWeb;
                        urunAilesi.EngWebUrl = item.EngWebUrl;
                        urunAilesi.Gcrecord = item.Gcrecord;
                        urunAilesi.Index = item.Index;
                        urunAilesi.Oid = item.Oid;
                        urunAilesi.OlusturanKisi = item.OlusturanKisi;
                        urunAilesi.OlusturmaTarihi = item.OlusturmaTarihi;
                        urunAilesi.OptimisticLockField = item.OptimisticLockField;
                        urunAilesi.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        urunAilesi.UrunAilesiAdi = item.UrunAilesiAdi;
                        urunAilesi.Web = item.Web;
                        urunAilesi.WebUrl = item.WebUrl;
                        webDB.UrunAilesi.Add(urunAilesi);
                        writeToFiles.WriteToFile("UrunAilesi Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("UrunAilesi Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("UrunAilesi Successfull", urunailesis.Count, add, update, error);
        }

        public void GetUrunGrubu(DateTime dateTime)
        {
            List<Models.test3.UrunGrubu> urunGrubus = testDB.UrunGrubu.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi>dateTime).ToList();
            writeToFiles.WriteToFile("UrunGrubu Atılıyor Toplam Sayı: " + urunGrubus.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in urunGrubus)
            {
                try
                {
                    if (webDB.UrunGrubu.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.UrunGrubu urunGrubu = webDB.UrunGrubu.Where(x => x.Oid == item.Oid).FirstOrDefault();

                        urunGrubu.Aciklama = item.Aciklama;
                        urunGrubu.EngAciklama = item.EngAciklama;
                        urunGrubu.EngUrunGrubuAdi = item.EngUrunGrubuAdi;
                        urunGrubu.EngWeb = item.EngWeb;
                        urunGrubu.EngWebUrl = item.EngWebUrl;
                        urunGrubu.Gcrecord = item.Gcrecord;
                        urunGrubu.Index = item.Index;
                        urunGrubu.Oid = item.Oid;
                        urunGrubu.OlusturanKisi = item.OlusturanKisi;
                        urunGrubu.OlusturmaTarihi = item.OlusturmaTarihi;
                        urunGrubu.OptimisticLockField = item.OptimisticLockField;
                        urunGrubu.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        urunGrubu.UrunAilesi = item.UrunAilesi;
                        urunGrubu.UrunGrubuAdi = item.UrunGrubuAdi;
                        urunGrubu.Web = item.Web;
                        urunGrubu.WebUrl = item.WebUrl;
                        webDB.UrunGrubu.Update(urunGrubu);
                        writeToFiles.WriteToFile("UrunGrubu Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.UrunGrubu urunGrubu = new Models.LandeWeb.UrunGrubu();

                        urunGrubu.Aciklama = item.Aciklama;
                        urunGrubu.EngAciklama = item.EngAciklama;
                        urunGrubu.EngUrunGrubuAdi = item.EngUrunGrubuAdi;
                        urunGrubu.EngWeb = item.EngWeb;
                        urunGrubu.EngWebUrl = item.EngWebUrl;
                        urunGrubu.Gcrecord = item.Gcrecord;
                        urunGrubu.Index = item.Index;
                        urunGrubu.Oid = item.Oid;
                        urunGrubu.OlusturanKisi = item.OlusturanKisi;
                        urunGrubu.OlusturmaTarihi = item.OlusturmaTarihi;
                        urunGrubu.OptimisticLockField = item.OptimisticLockField;
                        urunGrubu.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        urunGrubu.UrunAilesi = item.UrunAilesi;
                        urunGrubu.UrunGrubuAdi = item.UrunGrubuAdi;
                        urunGrubu.Web = item.Web;
                        urunGrubu.WebUrl = item.WebUrl;
                        webDB.UrunGrubu.Add(urunGrubu);
                        writeToFiles.WriteToFile("UrunGrubu Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("UrunGrubu Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("UrunGrubu Successfull", urunGrubus.Count, add, update, error);
        }


        public void GetUrunSerisi(DateTime dateTime)
        {
            List<Models.test3.UrunSerisi> urunSerisis = testDB.UrunSerisi.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi>dateTime).ToList();
            writeToFiles.WriteToFile("UrunSerisi Atılıyor Toplam Sayı: " + urunSerisis.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in urunSerisis)
            {
                try
                {
                    if (webDB.UrunSerisi.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.UrunSerisi urunSerisi = webDB.UrunSerisi.Where(x => x.Oid == item.Oid).FirstOrDefault();

                        urunSerisi.Aciklama = item.Aciklama;
                        urunSerisi.EngAciklama = item.EngAciklama;
                        urunSerisi.EngUrunSerisiAdi = item.EngUrunSerisiAdi;
                        urunSerisi.EngWeb = item.EngWeb;
                        urunSerisi.EngWebUrl = item.EngWebUrl;
                        urunSerisi.Gcrecord = item.Gcrecord;
                        urunSerisi.Index = item.Index;
                        urunSerisi.Oid = item.Oid;
                        urunSerisi.OlusturanKisi = item.OlusturanKisi;
                        urunSerisi.OlusturmaTarihi = item.OlusturmaTarihi;
                        urunSerisi.OptimisticLockField = item.OptimisticLockField;
                        urunSerisi.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        urunSerisi.UrunAilesi = item.UrunAilesi;
                        urunSerisi.UrunGrubu = item.UrunGrubu;
                        urunSerisi.UrunSerisiAdi = item.UrunSerisiAdi;
                        urunSerisi.Web = item.Web;
                        urunSerisi.WebUrl = item.WebUrl;
                        webDB.UrunSerisi.Update(urunSerisi);
                        writeToFiles.WriteToFile("UrunSerisi Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.UrunSerisi urunSerisi = new Models.LandeWeb.UrunSerisi();
                        urunSerisi.Aciklama = item.Aciklama;
                        urunSerisi.EngAciklama = item.EngAciklama;
                        urunSerisi.EngUrunSerisiAdi = item.EngUrunSerisiAdi;
                        urunSerisi.EngWeb = item.EngWeb;
                        urunSerisi.EngWebUrl = item.EngWebUrl;
                        urunSerisi.Gcrecord = item.Gcrecord;
                        urunSerisi.Index = item.Index;
                        urunSerisi.Oid = item.Oid;
                        urunSerisi.OlusturanKisi = item.OlusturanKisi;
                        urunSerisi.OlusturmaTarihi = item.OlusturmaTarihi;
                        urunSerisi.OptimisticLockField = item.OptimisticLockField;
                        urunSerisi.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        urunSerisi.UrunAilesi = item.UrunAilesi;
                        urunSerisi.UrunGrubu = item.UrunGrubu;
                        urunSerisi.UrunSerisiAdi = item.UrunSerisiAdi;
                        urunSerisi.Web = item.Web;
                        urunSerisi.WebUrl = item.WebUrl;
                        webDB.UrunSerisi.Add(urunSerisi);
                        writeToFiles.WriteToFile("UrunSerisi Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("UrunSerisi Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("UrunSerisi Successfull", urunSerisis.Count, add, update, error);
        }


        public void GetUrunler(DateTime dateTime)
        {
            List<Models.test3.Urunler> urunlers = testDB.Urunler.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi>dateTime).ToList();
            writeToFiles.WriteToFile("Urunler Atılıyor Toplam Sayı: " + urunlers.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in urunlers)
            {
                try
                {
                    if (webDB.Urunler.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.Urunler urunler = webDB.Urunler.Where(x => x.Oid == item.Oid).FirstOrDefault();

                        urunler.Aciklama = item.Aciklama;
                        urunler.AltUrunGrubu = item.AltUrunGrubu;
                        urunler.AltUrunTipi = item.AltUrunTipi;
                        urunler.AnaUrunGrubu = item.AnaUrunGrubu;
                        urunler.Barkod = item.Barkod;
                        urunler.Birim = item.Birim;
                        urunler.Boyut = item.Boyut;
                        urunler.EngAciklama = item.EngAciklama;
                        urunler.EngWeb = item.EngWeb;
                        urunler.EngWebUrl = item.EngWebUrl;
                        urunler.Gcrecord = item.Gcrecord;
                        urunler.IlkFoto = item.IlkFoto;
                        urunler.Index = item.Index;
                        urunler.IngStokAdi = item.IngStokAdi;
                        urunler.KatalogKodu = item.KatalogKodu;
                        urunler.Oid = item.Oid;
                        urunler.OlusturanKisi = item.OlusturanKisi;
                        urunler.OlusturmaTarihi = item.OlusturmaTarihi;
                        urunler.OptimisticLockField = item.OptimisticLockField;
                        urunler.Renk = item.Renk;
                        urunler.SatinAlma = item.SatinAlma;
                        urunler.Satis = item.Satis;
                        urunler.SatisAnalizGrubu = item.SatisAnalizGrubu;
                        urunler.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        urunler.StokAdi = item.StokAdi;
                        urunler.StokKodu = item.StokKodu;
                        urunler.Uretim = item.Uretim;
                        urunler.UrunAilesi = item.UrunAilesi;
                        urunler.UrunCinsi = item.UrunCinsi;
                        urunler.UrunGrubu = item.UrunGrubu;
                        urunler.UrunSerisi = item.UrunSerisi;
                        urunler.UrunTuru = item.UrunTuru;
                        urunler.Web = item.Web;
                        urunler.WebUrl = item.WebUrl;
                        urunler.Yukseklik = item.Yukseklik;
                        webDB.Urunler.Update(urunler);
                        writeToFiles.WriteToFile("Urunler Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.Urunler urunler = new Models.LandeWeb.Urunler();
                        urunler.Aciklama = item.Aciklama;
                        urunler.AltUrunGrubu = item.AltUrunGrubu;
                        urunler.AltUrunTipi = item.AltUrunTipi;
                        urunler.AnaUrunGrubu = item.AnaUrunGrubu;
                        urunler.Barkod = item.Barkod;
                        urunler.Birim = item.Birim;
                        urunler.Boyut = item.Boyut;
                        urunler.EngAciklama = item.EngAciklama;
                        urunler.EngWeb = item.EngWeb;
                        urunler.EngWebUrl = item.EngWebUrl;
                        urunler.Gcrecord = item.Gcrecord;
                        urunler.IlkFoto = item.IlkFoto;
                        urunler.Index = item.Index;
                        urunler.IngStokAdi = item.IngStokAdi;
                        urunler.KatalogKodu = item.KatalogKodu;
                        urunler.Oid = item.Oid;
                        urunler.OlusturanKisi = item.OlusturanKisi;
                        urunler.OlusturmaTarihi = item.OlusturmaTarihi;
                        urunler.OptimisticLockField = item.OptimisticLockField;
                        urunler.Renk = item.Renk;
                        urunler.SatinAlma = item.SatinAlma;
                        urunler.Satis = item.Satis;
                        urunler.SatisAnalizGrubu = item.SatisAnalizGrubu;
                        urunler.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        urunler.StokAdi = item.StokAdi;
                        urunler.StokKodu = item.StokKodu;
                        urunler.Uretim = item.Uretim;
                        urunler.UrunAilesi = item.UrunAilesi;
                        urunler.UrunCinsi = item.UrunCinsi;
                        urunler.UrunGrubu = item.UrunGrubu;;
                        urunler.UrunSerisi = item.UrunSerisi;
                        urunler.UrunTuru = item.UrunTuru;
                        urunler.Web = item.Web;
                        urunler.WebUrl = item.WebUrl;
                        urunler.Yukseklik = item.Yukseklik;
                        webDB.Urunler.Add(urunler);
                        writeToFiles.WriteToFile("Urunler Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("Urunler Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("Urunler Successfull", urunlers.Count, add, update, error);
        }


        public void GetUrunDegerler(DateTime dateTime)
        {
            List<Models.test3.UrunDegerler> urunDegerlers = testDB.UrunDegerler.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi>dateTime).ToList();
            writeToFiles.WriteToFile("UrunDegerler Atılıyor Toplam Sayı: " + urunDegerlers.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in urunDegerlers)
            {
                try
                {
                    if (webDB.UrunDegerler.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.UrunDegerler urunDegerler = webDB.UrunDegerler.Where(x => x.Oid == item.Oid).FirstOrDefault();

                        urunDegerler.Deger = item.Deger;
                        urunDegerler.Degerler = item.Degerler;
                        urunDegerler.EngDeger = item.EngDeger;
                        urunDegerler.Gcrecord = item.Gcrecord;
                        urunDegerler.Oid = item.Oid;
                        urunDegerler.OlusturanKisi = item.OlusturanKisi;
                        urunDegerler.OlusturmaTarihi = item.OlusturmaTarihi;
                        urunDegerler.OptimisticLockField = item.OptimisticLockField;
                        urunDegerler.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        urunDegerler.Urunler = item.Urunler;
                        webDB.UrunDegerler.Update(urunDegerler);
                        writeToFiles.WriteToFile("UrunDegerler Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.UrunDegerler urunDegerler = new Models.LandeWeb.UrunDegerler();
                        urunDegerler.Deger = item.Deger;
                        urunDegerler.Degerler = item.Degerler;
                        urunDegerler.EngDeger = item.EngDeger;
                        urunDegerler.Gcrecord = item.Gcrecord;
                        urunDegerler.Oid = item.Oid;
                        urunDegerler.OlusturanKisi = item.OlusturanKisi;
                        urunDegerler.OlusturmaTarihi = item.OlusturmaTarihi;
                        urunDegerler.OptimisticLockField = item.OptimisticLockField;
                        urunDegerler.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        urunDegerler.Urunler = item.Urunler;
                        webDB.UrunDegerler.Add(urunDegerler);
                        writeToFiles.WriteToFile("UrunDegerler Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("UrunDegerler Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("UrunDegerler Successfull", urunDegerlers.Count, add, update, error);
        }

    }
}
