﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Clases
{
    public partial class FrmCentro : Form
    {
        public FrmCentro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Centro cs = new Centro(tex1.Text,tex2.Text,tex3.Text,tex4.Text);
            Datos.Centros.Add(cs);
            this.Close();
        }

        private void tex2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
