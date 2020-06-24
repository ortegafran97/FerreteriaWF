namespace FerreteriaWF.Vistas
{
    partial class NuevoRubro
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(72, 75);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(75, 23);
            this.cargar.TabIndex = 1;
            this.cargar.Text = "Cargar";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.CrearNuevoRubro);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cargado con exito";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Visible = false;
            // 
            // NuevoRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.textBox1);
            this.Name = "NuevoRubro";
            this.Text = "NuevoRubro";
            this.Load += new System.EventHandler(this.NuevoRubro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Label label1;
    }
}