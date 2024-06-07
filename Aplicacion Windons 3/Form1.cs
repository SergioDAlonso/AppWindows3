using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Windons_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 58) && e.KeyChar !=8)
                e.Handled = true;
        }

        private void bttAceptar_Click(object sender, EventArgs e)
        {
            int valido = 0;

            if (tbxApellido.Text == "")
                tbxApellido.BackColor = Color.Red;
            else
            {
                tbxApellido.BackColor = System.Drawing.SystemColors.Control;
                valido++;
            }
            if (tbxNombre.Text == "")
                tbxNombre.BackColor = Color.Red;
            else
            {
                tbxNombre.BackColor = System.Drawing.SystemColors.Control;
                valido++;
            }
            if (tbxEdad.Text == "")
                tbxEdad.BackColor = Color.Red;
            else
            {
                tbxEdad.BackColor = System.Drawing.SystemColors.Control;
                valido++;
            }
            if (tbxDirec.Text == "")
                tbxDirec.BackColor = Color.Red;
            else
            {
                tbxDirec.BackColor = System.Drawing.SystemColors.Control;
                valido++;
            }
            string apellido = tbxApellido.Text;
            string nombre = tbxNombre.Text;
            int edad = int.Parse(tbxEdad.Text);
            string direc = tbxDirec.Text;

            string resultado = $"Apellido y Nombre: {apellido + nombre}\n" +
                               $"Edad: {edad}\n" +
                               $"Dirección: {direc}";
            if (valido == 4)
                rtbResultado.Text = resultado;
            else
                MessageBox.Show("Complete TODOS los campos");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
