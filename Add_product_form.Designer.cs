namespace MySpace_Inventory
{
    partial class Add_product_form
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
            btnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            parts_checkbox = new CheckBox();
            parts_listbox = new ListBox();
            part_textbox = new TextBox();
            label5 = new Label();
            btnAddPart = new Button();
            parts_hours_updown = new NumericUpDown();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)product_hours_updown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)parts_hours_updown).BeginInit();
            SuspendLayout();
            // 
            // titulo_principal
            // 
            titulo_principal.AutoSize = true;
            titulo_principal.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo_principal.Location = new Point(129, 9);
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
            product_name_textbox.Location = new Point(97, 117);
            product_name_textbox.Name = "product_name_textbox";
            product_name_textbox.Size = new Size(121, 23);
            product_name_textbox.TabIndex = 3;
            // 
            // product_value_textbox
            // 
            product_value_textbox.Location = new Point(224, 117);
            product_value_textbox.Name = "product_value_textbox";
            product_value_textbox.Size = new Size(93, 23);
            product_value_textbox.TabIndex = 4;
            // 
            // product_stock_ini_textbox
            // 
            product_stock_ini_textbox.Location = new Point(323, 117);
            product_stock_ini_textbox.Name = "product_stock_ini_textbox";
            product_stock_ini_textbox.Size = new Size(69, 23);
            product_stock_ini_textbox.TabIndex = 5;
            // 
            // product_hours_updown
            // 
            product_hours_updown.Location = new Point(399, 117);
            product_hours_updown.Name = "product_hours_updown";
            product_hours_updown.Size = new Size(48, 23);
            product_hours_updown.TabIndex = 6;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(265, 250);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 31);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 99);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 99);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 9;
            label2.Text = "Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 99);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 10;
            label3.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(396, 99);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 11;
            label4.Text = "Horas";
            // 
            // parts_checkbox
            // 
            parts_checkbox.AutoSize = true;
            parts_checkbox.Location = new Point(97, 191);
            parts_checkbox.Name = "parts_checkbox";
            parts_checkbox.Size = new Size(58, 19);
            parts_checkbox.TabIndex = 12;
            parts_checkbox.Text = "Partes";
            parts_checkbox.UseVisualStyleBackColor = true;
            parts_checkbox.CheckedChanged += parts_checkbox_CheckedChanged;
            // 
            // parts_listbox
            // 
            parts_listbox.BorderStyle = BorderStyle.FixedSingle;
            parts_listbox.FormattingEnabled = true;
            parts_listbox.Location = new Point(323, 146);
            parts_listbox.Name = "parts_listbox";
            parts_listbox.Size = new Size(120, 47);
            parts_listbox.TabIndex = 13;
            // 
            // part_textbox
            // 
            part_textbox.Enabled = false;
            part_textbox.Location = new Point(97, 162);
            part_textbox.Name = "part_textbox";
            part_textbox.Size = new Size(143, 23);
            part_textbox.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 146);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 15;
            label5.Text = "Pieza";
            // 
            // btnAddPart
            // 
            btnAddPart.Enabled = false;
            btnAddPart.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddPart.Location = new Point(201, 213);
            btnAddPart.Name = "btnAddPart";
            btnAddPart.Size = new Size(116, 31);
            btnAddPart.TabIndex = 16;
            btnAddPart.Text = "Agregar pieza";
            btnAddPart.UseVisualStyleBackColor = true;
            btnAddPart.Click += btnAddPart_Click;
            // 
            // parts_hours_updown
            // 
            parts_hours_updown.Enabled = false;
            parts_hours_updown.Location = new Point(246, 162);
            parts_hours_updown.Name = "parts_hours_updown";
            parts_hours_updown.Size = new Size(48, 23);
            parts_hours_updown.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(246, 146);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 18;
            label6.Text = "Horas";
            // 
            // Add_product_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 351);
            Controls.Add(label6);
            Controls.Add(parts_hours_updown);
            Controls.Add(btnAddPart);
            Controls.Add(label5);
            Controls.Add(part_textbox);
            Controls.Add(parts_listbox);
            Controls.Add(parts_checkbox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(product_hours_updown);
            Controls.Add(product_stock_ini_textbox);
            Controls.Add(product_value_textbox);
            Controls.Add(product_name_textbox);
            Controls.Add(btnAñadir);
            Controls.Add(titulo_principal);
            Name = "Add_product_form";
            Text = "Añadir";
            Load += Add_product_form_Load;
            ((System.ComponentModel.ISupportInitialize)product_hours_updown).EndInit();
            ((System.ComponentModel.ISupportInitialize)parts_hours_updown).EndInit();
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
        private Button btnSalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox parts_checkbox;
        private ListBox parts_listbox;
        private TextBox part_textbox;
        private Label label5;
        private Button btnAddPart;
        private NumericUpDown parts_hours_updown;
        private Label label6;
    }
}