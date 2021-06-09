using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Models.LandeWeb;
using WindowsServiceHosting.Models.test3;

namespace WindowsServiceHosting.Controllers
{
    public class VideoController
    {
        WriteToFiles writeToFiles = new WriteToFiles();
        test3Context testDB = new test3Context();
        LandeWebContext webDB = new LandeWebContext();
        public void GetVideolarSayfasi(DateTime dateTime)
        {
            List<Models.test3.VideolarSayfasi> videolarSayfasis = testDB.VideolarSayfasi.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi>dateTime).ToList();
            writeToFiles.WriteToFile("VideolarSayfasi Atılıyor Toplam Sayı: " + videolarSayfasis.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in videolarSayfasis)
            {
                try
                {
                    if (webDB.VideolarSayfasi.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.VideolarSayfasi videolarSayfasi = webDB.VideolarSayfasi.Where(x => x.Oid == item.Oid).FirstOrDefault();
                        videolarSayfasi.Baslik = item.Baslik;
                            videolarSayfasi.BaslikEng =item.BaslikEng;
                            videolarSayfasi.EngWeb=item.EngWeb;
                            videolarSayfasi.Gcrecord=item.Gcrecord;
                            videolarSayfasi.Index=item.Index;
                            videolarSayfasi.Oid=item.Oid;
                            videolarSayfasi.OlusturanKisi=item.OlusturanKisi;
                            videolarSayfasi.OlusturmaTarihi=item.OlusturmaTarihi;
                            videolarSayfasi.OptimisticLockField=item.OptimisticLockField;
                            videolarSayfasi.SonGuncellemeTarihi=item.SonGuncellemeTarihi;
                            videolarSayfasi.Web=item.Web;
                            webDB.VideolarSayfasi.Update(videolarSayfasi);
                            writeToFiles.WriteToFile("VideolarSayfasi Güncellendi    "+item.Oid);
                            update++;

                    }
                    else
                    {

                        Models.LandeWeb.VideolarSayfasi videolarSayfasi = new Models.LandeWeb.VideolarSayfasi();
                        videolarSayfasi.Baslik = item.Baslik;
                        videolarSayfasi.BaslikEng = item.BaslikEng;
                        videolarSayfasi.EngWeb = item.EngWeb;
                        videolarSayfasi.Gcrecord = item.Gcrecord;
                        videolarSayfasi.Index = item.Index;
                        videolarSayfasi.Oid = item.Oid;
                        videolarSayfasi.OlusturanKisi = item.OlusturanKisi;
                        videolarSayfasi.OlusturmaTarihi = item.OlusturmaTarihi;
                        videolarSayfasi.OptimisticLockField = item.OptimisticLockField;
                        videolarSayfasi.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        videolarSayfasi.Web = item.Web;
                        webDB.VideolarSayfasi.Add(videolarSayfasi);
                        writeToFiles.WriteToFile("VideolarSayfasi Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("VideolarSayfasi Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("Youtube Successfull", videolarSayfasis.Count, add, update, error);

        }

        public void GetYoutubeVideo(DateTime dateTime)
        {
            List<Models.test3.YoutubeVideo> youtubeVideos = testDB.YoutubeVideo.Where(x => x.Gcrecord == null && x.SonGuncellemeTarihi>dateTime).ToList();
            writeToFiles.WriteToFile("YoutubeVideo Atılıyor Toplam Sayı: " + youtubeVideos.Count + "  Tarih: " + DateTime.Now);
            int add = 0;
            int update = 0;
            int error = 0;
            foreach (var item in youtubeVideos)
            {
                try
                {
                    if (webDB.YoutubeVideo.Where(x => x.Oid == item.Oid).ToList().Count > 0)
                    {
                        Models.LandeWeb.YoutubeVideo youtubeVideo = webDB.YoutubeVideo.Where(x => x.Oid == item.Oid).FirstOrDefault();
                        youtubeVideo.Aciklama=item.Aciklama;
                        youtubeVideo.AnasayfadaGoster=item.AnasayfadaGoster;
                        youtubeVideo.EngAciklama=item.EngAciklama;
                        youtubeVideo.Gcrecord=item.Gcrecord;
                        youtubeVideo.Index=item.Index;
                        youtubeVideo.Link=item.Link;
                        youtubeVideo.Oid=item.Oid;
                        youtubeVideo.OlusturanKisi=item.OlusturanKisi;
                        youtubeVideo.OlusturmaTarihi=item.OlusturmaTarihi;
                        youtubeVideo.OptimisticLockField=item.OptimisticLockField;
                        youtubeVideo.ResimLinki=item.ResimLinki;
                        youtubeVideo.SonGuncellemeTarihi=item.SonGuncellemeTarihi;
                        youtubeVideo.Value=item.Value;
                        youtubeVideo.VideolarSayfasi=item.VideolarSayfasi;
                        webDB.YoutubeVideo.Update(youtubeVideo);
                        writeToFiles.WriteToFile("YoutubeVideo Güncellendi    "+item.Oid);
                        update++;
                    }
                    else
                    {

                        Models.LandeWeb.YoutubeVideo youtubeVideo = new Models.LandeWeb.YoutubeVideo();
                        youtubeVideo.Aciklama = item.Aciklama;
                        youtubeVideo.AnasayfadaGoster = item.AnasayfadaGoster;
                        youtubeVideo.EngAciklama = item.EngAciklama;
                        youtubeVideo.Gcrecord = item.Gcrecord;
                        youtubeVideo.Index = item.Index;
                        youtubeVideo.Link = item.Link;
                        youtubeVideo.Oid = item.Oid;
                        youtubeVideo.OlusturanKisi = item.OlusturanKisi;
                        youtubeVideo.OlusturmaTarihi = item.OlusturmaTarihi;
                        youtubeVideo.OptimisticLockField = item.OptimisticLockField;
                        youtubeVideo.ResimLinki = item.ResimLinki;
                        youtubeVideo.SonGuncellemeTarihi = item.SonGuncellemeTarihi;
                        youtubeVideo.Value = item.Value;
                        youtubeVideo.VideolarSayfasi = item.VideolarSayfasi;
                        webDB.YoutubeVideo.Add(youtubeVideo);
                        writeToFiles.WriteToFile("YoutubeVideo Eklendi    "+item.Oid);
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
            writeToFiles.WriteToFile("YoutubeVideo Successfull " + "Tarih: " + DateTime.Now);
            writeToFiles.Control("Youtube Successfull", youtubeVideos.Count, add, update, error);
        }
    }
}
