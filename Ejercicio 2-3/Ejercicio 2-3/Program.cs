using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea una aplicación que nos genere una cantidad de números enteros aleatorios que nosotros le pasaremos por teclado.
            //Crea un método donde pasamos como parámetros entre que números queremos que los genere,
            //podemos pedirlas por teclado antes de generar los números. Este método devolverá un número entero aleatorio.
            //Muestra estos números por pantalla.
            
            Console.WriteLine("Generemos números aleatorios. Dame un número. ");
            double cantidad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Dame un número para usarlo como base (el mínimo).");
            int numMin = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ahora el tope (máximo).");
            int numMax = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0;i<cantidad; i++)
            {
                Console.WriteLine(RandNumber(cantidad, numMin, numMax));
            }
            Console.ReadLine();

        }
        public static double RandNumber (double cantidad, int numMin, int numMax)
        {
            int aux;
            double numRand;
            Random random = new Random();
          
                if(numMin > numMax)
                {
                    aux = numMin;
                    numMax = numMin;
                    numMax = aux;
                    numRand = random.Next(numMin, numMax);
                return numRand;
                }
                else
                {
                    numRand = random.Next(numMin, numMax);
                    return numRand;
                }

           
            
        }
               
            
            
        
    }
}
