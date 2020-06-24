namespace FerreteriaWF.Vistas
{
    partial class Compras
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
            this.label1 = new System.Windows.Forms.Label();
            this.btNuevaCompra = new System.Windows.Forms.Button();
            this.tablaCompraDetalle = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCompraDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Compras";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btNuevaCompra
            // 
            this.btNuevaCompra.Location = new System.Drawing.Point(13, 10);
            this.btNuevaCompra.Name = "btNuevaCompra";
            this.btNuevaCompra.Size = new System.Drawing.Size(108, 35);
            this.btNuevaCompra.TabIndex = 2;
            this.btNuevaCompra.Text = "Nueva Compra";
            this.btNuevaCompra.UseVisualStyleBackColor = true;
            this.btNuevaCompra.Click += new System.EventHandler(this.btNuevaCompra_Click);
            // 
            // tablaCompraDetalle
            // 
            this.tablaCompraDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCompraDetalle.Location = new System.Drawing.Point(13, 80);
            this.tablaCompraDetalle.Name = "tablaCompraDetalle";
            this.tablaCompraDetalle.Size = new System.Drawing.Size(353, 473);
            this.tablaCompraDetalle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ultimos productos comprados:";
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(769, 581);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tablaCompraDetalle);
            this.Controls.Add(this.btNuevaCompra);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCompraDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btNuevaCompra;
        private System.Windows.Forms.DataGridView tablaCompraDetalle;
        private System.Windows.Forms.Label label2;
    }
}