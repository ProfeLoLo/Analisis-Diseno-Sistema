using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Resta:Aritmetica
    {

        public override void Calculo()
        {
            CapturaDatos();

            resultado = valor1 - valor2;
            Console.WriteLine("El resultado es = " + resultado);
            base.Calculo();
        }
    }
}
