using System;
namespace main
{
    class Menu
    {
        Producto prod = new Producto();
        public void imprimir()
        {
            int opc = 0;
            Console.Clear();
            Console.WriteLine(@" 
                                 _____________________________
                                |                             |
                                | Bienvenido al CRUD          |
                                | 1- Crear un producto        |  
                                | 2- Listar productos         |  
                                | 3- Actualizar un producto   |  
                                | 4- Borrar un producto       |
                                |_____________________________|");

            Console.Write("\nIngrese una opcion: ");
            opc = int.Parse(Console.ReadLine());
            while (!(opc >= 1 && opc <= 4))
            {
                Console.Clear();
                Console.Write("Esa opcion no existe, ingrese otra: ");
                opc = int.Parse(Console.ReadLine());
            }
            switch (opc)
            {
                case 1:
                    menuCrearP();
                    break;
                case 2:
                    menuListarP();
                    break;
                case 3:
                    Console.WriteLine("opc");
                    break;
                case 4:
                    Console.WriteLine("opc");
                    break;
            }

        } 
        private void menuCrearP()
        {
            Console.Clear();
            Console.WriteLine(@"
                                __________________________
                               |                          |     
                               |**************************|
                               |******Crear producto******|
                               |**************************|
                               |__________________________|\n");
            
            Console.WriteLine("Complete los siguientes campos");
            Console.Write("Codigo del producto: ");
            string codigo = Console.ReadLine();
            Console.Write("Nombre del producto: ");
            string nombre = Console.ReadLine();
            Console.Write("Precio: ");
            string precio = Console.ReadLine();
            prod.agregar(codigo, nombre, precio);
        }
        private void menuListarP()
        {
            Console.Clear();
            Console.WriteLine(@"
                                ____________________________
                               |                            |     
                               |****************************|
                               |******Listar productos******|
                               |****************************|
                               |____________________________|
                             ");
            prod.listar();
        }
    }
}
