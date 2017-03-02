namespace Pokedex
{
    partial class frmPokemon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPokemon));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnGuardarPokemon = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNombrePokemon = new System.Windows.Forms.TextBox();
            this.txtApodo = new System.Windows.Forms.TextBox();
            this.txtTipos = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtHabilidades = new System.Windows.Forms.TextBox();
            this.txtDebilidades = new System.Windows.Forms.TextBox();
            this.txtHp = new System.Windows.Forms.TextBox();
            this.txtAtaque = new System.Windows.Forms.TextBox();
            this.txtDefensa = new System.Windows.Forms.TextBox();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.txtDefensaEspecial = new System.Windows.Forms.TextBox();
            this.txtAtaqueEspecial = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblEvolucion1 = new System.Windows.Forms.LinkLabel();
            this.lblEvolucion2 = new System.Windows.Forms.LinkLabel();
            this.cmbEvolucion1 = new System.Windows.Forms.ComboBox();
            this.cmbEvolucion2 = new System.Windows.Forms.ComboBox();
            this.lblEvo1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnImagen = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picPokemon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtnPokeNoRegistrado = new System.Windows.Forms.RadioButton();
            this.rbtnEvolucionNoExiste = new System.Windows.Forms.RadioButton();
            this.btnModificarPokemon = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apodo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Altura (m):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Peso (kg):";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(229, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Género:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Categoría:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Debilidades:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Habilidades:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(229, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tipos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(235, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ataque";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "HP";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(425, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Defensa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(425, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Velocidad";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(222, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 38);
            this.label15.TabIndex = 15;
            this.label15.Text = "Defensa Especial";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 38);
            this.label16.TabIndex = 14;
            this.label16.Text = "Ataque Especial";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(95, 536);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 16);
            this.label18.TabIndex = 18;
            this.label18.Text = "Evoluciones";
            // 
            // btnGuardarPokemon
            // 
            this.btnGuardarPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPokemon.ForeColor = System.Drawing.Color.Blue;
            this.btnGuardarPokemon.Location = new System.Drawing.Point(303, 624);
            this.btnGuardarPokemon.Name = "btnGuardarPokemon";
            this.btnGuardarPokemon.Size = new System.Drawing.Size(83, 23);
            this.btnGuardarPokemon.TabIndex = 19;
            this.btnGuardarPokemon.Text = "Guardar";
            this.btnGuardarPokemon.UseVisualStyleBackColor = true;
            this.btnGuardarPokemon.Click += new System.EventHandler(this.btnGuardarPokemon_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Blue;
            this.btnCancelar.Location = new System.Drawing.Point(402, 624);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNombrePokemon
            // 
            this.txtNombrePokemon.Location = new System.Drawing.Point(86, 17);
            this.txtNombrePokemon.Name = "txtNombrePokemon";
            this.txtNombrePokemon.Size = new System.Drawing.Size(135, 22);
            this.txtNombrePokemon.TabIndex = 21;
            // 
            // txtApodo
            // 
            this.txtApodo.Location = new System.Drawing.Point(123, 17);
            this.txtApodo.Name = "txtApodo";
            this.txtApodo.Size = new System.Drawing.Size(100, 22);
            this.txtApodo.TabIndex = 23;
            // 
            // txtTipos
            // 
            this.txtTipos.Location = new System.Drawing.Point(287, 14);
            this.txtTipos.Name = "txtTipos";
            this.txtTipos.Size = new System.Drawing.Size(100, 22);
            this.txtTipos.TabIndex = 24;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(123, 40);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(262, 41);
            this.txtDescripcion.TabIndex = 25;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(123, 93);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 26;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(298, 93);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 22);
            this.txtPeso.TabIndex = 27;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(123, 119);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 22);
            this.txtCategoria.TabIndex = 28;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(298, 119);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 22);
            this.txtGenero.TabIndex = 29;
            // 
            // txtHabilidades
            // 
            this.txtHabilidades.Location = new System.Drawing.Point(125, 146);
            this.txtHabilidades.Multiline = true;
            this.txtHabilidades.Name = "txtHabilidades";
            this.txtHabilidades.Size = new System.Drawing.Size(262, 41);
            this.txtHabilidades.TabIndex = 30;
            // 
            // txtDebilidades
            // 
            this.txtDebilidades.Location = new System.Drawing.Point(123, 193);
            this.txtDebilidades.Multiline = true;
            this.txtDebilidades.Name = "txtDebilidades";
            this.txtDebilidades.Size = new System.Drawing.Size(262, 41);
            this.txtDebilidades.TabIndex = 31;
            // 
            // txtHp
            // 
            this.txtHp.Location = new System.Drawing.Point(94, 20);
            this.txtHp.Name = "txtHp";
            this.txtHp.Size = new System.Drawing.Size(100, 22);
            this.txtHp.TabIndex = 32;
            // 
            // txtAtaque
            // 
            this.txtAtaque.Location = new System.Drawing.Point(303, 20);
            this.txtAtaque.Name = "txtAtaque";
            this.txtAtaque.Size = new System.Drawing.Size(100, 22);
            this.txtAtaque.TabIndex = 33;
            // 
            // txtDefensa
            // 
            this.txtDefensa.Location = new System.Drawing.Point(512, 20);
            this.txtDefensa.Name = "txtDefensa";
            this.txtDefensa.Size = new System.Drawing.Size(100, 22);
            this.txtDefensa.TabIndex = 34;
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.Location = new System.Drawing.Point(512, 51);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(100, 22);
            this.txtVelocidad.TabIndex = 37;
            // 
            // txtDefensaEspecial
            // 
            this.txtDefensaEspecial.Location = new System.Drawing.Point(303, 51);
            this.txtDefensaEspecial.Name = "txtDefensaEspecial";
            this.txtDefensaEspecial.Size = new System.Drawing.Size(100, 22);
            this.txtDefensaEspecial.TabIndex = 36;
            // 
            // txtAtaqueEspecial
            // 
            this.txtAtaqueEspecial.Location = new System.Drawing.Point(94, 51);
            this.txtAtaqueEspecial.Name = "txtAtaqueEspecial";
            this.txtAtaqueEspecial.Size = new System.Drawing.Size(100, 22);
            this.txtAtaqueEspecial.TabIndex = 35;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(323, 536);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(154, 16);
            this.label19.TabIndex = 38;
            this.label19.Text = "No tiene evoluciones";
            // 
            // lblEvolucion1
            // 
            this.lblEvolucion1.AutoSize = true;
            this.lblEvolucion1.BackColor = System.Drawing.Color.Transparent;
            this.lblEvolucion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvolucion1.Location = new System.Drawing.Point(202, 592);
            this.lblEvolucion1.Name = "lblEvolucion1";
            this.lblEvolucion1.Size = new System.Drawing.Size(0, 16);
            this.lblEvolucion1.TabIndex = 39;
            this.lblEvolucion1.Visible = false;
            this.lblEvolucion1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEvolucion1_LinkClicked);
            // 
            // lblEvolucion2
            // 
            this.lblEvolucion2.AutoSize = true;
            this.lblEvolucion2.BackColor = System.Drawing.Color.Transparent;
            this.lblEvolucion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvolucion2.Location = new System.Drawing.Point(416, 592);
            this.lblEvolucion2.Name = "lblEvolucion2";
            this.lblEvolucion2.Size = new System.Drawing.Size(0, 16);
            this.lblEvolucion2.TabIndex = 41;
            this.lblEvolucion2.Visible = false;
            this.lblEvolucion2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // cmbEvolucion1
            // 
            this.cmbEvolucion1.FormattingEnabled = true;
            this.cmbEvolucion1.Location = new System.Drawing.Point(201, 564);
            this.cmbEvolucion1.Name = "cmbEvolucion1";
            this.cmbEvolucion1.Size = new System.Drawing.Size(143, 21);
            this.cmbEvolucion1.TabIndex = 42;
            this.cmbEvolucion1.SelectedIndexChanged += new System.EventHandler(this.cmbEvolucion1_SelectedIndexChanged);
            // 
            // cmbEvolucion2
            // 
            this.cmbEvolucion2.FormattingEnabled = true;
            this.cmbEvolucion2.Location = new System.Drawing.Point(474, 564);
            this.cmbEvolucion2.Name = "cmbEvolucion2";
            this.cmbEvolucion2.Size = new System.Drawing.Size(134, 21);
            this.cmbEvolucion2.TabIndex = 43;
            this.cmbEvolucion2.SelectedIndexChanged += new System.EventHandler(this.cmbEvolucion2_SelectedIndexChanged);
            // 
            // lblEvo1
            // 
            this.lblEvo1.AutoSize = true;
            this.lblEvo1.BackColor = System.Drawing.Color.Transparent;
            this.lblEvo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvo1.ForeColor = System.Drawing.Color.Blue;
            this.lblEvo1.Location = new System.Drawing.Point(102, 569);
            this.lblEvo1.Name = "lblEvo1";
            this.lblEvo1.Size = new System.Drawing.Size(92, 16);
            this.lblEvo1.TabIndex = 44;
            this.lblEvo1.Text = "Evolución 1:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(362, 569);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 16);
            this.label20.TabIndex = 45;
            this.label20.Text = "Evolución 2:";
            // 
            // btnImagen
            // 
            this.btnImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen.ForeColor = System.Drawing.Color.Blue;
            this.btnImagen.Location = new System.Drawing.Point(25, 251);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(185, 23);
            this.btnImagen.TabIndex = 47;
            this.btnImagen.Text = "Seleccionar Imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Blue;
            this.btnCerrar.Location = new System.Drawing.Point(193, 624);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(92, 23);
            this.btnCerrar.TabIndex = 48;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(189)))), ((int)(((byte)(21)))));
            this.groupBox1.Controls.Add(this.txtDebilidades);
            this.groupBox1.Controls.Add(this.txtHabilidades);
            this.groupBox1.Controls.Add(this.txtGenero);
            this.groupBox1.Controls.Add(this.txtCategoria);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.txtAltura);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtTipos);
            this.groupBox1.Controls.Add(this.txtApodo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(271, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 246);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(189)))), ((int)(((byte)(21)))));
            this.groupBox2.Controls.Add(this.txtVelocidad);
            this.groupBox2.Controls.Add(this.txtDefensaEspecial);
            this.groupBox2.Controls.Add(this.txtAtaqueEspecial);
            this.groupBox2.Controls.Add(this.txtDefensa);
            this.groupBox2.Controls.Add(this.txtAtaque);
            this.groupBox2.Controls.Add(this.txtHp);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(17, 436);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 88);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stats";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(189)))), ((int)(((byte)(21)))));
            this.groupBox3.Controls.Add(this.picPokemon);
            this.groupBox3.Controls.Add(this.btnImagen);
            this.groupBox3.Controls.Add(this.txtNombrePokemon);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(12, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 285);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Perfil";
            // 
            // picPokemon
            // 
            this.picPokemon.Location = new System.Drawing.Point(23, 45);
            this.picPokemon.Name = "picPokemon";
            this.picPokemon.Size = new System.Drawing.Size(185, 200);
            this.picPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPokemon.TabIndex = 1;
            this.picPokemon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // rbtnPokeNoRegistrado
            // 
            this.rbtnPokeNoRegistrado.AutoSize = true;
            this.rbtnPokeNoRegistrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPokeNoRegistrado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbtnPokeNoRegistrado.Location = new System.Drawing.Point(73, 598);
            this.rbtnPokeNoRegistrado.Name = "rbtnPokeNoRegistrado";
            this.rbtnPokeNoRegistrado.Size = new System.Drawing.Size(313, 20);
            this.rbtnPokeNoRegistrado.TabIndex = 53;
            this.rbtnPokeNoRegistrado.TabStop = true;
            this.rbtnPokeNoRegistrado.Text = "No está registrada ninguna evolución aún";
            this.rbtnPokeNoRegistrado.UseVisualStyleBackColor = true;
            this.rbtnPokeNoRegistrado.CheckedChanged += new System.EventHandler(this.rbtnPokeNoRegistrado_CheckedChanged);
            // 
            // rbtnEvolucionNoExiste
            // 
            this.rbtnEvolucionNoExiste.AutoSize = true;
            this.rbtnEvolucionNoExiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEvolucionNoExiste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbtnEvolucionNoExiste.Location = new System.Drawing.Point(392, 598);
            this.rbtnEvolucionNoExiste.Name = "rbtnEvolucionNoExiste";
            this.rbtnEvolucionNoExiste.Size = new System.Drawing.Size(256, 20);
            this.rbtnEvolucionNoExiste.TabIndex = 54;
            this.rbtnEvolucionNoExiste.TabStop = true;
            this.rbtnEvolucionNoExiste.Text = "Éste Pokemon no tiene evolución";
            this.rbtnEvolucionNoExiste.UseVisualStyleBackColor = true;
            this.rbtnEvolucionNoExiste.CheckedChanged += new System.EventHandler(this.rbtnEvolucionNoExiste_CheckedChanged);
            // 
            // btnModificarPokemon
            // 
            this.btnModificarPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPokemon.ForeColor = System.Drawing.Color.Blue;
            this.btnModificarPokemon.Location = new System.Drawing.Point(313, 624);
            this.btnModificarPokemon.Name = "btnModificarPokemon";
            this.btnModificarPokemon.Size = new System.Drawing.Size(83, 23);
            this.btnModificarPokemon.TabIndex = 55;
            this.btnModificarPokemon.Text = "Guardar";
            this.btnModificarPokemon.UseVisualStyleBackColor = true;
            this.btnModificarPokemon.Click += new System.EventHandler(this.btnModificarPokemon_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 664);
            this.Controls.Add(this.btnModificarPokemon);
            this.Controls.Add(this.rbtnEvolucionNoExiste);
            this.Controls.Add(this.rbtnPokeNoRegistrado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblEvo1);
            this.Controls.Add(this.cmbEvolucion2);
            this.Controls.Add(this.cmbEvolucion1);
            this.Controls.Add(this.lblEvolucion2);
            this.Controls.Add(this.lblEvolucion1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarPokemon);
            this.Controls.Add(this.label18);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPokemon";
            this.Load += new System.EventHandler(this.frmPokemon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picPokemon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnGuardarPokemon;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombrePokemon;
        private System.Windows.Forms.TextBox txtApodo;
        private System.Windows.Forms.TextBox txtTipos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtHabilidades;
        private System.Windows.Forms.TextBox txtDebilidades;
        private System.Windows.Forms.TextBox txtHp;
        private System.Windows.Forms.TextBox txtAtaque;
        private System.Windows.Forms.TextBox txtDefensa;
        private System.Windows.Forms.TextBox txtVelocidad;
        private System.Windows.Forms.TextBox txtDefensaEspecial;
        private System.Windows.Forms.TextBox txtAtaqueEspecial;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.LinkLabel lblEvolucion1;
        private System.Windows.Forms.LinkLabel lblEvolucion2;
        private System.Windows.Forms.ComboBox cmbEvolucion1;
        private System.Windows.Forms.ComboBox cmbEvolucion2;
        private System.Windows.Forms.Label lblEvo1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbtnPokeNoRegistrado;
        private System.Windows.Forms.RadioButton rbtnEvolucionNoExiste;
        private System.Windows.Forms.Button btnModificarPokemon;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}