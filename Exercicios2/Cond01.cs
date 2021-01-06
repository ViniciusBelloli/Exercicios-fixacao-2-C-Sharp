using System;

namespace Exercicios2
{
   class Cond01
   {
      static void Main(string[] args)
      {
         int numero = int.Parse(Console.ReadLine());

         if (numero < 0) {
            Console.WriteLine("NEGATIVO");
         }
         else
         {
            Console.WriteLine("NAO NEGATIVO");
         }
      }
   }
}