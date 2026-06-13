using System.Globalization;

internal class inttobinary
{
   private static void Main(string[] args)
   {
       Random random = new Random();
       int sayi = random.Next(1, 101);
       Console.WriteLine(sayi);
       string binary = "";
       while(sayi > 0) {
           binary += sayi % 2;
           sayi /= 2;
       }
       int bir = 0;
       Console.WriteLine(binary);
       foreach(char c in binary) {
           if(c == '1') {
               bir++;
           }
       }
       Console.WriteLine(bir);
   }
}