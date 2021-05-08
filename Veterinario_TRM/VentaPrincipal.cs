using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinario_TRM
{
    public partial class VentaPrincipal : Form
    {
        Conexion conexion = new Conexion();

        public VentaPrincipal()
        {
            InitializeComponent();
        }

        private void newUsuario_Click(object sender, EventArgs e)
        {
            AltaUsuario ventana = new AltaUsuario();
            ventana.Show();
        }
    }
}
