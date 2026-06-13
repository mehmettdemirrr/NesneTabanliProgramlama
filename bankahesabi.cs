using System.Globalization;
using System.Collections;

internal class bankahesabi
{
   public class BankaHesabı {  
       public string Ad;
       public string Soyad;
       public static int SonHesapNo;
       private static int HesapNo;
       private double Bakiye;

       public BankaHesabı(string ad, string soyad, double bakiye) {
           Ad = ad;
           Soyad = soyad;
           HesapNo = SonHesapNo + 1;
           Bakiye = bakiye < 0 ? 0 : bakiye;
       }

       public BankaHesabı(string ad, string soyad) {
           Ad = ad;
           Soyad = soyad;
           HesapNo = SonHesapNo + 1;
           Bakiye = 0;
       }

       public void ParaYatir(double miktar) {
           Console.WriteLine("Yatırılan Miktar: {0}", miktar);
           if(miktar <= 0) {
               Console.WriteLine("Negatif para yatıramazsınız.");
           }
           else {
               Bakiye += miktar;
           }
       }

       public void ParaCek(double miktar) {
           Console.WriteLine("Çekilmek İstenen Miktar: {0}", miktar);
           if(miktar < 0) {
               Console.WriteLine("Negatif para çekemezsiniz.");
           }
           else if(Bakiye - miktar < 0) {
               Console.WriteLine("Yetersiz bakiye");
           }
           else {
               Bakiye -= miktar;
           }
       }

       public double BakiyeSorgula {
           get { return Bakiye; }
       }

       public int HesapNumarasıSorgula {
           get { return HesapNo; }
       }

       public void BilgiAl() {
           Console.WriteLine("Ad: " + Ad);
           Console.WriteLine("Soyad: " + Soyad);
           Console.WriteLine("Hesap No: " + HesapNo);
           Console.WriteLine("Bakiye: " + Bakiye);
       }
   }

   private static void Mainss(string[] args)
   {
       BankaHesabı hesap1 = new BankaHesabı("Mehmet", "Demir", 1000);
       hesap1.BilgiAl();
       Console.WriteLine("Hesap Bakiyesi: " + hesap1.BakiyeSorgula);
       hesap1.ParaCek(1500);
       hesap1.BilgiAl();

       Console.WriteLine("\n");

       BankaHesabı hesap2 = new BankaHesabı("Furkan", "Demir");
       Console.WriteLine("Hesap Numarası: {0}", hesap2.HesapNumarasıSorgula);
        
       hesap2.BilgiAl();
       hesap2.ParaCek(1500);
       Console.WriteLine("Hesap Bakiyesi: {0}", hesap2.BakiyeSorgula);
       hesap2.ParaYatir(500);
       Console.WriteLine("Hesap Bakiyesi: {0}", hesap2.BakiyeSorgula);
       hesap2.ParaCek(200);
       hesap2.BilgiAl();
   }
}