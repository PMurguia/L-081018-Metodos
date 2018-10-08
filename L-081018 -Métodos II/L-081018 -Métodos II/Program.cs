using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_081018__Métodos_II
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función que reciba un array y lo muestre en pantalla de modo ascendente.
            //Después escribe otra función que reciba un array y lo muestre en pantalla de modo descendencte.
            //Crea un array en el programa principal y pásalo a cada una de las funciones.

            double[] array1 = { 2, 7, 5, 3, 7, 5, 7, 8, 9, 2 };
            double[] array2 = { 3, 8, 4, 7, 8, 9, 5, 3, 1, 6 };
            array1=Array1Orden(array1);
            for (int i = 0; i<array1.Length;i++)
            {
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine();
            array2 = Array2ORden(array2);
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
            Console.ReadLine();
        }
        public static double [] Array1Orden(double [] arrayFuncion1)
        {
            for(int i = 0; i<arrayFuncion1.Length;i++)
            {

            Array.Sort(arrayFuncion1);
            }
            return arrayFuncion1;
        }
        public static double [] Array2ORden(double[]arrayFuncion2)
        {
            for (int j=0; j < arrayFuncion2.Length; j++)
            {
                Array.Sort(arrayFuncion2);
                Array.Reverse(arrayFuncion2);
            }
            return arrayFuncion2;
        }
       
        
    
        
    }
}
