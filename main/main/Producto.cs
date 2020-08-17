using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
namespace main
{
    public class Producto
    {
        public string ruta = "D:\\crudCS\\ListaDeProductos.csv";
        public void agregar(string codigo, string nombre, string precio)
        {
            Console.Clear();
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);// el booleano true es para que no sobreescriba
                sw.Write($"{codigo},");
                sw.Write($"{nombre},");
                sw.Write($"{precio}\n");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepción: " + e.Message);
            }
            finally
            {
            }   
        }
        public void listar()
        {
            try
            {
                string[] lineas = File.ReadAllLines(ruta);//esto da un arreglo de strings
                foreach(var linea in lineas)
                {
                    var valores = linea.Split(',') ;
                    //to do se sale de indice si el primero no tiene , al final
                    Console.WriteLine("* ~~~~~~~~~~~ * ~~~~~~~~~~~ * ~~~~~~~~~~~ * ");
                    Console.WriteLine($"Codigo de producto: {valores[0]}\n" +
                        $"Nombre del producto {valores[1]}\n" +
                        $"Precio del producto: {valores[2]}");
                    Console.WriteLine("* ~~~~~~~~~~~ * ~~~~~~~~~~~ * ~~~~~~~~~~~ * ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepción: " + e.Message);
            }
            finally
            {
            }
            Console.Write("Fin de la lista");
            Console.ReadKey();
        }
        public void buscar(string datoBusqueda)
        {
            bool encontrado = false;
            string[] lineas = File.ReadAllLines(ruta);
            foreach (var linea in lineas)
            {
                var valores = linea.Split(',');
                if ((valores[0]==datoBusqueda) || (valores[1] == datoBusqueda) || (valores[1] == datoBusqueda))
                { 
                Console.WriteLine("* ~~~~~~~~~~~ * ~~~~~~~~~~~ * ~~~~~~~~~~~ * ");
                Console.WriteLine($"Codigo de producto: {valores[0]}\n" +
                    $"Nombre del producto {valores[1]}\n" +
                    $"Precio del producto: {valores[2]}");
                Console.WriteLine("* ~~~~~~~~~~~ * ~~~~~~~~~~~ * ~~~~~~~~~~~ * ");
                encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Producto no encontrado");
            }
            Console.ReadKey();
        }
        public void actualizar(string datoActualizar)
        {
            bool encontrado = false;
            string[] lineas = File.ReadAllLines(ruta);
            foreach (var linea in lineas)
            {
                var valores = linea.Split(',');
                if ((valores[0] == datoActualizar) || (valores[1] == datoActualizar) || (valores[1] == datoActualizar))
                {
                    Console.WriteLine("Producto encontrado, complete los nuevos valores");
                    encontrado = true;
                    Console.Write("Codigo de producto: ");
                    valores[0] = Console.ReadLine();
                    Console.Write("Nombre del producto: ");
                    valores[1] = Console.ReadLine();
                    Console.Write("Precio del producto: ");
                    valores[2] = Console.ReadLine();
                    agregar(valores[0], valores[1], valores[2]); 
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Producto no encontrado");
            }
            Console.ReadKey();
        }
    }
}