using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class frmPokedex : Form
    {
        Pokemon pokemonSeleccionado = new Pokemon();
        String pokemonList;
        String user;
        String imageList;
        Archivo archivo = new Archivo();
        LinkedList<Pokemon> listaPokemon = new LinkedList<Pokemon>();
        public frmPokedex(String user)
        {
            this.user = user;
            this.archivo.setUser(user);
            InitializeComponent();
        }

        private void pokemonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuAgregar_Click(object sender, EventArgs e)
        {
            frmPokemon form = new frmPokemon(1, user, null);
            form.ShowDialog();
            this.listView1.Items.Clear();
            actualizarLista();
        }

        private void menuModificar_Click(object sender, EventArgs e)
        {
            frmPokemon form = new frmPokemon(2, user, pokemonList);
            form.ShowDialog();
            this.listView1.Items.Clear();
            actualizarLista();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.menuAgregar.Enabled = true;
            this.menuEliminar.Enabled = true;
            this.menuVer.Enabled = true;
            this.menuModificar.Enabled = true;
            this.menuTransferir.Enabled = true;
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem itemSeleccionado = listView1.SelectedItems[0];
                pokemonList = itemSeleccionado.Text;
                imageList = itemSeleccionado.ImageList.ToString();
            }
        }

        private void menuTransferir_Click(object sender, EventArgs e)
        {
            frmTransferir form = new frmTransferir(user, pokemonList);
            form.ShowDialog();
        }

        private void menuVer_Click(object sender, EventArgs e)
        {
            frmPokemon form = new frmPokemon(3, user, pokemonList);
            form.ShowDialog();
            //actualizarLista();
        }

        private void frmPokedex_Load(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void actualizarLista()
        {
            Archivo nuevoArchivo = new Archivo();
            nuevoArchivo.setUser(user);
            this.listaPokemon = nuevoArchivo.listar();
            ImageList imageList = new ImageList();
            for (int i = 0; i < listaPokemon.Count; i++)
            {

                imageList.Images.Add(Image.FromFile(listaPokemon.ElementAt(i).getImagen()));
                this.listView1.View = View.LargeIcon;
                imageList.ImageSize = new Size(130, 150);
                listView1.LargeImageList = imageList;
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = listaPokemon.ElementAt(i).getNombre();

                listView1.Items.Add(item);

            }
        }

        private void regresarAEstadoDeFabricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archivo.eliminar();
            listView1.Clear();
            actualizarLista();
            MessageBox.Show("Datos de la pokedex eliminados con éxito");
        }
    }
}
