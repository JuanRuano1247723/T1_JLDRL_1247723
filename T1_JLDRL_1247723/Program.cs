using System;

namespace T1_JLDRL_1247723
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi segundo programa");

            Console.WriteLine("Ingrese nombre: ");
            String sNombre = Console.ReadLine();
            Console.WriteLine("Ingrese edad: ");
            String sEdad = Console.ReadLine();
            Console.WriteLine("Ingrese carrera: ");
            String sCarrera = Console.ReadLine();
            Console.WriteLine("Ingrese carné: ");
            String sCarne = Console.ReadLine();
            Console.ReadKey();

            Console.WriteLine("Nombre: " + sNombre);

            Console.WriteLine("Edad: " + sEdad);
 
            Console.WriteLine("Carrera: " + sCarrera);

            Console.WriteLine("Carné: " + sCarne);

            Console.WriteLine("Soy " + sNombre + ", tengo " + sEdad + " años y estudio la carrera de " + sCarrera + ". Mi número de carné es; " + sCarne);
            Console.ReadKey();


        }
    }
}
