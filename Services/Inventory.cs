using System;
using System.Collections.Generic;
using System.Text;
using MySpace_Inventory.Config;

namespace MySpace_Inventory.Services
{
    public static class Inventory
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

        public static void AddProduct(string product_name, string product_value, string product_stock, string product_hours)
        {
            if(string.IsNullOrEmpty(product_name) || string.IsNullOrEmpty(product_value) || string.IsNullOrEmpty(product_stock) || string.IsNullOrEmpty(product_hours) || Convert.ToInt32(product_hours) <= 0)
            {
                MessageBox.Show("Debes rellenar todos los campos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    string producto_to_add = $"\n{product_name}-{product_stock}-{product_hours}-{product_value}";
                    File.AppendAllText(AppConfig.inventory_path, producto_to_add);
                    MessageBox.Show("Producto añadido correctamente","Registro Exitoso",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error: {e}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
                


            
        }

    }
}
