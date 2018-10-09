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
            {
                int month, year, day, maxYear, minYear;

                //Generamos un mes
                month = AskMonth();

                //Generamos un año
                Console.WriteLine("Introduce un límite mínimo:");
                minYear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce un límite máximo:");
                maxYear = Convert.ToInt32(Console.ReadLine());
                year = AskYear(minYear, maxYear);

                //Generamos día
                day = AskDay(month, year);

                //Generamos el día siguiente
                NextDay(day, month, year);


            }
        }

        public static void NextDay(int day, int month, int year)
        {
            Console.WriteLine("Fecha actual: " + day + "/" + month + "/" + year);

            if (DateTime.IsLeapYear(year) && month == 2 && day == 29)
            {
                month++;
                day = 1;

            }
            else if (!DateTime.IsLeapYear(year) && month == 2 && day == 28)
            {
                month++;
                day = 1;
            }
            else if ((month == 4 || month == 6 || month == 9 || month == 11) && day == 30)
            {
                month++;
                day = 1;
            }
            else if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10) && day == 31)
            {
                month++;
                day = 1;
            }
            else if (month == 12 && day == 31)
            {
                year++;
                month = 1;
                day = 1;
            }
            else
            {
                day++;
            }
            Console.WriteLine("Fecha día siguiente: " + day + "/" + month + "/" + year);
            Console.ReadLine();
        }

        public static int AskDay(int month, int year)
        {
            int day;
            bool correcto = false;
            do
            {
                Console.WriteLine("Introduce un día");
                day = Convert.ToInt32(Console.ReadLine());

                if (DateTime.IsLeapYear(year) && month == 2)
                {
                    if (day > 0 && day < 30)
                    {
                        correcto = true;
                    }
                }
                else if (!DateTime.IsLeapYear(year) && month == 2)
                {

                    if (day > 0 && day < 29)
                    {
                        correcto = true;
                    }
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    if (day > 0 && day < 31)
                    {
                        correcto = true;
                    }
                }
                else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    if (day > 0 && day < 32)
                    {
                        correcto = true;
                    }
                }

            } while (!correcto);

            return day;
        }


        public static int AskMonth()
        {
            int month;
            do
            {
                Console.WriteLine("Introduce un mes");
                month = Convert.ToInt32(Console.ReadLine());

            } while (month < 1 || month > 12);

            return month;
        }

        public static int AskYear(int minYear, int maxYear)
        {
            int aux, year;
            Random rnd = new Random();

            if (minYear > maxYear)
            {
                //Creo la variable auxiliar para guardar el valor de minYear para que
                //cuando lo cambie no se pierda
                aux = minYear;
                minYear = maxYear;
                maxYear = aux;
                year = rnd.Next(minYear, maxYear + 1);
                return year;
            }
            else
            {
                year = rnd.Next(minYear, maxYear + 1);
                return year;
            }
        }
    }
        
    
}
    

