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
    public partial class VentanaLogin : Form
    {
        Conexion conexion = new Conexion();

        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
           if (conexion.loginVeterinario(DNIUsuario.Text, passwordUsuario.Text))
            {
                this.Hide();
                VentaPrincipal klk = new VentaPrincipal();
                klk.Show();
            }
            else
            {
                MessageBox.Show("EL USUARIO O LA CONTRASEÑA SON INCORRECTAS");
            }
            
        }
    }
}
