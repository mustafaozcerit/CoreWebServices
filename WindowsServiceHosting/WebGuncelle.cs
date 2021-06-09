using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting.Controllers;
using WindowsServiceHosting.Models.DateUpdate;

namespace WindowsServiceHosting
{
    public class WebGuncelle
    {
        WriteToFiles writeToFiles = new WriteToFiles();

        public void Guncelle(DateTime dateTime)
        {

            writeToFiles.WriteToFile("WebGuncelleme  Başlıyor " + DateTime.Now);

            AksesuarController aksesuarController = new AksesuarController();

            FileDataController fileDataController = new FileDataController();


            HaberlerContoller haberlerContoller = new HaberlerContoller();

            ReklamlarController reklamlarController = new ReklamlarController();

            VideoController videoController = new VideoController();

            KataloglarController kataloglarController = new KataloglarController();

            DegerController degerController = new DegerController();

            OzelliklerContoller ozelliklerContoller = new OzelliklerContoller();

            YukseklikController yukseklikController = new YukseklikController();

            RenkController renkController = new RenkController();

            UrunController urunController = new UrunController();

            BoyutController boyutController = new BoyutController();

            KapakController kapakController = new KapakController();

            UrunlerToAksesuarlarController urunlerToAksesuarlarController = new UrunlerToAksesuarlarController();

            MontajKilavuzlariController montajKilavuzlariController = new MontajKilavuzlariController();

            KaliteDokumanlariController kaliteDokumanlariController = new KaliteDokumanlariController();

            SertifikalarController sertifikalarController = new SertifikalarController();

            TeknikCizimlerController teknikCizimlerController = new TeknikCizimlerController();

            DigerDokumanlarController digerDokumanlarController = new DigerDokumanlarController();

            TeknikSartnameController teknikSartnameController = new TeknikSartnameController();

            YonetimKadrosuController yonetimKadrosuController = new YonetimKadrosuController();

            HakkimizdaController hakkimizdaController = new HakkimizdaController();

            DateUpdateContoller dateUpdateContoller = new DateUpdateContoller();

            fileDataController.GetFileData(dateTime);

            haberlerContoller.GetHabeler(dateTime);

            reklamlarController.GetReklamlar(dateTime);

            videoController.GetVideolarSayfasi(dateTime);

            videoController.GetYoutubeVideo(dateTime);

            kataloglarController.GetKataloglarSayfasi(dateTime);

            degerController.GetDegerTipleri(dateTime);

            ozelliklerContoller.GetOzellikler(dateTime);

            degerController.GetDegerler(dateTime);

            yukseklikController.GetYukseklik(dateTime);

            renkController.GetRenk(dateTime);

            urunController.GetUrunAilesi(dateTime);

            urunController.GetUrunGrubu(dateTime);

            urunController.GetUrunSerisi(dateTime);

            boyutController.GetBoyut(dateTime);

            urunController.GetUrunler(dateTime);

            urunController.GetUrunDegerler(dateTime);

            kapakController.GetKapakOpsiyonları(dateTime);

            kapakController.GetKapakOpsiyonDoc(dateTime);

            aksesuarController.GetAksesuarGrubu(dateTime);

            aksesuarController.GetAksesuar(dateTime);

            urunlerToAksesuarlarController.GetUrunlerToAksesuarlar(dateTime);

            montajKilavuzlariController.GetMontajKilavuzlari(dateTime);

            kataloglarController.GetKataloglar(dateTime);

            kaliteDokumanlariController.GetKaliteDokumanlari(dateTime);

            sertifikalarController.GetSertifikalar(dateTime);

            teknikCizimlerController.GetTeknikCizimler(dateTime);

            digerDokumanlarController.GetDigerDokumanlar(dateTime);

            teknikSartnameController.GetTeknikSartname(dateTime);


            hakkimizdaController.GetHakkimizdaAltBilgi(dateTime);

            hakkimizdaController.GetHakkimizdaAltGrup(dateTime);

            yonetimKadrosuController.GetYonetimKadrosu(dateTime);

            dateUpdateContoller.UpdateSuccess();
        }

    }
}
