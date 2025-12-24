using MySpace_Inventory.resource;
using System.Drawing.Text;


namespace MySpace_Inventory
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void update_inventary()
        {
            inventario_listview.Items.Clear();//Importante linea si no esta se sobreponen muchos elementos iguales al no limpiar antes de volver a agregar

            string[] lineas = File.ReadAllLines(AppConfig.inventory_path);
            string[] lineas_separada;
            foreach (string linea in lineas)//En este ciclo vamos a recorrer el inventario para mostrar todo el inventario
            {
                lineas_separada = linea.Split("-");
                ListViewItem producto = new ListViewItem(lineas_separada[0]);//Al crear el producto en el constructor el valor que va en la primera columna
                producto.SubItems.Add(lineas_separada[1]);//Despues en orden se colocan los valores que van en las siguientes columnas

                inventario_listview.Items.Add(producto);


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update_inventary();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            update_inventary();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Add_product añadir_window = new Add_product();
            añadir_window.ShowDialog();
        }
    }
}