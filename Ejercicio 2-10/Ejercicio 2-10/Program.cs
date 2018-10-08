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
            PedirMes(mes);
            Console.ReadLine();

            int anio;
            Console.WriteLine("Dame un año. ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Dame otro. ");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(PedirAnio(num1,num2));
            Console.ReadLine();
        }
        public static int PedirMes(int mes)
        {
           
                if (mes > 0 && mes <= 12)
                {
                    Console.WriteLine("Ha introducido el mes número " + mes);

                }
                else
                {
                    Console.WriteLine("Introduzca un numero de mes correcto. ");
                }
          

                return mes;
        }
        public static int PedirAnio(int num1, int num2)
        {
            int num3=0;
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
                anioRan = anioRandom.Next(num1, num2+1);
            }
            return anioRan;
        }
        public static int PedirDia(int dia)
        {

        }
    }
}
