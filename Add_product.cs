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
    public partial class Add_product : Form
    {
        public Add_product()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Inventory.AddProduct(product_name_textbox.Text, product_value_textbox.Text, product_stock_ini_textbox.Text, Convert.ToString(product_hours_updown.Value));
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product producto = new Product(product_name_textbox.Text, Convert.ToInt32(product_stock_ini_textbox.Text), Convert.ToInt32(product_value_textbox.Text), Convert.ToDouble(product_hours_updown.Value));
            string json = JsonSerializer.Serialize(producto);

            File.WriteAllText("C:\\Users\\jjrav\\source\\repos\\MySpace_Inventory\\resource\\Data\\inventario2.json",json);

        }
    }
}
