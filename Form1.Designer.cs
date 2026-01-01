namespace MySpace_Inventory
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titulo_principal = new Label();
            btnAñadir = new Button();
            btnPrograma = new Button();
            btnPedidos = new Button();
            inventario_listview = new ListView();
            Producto = new ColumnHeader();
            stock = new ColumnHeader();
            Valor = new ColumnHeader();
            button4 = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // titulo_principal
            // 
            titulo_principal.AutoSize = true;
            titulo_principal.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo_principal.Location = new Point(253, 19);
            titulo_principal.Name = "titulo_principal";
            titulo_principal.Size = new Size(170, 43);
            titulo_principal.TabIndex = 0;
            titulo_principal.Text = "My Space";
            // 
            // btnAñadir
            // 
            btnAñadir.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAñadir.Location = new Point(171, 325);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(92, 31);
            btnAñadir.TabIndex = 1;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnPrograma
            // 
            btnPrograma.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrograma.Location = new Point(171, 373);
            btnPrograma.Name = "btnPrograma";
            btnPrograma.Size = new Size(92, 31);
            btnPrograma.TabIndex = 2;
            btnPrograma.Text = "Programa";
            btnPrograma.UseVisualStyleBackColor = true;
            btnPrograma.Click += btnPrograma_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPedidos.Location = new Point(436, 373);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(92, 31);
            btnPedidos.TabIndex = 3;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            // 
            // inventario_listview
            // 
            inventario_listview.Columns.AddRange(new ColumnHeader[] { Producto, stock, Valor });
            inventario_listview.Location = new Point(171, 123);
            inventario_listview.Name = "inventario_listview";
            inventario_listview.Size = new Size(357, 155);
            inventario_listview.TabIndex = 4;
            inventario_listview.UseCompatibleStateImageBehavior = false;
            inventario_listview.View = View.Details;
            inventario_listview.SelectedIndexChanged += inventario_listview_SelectedIndexChanged;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 170;
            // 
            // stock
            // 
            stock.Text = "Stock";
            stock.TextAlign = HorizontalAlignment.Center;
            // 
            // Valor
            // 
            Valor.Text = "Valor ";
            Valor.TextAlign = HorizontalAlignment.Center;
            Valor.Width = 100;
            // 
            // button4
            // 
            button4.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(300, 373);
            button4.Name = "button4";
            button4.Size = new Size(92, 31);
            button4.TabIndex = 5;
            button4.Text = "Inventario";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(300, 325);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(92, 31);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(436, 325);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(92, 31);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(button4);
            Controls.Add(inventario_listview);
            Controls.Add(btnPedidos);
            Controls.Add(btnPrograma);
            Controls.Add(btnAñadir);
            Controls.Add(titulo_principal);
            Name = "Main";
            Text = "MySpace App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo_principal;
        private Button btnAñadir;
        private Button btnPrograma;
        private Button btnPedidos;
        private ListView inventario_listview;
        private Button button4;
        private Button btnActualizar;
        private Button btnEliminar;
        private ColumnHeader Producto;
        private ColumnHeader stock;
        private ColumnHeader Valor;
    }
}
