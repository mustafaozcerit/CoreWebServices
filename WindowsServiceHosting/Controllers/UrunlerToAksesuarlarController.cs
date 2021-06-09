using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;

namespace WindowsServiceHosting.Controllers
{
    public class UrunlerToAksesuarlarController
    {
        WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();
        public void GetUrunlerToAksesuarlar(DateTime dateTime)
        {
            List<Models.test3.UrunlerurunlerAksesuaraksesuar> urunlerurunlerAksesuaraksesuars = testDB.UrunlerurunlerAksesuaraksesuar.Where(x=> x.SonGuncellemeTarihi>dateTime).ToList();
            writeToFiles.WriteToFile("UrunlerurunlerAksesuaraksesuar Atılıyor Toplam Sayı: " + urunlerurunlerAksesuaraksesuars.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in urunlerurunlerAksesuaraksesuars)
            {
                try
                {
                    if (webDB.UrunlerurunlerAksesuaraksesuar.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.UrunlerurunlerAksesuaraksesuar urunlerurunlerAksesuaraksesuar = webDB.UrunlerurunlerAksesuaraksesuar.Where(x => x.Oid == item.Oid).FirstOrDefault();
                        urunlerurunlerAksesuaraksesuar.Aksesuar = item.Aksesuar;
                        urunlerurunlerAksesuaraksesuar.Oid = item.Oid;
                        urunlerurunlerAksesuaraksesuar.OptimisticLockField = item.OptimisticLockField;
                        urunlerurunlerAksesuaraksesuar.Urunler = item.Urunler;
                        webDB.UrunlerurunlerAksesuaraksesuar.Update(urunlerurunlerAksesuaraksesuar);
                        writeToFiles.WriteToFile("UrunlerurunlerAksesuaraksesuar Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {
                        Models.LandeWeb.UrunlerurunlerAksesuaraksesuar urunlerurunlerAksesuaraksesuar = new Models.LandeWeb.UrunlerurunlerAksesuaraksesuar();
                        urunlerurunlerAksesuaraksesuar.Aksesuar = item.Aksesuar;
                        urunlerurunlerAksesuaraksesuar.Oid = item.Oid;
                        urunlerurunlerAksesuaraksesuar.OptimisticLockField = item.OptimisticLockField;
                        urunlerurunlerAksesuaraksesuar.Urunler = item.Urunler;
                        webDB.UrunlerurunlerAksesuaraksesuar.Update(urunlerurunlerAksesuaraksesuar);
                        webDB.UrunlerurunlerAksesuaraksesuar.Add(urunlerurunlerAksesuaraksesuar);
                        writeToFiles.WriteToFile("UrunlerurunlerAksesuaraksesuar Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("UrunlerurunlerAksesuaraksesuar Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("UrunlerurunlerAksesuaraksesuar Successfull", urunlerurunlerAksesuaraksesuars.Count, add, update, error);
        }


    }
}
