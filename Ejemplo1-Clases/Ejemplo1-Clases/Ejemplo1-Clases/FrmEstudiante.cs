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
    public partial class FrmEstudiante : Form
    {
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno est = new Alumno(tex1.Text,tex2.Text);
            Datos.Alumnos.Add(est);
            FrmPersona person = new FrmPersona();
            person.ShowDialog();
            est.Id = person.tex1.Text;
            est.Nombre = person.tex2.Text;
            est.Direccion = person.tex3.Text;
            est.Telf = person.tex4.Text;
            est.Email = person.text5.Text;
            FrmCentro c = new FrmCentro();
            c.ShowDialog();
            this.Close();

        }
    }
}
