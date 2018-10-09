using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_10
{
    class Program
    {


        static void Main(string[] args)
        {
            //Diseña un  método pedirMes().  Solicita un  número de  mes y  valida que  se trata  de un número de mes correcto.
            //Devuelve dicho número de mes. 
            //Diseña un método pedirAnio().
            //Recibe como parámetros los límites entre los que debe de estar el año que se debe solicitar por teclado.
            //Devuelve el año entre dichos límites.  
            //Diseña un método pedirDia(). Solicita un número de día por teclado, 
            //y dado un mes y un año válidos  recibidos por  parámetro,  devuelve un  día correcto. 
            //(Nota: puede  llamar al método esBisiesto) 
            //Crea un nuevo método mostrarSiguienteDia() que recibe un día, un mes
            //y un año válido(estos tres datos forman la fecha actual) y muestra en pantalla 2 fechas:
            //la actual y la del día siguiente, a calcular a partir del día actual.
            //Pruébalo en  un programa  que pida  al usuario  una fecha(pedirDia(), pedirMes(), pedirAnio())
            //y muestre la fecha del día siguiente.
            //Ejemplo:  
            //Fecha actual: 31 / 12 / 2011
            //Día siguiente: 1 / 1 / 2012
            int mes;
            Console.WriteLine("Introduzca un número de mes. ");
            mes = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(PedirMes(mes));
            Console.ReadLine();


            Console.WriteLine("Dame un año. ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Dame otro. ");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(PedirAnio(num1, num2));
            Console.ReadLine();

            Console.WriteLine("Elige un día. ");
            int dia = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(PedirDia(mes,dia));
            Console.ReadLine();

           



        }
        public static int PedirMes(int mes)
        {
            while (mes <= 0 || mes > 12)
            {
                Console.WriteLine("No es un mes correcto. Por favor, introduzca un número de mes correcto. ");
                mes = Int32.Parse(Console.ReadLine());
            }
            return mes;
        }
        public static int PedirAnio(int num1, int num2)
        {
            int num3 = 0;
            int anioRan = 0;

            if (num1 > num2)
            {
                num3 = num1;
                num1 = num2;
                num2 = num3;
                Random anioRandom = new Random();
                anioRan = anioRandom.Next(num1, num2 + 1);
            }
            else
            {
                Random anioRandom = new Random();
                anioRan = anioRandom.Next(num1, num2 + 1);
            }
            return anioRan;
        }

        public static int PedirDia(int anioRan, int mes)
        {
            int diasMax;

            if (DateTime.IsLeapYear(anioRan) && mes == 2)
            {
                diasMax = 29;
            }
            else if (!DateTime.IsLeapYear(anioRan) && mes == 2)
            {
                diasMax = 28;
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                diasMax = 30;
            }
            else
            {
                diasMax = 31;
            }

            return diasMax;
        }

        public static int MostrarSiguienteDia1(int dia, int diasMax, int mes, int anio)
        {
            if (dia + 1 > diasMax)
            {
                dia = 1;
                mes++;
            }
            else if (mes > 12)
            {
                anio++;
            }
            else
            {
                //Console.WriteLine("Error!!");
            }
            return dia;

        }
        public static int MostrarSiguienteMes(int dia, int diasMax, int mes, int anio)
        {
            if (dia + 1 > diasMax)
            {
                dia = 1;
                mes++;
            }
            else if (mes > 12)
            {
                anio++;
            }
            else
            {
                //Console.WriteLine("Error!!");
            }
            return mes;
        }
        public static int MostrarSiguienteAnio(int dia, int diasMax, int mes, int anio)
        {
            if (dia + 1 > diasMax)
            {
                dia = 1;
                mes++;
            }
            else if (mes > 12)
            {
                anio++;
            }
            else
            {
                //Console.WriteLine("Error!!");
            }
            return anio;
        }
    }
}
