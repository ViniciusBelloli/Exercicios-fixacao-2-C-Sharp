using System;

namespace Cond02
{
   class Cond02
   {
      static void Main(string[] args)
      {
         int numero = int.Parse(Console.ReadLine());

         if ((numero % 2) == 0)
         {
            Console.WriteLine("PAR");
         }
         else
         {
            Console.WriteLine("IMPAR");
         }
      }
   }
}