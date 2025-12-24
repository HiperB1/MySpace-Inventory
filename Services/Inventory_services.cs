using System;
using System.Collections.Generic;
using System.Text;
using MySpace_Inventory.Config;

namespace MySpace_Inventory.Services
{
    public static class Inventory_services
    {

        public static List<string> GetProduct(string product_to_search)//Esta funcion nos va a buscar un producto indicado y nos va a devolver todos sus datos en una lista
        {
            List<string> product = new List<string>{};
            string[] lineas = File.ReadAllLines(AppConfig.inventory_path);
            string[] lineas_separada;
            foreach(string linea in lineas)
            {
                lineas_separada = linea.Split("-");
                if (lineas_separada[0] == product_to_search)
                {
                    product.AddRange(lineas_separada);
                }

            }

            return product;
        }

        public static List<string> GetAllProductsNames()//Esta funcion nos va a devolver todos los nombres de los productos en nuestro inventario
        {
            List<string> products_names = new List<string> { };
            string[] lineas = File.ReadAllLines(AppConfig.inventory_path);
            string[] lineas_separada;
            foreach (string linea in lineas)
            {
                lineas_separada = linea.Split("-");
                products_names.Add(lineas_separada[0]);

            }

            return products_names;


        }

    }
}
