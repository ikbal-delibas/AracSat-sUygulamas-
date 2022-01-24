using System;
using System.Collections.Generic;
using System.Text;

namespace AracSatısUygulaması
{
    class Musteri
    {
        public int ID { get; set; }
        public string TC { get; set; }
        public string Isim { get; set; }
        public string Soyad { get; set; }
        public string Tel { get; set; }
        public string Adres { get; set; }
        public Arac SatilanArac { get; set; }
        public override string ToString()
        {
            return "Müşteri bilgileri:\n\n"+ "TC: " + TC + "\nİsim: " + Isim + "\nSoyisim: " + Soyad + "\nTel: " + Tel + "\nAdres: " + Adres + "\n\nSatın aldığı araç bilgileri:\n\nMarka: " + SatilanArac.Marka + "\nFiyat: " + SatilanArac.Fiyat + " TL\n\n\n";
        }
    }
}
