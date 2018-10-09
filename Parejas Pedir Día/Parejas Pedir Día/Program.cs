using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parejas_Pedir_Día
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un día. ");
            int dia = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce un mes. ");
            int mes = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce un año. ");
            int anio = Int32.Parse(Console.ReadLine());
        }
    }
}
