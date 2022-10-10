using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221010_OhmschesGesetz
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            Console.WriteLine("Geben Sie den Wert des Widerstandes ein!");
            r=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(r+" Ohm");

            double i;
            Console.WriteLine("Geben Sie den Wert der Stromstärke ein!");
            i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(i+" A");

            double u;
            u = r * i;
            Console.WriteLine("Die Spannung beträgt "+u+"V");
            Console.ReadKey();

            
            

        }
    }
}
