using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.test3;
using WindowsServiceHosting.Models.LandeWeb;
namespace WindowsServiceHosting.Controllers
{
    public class AksesuarController
    {

        WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();
        public void GetAksesuarGrubu(DateTime dateTime)
        {
            List<Models.test3.AksesuarGrubu> aksesuarGrubus = testDB.AksesuarGrubu.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
            writeToFiles.WriteToFile("AksesuarGrubu Atılıyor Toplam Sayı: " + aksesuarGrubus.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in aksesuarGrubus)
            {
                try
                {
                    if (webDB.AksesuarGrubu.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.AksesuarGrubu aksesuarGrubu = webDB.AksesuarGrubu.Where(x => x.Oid == item.Oid).FirstOrDefault();

                        aksesuarGrubu.Aciklama = item.Aciklama;
                        //aksesuarGrubu.Aksesuar = item.Aksesuar;
                        aksesuarGrubu.AksesuarGrupAdi = item.AksesuarGrupAdi;
                        aksesuarGrubu.EngAciklama = item.EngAciklama;
                        aksesuarGrubu.EngAksesuarGrupAdi = item.EngAksesuarGrupAdi;
                        aksesuarGrubu.EngWeb = item.EngWeb;
                        aksesuarGrubu.EngWebUrl = item.EngWebUrl;
                        aksesuarGrubu.Fotograf = item.Fotograf;
                        aksesuarGrubu.Gcrecord = item.Gcrecord;
                        aksesuarGrubu.Index = item.Index;
                        aksesuarGrubu.Oid = item.Oid;
                        aksesuarGrubu.OptimisticLockField = item.OptimisticLockField;
                        aksesuarGrubu.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        aksesuarGrubu.Web = item.Web;
                        aksesuarGrubu.WebUrl = item.WebUrl;
                        webDB.AksesuarGrubu.Update(aksesuarGrubu);
                        writeToFiles.WriteToFile("AksesuarGrubu Güncellendi    " + item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.AksesuarGrubu aksesuarGrubu = new Models.LandeWeb.AksesuarGrubu();
                        aksesuarGrubu.Aciklama = item.Aciklama;
                        aksesuarGrubu.AksesuarGrupAdi = item.AksesuarGrupAdi;
                        aksesuarGrubu.EngAciklama = item.EngAciklama;
                        aksesuarGrubu.EngAksesuarGrupAdi = item.EngAksesuarGrupAdi;
                        aksesuarGrubu.EngWeb = item.EngWeb;
                        aksesuarGrubu.EngWebUrl = item.EngWebUrl;
                        aksesuarGrubu.Fotograf = item.Fotograf;
                        aksesuarGrubu.Gcrecord = item.Gcrecord;
                        aksesuarGrubu.Index = item.Index;
                        aksesuarGrubu.Oid = item.Oid;
                        aksesuarGrubu.OptimisticLockField = item.OptimisticLockField;
                        aksesuarGrubu.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        aksesuarGrubu.Web = item.Web;
                        aksesuarGrubu.WebUrl = item.WebUrl;
                        webDB.AksesuarGrubu.Add(aksesuarGrubu);
                        writeToFiles.WriteToFile("AksesuarGrubu Eklendi    " + item.Oid);
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
            writeToFiles.WriteToFile("AksesuarGrubu Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("AksesuarGrubu Successfull", aksesuarGrubus.Count, add, update, error);
        }

        public void GetAksesuar(DateTime dateTime)
        {
            List<Models.test3.Aksesuar> aksesuars = testDB.Aksesuar.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
            writeToFiles.WriteToFile("Aksesuar Atılıyor Toplam Sayı: " + aksesuars.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in aksesuars)
            {

                try
                {
                    if (webDB.Aksesuar.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.Aksesuar aksesuar = webDB.Aksesuar.Where(x => x.Oid == item.Oid).FirstOrDefault();
                        aksesuar.Aciklama = item.Aciklama;
                        aksesuar.AksesuarAdi = item.AksesuarAdi;
                        aksesuar.AksesuarAdi1 = item.AksesuarAdi1;
                        aksesuar.AksesuarGrubu = item.AksesuarGrubu;
                        aksesuar.AksesuarKodu = item.AksesuarKodu;
                        aksesuar.Boyut = item.Boyut;
                        aksesuar.EngAciklama = item.EngAciklama;
                        aksesuar.EngAksesuarAdi = item.EngAksesuarAdi;
                        aksesuar.EngWeb = item.EngWeb;
                        aksesuar.EngWebUrl = item.EngWebUrl;
                        aksesuar.Gcrecord = item.Gcrecord;
                        aksesuar.Index = item.Index;
                        aksesuar.Oid = item.Oid;
                        aksesuar.OlusturanKisi = item.OlusturanKisi;
                        aksesuar.OlusturmaTarihi = item.OlusturmaTarihi;
                        aksesuar.OptimisticLockField = item.OptimisticLockField;
                        aksesuar.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        aksesuar.StokKodu = item.StokKodu;
                        aksesuar.UrunAilesi = item.UrunAilesi;
                        aksesuar.UrunGrubu = item.UrunGrubu;
                        aksesuar.Urunler = item.Urunler;
                        aksesuar.UrunSerisi = item.UrunSerisi;
                        aksesuar.Web = item.Web;
                        aksesuar.WebUrl = item.WebUrl;
                        aksesuar.Yukseklik = item.Yukseklik;
                        webDB.Aksesuar.Update(aksesuar);
                        writeToFiles.WriteToFile("Aksesuar Güncellendi    " + item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.Aksesuar aksesuar = new Models.LandeWeb.Aksesuar();
                        aksesuar.Aciklama = item.Aciklama;
                        aksesuar.AksesuarAdi = item.AksesuarAdi;
                        aksesuar.AksesuarAdi1 = item.AksesuarAdi1;
                        aksesuar.AksesuarGrubu = item.AksesuarGrubu;
                        aksesuar.AksesuarKodu = item.AksesuarKodu;
                        aksesuar.Boyut = item.Boyut;
                        aksesuar.EngAciklama = item.EngAciklama;
                        aksesuar.EngAksesuarAdi = item.EngAksesuarAdi;
                        aksesuar.EngWeb = item.EngWeb;
                        aksesuar.EngWebUrl = item.EngWebUrl;
                        aksesuar.Gcrecord = item.Gcrecord;
                        aksesuar.Index = item.Index;
                        aksesuar.Oid = item.Oid;
                        aksesuar.OlusturanKisi = item.OlusturanKisi;
                        aksesuar.OlusturmaTarihi = item.OlusturmaTarihi;
                        aksesuar.OptimisticLockField = item.OptimisticLockField;
                        aksesuar.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        aksesuar.StokKodu = item.StokKodu;
                        aksesuar.UrunAilesi = item.UrunAilesi;
                        aksesuar.UrunGrubu = item.UrunGrubu;
                        aksesuar.Urunler = item.Urunler;
                        aksesuar.UrunSerisi = item.UrunSerisi;
                        aksesuar.Web = item.Web;
                        aksesuar.WebUrl = item.WebUrl;
                        aksesuar.Yukseklik = item.Yukseklik;
                        webDB.Aksesuar.Add(aksesuar);
                        writeToFiles.WriteToFile("Aksesuar Eklendi    " + item.Oid);
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
            writeToFiles.WriteToFile("Aksesuar Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("Aksesuar Successfull", aksesuars.Count, add, update, error);
        }
        public void GetAksesurDeger(DateTime dateTime)
        {
            List<Models.test3.AksesuarDeger> aksesuarDegers = testDB.AksesuarDeger.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
            writeToFiles.WriteToFile("AksesuarDeger Atılıyor Toplam Sayı: " + aksesuarDegers.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in aksesuarDegers)
            {

                try
                {
                    if (webDB.AksesuarDeger.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.AksesuarDeger aksesuarDeger = webDB.AksesuarDeger.Where(x => x.Oid == item.Oid).FirstOrDefault();
                        aksesuarDeger.Aksesuar = item.Aksesuar;
                        aksesuarDeger.Deger = item.Deger;
                        aksesuarDeger.Degerler = item.Degerler;
                        aksesuarDeger.EngDeger = item.EngDeger;
                        aksesuarDeger.Gcrecord = item.Gcrecord;
                        aksesuarDeger.Oid = item.Oid;
                        aksesuarDeger.OlusturanKisi = item.OlusturanKisi;
                        aksesuarDeger.OlusturmaTarihi = item.OlusturmaTarihi;
                        aksesuarDeger.OptimisticLockField = item.OptimisticLockField;
                        aksesuarDeger.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        webDB.AksesuarDeger.Update(aksesuarDeger);
                        writeToFiles.WriteToFile("AksesuarDeger Güncellendi    " + item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.AksesuarDeger aksesuarDeger = new Models.LandeWeb.AksesuarDeger();
                        aksesuarDeger.Aksesuar = item.Aksesuar;
                        aksesuarDeger.Deger = item.Deger;
                        aksesuarDeger.Degerler = item.Degerler;
                        aksesuarDeger.EngDeger = item.EngDeger;
                        aksesuarDeger.Gcrecord = item.Gcrecord;
                        aksesuarDeger.Oid = item.Oid;
                        aksesuarDeger.OlusturanKisi = item.OlusturanKisi;
                        aksesuarDeger.OlusturmaTarihi = item.OlusturmaTarihi;
                        aksesuarDeger.OptimisticLockField = item.OptimisticLockField;
                        aksesuarDeger.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        webDB.AksesuarDeger.Add(aksesuarDeger);
                        writeToFiles.WriteToFile("AksesuarDeger Eklendi     " + item.Oid);
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
            writeToFiles.WriteToFile("AksesuarDeger Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("AksesuarDeger Successfull", aksesuarDegers.Count, add, update, error);
        }
    }
}
