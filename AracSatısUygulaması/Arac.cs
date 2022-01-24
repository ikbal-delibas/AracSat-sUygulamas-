using System;
using System.Collections.Generic;
using System.Text;

namespace AracSatısUygulaması
{
    class Arac
    {
        public int ID { get; set; }
        public string Marka { get; set; }
        public string Yil { get; set; }
        public string Model { get; set; }
        public int Fiyat { get; set; }
        public string AracDurumu { get; set; }
        public double Kilometre { get; set; }
        public string VitesTipi { get; set; }
        public string YakitTuru { get; set; }
        public string MotorGucu { get; set; }
        public string MotorHacmi { get; set; }
        public string Renk { get; set; }

        public override string ToString()
        {
            return "Marka: "+Marka+ "\nYıl: " + Yil+ "\nModel: " + Model+ "\nFiyat: " + Fiyat+ "\nAracDurumu: " + AracDurumu+ "\nKilometre: " + Kilometre+ "\nVitesTipi: " + VitesTipi+ "\nYakitTuru: " + YakitTuru+ "\nMotorGucu: " + MotorGucu+ "\nMotorHacmi: " + MotorHacmi+ "\nRenk: " + Renk+"\n\n\n";
        }

    }

}
