namespace FerreteriaWF.Vistas
{
    partial class Rubros
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
            this.label2 = new System.Windows.Forms.Label();
            this.tablaRubros = new System.Windows.Forms.DataGridView();
            this.btNuevoRubro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRubros)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "RUBROS";
            // 
            // tablaRubros
            // 
            this.tablaRubros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tablaRubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRubros.Location = new System.Drawing.Point(17, 38);
            this.tablaRubros.Name = "tablaRubros";
            this.tablaRubros.Size = new System.Drawing.Size(279, 178);
            this.tablaRubros.TabIndex = 2;
            this.tablaRubros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaRubros_CellContentClick);
            // 
            // btNuevoRubro
            // 
            this.btNuevoRubro.Location = new System.Drawing.Point(302, 38);
            this.btNuevoRubro.Name = "btNuevoRubro";
            this.btNuevoRubro.Size = new System.Drawing.Size(123, 23);
            this.btNuevoRubro.TabIndex = 3;
            this.btNuevoRubro.Text = "Nuevo Rubro";
            this.btNuevoRubro.UseVisualStyleBackColor = true;
            this.btNuevoRubro.Click += new System.EventHandler(this.btNuevoRubro_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Eliminar Rubro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btNuevoRubro);
            this.Controls.Add(this.tablaRubros);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rubros";
            this.Text = "Rubros";
            this.Load += new System.EventHandler(this.Rubros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaRubros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tablaRubros;
        private System.Windows.Forms.Button btNuevoRubro;
        private System.Windows.Forms.Button button1;
    }
}