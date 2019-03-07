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

namespace Actividades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureEstudents_Click(object sender, EventArgs e)
        {
            Estudiante student1 = new Estudiante();
            var student2 = new Estudiante();

            student1.Edad = 20;
            student1.Nombre = "";
            student1.Genero = ' ';
            student1.NumeroControl = -2018100123;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
