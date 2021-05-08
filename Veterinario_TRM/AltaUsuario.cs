using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace Veterinario_TRM
{
    public partial class AltaUsuario : Form
    {

        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void Alta_Click(object sender, EventArgs e)
        {
            String passHasheada = BCrypt.Net.BCrypt.HashPassword(passwordAlta.Text, BCrypt.Net.BCrypt.GenerateSalt());

            //MessageBox.Show(passwordAlta.Text + "  " + passHasheada);

            Conexion conexion = new Conexion();
            Boolean resultado = conexion.altaUsuario(DNIAlta.Text, nombreAlta.Text, apellidosAlta.Text, passHasheada, emailAlta.Text);

            if (resultado)
            {
                MessageBox.Show("TODO BIEN PAPI");
            }
            else
            {
                MessageBox.Show("ALGO MALO HA PASADOOOO");
            }

        }
    }
}
