using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosBucles
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //int num;

            //do
            //{
            //    Console.WriteLine("Introduce un número:");
            //    num = Convert.ToInt32(Console.ReadLine());


            //} while (num > 0) ;

            //Console.WriteLine("El número introducido es negativo");
            //Console.ReadLine();

            //Console.WriteLine("Introduce un número:");
            //num = Convert.ToInt32(Console.ReadLine());

            //while (num > 0)
            //{
            //    Console.WriteLine("Introduce otro número:");
            //    num = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.ReadLine();

            //String respuesta = "";

            //while(respuesta != "P" && respuesta != "I")
            //{
            //    Console.WriteLine("Escribe P o I:");
            //    respuesta = Console.ReadLine();
            //}

            //if (respuesta == "P")
            //{
            //    for(int i = 2; i < 101; i=i + 2)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else
            //{
            //    for (int i = 1; i < 101; i = i + 2)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //Console.ReadLine();

            //Console.WriteLine("Introduce el número de líneas:");
            //int lineas = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < lineas; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("\t*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("\tNumero \t\t Operación");
            //Console.WriteLine("++++++++++++++++++++++++++++++++++++++++\n");
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write("\t"+ i + "\t");

            //    if (i % 2 == 0)
            //    {
            //        Console.Write("\t al cubo = " + Math.Pow(i,3));
            //    }
            //    else
            //    {
            //        Console.Write("\t al cuadrado = " + Math.Pow(i, 2));
            //    }
            //    Console.WriteLine();
            //}


            //Console.ReadLine();

            String respuesta;
            respuesta = Console.ReadLine();

            //if (respuesta.ToUpper() == "P" || respuesta.ToUpper() == "I")
            //{
            //    Console.WriteLine("BIEN");
            //}
            //if (respuesta.Contains("a"))
            //{
            //Console.WriteLine("si");

            //}
            for(int i=0; i < respuesta.Length; i++)
            {
              
            }

            Console.ReadLine();

            //int num = Convert.ToInt32(Console.ReadLine());
            //int suma = 0;
            //for (int i = num; i > 0; i--)
            //{
            //    suma = suma + i;
            //}
            //Console.WriteLine(suma);
            //Console.ReadLine();

            String palabra;
            int vocales = 0;

            //Console.WriteLine("Escribe una palabra:");
            //palabra = Console.ReadLine();

            //for (int i = 0; i < palabra.Length; i++)
            //{
            //    if (palabra[i] == 'a' || palabra[i] == 'e' || palabra[i] == 'i' || palabra[i] == 'o' || palabra[i] == 'u')
            //    {
            //        vocales++;
            //    }


            //}

            //Console.WriteLine("La palabra " + palabra + " tiene " + vocales + " vocales.");
            //Console.ReadLine();

            String frase;
            int palabras = 1;

            Console.WriteLine("Escribe una frase:");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ')
                {
                    palabras++;
                }


            }

            Console.WriteLine("La frase " + frase + " tiene " + palabras + " palabras.");
            Console.ReadLine();

            String a = "hjgsdhfgsgdfjsdjkfhdkshklfdsa";
            String b="";

            b=String.Copy(a);





        }
    }
}
