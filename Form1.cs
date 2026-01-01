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

        private void update_listview()
        {
            inventario_listview.Items.Clear();//Importante linea si no esta se sobreponen muchos elementos iguales al no limpiar antes de volver a agregar
            List<Product> products = Inventory.GetAllProducts(AppConfig.inventory_path);//Usamos el metodo GetAllProducts para obtener una lista con todos los productos del inventario

            if (products.Count > 0)//Comprobamos si el inventario esta vacio
            {//En caso de no estar vacio iteramos 
                foreach (Product producto in products)
                {//Por cada producto en la lista de productos creamos un item del listview y le asignamos valores
                    ListViewItem item = new ListViewItem(producto.Name);
                    item.SubItems.Add(Convert.ToString(producto.Stock));
                    item.SubItems.Add(Convert.ToString(producto.Value));

                    inventario_listview.Items.Add(item);//Aqui añ{adimos el item creado al ListView

                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update_listview();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            update_listview();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Add_product_form añadir_window = new Add_product_form();//Añadimos la ventana de añadir producto
            añadir_window.ShowDialog();//Mostramos la ventana de añadir producto y bloqueamos la main hasta que se cierre
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            if (inventario_listview.SelectedItems.Count > 0)//Comprobamos que si hayan seleccionado un producto del listview
            {
                ListViewItem producto_name = inventario_listview.SelectedItems[0];//Obtenemos el item seleccionado del listview
                List<Product> allProducts = Inventory.GetAllProducts(AppConfig.inventory_path);//Obtenemos todos los productos del inventario 

                foreach (Product product in allProducts)//Iteramos todos los productos para comparar el item buscado y el iterado
                {
                    if (product.Name.ToLower() == producto_name.Text.ToLower())//Comparamos si el producto iterado tiene el mismo nombre que el producto buscado
                    {
                        DialogResult confirmacion = MessageBox.Show($"Confirma querer eliminar el producto: {product.Name}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //Preguntamos al usuario si confirma eliminar el producto y guardamos su desicion en la variable confirmacion
                        if (confirmacion == DialogResult.Yes)//Si el usuario confirma que desea eliminar 
                        {
                            Inventory.EliminateProductInventory(product, AppConfig.inventory_path);//Eliminamos el producto 
                            MessageBox.Show("Producto eliminado correctamente", "Eliminacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar algun producto del inventario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void inventario_listview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrograma_Click(object sender, EventArgs e)
        {
            Program program_form = new Program();
            program_form.ShowDialog();
        }
    }
}