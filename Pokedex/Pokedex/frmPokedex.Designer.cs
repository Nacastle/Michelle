namespace Pokedex
{
    partial class frmPokedex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPokedex));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransferir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVer = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarAEstadoDeFabricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(40, 114);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(601, 390);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokemonToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.regresarAEstadoDeFabricaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pokemonToolStripMenuItem
            // 
            this.pokemonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAgregar,
            this.menuModificar,
            this.menuEliminar,
            this.menuTransferir,
            this.menuVer});
            this.pokemonToolStripMenuItem.Name = "pokemonToolStripMenuItem";
            this.pokemonToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.pokemonToolStripMenuItem.Text = "Pokemon";
            this.pokemonToolStripMenuItem.Click += new System.EventHandler(this.pokemonToolStripMenuItem_Click);
            // 
            // menuAgregar
            // 
            this.menuAgregar.Name = "menuAgregar";
            this.menuAgregar.Size = new System.Drawing.Size(152, 22);
            this.menuAgregar.Text = "Agregar";
            this.menuAgregar.Click += new System.EventHandler(this.menuAgregar_Click);
            // 
            // menuModificar
            // 
            this.menuModificar.Enabled = false;
            this.menuModificar.Name = "menuModificar";
            this.menuModificar.Size = new System.Drawing.Size(152, 22);
            this.menuModificar.Text = "Modificar";
            this.menuModificar.Click += new System.EventHandler(this.menuModificar_Click);
            // 
            // menuEliminar
            // 
            this.menuEliminar.Enabled = false;
            this.menuEliminar.Name = "menuEliminar";
            this.menuEliminar.Size = new System.Drawing.Size(152, 22);
            this.menuEliminar.Text = "Eliminar";
            // 
            // menuTransferir
            // 
            this.menuTransferir.Enabled = false;
            this.menuTransferir.Name = "menuTransferir";
            this.menuTransferir.Size = new System.Drawing.Size(152, 22);
            this.menuTransferir.Text = "Transferir";
            this.menuTransferir.Click += new System.EventHandler(this.menuTransferir_Click);
            // 
            // menuVer
            // 
            this.menuVer.Enabled = false;
            this.menuVer.Name = "menuVer";
            this.menuVer.Size = new System.Drawing.Size(152, 22);
            this.menuVer.Text = "Ver detalles";
            this.menuVer.Click += new System.EventHandler(this.menuVer_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // regresarAEstadoDeFabricaToolStripMenuItem
            // 
            this.regresarAEstadoDeFabricaToolStripMenuItem.Name = "regresarAEstadoDeFabricaToolStripMenuItem";
            this.regresarAEstadoDeFabricaToolStripMenuItem.Size = new System.Drawing.Size(168, 20);
            this.regresarAEstadoDeFabricaToolStripMenuItem.Text = "Regresar a Estado de Fabrica";
            this.regresarAEstadoDeFabricaToolStripMenuItem.Click += new System.EventHandler(this.regresarAEstadoDeFabricaToolStripMenuItem_Click);
            // 
            // frmPokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pokedex.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(685, 516);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPokedex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPokedex";
            this.Load += new System.EventHandler(this.frmPokedex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pokemonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAgregar;
        private System.Windows.Forms.ToolStripMenuItem menuModificar;
        private System.Windows.Forms.ToolStripMenuItem menuEliminar;
        private System.Windows.Forms.ToolStripMenuItem menuTransferir;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuVer;
        private System.Windows.Forms.ToolStripMenuItem regresarAEstadoDeFabricaToolStripMenuItem;
    }
}