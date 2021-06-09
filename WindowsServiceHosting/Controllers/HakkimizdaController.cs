using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;
namespace WindowsServiceHosting.Controllers
{
    public class HakkimizdaController
    {
        WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();

        public void GetHakkimizdaAltBilgi(DateTime dateTime)
        {
            List<Guid> guids = webDB.HakkimizdaVeAltBilgi.Select(x => x.Oid).ToList();
            List<Models.test3.HakkimizdaVeAltBilgi> hakkimizdaVeAltBilgis = testDB.HakkimizdaVeAltBilgi.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
            writeToFiles.WriteToFile("Toplam Sayı: " + hakkimizdaVeAltBilgis.Count);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var hakkimizda in hakkimizdaVeAltBilgis)
            {
                try
                {
                    if (webDB.HakkimizdaVeAltBilgi.Where(x => x.Oid == hakkimizda.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.HakkimizdaVeAltBilgi hakkimizdaVeAltBilgi = webDB.HakkimizdaVeAltBilgi.Where(x => x.Oid == hakkimizda.Oid).FirstOrDefault();
                        hakkimizdaVeAltBilgi.AltBilgi = hakkimizda.AltBilgi;
                        hakkimizdaVeAltBilgi.EngAltBilgi = hakkimizda.EngAltBilgi;
                        hakkimizdaVeAltBilgi.EngHakkimizdaAciklama = hakkimizda.EngHakkimizdaAciklama;
                        hakkimizdaVeAltBilgi.EngHakkimizdaAciklama2 = hakkimizda.EngHakkimizdaAciklama2;
                        hakkimizdaVeAltBilgi.EngHakkimizdaBaslk = hakkimizda.EngHakkimizdaBaslk;
                        hakkimizdaVeAltBilgi.EngHakkimizdaBaslk2 = hakkimizda.EngHakkimizdaBaslk2;
                        hakkimizdaVeAltBilgi.Fotograf = hakkimizda.Fotograf;
                        hakkimizdaVeAltBilgi.Gcrecord = hakkimizda.Gcrecord;
                        hakkimizdaVeAltBilgi.HakkimizdaAciklama = hakkimizda.HakkimizdaAciklama;
                        hakkimizdaVeAltBilgi.HakkimizdaAciklama2 = hakkimizda.HakkimizdaAciklama2;
                        hakkimizdaVeAltBilgi.HakkimizdaBaslk = hakkimizda.HakkimizdaBaslk;
                        hakkimizdaVeAltBilgi.HakkimizdaBaslk2 = hakkimizda.HakkimizdaBaslk2;
                        hakkimizdaVeAltBilgi.Oid = hakkimizda.Oid;
                        hakkimizdaVeAltBilgi.OptimisticLockField = hakkimizda.OptimisticLockField;
                        hakkimizdaVeAltBilgi.SonGuncellemeTarihi = hakkimizda.SonGuncellemeTarihi;
                        webDB.HakkimizdaVeAltBilgi.Update(hakkimizdaVeAltBilgi);
                        writeToFiles.WriteToFile("Hakkımızda eve Alt Bilgi Güncellendi    " + hakkimizda.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.HakkimizdaVeAltBilgi hakkimizdaVeAltBilgi = new Models.LandeWeb.HakkimizdaVeAltBilgi();
                        hakkimizdaVeAltBilgi.AltBilgi = hakkimizda.AltBilgi;
                        hakkimizdaVeAltBilgi.EngAltBilgi = hakkimizda.EngAltBilgi;
                        hakkimizdaVeAltBilgi.EngHakkimizdaAciklama = hakkimizda.EngHakkimizdaAciklama;
                        hakkimizdaVeAltBilgi.EngHakkimizdaAciklama2 = hakkimizda.EngHakkimizdaAciklama2;
                        hakkimizdaVeAltBilgi.EngHakkimizdaBaslk = hakkimizda.EngHakkimizdaBaslk;
                        hakkimizdaVeAltBilgi.EngHakkimizdaBaslk2 = hakkimizda.EngHakkimizdaBaslk2;
                        hakkimizdaVeAltBilgi.Fotograf = hakkimizda.Fotograf;
                        hakkimizdaVeAltBilgi.Gcrecord = hakkimizda.Gcrecord;
                        hakkimizdaVeAltBilgi.HakkimizdaAciklama = hakkimizda.HakkimizdaAciklama;
                        hakkimizdaVeAltBilgi.HakkimizdaAciklama2 = hakkimizda.HakkimizdaAciklama2;
                        hakkimizdaVeAltBilgi.HakkimizdaBaslk = hakkimizda.HakkimizdaBaslk;
                        hakkimizdaVeAltBilgi.HakkimizdaBaslk2 = hakkimizda.HakkimizdaBaslk2;
                        hakkimizdaVeAltBilgi.Oid = hakkimizda.Oid;
                        hakkimizdaVeAltBilgi.OptimisticLockField = hakkimizda.OptimisticLockField;
                        hakkimizdaVeAltBilgi.SonGuncellemeTarihi = hakkimizda.SonGuncellemeTarihi;
                        webDB.HakkimizdaVeAltBilgi.Update(hakkimizdaVeAltBilgi);
                        webDB.HakkimizdaVeAltBilgi.Add(hakkimizdaVeAltBilgi);
                        writeToFiles.WriteToFile("Hakkımızda ve Alt Bilgi Eklendi    " + hakkimizda.Oid);
                        add++;
                    }
                }
                catch (Exception e)
                {
                    writeToFiles.WriteToFile("Hata: " + e.Message.ToString());
                    writeToFiles.Error(e.Message.ToString());
                    error++;
                }

            }
            webDB.SaveChanges();
            writeToFiles.WriteToFile("Hakkımızda Alt Bilgi Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("Hakkımızda Alt Bilgi  Successfull", hakkimizdaVeAltBilgis.Count, add, update, error);
        }


        public void GetHakkimizdaAltGrup(DateTime dateTime)
        {

            List<Models.test3.HakkimizdaAltGrup> HakkimizdaAltGrups = testDB.HakkimizdaAltGrup.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
            writeToFiles.WriteToFile("Toplam Sayı: " + HakkimizdaAltGrups.Count);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var hakkimizda in HakkimizdaAltGrups)
            {
                try
                {
                    if (webDB.HakkimizdaAltGrup.Where(x => x.Oid == hakkimizda.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.HakkimizdaAltGrup HakkimizdaAltGrup = webDB.HakkimizdaAltGrup.Where(x => x.Oid == hakkimizda.Oid).FirstOrDefault();
                        HakkimizdaAltGrup.EngGrupAciklama = hakkimizda.EngGrupAciklama;
                        HakkimizdaAltGrup.EngGrupBaslik2 = hakkimizda.EngGrupBaslik2;
                        HakkimizdaAltGrup.OptimisticLockField = hakkimizda.OptimisticLockField;
                        HakkimizdaAltGrup.SonGuncellemeTarihi = hakkimizda.SonGuncellemeTarihi;
                        HakkimizdaAltGrup.GrupAciklama = hakkimizda.GrupAciklama;
                        HakkimizdaAltGrup.GrupBaslik = hakkimizda.GrupBaslik;
                        HakkimizdaAltGrup.Hakkimizda = hakkimizda.Hakkimizda;
                        HakkimizdaAltGrup.Fotograf = hakkimizda.Fotograf;
                        HakkimizdaAltGrup.Gcrecord = hakkimizda.Gcrecord;
                        webDB.HakkimizdaAltGrup.Update(HakkimizdaAltGrup);
                        writeToFiles.WriteToFile("Hakkımızda eve Alt Grup Güncellendi    " + hakkimizda.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.HakkimizdaAltGrup HakkimizdaAltGrup = new Models.LandeWeb.HakkimizdaAltGrup();
                        HakkimizdaAltGrup.Oid = hakkimizda.Oid;
                        HakkimizdaAltGrup.EngGrupAciklama = hakkimizda.EngGrupAciklama;
                        HakkimizdaAltGrup.EngGrupBaslik2 = hakkimizda.EngGrupBaslik2;
                        HakkimizdaAltGrup.Fotograf = hakkimizda.Fotograf;
                        HakkimizdaAltGrup.Gcrecord = hakkimizda.Gcrecord;
                        HakkimizdaAltGrup.GrupAciklama = hakkimizda.GrupAciklama;
                        HakkimizdaAltGrup.GrupBaslik = hakkimizda.GrupBaslik;
                        HakkimizdaAltGrup.Hakkimizda = hakkimizda.Hakkimizda;
                        HakkimizdaAltGrup.HakkimizdaNavigation = (Models.LandeWeb.HakkimizdaVeAltBilgi)(ICollection<Models.LandeWeb.HakkimizdaVeAltBilgi>)hakkimizda.HakkimizdaNavigation;
                        HakkimizdaAltGrup.OptimisticLockField = hakkimizda.OptimisticLockField;
                        HakkimizdaAltGrup.SonGuncellemeTarihi = hakkimizda.SonGuncellemeTarihi;
                        writeToFiles.WriteToFile("Hakkımızda ve Alt Grup Eklendi    " + hakkimizda.Oid);
                        add++;
                    }
                }
                catch (Exception e)
                {
                    writeToFiles.WriteToFile("Hata: " + e.Message.ToString());
                    writeToFiles.Error(e.Message.ToString());
                    error++;
                }
                finally
                {
                    webDB.SaveChanges();
                }
            }
            writeToFiles.WriteToFile("Hakkımızda ve Alt Grup Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("Hakkımızda ve Alt Grup Successfull", HakkimizdaAltGrups.Count, add, update, error);
        }

    }
}
