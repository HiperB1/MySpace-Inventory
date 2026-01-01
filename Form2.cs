using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySpace_Inventory.Services;
using MySpace_Inventory.Config;
using System.Text.Json;

namespace MySpace_Inventory
{
    public partial class Program : Form
    {
        public Program()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            // Printer printerX = new Printer(printer_combobox.Text);
            // printerX.AddToQueue(product_textbox.Text, Convert.ToInt32(priority_numberbox.Value));
            if (!string.IsNullOrEmpty(printer_combobox.Text) && !string.IsNullOrEmpty(product_textbox.Text) && !string.IsNullOrEmpty(time_textbox.Text) && priority_numberbox.Value > 0)
            {
                List<Program_product> printer_products = new List<Program_product> { };
                string path = Path.Combine(AppConfig.app_folder,$"{printer_combobox.Text}.json");

                //AppConfig.app_folder + $"{printer_combobox.Text}.json";
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    printer_products = JsonSerializer.Deserialize<List<Program_product>>(json);
                    Program_product product_new = new Program_product(printer_combobox.Text, product_textbox.Text, Convert.ToInt32(time_textbox.Text), Convert.ToInt32(priority_numberbox.Value));


                    printer_products.Add(product_new);
                    string json_new = JsonSerializer.Serialize(printer_products, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(path, json_new);

                }
                else
                {
                    Program_product product_new = new Program_product(printer_combobox.Text, product_textbox.Text, Convert.ToInt32(time_textbox.Text), Convert.ToInt32(priority_numberbox.Value));
                    printer_products.Add(product_new);

                    string json = JsonSerializer.Serialize(printer_products, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(path, json);

                }
                MessageBox.Show("Producto agregado a cola correctamente", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);





            }
            else
            {
                MessageBox.Show("Debes completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void printer1_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = AppConfig.app_folder + $"{printer1_combobox.Text}.json";
            if (printer1_combobox.SelectedIndex > 0)
            {
                if (printer1_combobox.Text == "215")
                {
                    string json = File.ReadAllText(path);



                }

            }
        }

        private void Program_Load(object sender, EventArgs e)
        {

        }
    }
}
