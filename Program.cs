using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Suma ObjSuma = new Suma();
            ObjSuma.Calculo();
            Resta ObjResta = new Resta();
            ObjResta.Calculo();
            Multiplica ObjMultiplica = new Multiplica();
            ObjMultiplica.Calculo();
            Divide ObjDivide = new Divide();
            ObjDivide.Calculo();

        }
    }
}
