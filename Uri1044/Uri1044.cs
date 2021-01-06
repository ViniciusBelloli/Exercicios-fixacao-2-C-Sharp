using System;

namespace Uri1044
{
   class Uri1044
   {
      static void Main(string[] args)
      {
         string[] valores = Console.ReadLine().Split(' ');
         int n1 = int.Parse(valores[0]);
         int n2 = int.Parse(valores[1]);

         if (n1 % n2 == 0 || n2 % n1 == 0)
         {
            Console.WriteLine("Sao Multiplos");
         }
         else
         {
            Console.WriteLine("Nao sao Multiplos");
         }
      }
   }
}
