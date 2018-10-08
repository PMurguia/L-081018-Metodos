using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_2
{
    class Program
    {
        public static double Circulo (double radio)
        {
            double numero = Math.Pow(radio, 2);
            const double PI=3.141593;
            return (numero * PI);
        }
        public static double Triangulo(double bas, double alt)
        {
            return ((bas * alt) / 2);
        }
        public static double Cuadrado(double lado)
        {
            return (Math.Pow(lado, 2));
        }
    
       
        static void Main(string[] args)
        {
            //Crea una aplicación que nos calcule el área de un circulo,
            //cuadrado o triangulo.Pediremos que figura queremos calcular su área
            //y según lo introducido pedirá los valores necesarios para calcular el área.
            //Crea un método por cada figura para calcular cada área, este devolverá un número real. 
            //Muestra el resultado por pantalla
            //Aquí te mostramos que necesita cada figura:
            //    Circulo: (radio ^ 2) * PI
            //    Triangulo: (base * altura) / 2
            //    Cuadrado: lado* lado

            Console.WriteLine("Calculemos el área de una figura. Elige una: \n 1.- Círculo \n 2.- Triangulo \n 3.- Cuadrado");
            int eleccion = Int32.Parse(Console.ReadLine());
            switch (eleccion)
            {
                case 1:
                    Console.WriteLine("Dame el radio del círculo. ");
                    double radio = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(Circulo(radio));
                    break;
                case 2:
                    Console.WriteLine("Dame la base del triángulo. ");
                    double bas = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ahora la altura. ");
                    double alt = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(Triangulo(bas, alt));
                    break;
                case 3:
                    Console.WriteLine("Dame el lado del cuadrado. ");
                    int lado = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(Cuadrado(lado));
                    break;
                    
            }
            Console.ReadLine();

        }
    }
}
