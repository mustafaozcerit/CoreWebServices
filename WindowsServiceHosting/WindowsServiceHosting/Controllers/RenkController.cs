using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;

namespace WindowsServiceHosting.Controllers
{
    public class RenkController
    {

        WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();
        public void GetRenk(DateTime dateTime)
        {
            List<Models.test3.Renk> renks = testDB.Renk.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
            writeToFiles.WriteToFile("Renk Atılıyor Toplam Sayı: " + renks.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in renks)
            {
                try
                {
                    if (webDB.Renk.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.Renk renk = webDB.Renk.Where(x => x.Oid == item.Oid).FirstOrDefault();
                        renk.EngRenk = item.EngRenk;
                        renk.Gcrecord = item.Gcrecord;
                        renk.Oid = item.Oid;
                        renk.OptimisticLockField = item.OptimisticLockField;
                        renk.Renk1 = item.Renk1;
                        renk.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        //Urunler=item.Urunler;
                        renk.Web = item.Web;
                        webDB.Renk.Update(renk);
                        writeToFiles.WriteToFile("Renk Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.Renk renk = new Models.LandeWeb.Renk();
                        renk.EngRenk = item.EngRenk;
                        renk.Gcrecord = item.Gcrecord;
                        renk.Oid = item.Oid;
                        renk.OptimisticLockField = item.OptimisticLockField;
                        renk.Renk1 = item.Renk1;
                        renk.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        //Urunler=item.Urunler;
                        renk.Web = item.Web;
                        webDB.Renk.Add(renk);
                        writeToFiles.WriteToFile("Renk Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("Renk Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("Renk Successfull", renks.Count, add, update, error);
        }
    }
}
