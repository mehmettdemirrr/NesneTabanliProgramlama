using System.Globalization;
using System.Collections;

internal class operatoroverload
{
   public class karmasiksayi {
       public double reel;
       public double imajiner;

       public karmasiksayi(double a, double b) {
           reel = a;
           imajiner = b;
       }

       public karmasiksayi() {
           reel = 0;
           imajiner = 0;
       }

       public static karmasiksayi operator +(double a, karmasiksayi b) {
           return new karmasiksayi(a + b.reel, b.imajiner);
       }

       public static karmasiksayi operator -(double a, karmasiksayi b) {
           return new karmasiksayi(a - b.reel, -b.imajiner);
       }

       public static karmasiksayi operator +(karmasiksayi a, double b) {
           return b + a;
       }

       public static karmasiksayi operator -(karmasiksayi a, double b) {
           return b - a;
       }

       public static karmasiksayi operator +(karmasiksayi a, karmasiksayi b) {
           return new karmasiksayi(a.reel + b.reel, a.imajiner + b.imajiner);
       }

       public static karmasiksayi operator -(karmasiksayi a, karmasiksayi b) {
           return new karmasiksayi(a.reel - b.reel, a.imajiner - b.imajiner);
       }

       public static karmasiksayi operator *(karmasiksayi a, karmasiksayi b) {
           return new karmasiksayi(a.reel * b.reel - a.imajiner * b.imajiner, a.reel * b.imajiner + a.imajiner * b.reel);
       }

       public void yazdir() {
           Console.WriteLine(reel + " + " + imajiner + "i");
       }
   }

   private static void Mainasd(string[] args)
   {
       karmasiksayi a = new karmasiksayi(1, 2);
       karmasiksayi b = new karmasiksayi(3, 4);
       a.yazdir();
       b.yazdir();
       karmasiksayi c = a + b;
       Console.WriteLine("Toplam sonucu 1+2i + 3+4i: " + c.reel + " + " + c.imajiner + "i");
        
       karmasiksayi d = new karmasiksayi(2, 2);
       karmasiksayi e = new karmasiksayi(4, 4);
       d.yazdir();
       e.yazdir();
       karmasiksayi f = d * e;
       Console.WriteLine("Çarpım sonucu 2+2i * 4+4i: " + f.reel + " + " + f.imajiner + "i");

       karmasiksayi g = new karmasiksayi(1,6);
       g.yazdir();

       karmasiksayi h = 5 + g;
       Console.WriteLine("Toplama sonucu 5 + 1 + 6i: " + h.reel + " + " + h.imajiner + "i");

       karmasiksayi i = 5 - g;
       Console.WriteLine("Çıkarma sonucu 5 - 1 + 6i: " + i.reel + " + " + i.imajiner + "i");

       karmasiksayi j = g + 5;
       j.yazdir();

       karmasiksayi k = g - 5;
       k.yazdir();
   }
}