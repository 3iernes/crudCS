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
        static void crearProducto()
        {

        }
        static void Main(string[] args)
        {
            char opcMenu;
            //string direc = @"D:\crudCS\"
            do
            {
                imprimirMenu();
                Console.Write("\nOpción:");
                opcMenu = Char.Parse(Console.ReadLine());
                switch (opcMenu)
                {
                    case 'c':

                        break;
                    case 'l':
                        break;
                    case 'a':
                        break;
                    case 'b':
                        break;
                    case 's':
                        break;
                }
            } while (opcMenu != 's');



        }
    }
}
