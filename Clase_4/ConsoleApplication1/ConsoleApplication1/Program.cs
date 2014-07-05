using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1; // declaracion de variables de tipo entero
            string b = "hola"; //declaracion de3 variables de tipo cadena
            Console.Write(a + " " + b);//para visualizar
 

            //declaracion de array de tres elementos
            string[] telefono = new string[3];
            // carga de un array metodo uno
            telefono[0] = "0971";
            telefono[1] = "0981";
            telefono[2] = "0991";
            //Console.Write(telefono[2]);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(telefono[i]);
            }
               
        
            //Sentencias condicionales
            if (a == 2)
            {
                Console.WriteLine("Verdadero");
            }
            else
            {
                Console.WriteLine("False");
            }
            

            //Condicional WHILE
           int x = 0;
            while (x<10){
                x++;
                Console.WriteLine(x);
            }

            //Ingresar datos por consola
            int d;
            int e;
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            Console.WriteLine(d + "+" + e + "=" + (d + e));


            Console.ReadKey(); //pido una tecla  
        }
    }
}
