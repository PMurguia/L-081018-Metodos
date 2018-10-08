using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_081018_Métodos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Diseña un método esPar() que reciba como parámetro un entero y devuelva si ese número es par o no.
            //Utilízalo en un programa que lea un número por teclado y determine si es par o no.


            //Console.WriteLine("Dame un número.");
            //int numero = Int32.Parse(Console.ReadLine());
            //esPar(numero);
            //Console.ReadLine();   



            //Escribe una función que escriba “Hola” 3 veces.Llámala desde el programa principal.)

            //saludo();
            //Console.ReadLine();


            //Escribe una función que escriba “Hola” tantas veces como el número que le pasamos de parámetro.
            //Llámala desde el programa principal dos veces, primero con 5 y después con 3.

            //Console.WriteLine("Dame un número. ");
            //int respuesta = Int32.Parse(Console.ReadLine());
            //for(int i = 0; i < respuesta; i++)
            //{
            //    Saludo(respuesta);
            //}
            //Console.ReadLine();


            //Escribe una función que devuelva el resultado de sumar los dos parámetros que le pasamos. 
            //Asigna el valor de llamar a la función en una variable en el programa principal y muestra el resultado en la pantalla.

            //Console.WriteLine("Dame un número. ");
            //int num1 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Dame otro número. ");
            //int num2 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("la suma es " + DosNumeros(num1, num2));
            //Console.ReadLine();



            //Escribe una función que devuelva el resultado de sumar los dos parámetros que le pasamos.
            //En el programa principal, pide al usuario 2 números. Usa esos 2 números como parámetros de la función
            //y después asigna el valor que devuelve la función a una tercera variable en el programa.
            //Finalmente, muestra el valor de la variable en la pantalla.


            //Console.WriteLine("Dame un número. ");
            //int num1 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Dame otro número. ");
            //int num2 = Int32.Parse(Console.ReadLine());
            //int suma = DosNumeros(num1, num2);
            //Console.WriteLine("la suma es " + suma);
            //Console.ReadLine();



            //Escribe un programa que pida al usuario dos números. 
            //Usa esos 2 números en una función que divide el primero por el segundo y devuelve el resultado.
            //Muestra el resultado que devuelve la función en pantalla.
            //Después vuelve a pedir los números y hacer todo otra vez hasta que el usuario introduzca un 0 como segundo número.

            //double num1, num2;

            //do
            //{
            //    Console.WriteLine("Dame un número. ");
            //    num1 = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine("Dame otro número. ");
            //    num2 = Int32.Parse(Console.ReadLine());
            //    double division = DosNumeros(num1, num2);
            //    Console.WriteLine("la division es " + division);
            //    Console.ReadLine();

            //} while (num2 != 0);



            //Escribe una función a la que le damos dos números y que devuelva true si el primer número es más grande que el segundo
            //número y false en el caso contrario. 
            //En el programa principal, pide dos números al usuario, y pasalos a la función. 
            //Muestra en pantalla “El primer número es más grande” o “El primer número no es más grande”


            //    Console.WriteLine("Dame un número. ");
            //    double numero1 = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine("Dame otro número. ");
            //    double numero2 = Int32.Parse(Console.ReadLine());
            //    bool mayorMenor = Numero(numero1, numero2);
            //    if(mayorMenor)
            //    {
            //        Console.WriteLine("El primer número es más grande. ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("El primer número no es más grande. ");
            //    }
            //    Console.ReadLine();
            //}



            //Escribe una función a la que le pasamos un año y devuelve true si es bisiesto.
            //En el programa principal, pídele al usuario un número y muestra en pantalla
            //“El año … es bisiesto” o “El año … no es bisiesto” y sigue pidiendo números 
            //y diciendo si es o no bisiesto hasta que introduzca un 0.

            int year;
            do
            {
                Console.WriteLine("Introduce un año. ");
                year = Int32.Parse(Console.ReadLine());
                bool verdad = Año(year);
                if (verdad)
                {
                    Console.WriteLine("El año " + year + " es bisiesto. ");

                }
                else
                {
                    Console.WriteLine("El año " + year + " no es bisiesto. ");
                }
            }
            while (year != 0);
            Console.ReadLine();
        }
        public static bool Año(int añoRecibido)
        {
            bool bisiesto;
            if (añoRecibido % 4 == 0 && (añoRecibido % 100 != 0 || añoRecibido % 400 == 0))
            {
                bisiesto = true;
            }
            else
            {
                bisiesto = false;
            }
            return bisiesto;






            //public static bool Numero(double num1, double num2)
            //{
            //    bool mayorMenor;
            //    {
            //        if (num1 > num2)
            //        {
            //            mayorMenor = true;

            //        }
            //        else
            //        {
            //            mayorMenor = false;
            //        }
            //    }
            //    return mayorMenor;


            //public static double DosNumeros(double num1, double num2)
            //{

            //     return num1/num2;

            //}
            //public static void Saludo(int numRecib2)
            //{
            //    Console.WriteLine("Hola. ");
            //}

            //public static void EsPar(int numRecibido)
            //{
            //    if(numRecibido % 2 == 0)
            //    {
            //        Console.WriteLine("Es par.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Es impar.");
            //    }


        }
    }
}
