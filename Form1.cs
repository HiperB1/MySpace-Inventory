using MySpace_Inventory.Config;
using MySpace_Inventory.Services;
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
            Add_product_form añadir_window = new Add_product_form();//Añadimos la ventana de añadir producto
            añadir_window.ShowDialog();//Mostramos la ventana de añadir producto y bloqueamos la main hasta que se cierre
        }
    }
}