using System;
using System.ComponentModel;
using System.Security.Cryptography;

namespace main
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            int opc = 0;
            //agregar manejo de excepciones pq esto se cae a pedazos 
            while (opc != 6)
            {
                menu.imprimir();
                Console.Write("\nIngrese una opcion: ");
                opc = int.Parse(Console.ReadLine());
                while (!(opc >= 1 && opc <= 6))
                {
                    Console.Clear();
                    Console.Write("Esa opcion no existe, ingrese otra: ");
                    opc = int.Parse(Console.ReadLine());
                }
                switch (opc)
                {
                    case 1:
                        menu.crearP();
                        break;
                    case 2:
                        menu.listarP();
                        break;
                    case 3:
                        menu.actualizarP();
                        break;
                    case 4:
                        Console.WriteLine("opc");
                        break;
                    case 5:
                        menu.buscarP();
                        break;
                }
            }
        }
    }
}
