using System;

namespace condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            int b = 10;
            int c = 56;
            if (a>b && a>c)
            {
                System.Console.WriteLine("a es mayor que b");
            }
            else if (b>a && b>c)
            {
                System.Console.WriteLine("b es mayor que a y c");
            }
            else
            {
                System.Console.WriteLine("c es mayor que a y b");
            }


            double hemoglobina = double.Parse(Console.ReadLine());
            char genero = char.Parse(Console.ReadLine());
            if (genero == 'm')
            {
                if (hemoglobina < 13)
                {
                    System.Console.WriteLine("baja");
                }
                else if (hemoglobina >= 13 && hemoglobina <16)
                {
                    System.Console.WriteLine("normal");
                }
            }

            else if (genero == 'f')
            {
                if (hemoglobina < 11)
                {
                    System.Console.WriteLine("baja");
                }
                else if (hemoglobina >= 11 && hemoglobina <15)
                {
                    System.Console.WriteLine("normal");
                }
            }
            else
            {
                System.Console.WriteLine("ingresaste un genero no valido");
            }

            





            double edad = double.Parse(Console.ReadLine());
            System.Console.WriteLine("ingrese su edad");
           
                if (edad >= 0 && edad <= 12)
                {
                    System.Console.WriteLine("usted es un niño");
                }
                else if (edad >= 13 && edad <= 29)
                {
                    System.Console.WriteLine("usted es un joven");
                }    
                else if (edad >= 30 && edad < 65)
                {
                     System.Console.WriteLine("usted es un adulto");
                }
                 else if (edad >= 65 && edad <= 150)
                {
                     System.Console.WriteLine("usted es un adulto mayor");
                }
                else
                {
                    System.Console.WriteLine("edad no valida");
                }



            double edad = double.Parse(Console.ReadLine());
            System.Console.WriteLine("ingrese su nombre");
            string nombre = string.Parse(Console.ReadLine());
            System.Console.WriteLine("ingrese su edad");
            int edad = int.Parse(Console.ReadLine());
            System.Console.WriteLine("ingrese su sexo");
            int sexo = int.Parse(Console.ReadLine());
            if (sexo == 1)
            {
                System.Console.WriteLine("femenino");
            }
            else (sexo == 2)
            {
                System.Console.WriteLine("masculino");
            }

            System.Console.WriteLine("ingrese su estado civil");
            int estadoCivil = int.Parse(Console.ReadLine());
            if (estadoCivil == 1)
            {
                System.Console.WriteLine("soltero");
            }
            else if (estadoCivil == 2)
            {
                System.Console.WriteLine("casado");
            }
            else (estadoCivil == 3)
            {
                System.Console.WriteLine("otro");
            }


            string persona = string.Parse(Console.ReadLine());
            if (genero == 1 && estadoCivil == 1 && edad >=18 && edad <=25)
            {
                System.Console.WriteLine("Bienvenida al club");
            }
            else if (genero == 2 && estadoCivil == 1 && edad >=18 && edad <=38)
             {
                System.Console.WriteLine("Bienvenida al club");
            }
            else
            {
                System.Console.WriteLine("No cumples con las condicionales");
            }
            
            System.Console.WriteLine("escribre 1. enero o 2. febrero");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("El mes de enero tiene 31 dias");
                case 2:
                    Console.WriteLine("El mes de febrero tiene 28 0 29 dias");
                default:
                    Console.WriteLine("Ingresa un valor correcto");
                    break;
            }

            Console.WriteLine("Menu");
            Console.WriteLine("1. Hamburguesa \n2. perro caliente \n3. Salchipapa");
            Console.WriteLine("Elige una opcion");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Digita la cantidad de productos");
            int cantidadProductos = int.Parse(Console.ReadLine());
            int precioHam = 15000;
            int precioPerro = 8000;
            int precioSalchi = 12000;

            int totalPago = 0;
            double desc = 0.10;

            //forma uno
            if (opcion == 1)
            {
                totalPago = precioHam * cantidadProductos;
                if (cantidadProductos >= 5)
                {
                    totalPago -= (int)(totalPago * desc);
                }
            } 
            else if (opcion == 2)
             {
                totalPago = precioPerro * cantidadProductos;
                if (cantidadProductos >= 5)
                {
                    totalPago -= (int)(totalPago * desc);
                }
            } 
            else if (opcion == 3)
             {
                totalPago = precioSalchi * cantidadProductos;
                if (cantidadProductos >= 5)
                {
                    totalPago -= (int)(totalPago * desc);
                }
            } 

            //forma dos
            switch (opcion)
            {
                case 1:
                totalPago = precioHam * cantidadProductos;
                if (cantidadProductos >=5)
                {
                    totalPago -= (int)(totalPago * desc);
                }
                Console.WriteLine("El total a pagar es:" + totalPago)
                    break;

                case 2:
                totalPago = precioPerro * cantidadProductos;
                if (cantidadProductos >=5)
                {
                    totalPago -= (int)(totalPago * desc);
                }
                Console.WriteLine("El total a pagar es:" + totalPago)
                    break;

                case 3:
                 totalPago = precioSalchi * cantidadProductos;
                 if (cantidadProductos >=5)
                {
                    totalPago -= (int)(totalPago * desc);
                }
                Console.WriteLine("El total a pagar es:" + totalPago)
                    break;

                default:
                Console.WriteLine("Debes elegir una opcion")
            }



            


        }
    }
}
