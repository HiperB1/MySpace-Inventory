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
            List<Product> products = Inventory.GetAllProducts();//Usamos el metodo GetAllProducts para obtener una lista con todos los productos del inventario

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
           
            if (inventario_listview.SelectedItems.Count > 0)
            {
                ListViewItem producto_name = inventario_listview.SelectedItems[0];
                List<Product> allProducts = Inventory.GetAllProducts();
                
                foreach(Product product in allProducts)
                {
                    if(product.Name.ToLower() ==  producto_name.Text.ToLower())
                    {

                        Inventory.EliminateProductInventory(product);

                    }

                }



            }
        }
    }
}