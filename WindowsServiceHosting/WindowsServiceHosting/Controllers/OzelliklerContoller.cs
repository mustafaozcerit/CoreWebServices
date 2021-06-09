using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;
namespace WindowsServiceHosting.Controllers
{
    public class OzelliklerContoller
    {

        WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();
        public void GetOzellikler(DateTime dateTime)
        {
            List<Models.test3.Ozellikler> ozelliklers = testDB.Ozellikler.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
            writeToFiles.WriteToFile("Ozellikler Atılıyor Toplam Sayı: " + ozelliklers.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in ozelliklers)
            {
                try
                {
                    if (webDB.Ozellikler.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.Ozellikler ozellikler = webDB.Ozellikler.Where(x => x.Oid == item.Oid).FirstOrDefault();

                        ozellikler.Oid = item.Oid;
                        ozellikler.EngOzellikAdi = item.EngOzellikAdi;
                        ozellikler.EngWeb = item.EngWeb;
                        ozellikler.Gcrecord = item.Gcrecord;
                        ozellikler.OlusturanKisi = item.OlusturanKisi;
                        ozellikler.OlusturmaTarihi = item.OlusturmaTarihi;
                        ozellikler.OptimisticLockField = item.OptimisticLockField;
                        ozellikler.OzellikAdi = item.OzellikAdi;
                        ozellikler.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        ozellikler.Web = item.Web;
                        webDB.Ozellikler.Update(ozellikler);
                        writeToFiles.WriteToFile("Ozellikler Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.Ozellikler ozellikler = new Models.LandeWeb.Ozellikler();
                        ozellikler.Oid = item.Oid;
                        ozellikler.EngOzellikAdi = item.EngOzellikAdi;
                        ozellikler.EngWeb = item.EngWeb;
                        ozellikler.Gcrecord = item.Gcrecord;
                        ozellikler.OlusturanKisi = item.OlusturanKisi;
                        ozellikler.OlusturmaTarihi = item.OlusturmaTarihi;
                        ozellikler.OptimisticLockField = item.OptimisticLockField;
                        ozellikler.OzellikAdi = item.OzellikAdi;
                        ozellikler.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        ozellikler.Web = item.Web;
                        webDB.Ozellikler.Add(ozellikler);
                        writeToFiles.WriteToFile("Ozellikler Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("Ozellikler Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("Ozellikler Successfull", ozelliklers.Count, add, update, error);
        }

    }
}
