namespace FerreteriaWF.Vistas
{
    partial class NuevaCompra
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
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.lblRubro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(9, 28);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(168, 21);
            this.cbProductos.TabIndex = 0;
            this.cbProductos.SelectedIndexChanged += new System.EventHandler(this.cbProductos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Seleccionar producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. Seleccionar Proveedor";
            // 
            // cbProveedores
            // 
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(12, 85);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(168, 21);
            this.cbProveedores.TabIndex = 2;
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(200, 28);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(36, 13);
            this.lblRubro.TabIndex = 4;
            this.lblRubro.Text = "Rubro";
            // 
            // NuevaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRubro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProveedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProductos);
            this.Name = "NuevaCompra";
            this.Text = "NuevaCompra";
            this.Load += new System.EventHandler(this.NuevaCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.Label lblRubro;
    }
}