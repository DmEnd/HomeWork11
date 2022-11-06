using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    struct LinEquation
    {
        double k;
        double b;

        public LinEquation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public void Root()
        {
            if (k==0)
            {
                Console.WriteLine($"Решений нет.");
            }
            else
            { 
                double x = -b / k;
                Console.WriteLine($"Корень уравнения {x}.");
            }  
            
        }

    }
}
