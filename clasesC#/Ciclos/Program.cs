using System;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            //while, do-while, for, foreach

            //while

            /*int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Recorrido" + i);
                i++;
            } 

            //ingrese el numero de invitados
            System.Console.WriteLine("ingrese el numero de invitados");
            int invitados = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= invitados)
            {
                System.Console.WriteLine("ingrese el nombre del invitado" + i);
                string nombre = (Console.ReadLine());
                i++;
            } 


            System.Console.WriteLine("ingrese la cantidad de notas");
            int cantNotas = int.Parse(Console.ReadLine());
            int i = 1;
            double promedio = 0;
            while (i <= cantNotas)
            {
                System.Console.WriteLine("ingrese la nota" + i);
                int nota = int.Parse(Console.ReadLine());
                promedio += nota;
                i++;
            }

                promedio = promedio / cantNotas;
                System.Console.WriteLine(promedio); 



            //do-while
            int j = 0;
            do
            {
                System.Console.WriteLine(j);
                j++;
            } while (j < 5);



            //for
            System.Console.WriteLine("ingrese la cantidad de notas");
            int cantNotas = int.Parse(Console.ReadLine());
            double promedio = 0;
            for (int i = 0; i < cantNotas; i++)
            {
                System.Console.WriteLine("ingrese la nota" + i);
                double nota = double.Parse(Console.ReadLine());
                promedio += nota;
            }
            promedio = promedio / cantNotas;
            System.Console.WriteLine(promedio);*/


            //ciclos anidados
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("saludo");
                for (int j = 0; j < 2; j++)
                {
                    System.Console.WriteLine("saludo desde otra dimension");
                }
            }


            //solicitar la cantidad de productos que una persona va pagar
            //solicitar el valor de cada producto
            // mostrara total a pagar por los productos

            System.Console.WriteLine("ingrese la cantidad de prodcutos");
            int cantPro = int.Parse(Console.ReadLine());
            int total = 0;
            double descuento = 0.10;
            for (int i = 0; i < cantPro; i++)
            {
                System.Console.WriteLine("Digite el valor de cada producto" + (i+1));
                int vPro = int.Parse(Console.ReadLine());
                total+=vPro;
            }
            System.Console.WriteLine(total);

            if (total > 50000)
            {
                total -= (int)(total * descuento);
            }
            System.Console.WriteLine("el total a pagar es" + total);
            
            
            //N cantidad de personas
            // valor del impuesto por cada persona
            //impuesto predial > 500000 se aplica descuento del 5%
            //total a pagar con el despuesto si aplica

            System.Console.WriteLine("ingrese el numero de personas");
            int Npersona = int.Parse(Console.ReadLine());
            double descuento = 0.05;
            int total = 0;
            for (int i = 0; i < Npersona; i++)
            {
                System.Console.WriteLine("valor de su predial" + (i+1));
                int predial = int.Parse(Console.ReadLine());
                total+= predial;
            }
            System.Console.WriteLine(total);

            if (total > 500000)
            {
                total -= (int)(total * descuento);
            }
            System.Console.WriteLine("el total a pagar es" + total);
        }
    }
}

