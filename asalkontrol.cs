using System.Globalization;
using System.Collections;

internal class asalkontrol
{
   public static bool asal(int sayi) {
       for(int i = 2; i < sayi; i++) {
           if(sayi % i == 0) {
               return false;
           }
       }
       return true;
   }

   private static void Mainssss(string[] args)
   {
       int sayi = Convert.ToInt32(Console.ReadLine());
       if(asal(sayi)) {
           Console.WriteLine("Asaldır");
       }
       else {
           Console.WriteLine("Asal değildir");
       }
   }
}