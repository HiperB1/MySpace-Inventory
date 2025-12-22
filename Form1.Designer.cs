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
            SuspendLayout();
            // 
            // titulo_principal
            // 
            titulo_principal.AutoSize = true;
            titulo_principal.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo_principal.Location = new Point(299, 42);
            titulo_principal.Name = "titulo_principal";
            titulo_principal.Size = new Size(126, 32);
            titulo_principal.TabIndex = 0;
            titulo_principal.Text = "My Space";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(titulo_principal);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo_principal;
    }
}
