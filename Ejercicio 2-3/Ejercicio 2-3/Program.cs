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
            int cantidad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Dame un número para usarlo como base (el mínimo).");
            int numMin = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ahora el tope (máximo).");
            int numMax = Int32.Parse(Console.ReadLine());

            cantidad = Rnd(cantidad, numMin, numMax);
      

        }
    }public static int Rnd (int cantidad, int numMin, int numMax)
    {
        int aux = 0;
        Random random = new Random();
        if (numMax < numMin)
        {
            aux = numMax;
            numMax = numMin;
            numMin = aux;
            random.Next(numMin, numMax);

            for (int i = 0; i < cantidad; i++)
            {
                random.Next(numMin, numMax);
            }
            return cantidad;
        }
        else
        {
            for (int i = 0; i < cantidad; i++)
            {
                random.Next(numMin, numMax);
                
            }
            return cantidad;
        }
    }
}
