using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class frmTransferir : Form
    {
        Archivo achivo;
        Pokemon pokemonE;
        StreamReader sr;
        Usuario userTrans = new Usuario();
        Archivo archTrans;
        String user;
        String pokemon;
        String poke;
        public frmTransferir(String user, String pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            this.user = user;
            achivo = new Archivo();
            pokemonE = new Pokemon();
            achivo.setUser(user);
            pokemonE = achivo.buscar(pokemon);
            poke = pokemonE.toString();
            textBox1.Text = pokemonE.getNombre();
            this.picPokemon.ImageLocation = pokemonE.getImagen();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTransferir_Load(object sender, EventArgs e)
        {
            sr = new StreamReader("C/Usuarios.txt");
            String datosUsuario;

            String[] datos;
            while ((datosUsuario = sr.ReadLine()) != null)
            {
                datos = datosUsuario.Split('|');
                listUsarios.Items.Add(datos[0]);
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            archTrans = new Archivo();
            archTrans.setUser(listUsarios.SelectedItem.ToString());
            archTrans.agregarRegistro(pokemonE.toString());
            this.Close();
        }
    }
}
