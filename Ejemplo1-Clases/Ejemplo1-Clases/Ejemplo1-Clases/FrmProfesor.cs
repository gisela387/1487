using System;
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
    public partial class FrmProfesor : Form
    {
        public FrmProfesor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {           
            Profesor profe = new Profesor(tex1.Text, double.Parse(tex2.Text));
            Datos.Profesores.Add(profe);
            FrmPersona person = new FrmPersona();
            person.ShowDialog();
            profe.Id = person.tex1.Text;
            profe.Nombre = person.tex2.Text;
            profe.Direccion = person.tex3.Text;
            profe.Telf = person.tex4.Text;
            profe.Email = person.text5.Text;
            DialogResult resp = DialogResult.Yes;
            while (resp == DialogResult.Yes)
            {
                FrmCentro cen = new FrmCentro();
                cen.ShowDialog();
                this.Close();
                resp = MessageBox.Show("hay mas centros", "confirmar", MessageBoxButtons.YesNo);

            }
            this.Close();
            
        }
    }
}
