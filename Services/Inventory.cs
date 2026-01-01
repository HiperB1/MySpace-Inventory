using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using MySpace_Inventory.Config;
using System.IO;

namespace MySpace_Inventory.Services
{
    public static class Inventory
    {
        private static List<Product> DeserializeInventory(string path)
        {

            List<Product> products = new List<Product> { };//Creamos la lista donde vamos a guardar todos los productos



            if (File.Exists(path))//Comprobamos que el archivo exista
            {
                string json = File.ReadAllText(path);//Leemos y guardamos toda la info del archivo


                if (!string.IsNullOrWhiteSpace(json))//Comprobamos que el archivo no este vacio o corrupto
                {
                    products = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product> { };//Deserializamos el JSON y lo guardamos en la lista de productos
                }

            }

            return products;

        }
        private static void VerifyInventoryExist()
        {
            if (!Directory.Exists(AppConfig.app_folder))//Verificamos si la carpeta donde guardaremos el inventario existe
            {//En caso de no exisitir la crearemos, no es necesario crear el .json como tal pues el File.Write ya lo crea en caso de no existir
                Directory.CreateDirectory(AppConfig.app_folder);
            }
        }
        public static Product? GetProduct(string product_to_search, string path)//Esta funcion nos va a buscar un producto indicado y nos va a devolver el producto
        {

            VerifyInventoryExist();
            List<Product> products = DeserializeInventory(path);//Usamos nuestro metodo para deserializar el inventario

            foreach(Product producto in products)//Recorremos la lista de productos
            {
                if(producto.Name.ToLower() == product_to_search.ToLower())//Comparamos el nombre del producto buscado con el nombre de produ
                {
                    return producto;//Retornamos el producto

                }

            }

            return null;//En caso de no encontrar el producto devolvemos Null


        }

        public static List<Product> GetAllProducts(string path)//Esta funcion nos va a devolver todos los nombres de los productos en nuestro inventario
        {

            List<Product> products = DeserializeInventory(path);//Creamos la lista donde vamos a guardar todos los productos


            return products;//Retornamos


        }

        public static void AddProductInventory(Product producto, string path)//Añade un producto al inventario
        {

            VerifyInventoryExist();

            List<Product> products = new List<Product> { };//Creamos la lista donde vamos a guardar todos los productos
            string json_new; //Creamos el string donde guardaremos el json con el nuevo producto

            products = DeserializeInventory(path);//Usamos nuestra funcion que devuelve en caso de que el archvio si contenga productos una lista<Product> con los productos

            products.Add(producto);//Añadimos el nuevo producto a la lista de productos

            json_new = JsonSerializer.Serialize(products, new JsonSerializerOptions{WriteIndented = true});//Serializamos la lista de productos para guardarla en JSON

            try
            {
                File.WriteAllText(path, json_new);//Escribimos en el JSON la lista con los productos

            }
            catch (Exception e)
            {
                MessageBox.Show($"Error {e}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            
        }

        public static void EliminateProductInventory(Product producto, string path)//Metodo para eliminar un producto del inventario
        {
            VerifyInventoryExist();//Usamos el metodo para verificar si la carpeta de inventario existe en caso de no el metodo la crea

            List<Product> products = DeserializeInventory(path);//Usamos el metodo para que nos devuelvan los productos en la lista
            Product product_to_eliminate = new Product("a",1,1);//Creamos un producto X donde guardaremos el producto a eliminar
            foreach(Product producto_i in products)//Recorremos la lista de productos buscando el producto a eliminar
            {
                if(producto_i.Name == producto.Name)
                {
                    product_to_eliminate = producto_i;//En caso de ser encontrado el producto se guarda en la variable
                }
            }
            products.Remove(product_to_eliminate);//Se elimina el producto de la lista inventario

            string json = JsonSerializer.Serialize(products);//Serializamos el nuevo inventario sin el producto
            try
            {

                File.WriteAllText(path, json);//Escribimos el nuevo Json sin el producto en la ruta indicada


            }catch(Exception e)
            {
                MessageBox.Show($"Error al borrar: {e}","Error de borrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


    }
}
