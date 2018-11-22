using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVectores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Control de Versiones");
            Console.WriteLine(potencia(5, 2));
            Console.ReadKey(); 
        }


        public static double potencia(double x, double y)
        {
            if (x <= 0)
            {
                throw new Exception("x debe ser positivo");
            }
            if(y<=0)
            {
                throw new Exception("y debe ser positivo");
            }
            double p = 1;
            for (int i = 1; i <= y; i++)
            {
                p = p * x;
            }
            return p;
        }

        
    }
}



