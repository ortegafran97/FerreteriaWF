namespace FerreteriaWF.Vistas
{
    partial class D_Agregacion
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
            this.tablaGroupBy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaGroupBy)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaGroupBy
            // 
            this.tablaGroupBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tablaGroupBy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaGroupBy.Location = new System.Drawing.Point(149, 53);
            this.tablaGroupBy.Name = "tablaGroupBy";
            this.tablaGroupBy.Size = new System.Drawing.Size(279, 178);
            this.tablaGroupBy.TabIndex = 4;
            // 
            // D_Agregacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablaGroupBy);
            this.Name = "D_Agregacion";
            this.Text = "D_Agregacion";
            this.Load += new System.EventHandler(this.D_Agregacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaGroupBy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaGroupBy;
    }
}