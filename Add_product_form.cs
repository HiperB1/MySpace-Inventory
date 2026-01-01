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
        public List<string> parts_of_product = new List<string> {};
        public Add_product_form()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(product_name_textbox.Text) && !string.IsNullOrEmpty(product_stock_ini_textbox.Text) && !string.IsNullOrEmpty(product_value_textbox.Text))
            {
                if (parts_of_product.Count > 0)
                {
                    Product producto_with_parts = new Product(product_name_textbox.Text, Convert.ToInt32(product_stock_ini_textbox.Text), Convert.ToInt32(product_value_textbox.Text));
                    producto_with_parts.parts.AddRange(parts_of_product);
                    Inventory.AddProductInventory(producto_with_parts, AppConfig.inventory_path);
                    MessageBox.Show("Producto y sus partes añadidos correctamente ");

                }
                else
                {
                    Product producto = new Product(product_name_textbox.Text, Convert.ToInt32(product_stock_ini_textbox.Text), Convert.ToInt32(product_value_textbox.Text));
                    //Creamos el objeto a añadir
                    Inventory.AddProductInventory(producto, AppConfig.inventory_path);//Añadimos el producto al inventario mediante nuestra funcion AddProductInventory
                    MessageBox.Show("Producto añadido correctamente");
                }

                parts_listbox.Items.Clear();

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

        private void parts_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (parts_checkbox.Checked)
            {
                product_hours_updown.Enabled = false;
                btnAddPart.Enabled = true;
                part_textbox.Enabled = true;
                parts_hours_updown.Enabled = true;
            }
            if (!parts_checkbox.Checked)
            {
                product_hours_updown.Enabled = true;
                btnAddPart.Enabled = false;
                part_textbox.Enabled = false;
                parts_hours_updown.Enabled = false;
            }

        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(part_textbox.Text))
            {
                parts_of_product.Add($"{part_textbox.Text.ToLower()}-{parts_hours_updown.Value}");
                parts_listbox.Items.Add(part_textbox.Text);

            }
        }
    }
}
