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
                sw.Flush();
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
                    imprimir(linea);
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

        public bool buscar(string datoBusqueda)
        {
            string[] lineas = File.ReadAllLines(ruta);
            foreach (var linea in lineas)
            {
                if (linea.Contains(datoBusqueda))
                {
                    imprimir(linea);
                    return true;
                }
            }
            return false;
        }

        public void actualizar(string datoActualizar)
        {
            if (buscar(datoActualizar))
            {
                Console.WriteLine("Producto encontrado");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadKey();
            }
        }
        public void imprimir(string linea)
        {
            var valores = linea.Split(',');
            Console.WriteLine("* ~~~~~~~~~~~ * ~~~~~~~~~~~ * ~~~~~~~~~~~ * ");
            Console.WriteLine($"Codigo de producto: {valores[0]}\n" +
                $"Nombre del producto {valores[1]}\n" +
                $"Precio del producto: {valores[2]}");
            Console.WriteLine("* ~~~~~~~~~~~ * ~~~~~~~~~~~ * ~~~~~~~~~~~ * ");
        }
    }
}