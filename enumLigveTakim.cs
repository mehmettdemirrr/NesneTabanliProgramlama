using System.Globalization;
using System.Collections;

enum Lig
{
    SuperLig,
    BirinciLig,
    IkinciLig
}

class Takim
{
    
    public string Ad { get; set; }
    public Lig TakimLigi { get; set; }
    public int Puan { get; set; }

    public Takim(string ad, int puan)
    {
        Ad = ad;
        Puan = puan;
    }

    public void LigHesapla()
    {
        if (Puan >= 60)
        {
            TakimLigi = Lig.SuperLig;
        }
        else if (Puan >= 40)
        {
            TakimLigi = Lig.BirinciLig;
        }
        else
        {
            TakimLigi = Lig.IkinciLig;
        }
    }

    public void BilgiGoster()
    {
        Console.WriteLine($"Takım Adı: {Ad}, Lig: {TakimLigi}, Puan: {Puan}");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Takim takim1 = new Takim("takim1", 99);
        takim1.LigHesapla();
        Takim takim2 = new Takim("takim2", 20);
        takim2.LigHesapla();
        Takim takim3 = new Takim("takim3", 75);
        takim3.LigHesapla();

        takim1.BilgiGoster();
        takim2.BilgiGoster();
        takim3.BilgiGoster();
    }
}