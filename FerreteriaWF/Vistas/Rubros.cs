﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaWF.Vistas
{
    public partial class Rubros : Form
    {

        public Rubros()
        {
            InitializeComponent();
        }
        public Rubros(DataTable dt)
        {
            InitializeComponent();
            tablaRubros.DataSource = dt;
            //tablaRubros.
        }

        private void Rubros_Load(object sender, EventArgs e)
        {
            
        }
    }
}
