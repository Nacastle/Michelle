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
    public partial class frmPokemon : Form
    {
        Pokemon nuevoPokemon;
        private String Nombre;
        private String Apodo;
        private String Descripcion;
        private double Peso;
        private double Altura;
        private String Categoria;
        private String Habilidades;
        private String Genero;
        private String Tipos;
        private String Debilidades;
        private int Hp;
        private int Ataque;
        private int Defensa;
        private int AtaqueEspecial;
        private int DefensaEspecial;
        private int Velocidad;
        private String Evolucion1;
        private String Evolucion2;
        private String Imagen;
        private bool evolucion;
        Usuario usuario = new Usuario();
        Archivo archivo = new Archivo();
        String imagen = " ";
        
        LinkedList<Pokemon> listaPokemon = new LinkedList<Pokemon>();
        Pokemon pokemonModificar = new Pokemon();
        public frmPokemon(int accion, String user, String pokemon) // 1-->Abre el frmPokemon para crear un nuevo, 2-->modificar, 3-->ver detalles
        {
            InitializeComponent();
            archivo.setUser(user);
            pokemonModificar = archivo.buscar(pokemon);
            usuario.setUser(user);
            if (accion == 1)
            {
                lblEvolucion1.Visible = false;
                lblEvolucion2.Visible = false;
                btnCerrar.Visible = false;
                label19.Visible = false;
                btnModificarPokemon.Visible = false;
                llenarCombo(pokemonModificar);
            }
            else if(accion == 2)
            {
                btnCerrar.Visible = false;
                btnGuardarPokemon.Visible = false;
                rbtnEvolucionNoExiste.Visible = false;
                rbtnPokeNoRegistrado.Visible = false;
                llenarCampos();
                llenarCombo(pokemonModificar);
            }
            else if (accion == 3)
            {
                this.txtAltura.Enabled = false;
                this.txtApodo.Enabled = false;
                this.txtAtaque.Enabled = false;
                this.txtCategoria.Enabled = false;
                this.txtAtaqueEspecial.Enabled = false;
                this.txtDebilidades.Enabled = false;
                this.txtDefensa.Enabled = false;
                this.txtDefensaEspecial.Enabled = false;
                this.txtDescripcion.Enabled = false;
                this.txtGenero.Enabled = false;
                this.txtHabilidades.Enabled = false;
                this.txtHp.Enabled = false;
                this.txtNombrePokemon.Enabled = false;
                this.txtNombrePokemon.Enabled = false;
                this.txtPeso.Enabled = false;
                this.txtTipos.Enabled = false;
                this.txtVelocidad.Enabled = false;
                this.btnCancelar.Visible = false;
                this.btnGuardarPokemon.Visible = false;
                this.btnModificarPokemon.Visible = false;
                this.btnImagen.Visible = false;
                this.cmbEvolucion1.Visible = false;
                this.cmbEvolucion2.Visible = false;
                lblEvolucion1.Visible = true;
                lblEvolucion2.Visible = true;
                rbtnEvolucionNoExiste.Visible = false;
                rbtnPokeNoRegistrado.Visible = false;
                llenarCampos();
                if (pokemonModificar.getEvolucion().Equals(false))
                {
                    this.label19.Visible = true;
                }
                if (!pokemonModificar.getEvolucion1().Equals("no"))
                {
                    lblEvolucion1.Visible = true;
                    lblEvolucion1.Text = pokemonModificar.getEvolucion1();
                }
                if (!pokemonModificar.getEvolucion2().Equals("no"))
                {
                    lblEvolucion2.Visible = true;
                    lblEvolucion2.Text = pokemonModificar.getEvolucion2();
                }
                int o = 0;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmPokemon_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarPokemon_Click(object sender, EventArgs e)
        {
            agregarPokemon();
            if (verificarEspaciosVacios())
            {
                String l = nuevoPokemon.toString();
                archivo.agregarRegistro(nuevoPokemon.toString());
                MessageBox.Show("Registrado con éxito");
            }
            else
                MessageBox.Show("Por favor llene todos los campos");
            this.Close();
        }

        public bool verificarEspaciosVacios()
        {
            if (txtAltura.Text.Equals(null) || txtApodo.Text.Equals(null) || txtAtaque.Text.Equals(null)
                || txtAtaqueEspecial.Text.Equals(null) || txtCategoria.Text.Equals(null) || txtDebilidades.Text.Equals(null)
                || txtDefensa.Text.Equals(null) || txtDefensaEspecial.Text.Equals(null) || txtDescripcion.Text.Equals(null)
                || txtGenero.Text.Equals(null) || txtHabilidades.Text.Equals(null) || txtHp.Text.Equals(null)
                || txtNombrePokemon.Text.Equals(null) || txtPeso.Text.Equals(null) || txtTipos.Text.Equals(null)
                || txtVelocidad.Text.Equals(null) || picPokemon.Image.Equals(null))
                return false;
            else
                return true;
            

        }

        public void agregarPokemon()
        {
            Nombre = txtNombrePokemon.Text;
            Apodo = txtApodo.Text;
            Categoria = txtCategoria.Text;
            Debilidades = txtDebilidades.Text;
            Genero = txtGenero.Text;
            Descripcion = txtDescripcion.Text;
            Habilidades = txtHabilidades.Text;
            
                Imagen = imagen;
            
            Tipos = txtTipos.Text;
            
            if (verificarDouble(txtAltura.Text) > 0)
                Altura = verificarDouble(txtAltura.Text);
            else
                txtAltura.Text = null;
            
            if (verificarDouble(txtPeso.Text) > 0) 
                Peso = verificarDouble(txtPeso.Text);
            else
                txtPeso.Text = null;
            
            if (verificarInt(txtAtaque.Text) > 0)
                Ataque = verificarInt(txtAtaque.Text);
            else
                txtAtaque.Text = null;

            if (verificarInt(txtAtaqueEspecial.Text) > 0)
                AtaqueEspecial = verificarInt(txtAtaqueEspecial.Text);
            else
                txtAtaqueEspecial.Text = null;

            if (verificarInt(txtDefensaEspecial.Text) > 0)
                DefensaEspecial = verificarInt(txtDefensaEspecial.Text);
            else
                txtDefensaEspecial.Text = null;

            if (verificarInt(txtDefensa.Text) > 0)
                Defensa = verificarInt(txtDefensa.Text);
            else
                txtDefensaEspecial.Text = null;

            if (verificarInt(txtHp.Text) > 0)
                Hp = verificarInt(txtHp.Text);
            else
                txtHp.Text = null;

            if (verificarInt(txtVelocidad.Text) > 0)
                Velocidad = verificarInt(txtVelocidad.Text);
            else
                txtVelocidad.Text = null;

            Evolucion1 = cmbEvolucion1.Text;
            Evolucion2 = cmbEvolucion2.Text;

            if (cmbEvolucion1.Enabled && cmbEvolucion2.Enabled )
            {
                nuevoPokemon = new Pokemon(this.Nombre, this.Apodo, this.Descripcion, this.Peso, this.Altura, this.Categoria, this.Habilidades,
                    this.Genero, this.Tipos, this.Debilidades, this.Hp, this.Ataque, this.Defensa, this.AtaqueEspecial, this.DefensaEspecial,
                    this.Velocidad, true, this.Evolucion1, this.Evolucion2, this.Imagen);
            }
            if (rbtnPokeNoRegistrado.Checked == false || rbtnEvolucionNoExiste.Checked == false)
            {
                nuevoPokemon = new Pokemon(this.Nombre, this.Apodo, this.Descripcion, this.Peso, this.Altura, this.Categoria, this.Habilidades,
                    this.Genero, this.Tipos, this.Debilidades, this.Hp, this.Ataque, this.Defensa, this.AtaqueEspecial, this.DefensaEspecial,
                    this.Velocidad, false, "no", "no", this.Imagen);
            }
            int o = 0;
        }

        public int verificarInt(String numero)
        {
            try
            {
                int n = Int32.Parse(numero);
                return n;
            }
            catch(FormatException e)
            {
                MessageBox.Show(numero + " no está en el formato correcto");
                return 0;
            }
        }

        public double verificarDouble(String numero)
        {
            try
            {
                double n = Convert.ToDouble(numero);
                return n;
            }
            catch (FormatException)
            {
                MessageBox.Show(numero + "no está en el formato correcto");
                return 0;
            }
        }

        private void rbtnPokeNoRegistrado_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbEvolucion1.Enabled = false;
            this.cmbEvolucion2.Enabled = false;
        }

        private void rbtnEvolucionNoExiste_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbEvolucion1.Enabled = false;
            this.cmbEvolucion2.Enabled = false;
        }

        private void cmbEvolucion1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEvolucion2.Items.Remove(cmbEvolucion1.Text);
        }

        private void cmbEvolucion2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imagen = openFileDialog1.FileName;
                    picPokemon.Image = Image.FromFile(imagen);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("El archivo seleccionado no es una imagen");

            }
        }

        private void btnModificarPokemon_Click(object sender, EventArgs e)
        {
            agregarPokemon();
            String l;
            if (nuevoPokemon.getImagen().Equals(" "))
            {
                l = nuevoPokemon.toString() + pokemonModificar.getImagen();
            }
            else
            {
                l = nuevoPokemon.toString();
            }
            
            archivo.modificar(pokemonModificar.toString(), l);
            this.Close();
        }

        public void llenarCampos()
        {
            txtAltura.Text = pokemonModificar.getAltura().ToString();
            txtNombrePokemon.Text = pokemonModificar.getNombre();
            txtApodo.Text = pokemonModificar.getApodo();
            txtAtaque.Text = pokemonModificar.getAtaque().ToString();
            txtAtaqueEspecial.Text = pokemonModificar.getAtaqueEspecial().ToString();
            txtCategoria.Text = pokemonModificar.getCategoria();
            txtDebilidades.Text = pokemonModificar.getCategoria();
            txtDefensa.Text = pokemonModificar.getDefensa().ToString();
            txtDefensaEspecial.Text = pokemonModificar.getDefensaEspecial().ToString();
            txtDescripcion.Text = pokemonModificar.getDescripcion();
            txtGenero.Text = pokemonModificar.getGenero();
            txtHabilidades.Text = pokemonModificar.getHabilidades();
            txtHp.Text = pokemonModificar.getHp().ToString();
            txtPeso.Text = pokemonModificar.getPeso().ToString();
            txtTipos.Text = pokemonModificar.getTipos();
            txtVelocidad.Text = pokemonModificar.getVelocidad().ToString();
            picPokemon.Image = Image.FromFile(pokemonModificar.getImagen());
            
        }

        private void llenarCombo(Pokemon pokemonModificar)
        {
            this.listaPokemon = archivo.listar();
            for (int i = 0; i < listaPokemon.Count; i++)
            {
                if (!listaPokemon.ElementAt(i).getNombre().Equals(this.pokemonModificar.getNombre()))
                {
                    cmbEvolucion1.Items.Add(listaPokemon.ElementAt(i).getNombre());
                    if (!cmbEvolucion1.Items[i].Equals(this.pokemonModificar.getNombre()))
                    {
                        cmbEvolucion2.Items.Add(listaPokemon.ElementAt(i).getNombre());
                    }
                }
                
            }
            if(cmbEvolucion1.SelectedText.Length > 0)
            {
                cmbEvolucion2.Items.RemoveAt(cmbEvolucion1.SelectedIndex);
            }
        }

        private void lblEvolucion1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPokemon form = new frmPokemon(3, usuario.getUser(), lblEvolucion1.Text);
            form.ShowDialog();
        }
    }
}
