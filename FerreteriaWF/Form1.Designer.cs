namespace FerreteriaWF
{
    partial class FormFerreteria
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.btInicio = new System.Windows.Forms.Button();
            this.btCompras = new System.Windows.Forms.Button();
            this.btStock = new System.Windows.Forms.Button();
            this.btProveedores = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelContenedor);
            this.panel1.Controls.Add(this.panelBotones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 477);
            this.panel1.TabIndex = 0;
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBotones.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelBotones.Controls.Add(this.btProveedores);
            this.panelBotones.Controls.Add(this.btStock);
            this.panelBotones.Controls.Add(this.btCompras);
            this.panelBotones.Controls.Add(this.btInicio);
            this.panelBotones.Location = new System.Drawing.Point(4, 4);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(134, 470);
            this.panelBotones.TabIndex = 0;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContenedor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PanelContenedor.Location = new System.Drawing.Point(144, 4);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(781, 461);
            this.PanelContenedor.TabIndex = 1;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint);
            // 
            // btInicio
            // 
            this.btInicio.Location = new System.Drawing.Point(9, 9);
            this.btInicio.Name = "btInicio";
            this.btInicio.Size = new System.Drawing.Size(122, 23);
            this.btInicio.TabIndex = 0;
            this.btInicio.Text = "btInicio";
            this.btInicio.UseVisualStyleBackColor = true;
            this.btInicio.Click += new System.EventHandler(this.btInicio_Click);
            // 
            // btCompras
            // 
            this.btCompras.Location = new System.Drawing.Point(9, 38);
            this.btCompras.Name = "btCompras";
            this.btCompras.Size = new System.Drawing.Size(122, 23);
            this.btCompras.TabIndex = 1;
            this.btCompras.Text = "btCompras";
            this.btCompras.UseVisualStyleBackColor = true;
            this.btCompras.Click += new System.EventHandler(this.btCompras_Click);
            // 
            // btStock
            // 
            this.btStock.Location = new System.Drawing.Point(9, 67);
            this.btStock.Name = "btStock";
            this.btStock.Size = new System.Drawing.Size(122, 23);
            this.btStock.TabIndex = 2;
            this.btStock.Text = "btStock";
            this.btStock.UseVisualStyleBackColor = true;
            this.btStock.Click += new System.EventHandler(this.btStock_Click);
            // 
            // btProveedores
            // 
            this.btProveedores.Location = new System.Drawing.Point(9, 96);
            this.btProveedores.Name = "btProveedores";
            this.btProveedores.Size = new System.Drawing.Size(122, 23);
            this.btProveedores.TabIndex = 3;
            this.btProveedores.Text = "btProveedores";
            this.btProveedores.UseVisualStyleBackColor = true;
            this.btProveedores.Click += new System.EventHandler(this.btProveedores_Click);
            // 
            // FormFerreteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 477);
            this.Controls.Add(this.panel1);
            this.Name = "FormFerreteria";
            this.Text = "Ferreteria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormFerreteria_Load);
            this.panel1.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btProveedores;
        private System.Windows.Forms.Button btStock;
        private System.Windows.Forms.Button btCompras;
        private System.Windows.Forms.Button btInicio;
    }
}

