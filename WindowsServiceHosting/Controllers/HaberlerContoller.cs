using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;

namespace WindowsServiceHosting.Controllers
{
    public class HaberlerContoller
    {
        WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();
        public void GetHabeler(DateTime dateTime)
        {
            List<Models.test3.Haberler> haberlers = testDB.Haberler.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
            writeToFiles.WriteToFile("Haberler Atılıyor Toplam Sayı: " + haberlers.Count +"  Tarih: "+DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in haberlers)
            {
                try
                {
                    if (webDB.Haberler.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.Haberler haberler = webDB.Haberler.Where(x => x.Oid == item.Oid ).FirstOrDefault();
                        haberler.Gcrecord = item.Gcrecord;
                        haberler.HaberAciklama = item.HaberAciklama;
                        haberler.HaberBaslik = item.HaberBaslik;
                        haberler.HaberFoto = item.HaberFoto;
                        haberler.HaberLink = item.HaberLink;
                        haberler.HaberTarih = item.HaberTarih;
                        haberler.Index = item.Index;
                        haberler.Oid = item.Oid;
                        haberler.OlusturanKisi = item.OlusturanKisi;
                        haberler.OlusturmaTarihi = item.OlusturmaTarihi;
                        haberler.OptimisticLockField = item.OptimisticLockField;
                        haberler.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        haberler.Web = item.Web;
                        webDB.Haberler.Update(haberler);
                        writeToFiles.WriteToFile("Haberler Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.Haberler haberler = new Models.LandeWeb.Haberler();
                        haberler.Gcrecord = item.Gcrecord;
                        haberler.HaberAciklama = item.HaberAciklama;
                        haberler.HaberBaslik = item.HaberBaslik;
                        haberler.HaberFoto = item.HaberFoto;
                        haberler.HaberLink = item.HaberLink;
                        haberler.HaberTarih = item.HaberTarih;
                        haberler.Index = item.Index;
                        haberler.Oid = item.Oid;
                        haberler.OlusturanKisi = item.OlusturanKisi;
                        haberler.OlusturmaTarihi = item.OlusturmaTarihi;
                        haberler.OptimisticLockField = item.OptimisticLockField;
                        haberler.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        haberler.Web = item.Web;
                        webDB.Haberler.Add(haberler);
                        writeToFiles.WriteToFile("Haberler Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("Haberler Successfull "+"Tarih: " + DateTime.Now);
            writeToFiles.Control("Haberler Successfull", haberlers.Count, add, update, error);
        }
    }
}
