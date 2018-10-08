using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escriba una función que reciba un array y un valor booleano.
            //Si el booleano es true, mostrar el array de modo ascendente. 
            //si es false, mostrarlo de modo descendente. 
            //En el programa principal, crear un array y hacer que la función lo muestre primero en modo ascendente
            //y después en modo descendente.

            double[] array = { 9, 7, 2, 8, 3, 7, 1 };

            array = OrderArray(true, array);
            ShowArray(array);

            array = OrderArray(false, array);
            ShowArray(array);
        }
        public static double [] OrderArray (bool ascendente, double [] array)
        {
            if(ascendente)
            {
                Array.Sort(array);
            }
            else
            {
                Array.Sort(array);
                Array.Reverse(array);
            }
            return array;
        }

        public static void ShowArray(double [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

    }
}
