namespace MySpace_Inventory
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // titulo_principal
            // 
            titulo_principal.AutoSize = true;
            titulo_principal.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo_principal.Location = new Point(281, 22);
            titulo_principal.Name = "titulo_principal";
            titulo_principal.Size = new Size(170, 43);
            titulo_principal.TabIndex = 0;
            titulo_principal.Text = "My Space";
            // 
            // button1
            // 
            button1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(199, 328);
            button1.Name = "button1";
            button1.Size = new Size(92, 31);
            button1.TabIndex = 1;
            button1.Text = "Inventario";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(327, 328);
            button2.Name = "button2";
            button2.Size = new Size(92, 31);
            button2.TabIndex = 2;
            button2.Text = "Programa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(464, 328);
            button3.Name = "button3";
            button3.Size = new Size(92, 31);
            button3.TabIndex = 3;
            button3.Text = "Pedidos";
            button3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(199, 119);
            listView1.Name = "listView1";
            listView1.Size = new Size(357, 128);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(titulo_principal);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo_principal;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListView listView1;
    }
}
