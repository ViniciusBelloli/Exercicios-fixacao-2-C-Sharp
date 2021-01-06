using System;
using System.Globalization;

namespace Uri1038
{
   class Uri1038
   {
      static void Main(string[] args)
      {
         double[] precos = {4.0, 4.5, 5.0, 2.0, 1.5};
         string[] valores = Console.ReadLine().Split(' ');
         int p1 = int.Parse(valores[0]);
         int p2 = int.Parse(valores[1]);
         double total = (precos[p1 - 1] * p2);

         Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
      }
   }
}
