using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;
namespace WindowsServiceHosting.Controllers
{

    public class KapakController
    {
        WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();
        public void GetKapakOpsiyonları(DateTime dateTime)
        {
            List<Models.test3.KapakOpsiyonlari> kapakOpsiyonlaris = testDB.KapakOpsiyonlari.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
            writeToFiles.WriteToFile("KapakOpsiyonlari Atılıyor Toplam Sayı: " + kapakOpsiyonlaris.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in kapakOpsiyonlaris)
            {
                try
                {
                    if (webDB.KapakOpsiyonlari.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.KapakOpsiyonlari kapakOpsiyonlari = webDB.KapakOpsiyonlari.Where(x => x.Oid == item.Oid ).FirstOrDefault();
                        kapakOpsiyonlari.Engopsiyon = item.Engopsiyon;
                        kapakOpsiyonlari.Engweb = item.Engweb;
                        //kapakOpsiyonlari.Fotograflar = item.Fotograflar;
                        kapakOpsiyonlari.Gcrecord = item.Gcrecord;
                        //kapakOpsiyonlari.KapakOpsiyonDoc = item.KapakOpsiyonDoc;
                        kapakOpsiyonlari.Oid = item.Oid;
                        kapakOpsiyonlari.OlusturanKisi = item.OlusturanKisi;
                        kapakOpsiyonlari.OlusturmaTarihi = item.OlusturmaTarihi;
                        kapakOpsiyonlari.Opsiyon = item.Opsiyon;
                        kapakOpsiyonlari.OpsiyonKodu = item.OpsiyonKodu;
                        kapakOpsiyonlari.OptimisticLockField = item.OptimisticLockField;
                        kapakOpsiyonlari.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        //kapakOpsiyonlari.Taglar = item.Taglar;
                        kapakOpsiyonlari.UrunAilesi = item.UrunAilesi;
                        //kapakOpsiyonlari.UrunAilesiNavigation = item.UrunAilesiNavigation;
                        kapakOpsiyonlari.UrunGrubu = item.UrunGrubu;
                        //kapakOpsiyonlari.UrunGrubuNavigation = item.UrunGrubuNavigation;
                        kapakOpsiyonlari.Urunler = item.Urunler;
                        //kapakOpsiyonlari.UrunlerNavigation = item.UrunlerNavigation;
                        kapakOpsiyonlari.UrunSerisi = item.UrunSerisi;
                        //kapakOpsiyonlari.UrunSerisiNavigation = item.UrunSerisiNavigation;
                        kapakOpsiyonlari.Web = item.Web;
                        webDB.KapakOpsiyonlari.Update(kapakOpsiyonlari);
                        writeToFiles.WriteToFile("KapakOpsiyonlari Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.KapakOpsiyonlari kapakOpsiyonlari = new Models.LandeWeb.KapakOpsiyonlari();
                        kapakOpsiyonlari.Engopsiyon = item.Engopsiyon;
                        kapakOpsiyonlari.Engweb = item.Engweb;
                        //kapakOpsiyonlari.Fotograflar = item.Fotograflar;
                        kapakOpsiyonlari.Gcrecord = item.Gcrecord;
                        //kapakOpsiyonlari.KapakOpsiyonDoc = item.KapakOpsiyonDoc;
                        kapakOpsiyonlari.Oid = item.Oid;
                        kapakOpsiyonlari.OlusturanKisi = item.OlusturanKisi;
                        kapakOpsiyonlari.OlusturmaTarihi = item.OlusturmaTarihi;
                        kapakOpsiyonlari.Opsiyon = item.Opsiyon;
                        kapakOpsiyonlari.OpsiyonKodu = item.OpsiyonKodu;
                        kapakOpsiyonlari.OptimisticLockField = item.OptimisticLockField;
                        kapakOpsiyonlari.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        //kapakOpsiyonlari.Taglar = item.Taglar;
                        kapakOpsiyonlari.UrunAilesi = item.UrunAilesi;
                        //kapakOpsiyonlari.UrunAilesiNavigation = item.UrunAilesiNavigation;
                        kapakOpsiyonlari.UrunGrubu = item.UrunGrubu;
                        //kapakOpsiyonlari.UrunGrubuNavigation = item.UrunGrubuNavigation;
                        kapakOpsiyonlari.Urunler = item.Urunler;
                        //kapakOpsiyonlari.UrunlerNavigation = item.UrunlerNavigation;
                        kapakOpsiyonlari.UrunSerisi = item.UrunSerisi;
                        //kapakOpsiyonlari.UrunSerisiNavigation = item.UrunSerisiNavigation;
                        kapakOpsiyonlari.Web = item.Web;
                        webDB.KapakOpsiyonlari.Add(kapakOpsiyonlari);
                        writeToFiles.WriteToFile("KapakOpsiyonlari Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("KapakOpsiyonlari Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("KapakOpsiyonlari Successfull", kapakOpsiyonlaris.Count, add, update, error);
        }


        public void GetKapakOpsiyonDoc(DateTime dateTime)
        {
            List<Models.test3.KapakOpsiyonDoc> kapakOpsiyonDocs = testDB.KapakOpsiyonDoc.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
            writeToFiles.WriteToFile("KapakOpsiyonDoc Atılıyor Toplam Sayı: " + kapakOpsiyonDocs.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in kapakOpsiyonDocs)
            {
                try
                {
                    if (webDB.KapakOpsiyonDoc.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.KapakOpsiyonDoc kapakOpsiyonDoc = webDB.KapakOpsiyonDoc.Where(x => x.Oid == item.Oid ).FirstOrDefault();
                        kapakOpsiyonDoc.DokumanAdi = item.DokumanAdi;
                        kapakOpsiyonDoc.DokumanType = item.DokumanType;
                        kapakOpsiyonDoc.DokumanUzanti = item.DokumanUzanti;
                        kapakOpsiyonDoc.File = item.File;
                        kapakOpsiyonDoc.Gcrecord = item.Gcrecord;
                        kapakOpsiyonDoc.KapakOpsiyonlari = item.KapakOpsiyonlari;
                        kapakOpsiyonDoc.OcrText = item.OcrText;
                        kapakOpsiyonDoc.Oid = item.Oid;
                        kapakOpsiyonDoc.OlusturanKisi = item.OlusturanKisi;
                        kapakOpsiyonDoc.OlusturmaTarihi = item.OlusturmaTarihi;
                        kapakOpsiyonDoc.OptimisticLockField = item.OptimisticLockField;
                        kapakOpsiyonDoc.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        kapakOpsiyonDoc.Web = item.Web;
                        webDB.KapakOpsiyonDoc.Update(kapakOpsiyonDoc);
                        writeToFiles.WriteToFile("KapakOpsiyonDoc Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.KapakOpsiyonDoc kapakOpsiyonDoc = new Models.LandeWeb.KapakOpsiyonDoc();
                        kapakOpsiyonDoc.DokumanAdi = item.DokumanAdi;
                        kapakOpsiyonDoc.DokumanType = item.DokumanType;
                        kapakOpsiyonDoc.DokumanUzanti = item.DokumanUzanti;
                        kapakOpsiyonDoc.File = item.File;
                        kapakOpsiyonDoc.Gcrecord = item.Gcrecord;
                        kapakOpsiyonDoc.KapakOpsiyonlari = item.KapakOpsiyonlari;
                        kapakOpsiyonDoc.OcrText = item.OcrText;
                        kapakOpsiyonDoc.Oid = item.Oid;
                        kapakOpsiyonDoc.OlusturanKisi = item.OlusturanKisi;
                        kapakOpsiyonDoc.OlusturmaTarihi = item.OlusturmaTarihi;
                        kapakOpsiyonDoc.OptimisticLockField = item.OptimisticLockField;
                        kapakOpsiyonDoc.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        kapakOpsiyonDoc.Web = item.Web;
                        webDB.KapakOpsiyonDoc.Add(kapakOpsiyonDoc);
                        writeToFiles.WriteToFile("KapakOpsiyonDoc Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("KapakOpsiyonDoc Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("KapakOpsiyonDoc Successfull", kapakOpsiyonDocs.Count, add, update, error);
        }





    }
}
