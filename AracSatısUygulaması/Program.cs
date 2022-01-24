using System;
using System.Collections.Generic;
using System.IO;

namespace AracSatısUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Araçlarımız Json formatında c:\\JsonIslemlerim klasörüne Araclar.json dosyası olarak kaydedilecektir.\n\n");
            Console.WriteLine("Araçlarımızın özellikleri:\n");
            AracSatişIlişkisi();
            


        }
        public static void AracSatişIlişkisi()
        {
            List<Arac> AracListesi = new List<Arac>();
            Arac arac1 = new Arac()
            {
                ID = 1,
                Fiyat = 220500,
                Kilometre = 99.418,
                MotorGucu = "100 BG ve Altı",
                MotorHacmi = "1300 cc ve Altı",
                Marka = "Fiat",
                Model = "Linea",
                Yil = "2017",
                AracDurumu = "Hasarsız",
                VitesTipi = "Düz Vites",
                YakitTuru = "Benzin",
                Renk = "Beyaz"
            };
            AracListesi.Add(arac1);
            Arac arac2 = new Arac()
            {
                ID = 2,
                Fiyat = 82000000,
                Kilometre = 0,
                MotorGucu = "1500 hp",
                MotorHacmi = "7993 cc",
                Marka = "Bugatti",
                Model = "Chiron ",
                Yil = "2020",
                AracDurumu = "Hasarsız",
                VitesTipi = "Otomatik",
                YakitTuru = "Benzin",
                Renk = "Mavi"
            };
            AracListesi.Add(arac2);
            Arac arac3 = new Arac()
            {
                ID = 3,
                Fiyat = 220000,
                Kilometre = 10000,
                MotorGucu = "100 BG ve Altı",
                MotorHacmi = "1300 cc ve Altı",
                Marka = "Fiat",
                Model = "Linea",
                Yil = "2014",
                AracDurumu = "Hasarsız",
                VitesTipi = "Düz Vites",
                YakitTuru = "Benzin",
                Renk = "Siyah"
            };
            AracListesi.Add(arac3);
            Arac arac4 = new Arac()
            {
                ID = 4,
                Fiyat = 226250,
                Kilometre = 75944,
                MotorGucu = "100 BG ve Altı",
                MotorHacmi = "1,3",
                Marka = "Fiat",
                Model = "EGEA",
                Yil = "2019",
                AracDurumu = "Hasarsız",
                VitesTipi = "Düz Vites",
                YakitTuru = "Dizel",
                Renk = "Beyaz"
            };
            AracListesi.Add(arac4);
            Arac arac5 = new Arac()
            {
                ID = 5,
                Fiyat = 510000,
                Kilometre = 11314,
                MotorGucu = "100 BG ve Altı",
                MotorHacmi = "1,3",
                Marka = "JEEP",
                Model = "RENEGADE",
                Yil = "2021",
                AracDurumu = "Hasarsız",
                VitesTipi = "Yarı Otomatik",
                YakitTuru = "Benzin",
                Renk = "GRANİT GRİ"
            };
            AracListesi.Add(arac5);

            if (Directory.Exists("c:\\JsonIslemlerim\\"))
            {
                //  /ilgili klasör varsa işlem yapmıyoruz

            }
            else
            {
                Directory.CreateDirectory("c:\\JsonIslemlerim\\");
            }

            string JsonAraclarim = Newtonsoft.Json.JsonConvert.SerializeObject(AracListesi);

            File.WriteAllText("c:\\JsonIslemlerim\\Araclar.json", JsonAraclarim);
            
            for (int i = 0; i < AracListesi.Count; i++)
            {
                Console.WriteLine(AracListesi[i]);
            }

            Console.WriteLine("Müşteri listesi ve satın aldıkları araçlar\n\n");
            List<Musteri> MusteriListesi = new List<Musteri>();

            Musteri musteri1 = new Musteri()
            {
                ID = 1,
                TC = "12345678910",
                Isim = "Osman Erdem",
                Soyad = "KILIÇ",
                Tel = "05353693636",
                Adres = "Bursa",
                SatilanArac = arac2
             };
             MusteriListesi.Add(musteri1);
            Musteri musteri2 = new Musteri()
            {
                ID = 2,
                TC = "35648256984",
                Isim = "İkbal",
                Soyad = "DELİBAŞ",
                Tel = "05317106003",
                Adres = "Rize",
                SatilanArac = arac1
            };
            MusteriListesi.Add(musteri2);
            Musteri musteri3 = new Musteri()
            {
                ID = 3,
                TC = "56845972103",
                Isim = "Melike",
                Soyad = "ÇELİKEL",
                Tel = "05353658745",
                Adres = "İzmir",
                SatilanArac = arac3
            };
            MusteriListesi.Add(musteri3);
            Musteri musteri4 = new Musteri()
            {
                ID = 4,
                TC = "16462556498",
                Isim = "Ataberk",
                Soyad = "ÖZDEMİR",
                Tel = "05616186600",
                Adres = "Aydın",
                SatilanArac = arac4
            };
            MusteriListesi.Add(musteri4);
            Musteri musteri5 = new Musteri()
            {
                ID = 5,
                TC = "16462556498",
                Isim = "Semih",
                Soyad = "ÖNDER",
                Tel = "05616186600",
                Adres = "Bursa",
                SatilanArac = arac5
            };
            MusteriListesi.Add(musteri5);

            string JsonMusterilerim = Newtonsoft.Json.JsonConvert.SerializeObject(MusteriListesi);

             File.WriteAllText("c:\\JsonIslemlerim\\Musteriler.json", JsonMusterilerim);

            for (int i = 0; i<MusteriListesi.Count; i++)
            {
                Console.WriteLine(MusteriListesi[i]);
            }
            Console.ReadLine();

            
        }
       
           
    }
}
