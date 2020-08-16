using System;
using System.ComponentModel;
using System.Security.Cryptography;

namespace main
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Producto producto = new Producto();
            char opcMenu;
            do
            {
                Console.Write("\nOpción: ");
                opcMenu = Char.Parse(Console.ReadLine());
                switch (opcMenu)
                {
                    case 'c':
                        producto.agregar();
                        break;
                    case 'l':
                        producto.listar();
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
