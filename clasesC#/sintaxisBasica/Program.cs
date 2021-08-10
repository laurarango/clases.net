 using System;
using sintaxisBasica.Enumerations;
using sintaxisBasica.Structure;

namespace sintaxisBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = Console.ReadLine();
            short edad = short.Parse(console.ReadLine());
            int numeroDocumento = int.Parse(console.ReadLine());
            float peso = float.Parse(console.ReadLine());
            double estatura = double.Parse(console.ReadLine());
            bool tieneMascota = bool.Parse(console.ReadLine());

            System.Console.WriteLine("Escribe el año de nacimiento");
            int añoNac = int.Parse(console.ReadLine());
            System.Console.WriteLine("Escribe el mes de nacimiento");
            int mesNac = int.Parse(console.ReadLine());
            System.Console.WriteLine("Escribe el dia de nacimiento");
            int diaNac = int.Parse(console.ReadLine());

            Direccion dir1; 
            dir1.numeroCalle = 85;
            dir1.letra = "A";
            dir1.numero = 35;
            string direccion = $"Calle {dir1.numeroCalle}  {dir1.letra}  {dir1.numero}"
            var genero = Genero.Masculino;
            var tipodocumento = tipoDocumento.Cedula;
            
            DateTime fechaNacimiento = new DateTime(añoNac, mesNac, diaNac);
            DateTime fechaActual = DateTime.Now;
            
            Console.WriteLine("Nombre:" + nombre);
            Console.WriteLine("Tipo de Documento:" + tipoDocumento);
            Console.WriteLine("Numero de Documento:" + numeroDocumento);
            Console.WriteLine("Direccion" + direccion)
            Console.WriteLine(fechaNacimiento); //fecha mas hora
            Console.WriteLine(fechaNacimiento.Date.toShortDateString()); //fecha sin hora
            System.Console.WriteLine(fechaActual);
            int edad2 - (fechaActual - fechaNacimiento).Days / 365;
            System.Console.WriteLine(edad2);

            int? cantidad = null;
            int cantidad2 = 50;
            if (cantidad.HasValue)
            {
                cantidad2 = cantidad.value;
            }
            Console.WriteLine(cantidad);
            Console.WriteLine(cantidad2);

            int estaturaEntero = (int)estatura;
            System.Console.WriteLine(estaturaEntero);
            double estatura2 = estaturaEntero;
            
            int edad3 = edad;

            int numero = int.Parse(console.ReadLine());
            double numero = double.Parse(console.ReadLine());

            System.Console.WriteLine(56==25);

            console.WriteLine("Escribe un numero");
            int numero2 = int.Parse(console.ReadLine());


            //Datos del animal
            System.Console.WriteLine("igrese el nombre de su mascota");
            string nombrePerro = Console.ReadLine();
            System.Console.WriteLine("ingrese la edad de su mascota");
            short edadPerro = short.Parse(console.ReadLine());
            System.Console.WriteLine("ingrese la raza de su mascota");
            string raza = Console.ReadLine();
            System.Console.WriteLine("ingrese el peso de su mascota");
            double peso = double.Parse(console.ReadLine());
            System.Console.WriteLine("ponga verdadero o falso segun si su mascota esta vacunado");
            bool vacuna = bool.Parse(console.ReadLine());
            System.Console.WriteLine("ingrese el color de su mascota");
            string color = console.ReadLine();


            //Datos del dueño
            System.Console.WriteLine("ingrese su nombre");
            string nombre = Console.ReadLine();
            System.Console.WriteLine("ingrese su apellido");
            string apellido = Console.ReadLine();
            System.Console.WriteLine("ingrese su tipo de documento");
            string tipoDocument = Console.ReadLine();
            System.Console.WriteLine("ingrese su numero de docuemnto");
            int document = int.Parse(console.ReadLine());
            System.Console.WriteLine("ingrese su genero");
            string genero = Console.ReadLine();

            direcion Direcion;
            System.Console.WriteLine("ingrese su direccion");
            System.Console.WriteLine("numero de la calle");
            direcion.numerocalle = int.Parse(console.ReadLine());
            System.Console.WriteLine("letra del numero de la calle");
            direcion.letra = console.ReadLine()
            System.Console.WriteLine("numero de carrera");
            direcion.numero = int.Parse(console.ReadLine());
            string direcion1 = $"calle {direcion.numerocalle} {direcion.letra} {direcion.numero}"

            System.Console.WriteLine("ingrese su numero de telefono");
            int numerotelefono = int.Parse(console.ReadLine());

            //servivio que requiere el cliente para la mascota
            System.Console.WriteLine("ingrese que servicio desea");
            string servicio = Console.ReadLine();
            System.Console.WriteLine("ingrese el valor del servicio");
            int valor = int.Parse(console.ReadLine());
            System.Console.WriteLine("ingrese si el tipo de pago es efectivo, trasferencia o tarjeta");
            string tipodepago = Console.ReadLine();
            System.Console.WriteLine("ingrese el estado de pago por el servicio si es negativo o positivo");
            string estadodepago = Console.ReadLine();
            

            




        }
    }
}
