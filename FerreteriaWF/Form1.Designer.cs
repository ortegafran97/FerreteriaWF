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
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btRubros = new System.Windows.Forms.Button();
            this.btProveedores = new System.Windows.Forms.Button();
            this.btStock = new System.Windows.Forms.Button();
            this.btCompras = new System.Windows.Forms.Button();
            this.btInicio = new System.Windows.Forms.Button();
            this.btD = new System.Windows.Forms.Button();
            this.btE = new System.Windows.Forms.Button();
            this.btF = new System.Windows.Forms.Button();
            this.btG = new System.Windows.Forms.Button();
            this.btH = new System.Windows.Forms.Button();
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
            // PanelContenedor
            // 
            this.PanelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContenedor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PanelContenedor.Location = new System.Drawing.Point(144, 4);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(790, 461);
            this.PanelContenedor.TabIndex = 1;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint);
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBotones.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelBotones.Controls.Add(this.btH);
            this.panelBotones.Controls.Add(this.btG);
            this.panelBotones.Controls.Add(this.btF);
            this.panelBotones.Controls.Add(this.btE);
            this.panelBotones.Controls.Add(this.btD);
            this.panelBotones.Controls.Add(this.button1);
            this.panelBotones.Controls.Add(this.btRubros);
            this.panelBotones.Controls.Add(this.btProveedores);
            this.panelBotones.Controls.Add(this.btStock);
            this.panelBotones.Controls.Add(this.btCompras);
            this.panelBotones.Controls.Add(this.btInicio);
            this.panelBotones.Location = new System.Drawing.Point(0, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(138, 477);
            this.panelBotones.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "C- Group by";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btRubros
            // 
            this.btRubros.Location = new System.Drawing.Point(9, 125);
            this.btRubros.Name = "btRubros";
            this.btRubros.Size = new System.Drawing.Size(122, 23);
            this.btRubros.TabIndex = 4;
            this.btRubros.Text = "btRubros";
            this.btRubros.UseVisualStyleBackColor = true;
            this.btRubros.Click += new System.EventHandler(this.btRubros_click);
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
            // btD
            // 
            this.btD.Location = new System.Drawing.Point(9, 183);
            this.btD.Name = "btD";
            this.btD.Size = new System.Drawing.Size(122, 23);
            this.btD.TabIndex = 6;
            this.btD.Text = "D- ";
            this.btD.UseVisualStyleBackColor = true;
            // 
            // btE
            // 
            this.btE.Location = new System.Drawing.Point(9, 212);
            this.btE.Name = "btE";
            this.btE.Size = new System.Drawing.Size(122, 23);
            this.btE.TabIndex = 7;
            this.btE.Text = "E-";
            this.btE.UseVisualStyleBackColor = true;
            // 
            // btF
            // 
            this.btF.Location = new System.Drawing.Point(9, 241);
            this.btF.Name = "btF";
            this.btF.Size = new System.Drawing.Size(122, 23);
            this.btF.TabIndex = 8;
            this.btF.Text = "F-";
            this.btF.UseVisualStyleBackColor = true;
            // 
            // btG
            // 
            this.btG.Location = new System.Drawing.Point(9, 270);
            this.btG.Name = "btG";
            this.btG.Size = new System.Drawing.Size(122, 23);
            this.btG.TabIndex = 9;
            this.btG.Text = "G-";
            this.btG.UseVisualStyleBackColor = true;
            // 
            // btH
            // 
            this.btH.Location = new System.Drawing.Point(9, 299);
            this.btH.Name = "btH";
            this.btH.Size = new System.Drawing.Size(122, 23);
            this.btH.TabIndex = 10;
            this.btH.Text = "H-";
            this.btH.UseVisualStyleBackColor = true;
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFerreteria_FormClosed);
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
        private System.Windows.Forms.Button btRubros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btH;
        private System.Windows.Forms.Button btG;
        private System.Windows.Forms.Button btF;
        private System.Windows.Forms.Button btE;
        private System.Windows.Forms.Button btD;
    }
}

