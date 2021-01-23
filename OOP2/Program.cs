using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekmusteri1 = new GercekMusteri();
            gercekmusteri1.Id = 1;
            gercekmusteri1.MusteriNo = "12352";
            gercekmusteri1.Adi = "Emre";
            gercekmusteri1.Soyadi = "Yalnızlar";
            gercekmusteri1.TcNo = "5267200220";

            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.Id = 2;
            tuzelMusteri.SirketAdi = "YalnızlarCompany";
            tuzelMusteri.MusteriNo = "5643464";
            tuzelMusteri.VergiNo = "56565";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(gercekmusteri1);
            musteriManager.Ekle(tuzelMusteri);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

        }
    }
}
