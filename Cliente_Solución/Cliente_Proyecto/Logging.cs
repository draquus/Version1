using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Cliente_Proyecto
{


    public partial class Logging : Form
    {
        string usuario;
        string contra;
        public Logging()
        {
            InitializeComponent();

        }

        private void Logging_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
        }

        private void EnviarB_Click(object sender, EventArgs e)
        {
            usuario = UsuarioT.Text;
            contra = ContraseñaT.Text;
        }

        public string Mensaje()
        {if ((usuario == null) || (contra == null))
            {
                string mensaje = "4/" + usuario + "/" + contra;
                return mensaje;
            }
            return "No se completó el inicio de sesión";
           
        }
    }
}
