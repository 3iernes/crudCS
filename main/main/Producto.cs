using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
namespace main
{
    public class Producto
    {
        string ruta = "D:\\crudCS\\ListaDeProductos.csv";
        public void agregar()
        {
            Console.Clear();
            try
            {
                string nombre, precio, codigo;
                Console.WriteLine("Complete los siguientes campos");
                Console.Write("Codigo del producto: ");
                codigo = Console.ReadLine();
                Console.Write("Nombre del producto: ");
                nombre = Console.ReadLine();
                Console.Write("Precio: ");
                precio = Console.ReadLine();
                StreamWriter sw = new StreamWriter(ruta, true);
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
            Console.Clear();
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

        }
    }
}
