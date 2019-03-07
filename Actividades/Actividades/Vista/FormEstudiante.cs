using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividades.Modelo;


namespace Actividades.Vista
{
    public partial class FormEstudiante : Form
    {
        public FormEstudiante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            Estudiante student01 = new Estudiante();
            student01.NumeroControl = 2018100123;
            student01.Nombre = "Jaqueline Morales";
            student01.Edad = 19;
            student01.Genero = 'M';

            textoNumeroControl.Text = student01.NumeroControl.ToString();
            textoNombre.Text = student01.Nombre.ToString();
            textoEdad.Text = student01.Edad.ToString();
            textoGenero.Text = student01.Genero.ToString();
        }

     

        private void FormEstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
