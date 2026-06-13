using System.Globalization;
using System.Collections;

abstract class Sekil
{
    public string Ad;
    public string Renk;
    public static double ToplamAlan;

    public Sekil(string ad, string renk)
    {
        Ad = ad;
        Renk = renk;
    }

    public abstract double AlanHesapla();

    public virtual void BilgiYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Renk: {Renk}, Alan: {ToplamAlan}");
    }
}

class Dikdortgen : Sekil
{
    public double Genislik;
    public double Yukseklik;

    public Dikdortgen(string ad, string renk, double genislik, double yukseklik) : base(ad, renk)
    {
        Genislik = genislik;
        Yukseklik = yukseklik;
    }

    public override double AlanHesapla()
    {
        double Alan = Genislik * Yukseklik;
        ToplamAlan += Alan;
        return Alan;
    }

    public override void BilgiYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Renk: {Renk} - Genişlik: {Genislik}, Yükseklik: {Yukseklik}, Alan: {AlanHesapla()}");
    }
}

class Ucgen : Sekil
{
    public double Taban;
    public double Yukseklik;

    public Ucgen(string ad, string renk, double taban, double yukseklik) : base(ad, renk)
    {
        Taban = taban;
        Yukseklik = yukseklik;
    }

    public override double AlanHesapla()
    {
        double Alan = (Taban * Yukseklik) / 2;
        ToplamAlan += Alan;
        return Alan;
    }

    public override void BilgiYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Renk: {Renk} - Taban: {Taban}, Yükseklik: {Yukseklik}, Alan: {AlanHesapla()}");
    }
}
internal class Program
{
    public static void Main()
    {
        Sekil dikdortgen1 = new Dikdortgen("Dikdörtgen", "Kırmızı", 5, 10);
        Sekil dikdortgen2 = new Dikdortgen("Dikdörtgen", "Sarı", 4, 15);
        Sekil ucgen1 = new Ucgen("Üçgen", "Mavi", 4, 8);
        dikdortgen1.BilgiYazdir();
        ucgen1.BilgiYazdir();
        dikdortgen2.BilgiYazdir();
        Console.WriteLine($"Toplam Alan: {Sekil.ToplamAlan}");
    }
}