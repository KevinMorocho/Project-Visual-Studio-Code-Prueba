using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace mio
{
    public class Estudiante
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public int edad { get; set; }
        public Estudiante(string nombre, string apellido, string correo, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.edad = edad;

        }

    }
    public partial class Form1 : Form
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        Estudiante estudiante;

        public Form1()
        {
            InitializeComponent();
            btn1.Click += btn1_click;
            btn2.Click += btn2_click;
            btn3.Click += btn3_click;
            btn4.Click += btn4_click;
            btn5.Click += btn5_click;



        }
        private void btn1_click(object sender, EventArgs e)
        {
            estudiante = new Estudiante(txt1.Text, txt2.Text, txt3.Text, int.Parse(txt4.Text));
            estudiantes.Add(estudiante);
            txt1.Text = " ";
            txt2.Text = " ";
            txt3.Text = " ";
            txt4.Text = " ";

        }

        private void btn2_click(object sender, EventArgs e)
        {
            foreach (Estudiante est in estudiantes)
            {
                lstB1.Items.Add(est.nombre + " " + est.apellido + " " + est.correo + " " + est.edad);
            }
        }
        private void btn3_click(object sender, EventArgs e)
        {
            int i = 0, edadEs = 0;
            double promedio = 0;
            int longitud = estudiantes.Count();
            //promedio
            while (i < longitud)
            {
                edadEs += estudiantes[i].edad;
                i += 1;
            }
            promedio = edadEs / longitud;
            lbtxt6.Text = promedio.ToString();
        }
        private void btn4_click(object sender, EventArgs e)
        {
            int mayor = 0;
            int i = 0, j = 0;
            int longitud = estudiantes.Count();
            //mayor edad
            do
            {
                if (mayor > estudiantes[i].edad)
                {
                    mayor = mayor;
                    i += 1;
                }
                else
                {
                    mayor = estudiantes[i].edad;
                    i += 1;
                }

            } while (i < longitud);
            do
            {
                if (mayor == estudiantes[j].edad)
                {
                    lbtxt8.Text = estudiantes[j].nombre + " " + estudiantes[j].apellido;
                    j += 1;
                }
                else
                {
                    j += 1;
                }
            } while (j < longitud);
        }
        private void btn5_click(object sender, EventArgs e)
        {
            int op = 0;
            if (rbt1.Checked)
            {
                op = 1;
            }
            if (rbt2.Checked)
            {
                op = 2;
            }
            switch (op)
            {
                case 1:
                    foreach (Estudiante est in estudiantes)
                    {
                        lstB1.Items.Add(est.nombre);
                    }
                    break;
                case 2:
                    foreach (Estudiante est in estudiantes)
                    {
                        lstB1.Items.Add(est.apellido);
                    }
                    break;
                default:
                    break;
            }

        }

    }
}
