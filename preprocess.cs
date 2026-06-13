//#define KURUMSAL

using System.Globalization;
using System.Collections;

namespace ElektrikSistemi
{
    class Abone
    {
        #region
        public int AboneNo;
        public string Ad;
        public string SoyAd;
        public double Tuketim;
        #endregion

        #region
        public Abone(string Ad, string SoyAd, double Tuketim)
        {
            Random rnd = new Random();
            this.AboneNo = rnd.Next(100000, 999999);
            this.Ad = Ad;
            this.SoyAd = SoyAd;
            this.Tuketim = Tuketim;
            
            #if KURUMSAL
                Console.WriteLine("Kurumsal Abone Oluşturuldu: " + AboneNo + " " + Ad + " " + SoyAd + " " + Tuketim);
            #else
                Console.WriteLine("Bireysel Abone Oluşturuldu: " + AboneNo + " " + Ad + " " + SoyAd + " " + Tuketim);
            #endif
        }
        #endregion

        #region
        #if KURUMSAL
            public double FaturaHesapla()
            {
            if (Tuketim <= 500)
                return Tuketim * 2.5;
            else
                return (500 * 2.5 + (Tuketim - 500) * 3.8);
            }

            public void FaturaDetay()
            {
                Console.WriteLine("Tarife: Kurumsal");
                Console.WriteLine("Abone No: " + AboneNo);
                Console.WriteLine("Ad: " + Ad);
                Console.WriteLine("SoyAd: " + SoyAd);
                Console.WriteLine("Tuketim: " + Tuketim);
                Console.WriteLine("Toplam Tutar: " + FaturaHesapla());
            }
        #else
            public double FaturaHesapla()
            {
                if(Tuketim <= 150)
                    return Tuketim * 1.8;
                else {
                    if(Tuketim > 300)
                    {
                        return 1.15 * (150 * 1.8 + (Tuketim - 150) * 2.9);
                    }
                    else
                        return (150 * 1.8 + (Tuketim - 150) * 2.9);
                }
            }

            public void FaturaDetay()
            {
                Console.WriteLine("Tarife: Bireysel");
                Console.WriteLine("Abone No: " + AboneNo);
                Console.WriteLine("Ad: " + Ad);
                Console.WriteLine("SoyAd: " + SoyAd);
                Console.WriteLine("Tuketim: " + Tuketim);
                Console.WriteLine("Toplam Tutar: " + FaturaHesapla());
            }
        #endif
        #endregion
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Abone a1 = new Abone("Mehmet", "Demir", 200);
            a1.FaturaDetay();
            Console.WriteLine("\n*****************************\n");
            Abone a2 = new Abone("Furkan", "Demir", 600);
            a2.FaturaDetay();
        }
    }
}