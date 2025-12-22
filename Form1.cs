using System.Drawing.Text;


namespace MySpace_Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrivateFontCollection fonts = new PrivateFontCollection();
            fonts.AddFontFile("C:\\Users\\jjrav\\source\\repos\\MySpace_Inventory\\resource\\fonts\\cubic.ttf");

            Font cubic = new Font(fonts.Families[0], 30, FontStyle.Bold);
            titulo_principal.Font = cubic;
        }
    }
}
