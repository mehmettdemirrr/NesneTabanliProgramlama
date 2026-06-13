using System.Globalization;
using System.Collections;

public abstract class Karakter
{
   public string isim;
   public int can;
   public int saldiriGucu;

   public Karakter(string isim, int can, int saldiriGucu) {
       this.isim = isim;
       this.can = can;
       this.saldiriGucu = saldiriGucu;
   }

   public abstract void BilgiYazdir(Karakter k);
   public abstract void OzelYetenek(Karakter k);
}

public class Tank : Karakter
{
   public int zirh;

   public Tank(string isim, int can, int saldiriGucu, int zirh) : base(isim, can, saldiriGucu)
   {
       this.zirh = zirh;
   }

   public override void BilgiYazdir(Karakter k) {
       Console.WriteLine("Tank Bilgileri: ");
       Console.WriteLine("İsim: " + k.isim);
       Console.WriteLine("Can: " + k.can);
       Console.WriteLine("Saldırı Gücü: " + k.saldiriGucu);
       Console.WriteLine("Zırh: " + this.zirh);
   }

   public override void OzelYetenek(Karakter k) {
       Console.WriteLine(k.isim + " Kılıç Fırtınası kullanıyor. Saldırı gücünün 2 katı kadar hasar veriyor: " + k.saldiriGucu * 2);
   }
}

public class Buyucu : Karakter
{
   public int mana;

   public Buyucu(string isim, int can, int saldiriGucu, int mana) : base(isim, can, saldiriGucu)
   {
       this.mana = mana;
   }

   public override void BilgiYazdir(Karakter k) {
       Console.WriteLine("Büyücü Bilgileri: ");
       Console.WriteLine("İsim: " + k.isim);
       Console.WriteLine("Can: " + k.can);
       Console.WriteLine("Saldırı Gücü: " + k.saldiriGucu);
       Console.WriteLine("Mana: " + this.mana);
   }

   public override void OzelYetenek(Karakter k) {
       Console.WriteLine(k.isim + " Ateş Topu özelliğini kullanıyor. Saldırı gücünün 3 katı kadar hasar veriyor: " + k.saldiriGucu * 3);
   }
}

public class Okcu : Karakter
{
   public int okSayisi;

   public Okcu(string isim, int can, int saldiriGucu, int okSayisi) : base(isim, can, saldiriGucu)
   {
       this.okSayisi = okSayisi;
   }

   public override void BilgiYazdir(Karakter k) {
       Console.WriteLine("Okçu Bilgileri: ");
       Console.WriteLine("İsim: " + k.isim);
       Console.WriteLine("Can: " + k.can);
       Console.WriteLine("Saldırı Gücü: " + k.saldiriGucu);
       Console.WriteLine("Ok Sayısı: " + this.okSayisi);
   }
   public override void OzelYetenek(Karakter k) {
       Console.WriteLine(k.isim + " Üçlü Ok özelliğini kullanıyor. Ok sayısı kadar hasar veriyor: " + this.okSayisi * k.saldiriGucu);
   }
}

internal class Program
{
   private static void Mainssss(string[] args)
   {
       Tank tank = new Tank("Tank", 300, 5, 20);
       Buyucu buyucu = new Buyucu("Büyücü", 100, 10, 10);
       Okcu okcu = new Okcu("Okçu", 80, 15, 5);

       tank.BilgiYazdir(tank);
       buyucu.BilgiYazdir(buyucu);
       okcu.BilgiYazdir(okcu);
        
       tank.OzelYetenek(tank);
       buyucu.OzelYetenek(buyucu);
       okcu.OzelYetenek(okcu);
   }
}