namespace MySpace_Inventory
{
    partial class Add_product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titulo_principal = new Label();
            btnAñadir = new Button();
            product_name_textbox = new TextBox();
            product_value_textbox = new TextBox();
            product_stock_ini_textbox = new TextBox();
            product_hours_updown = new NumericUpDown();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)product_hours_updown).BeginInit();
            SuspendLayout();
            // 
            // titulo_principal
            // 
            titulo_principal.AutoSize = true;
            titulo_principal.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo_principal.Location = new Point(131, 50);
            titulo_principal.Name = "titulo_principal";
            titulo_principal.Size = new Size(286, 43);
            titulo_principal.TabIndex = 1;
            titulo_principal.Text = "Añadir Producto";
            // 
            // btnAñadir
            // 
            btnAñadir.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAñadir.Location = new Point(167, 250);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(92, 31);
            btnAñadir.TabIndex = 2;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // product_name_textbox
            // 
            product_name_textbox.Location = new Point(99, 158);
            product_name_textbox.Name = "product_name_textbox";
            product_name_textbox.Size = new Size(121, 23);
            product_name_textbox.TabIndex = 3;
            // 
            // product_value_textbox
            // 
            product_value_textbox.Location = new Point(226, 158);
            product_value_textbox.Name = "product_value_textbox";
            product_value_textbox.Size = new Size(93, 23);
            product_value_textbox.TabIndex = 4;
            // 
            // product_stock_ini_textbox
            // 
            product_stock_ini_textbox.Location = new Point(325, 158);
            product_stock_ini_textbox.Name = "product_stock_ini_textbox";
            product_stock_ini_textbox.Size = new Size(69, 23);
            product_stock_ini_textbox.TabIndex = 5;
            // 
            // product_hours_updown
            // 
            product_hours_updown.Location = new Point(401, 158);
            product_hours_updown.Name = "product_hours_updown";
            product_hours_updown.Size = new Size(48, 23);
            product_hours_updown.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(265, 250);
            button1.Name = "button1";
            button1.Size = new Size(92, 31);
            button1.TabIndex = 7;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 140);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 140);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 9;
            label2.Text = "Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 140);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 10;
            label3.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 140);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 11;
            label4.Text = "Horas";
            // 
            // button2
            // 
            button2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(69, 250);
            button2.Name = "button2";
            button2.Size = new Size(92, 31);
            button2.TabIndex = 12;
            button2.Text = "JSON";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Add_product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 351);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(product_hours_updown);
            Controls.Add(product_stock_ini_textbox);
            Controls.Add(product_value_textbox);
            Controls.Add(product_name_textbox);
            Controls.Add(btnAñadir);
            Controls.Add(titulo_principal);
            Name = "Add_product";
            Text = "Añadir";
            ((System.ComponentModel.ISupportInitialize)product_hours_updown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo_principal;
        private Button btnAñadir;
        private TextBox product_name_textbox;
        private TextBox product_value_textbox;
        private TextBox product_stock_ini_textbox;
        private NumericUpDown product_hours_updown;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
    }
}