using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;

namespace WindowsServiceHosting.Controllers
{
    public class ReklamlarController
    {
        WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();
        public void GetReklamlar(DateTime dateTime)
        {
            List<Models.test3.Reklamlar> reklamlars = testDB.Reklamlar.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi > dateTime).ToList();
            writeToFiles.WriteToFile("Reklamlar Atılıyor Toplam Sayı: " + reklamlars.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in reklamlars)
            {
                try
                {
                    if (webDB.Reklamlar.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.Reklamlar reklamlar = webDB.Reklamlar.Where(x => x.Oid == item.Oid ).FirstOrDefault();

                         reklamlar.Aktif=item.Aktif;
                         reklamlar.Baslik =item.Baslik;
                         reklamlar.Gcrecord=item.Gcrecord;
                         reklamlar.Image=item.Image;
                         reklamlar.Oid=item.Oid;
                         reklamlar.OlusturanKisi=item.OlusturanKisi;
                         reklamlar.OlusturmaTarihi=item.OlusturmaTarihi;
                         reklamlar.OptimisticLockField=item.OptimisticLockField;
                         reklamlar.SonGuncellemeTarihi=item.SonGuncellemeTarihi;
                         reklamlar.Web=item.Web;
                        webDB.Reklamlar.Update(reklamlar);
                        writeToFiles.WriteToFile("Reklamlar Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {

                        Models.LandeWeb.Reklamlar reklamlar = new Models.LandeWeb.Reklamlar();
                        reklamlar.Aktif = item.Aktif;
                        reklamlar.Baslik = item.Baslik;
                        reklamlar.Gcrecord = item.Gcrecord;
                        reklamlar.Image = item.Image;
                        reklamlar.Oid = item.Oid;
                        reklamlar.OlusturanKisi = item.OlusturanKisi;
                        reklamlar.OlusturmaTarihi = item.OlusturmaTarihi;
                        reklamlar.OptimisticLockField = item.OptimisticLockField;
                        reklamlar.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        reklamlar.Web = item.Web;
                        webDB.Reklamlar.Add(reklamlar);
                        writeToFiles.WriteToFile("Reklamlar Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("Reklamlar Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("Reklamlar Successfull", reklamlars.Count, add, update, error);
        }
    }
       
}
