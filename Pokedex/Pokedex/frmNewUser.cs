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
    public partial class frmRegistro : Form
    {
        StreamReader sr;
        StreamWriter sw;
        Usuario nuevoUsuario;
        Archivo nuevoArchivo;
        String nombre;
        String user;
        String password;
        public frmRegistro()
        {
            
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            sr = new StreamReader("C/Usuarios.txt");
            String datosUsuario;
            
            String[] datos;
            while ((datosUsuario = sr.ReadLine()) != null)
            {
                datos = datosUsuario.Split('|');
                if (datos[0] == txtUser.Text)
                {
                    MessageBox.Show("Ese usuario ya existe, escribe otro");
                }
            }
            sr.Close();
            user = this.txtUser.Text;
            nombre = this.txtNombre.Text;
            password = this.txtPassword.Text;
            nuevoArchivo = new Archivo();
            nuevoArchivo.crearArchivo("C/" + user + ".txt");
            nuevoUsuario = new Usuario(nombre, user, password, nuevoArchivo);
            sw = new StreamWriter("C/Usuarios.txt", true);
            sw.WriteLine(nuevoUsuario.toString());
            String n = nuevoUsuario.toString();
            MessageBox.Show("Usuario creado con éxito");
            sw.Close();
            this.Close();
        }
    }
}
