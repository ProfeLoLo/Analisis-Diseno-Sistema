using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
   public class Aritmetica
    {
        public float valor1, valor2, resultado;

        public void CapturaDatos()
        {
            Console.WriteLine("OPERACION CON DOS NUMEROS");
            Console.WriteLine("Digitar primer valor");
            valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digitar segundo valor");
            valor2 = float.Parse(Console.ReadLine());
        }

        public virtual void Calculo()
        {
            Console.ReadKey();
            Console.Clear();

        }
    }
}