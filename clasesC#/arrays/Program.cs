using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //un arreglo con tamaño
            string[] letra = new string[5];
            letras[0] = "b";
            letras[1] = "c";
            letras[2] = "d";
            letras[3] = "e";
            letras[4] = "f";

            System.Console.WriteLine(letras[4]);

            //con valores
            int[] numeros = {23, 56, 89, 78, 45, 25};
            //para validar
            for (int i = 0; i < numeros.Length; i++)
            {
               System.Console.WriteLine(numeros[i]); 
            }
            
            //para mostrar
            foreach (var l in letras)
            {
                System.Console.WriteLine(l);
            }

            //sin saber que valor se va ingresar
            System.Console.WriteLine("ingresa la cantidad de frutas");
            int[] cantFrutas = int.Parse(Console.ReadLine());
            string[] Frutas = new string[cantFrutas];
            for (int i = 0; i < Frutas.Length; i++)
            {
                System.Console.WriteLine("ingrese una fruta");
                string fruta = Console.ReadLine();
                Frutas[i] = Frutas;
            }

            foreach (var item in Frutas)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine("ingresa la cantidad de Frutas");
            int cantFrutas = int.Parse(Console.ReadLine());
            string[,] frutas = new string[cantFrutas,4];

            for (int i = 0; i < cantFrutas; i++)
            {
                System.Console.WriteLine("ingresa los datos de la fruta" + i+i);
                for (int j = 0; j < 4; j++)
                {
                    string dato = Console.ReadLine();
                    frutas[i,j] = dato;
                }
            }
            int sumPrecioCompra = 0, sumPrecioVenta = 0, ganancias = 0;
            for (int i = 0; i < cantFrutas; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sumPrecioCompra += int.Parsefrutas[1,2];
                }
            }
        }
    }
}
