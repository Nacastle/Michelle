using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pokedex
{
    public partial class Form1 : Form
    {
        StreamWriter sw;
        StreamReader sr;
        Usuario user = new Usuario();
        LinkedList<Usuario> listaUsuarios = new LinkedList<Usuario>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sr = new StreamReader("C/Usuarios.txt");
            String datosUsuario;
            bool adentro = false;
            String[] datos;
            while ((datosUsuario = sr.ReadLine()) != null)
            {
                datos = datosUsuario.Split('|');
                if (datosUsuario.Length > 1)
                {
                    if (datos[0] == txtUser.Text && datos[1] == txtPassword.Text)
                    {
                        user.setUser(datos[0]);
                        adentro = true;
                        sr.Close();
                        frmPokedex form = new frmPokedex(user.getUser());
                        form.ShowDialog();
                        this.txtUser.Text = null;
                        this.txtPassword.Text = null;
                        sr = new StreamReader("C/Usuarios.txt");
                    }
                }
                            }
                         
            if (adentro == false){
                MessageBox.Show("Usuario o contraseña incorrecta. Intente nuevamente", "Error");
                this.txtUser.Text = null;
                this.txtPassword.Text = null;

            }
            sr.Close();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro form = new frmRegistro();
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
