using MySpace_Inventory.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            Inventory_services.AddProduct(product_name_textbox.Text,product_value_textbox.Text,product_stock_ini_textbox.Text,Convert.ToString(product_hours_updown.Value));
        }
    }
}
