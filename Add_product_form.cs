using MySpace_Inventory.Config;
using MySpace_Inventory.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace MySpace_Inventory
{
    public partial class Add_product_form : Form
    {
        public Add_product_form()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(product_name_textbox.Text) && !string.IsNullOrEmpty(product_stock_ini_textbox.Text) && !string.IsNullOrEmpty(product_value_textbox.Text) && product_hours_updown.Value > 0)
            {

                Product producto = new Product(product_name_textbox.Text, Convert.ToInt32(product_stock_ini_textbox.Text), Convert.ToInt32(product_value_textbox.Text), Convert.ToDouble(product_hours_updown.Value));
                //Creamos el objeto a añadir
                Inventory.AddProductInventory(producto,AppConfig.inventory_path);//Añadimos el producto al inventario mediante nuestra funcion AddProductInventory
                MessageBox.Show("Producto añadido correctamente");


            }
            else
            {
                MessageBox.Show("Hay campos faltantes o invalidos", "Error registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_product_form_Load(object sender, EventArgs e)
        {
            
        }
    }
}
