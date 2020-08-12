using System;

namespace main
{
    class Program
    {
        static void imprimirMenu()
        {
            Console.WriteLine(@"    
            Bienvenido al controlador de stock
            Opciones:
            C crear un producto
            L listar productos
            A actualizar un producto
            B borrar un producto
            S salir");
        }
        static void Main(string[] args)
        {
            char opcMenu='z';
            while (opcMenu!='s')
            {
                imprimirMenu();
                Console.Write("Opción:");
                opcMenu=Char.Parse(Console.ReadLine());
                Console.WriteLine($"Eligio la opc: {opcMenu}");
            }
                
            
        }
    }
}
