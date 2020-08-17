using System;
namespace main
{
    class Menu
    {
        Producto prod = new Producto();

        public void imprimir()
        {
            
            Console.Clear();
            Console.WriteLine(@" 
                                 _____________________________
                                |                             |
                                | Bienvenido al CRUD          |
                                | 1- Crear un producto        |  
                                | 2- Listar productos         |  
                                | 3- Actualizar un producto   |  
                                | 4- Borrar un producto       | 
                                | 5- Buscar un producto       |
                                | 6- Salir                    |  
                                |_____________________________|");
        } 
        public void crearP()
        {
            Console.Clear();
            Console.WriteLine(@"
                                __________________________
                               |                          |     
                               |**************************|
                               |******Crear producto******|
                               |**************************|
                               |__________________________|
                                ");
            
            Console.WriteLine("Complete los siguientes campos");
            Console.Write("Codigo del producto: ");
            string codigo = Console.ReadLine();
            Console.Write("Nombre del producto: ");
            string nombre = Console.ReadLine();
            Console.Write("Precio: ");
            string precio = Console.ReadLine();
            prod.agregar(codigo, nombre, precio);
        }
        public void listarP()
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
        public void buscarP()
        {
            Console.Clear();
            Console.WriteLine(@"
                                ____________________________
                               |                            |     
                               |****************************|
                               |******Buscar productos******|
                               |****************************|
                               |____________________________|
                             ");
            Console.Write("Ingrese algun dato del producto a buscar: ");
            string datoBusqueda = Console.ReadLine();
            prod.buscar(datoBusqueda);
        }
        public void actualizarP()
        {
            Console.Clear();
            Console.WriteLine(@"
                                ________________________________
                               |                                |     
                               |********************************|
                               |******Actualizar productos******|
                               |********************************|
                               |________________________________|
                             ");
            Console.Write("Ingrese algun dato del producto a actualizar: ");
            string datoActualizar = Console.ReadLine();
            prod.actualizar(datoActualizar);
        }
    }
}
