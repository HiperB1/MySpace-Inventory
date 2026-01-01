namespace MySpace_Inventory
{
    partial class Program
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
            btnAñadirACola = new Button();
            listView1 = new ListView();
            cola_impresora = new ColumnHeader();
            hora = new ColumnHeader();
            printer1_combobox = new ComboBox();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            comboBox2 = new ComboBox();
            printer_combobox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            product_textbox = new TextBox();
            btnAñadir = new Button();
            priority_numberbox = new NumericUpDown();
            priority_label = new Label();
            time_textbox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)priority_numberbox).BeginInit();
            SuspendLayout();
            // 
            // titulo_principal
            // 
            titulo_principal.AutoSize = true;
            titulo_principal.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo_principal.Location = new Point(197, 19);
            titulo_principal.Name = "titulo_principal";
            titulo_principal.Size = new Size(419, 43);
            titulo_principal.TabIndex = 1;
            titulo_principal.Text = "Contabilidad y programa";
            // 
            // btnAñadirACola
            // 
            btnAñadirACola.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAñadirACola.Location = new Point(358, 376);
            btnAñadirACola.Name = "btnAñadirACola";
            btnAñadirACola.Size = new Size(114, 31);
            btnAñadirACola.TabIndex = 2;
            btnAñadirACola.Text = "Añadir a cola";
            btnAñadirACola.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { cola_impresora, hora });
            listView1.Location = new Point(42, 78);
            listView1.Name = "listView1";
            listView1.Size = new Size(204, 228);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // cola_impresora
            // 
            cola_impresora.Text = "Cola";
            cola_impresora.Width = 120;
            // 
            // hora
            // 
            hora.Text = "Hora";
            hora.Width = 80;
            // 
            // printer1_combobox
            // 
            printer1_combobox.FormattingEnabled = true;
            printer1_combobox.Items.AddRange(new object[] { "215", "430", "820", "835" });
            printer1_combobox.Location = new Point(42, 312);
            printer1_combobox.Name = "printer1_combobox";
            printer1_combobox.Size = new Size(204, 23);
            printer1_combobox.TabIndex = 4;
            printer1_combobox.SelectedIndexChanged += printer1_combobox_SelectedIndexChanged;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView2.Location = new Point(268, 78);
            listView2.Name = "listView2";
            listView2.Size = new Size(204, 228);
            listView2.TabIndex = 5;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Cola";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Hora";
            columnHeader2.Width = 80;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "215", "430", "820", "835" });
            comboBox2.Location = new Point(268, 312);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(204, 23);
            comboBox2.TabIndex = 6;
            // 
            // printer_combobox
            // 
            printer_combobox.FormattingEnabled = true;
            printer_combobox.Items.AddRange(new object[] { "215", "430", "820", "835" });
            printer_combobox.Location = new Point(482, 99);
            printer_combobox.Name = "printer_combobox";
            printer_combobox.Size = new Size(147, 23);
            printer_combobox.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(482, 78);
            label3.Name = "label3";
            label3.Size = new Size(67, 18);
            label3.TabIndex = 14;
            label3.Text = "Impresora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(635, 77);
            label4.Name = "label4";
            label4.Size = new Size(95, 18);
            label4.TabIndex = 17;
            label4.Text = "Producto/Pieza";
            // 
            // product_textbox
            // 
            product_textbox.Location = new Point(635, 99);
            product_textbox.Name = "product_textbox";
            product_textbox.Size = new Size(147, 23);
            product_textbox.TabIndex = 16;
            // 
            // btnAñadir
            // 
            btnAñadir.Font = new Font("Trebuchet MS", 10F);
            btnAñadir.Location = new Point(596, 189);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(80, 26);
            btnAñadir.TabIndex = 18;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // priority_numberbox
            // 
            priority_numberbox.Location = new Point(635, 146);
            priority_numberbox.Name = "priority_numberbox";
            priority_numberbox.Size = new Size(147, 23);
            priority_numberbox.TabIndex = 19;
            // 
            // priority_label
            // 
            priority_label.AutoSize = true;
            priority_label.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priority_label.Location = new Point(635, 125);
            priority_label.Name = "priority_label";
            priority_label.Size = new Size(60, 18);
            priority_label.TabIndex = 20;
            priority_label.Text = "Prioridad";
            // 
            // time_textbox
            // 
            time_textbox.Location = new Point(482, 146);
            time_textbox.Name = "time_textbox";
            time_textbox.Size = new Size(147, 23);
            time_textbox.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(482, 125);
            label1.Name = "label1";
            label1.Size = new Size(51, 18);
            label1.TabIndex = 22;
            label1.Text = "Tiempo";
            // 
            // Program
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(time_textbox);
            Controls.Add(priority_label);
            Controls.Add(priority_numberbox);
            Controls.Add(btnAñadir);
            Controls.Add(label4);
            Controls.Add(product_textbox);
            Controls.Add(printer_combobox);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(listView2);
            Controls.Add(printer1_combobox);
            Controls.Add(listView1);
            Controls.Add(btnAñadirACola);
            Controls.Add(titulo_principal);
            Name = "Program";
            Text = "Programación";
            Load += Program_Load;
            ((System.ComponentModel.ISupportInitialize)priority_numberbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo_principal;
        private Button btnAñadirACola;
        private ListView listView1;
        private ColumnHeader cola_impresora;
        private ColumnHeader hora;
        private ComboBox printer1_combobox;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ComboBox comboBox2;
        private ComboBox printer_combobox;
        private Label label3;
        private Label label4;
        private TextBox product_textbox;
        private Button btnAñadir;
        private NumericUpDown priority_numberbox;
        private Label priority_label;
        private TextBox time_textbox;
        private Label label1;
    }
}