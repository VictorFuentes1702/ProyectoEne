namespace ProyectoENE.Entities.View
{
    partial class viewListarTrabajadores
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
            this.tbl_Trajabadores = new System.Windows.Forms.DataGridView();
            this.cmb_buscar = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Trajabadores)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_Trajabadores
            // 
            this.tbl_Trajabadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_Trajabadores.Location = new System.Drawing.Point(12, 97);
            this.tbl_Trajabadores.Name = "tbl_Trajabadores";
            this.tbl_Trajabadores.ReadOnly = true;
            this.tbl_Trajabadores.Size = new System.Drawing.Size(776, 241);
            this.tbl_Trajabadores.TabIndex = 0;
            this.tbl_Trajabadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_Trajabadores_CellContentClick);
            // 
            // cmb_buscar
            // 
            this.cmb_buscar.FormattingEnabled = true;
            this.cmb_buscar.Location = new System.Drawing.Point(227, 13);
            this.cmb_buscar.Name = "cmb_buscar";
            this.cmb_buscar.Size = new System.Drawing.Size(141, 21);
            this.cmb_buscar.TabIndex = 1;
            this.cmb_buscar.SelectedIndexChanged += new System.EventHandler(this.cmb_buscar_SelectedIndexChanged_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem1,
            this.cerrarSesionToolStripMenuItem});
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.volverToolStripMenuItem.Text = "Opciones";
            // 
            // volverToolStripMenuItem1
            // 
            this.volverToolStripMenuItem1.Name = "volverToolStripMenuItem1";
            this.volverToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.volverToolStripMenuItem1.Text = "Volver";
            this.volverToolStripMenuItem1.Click += new System.EventHandler(this.volverToolStripMenuItem1_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // viewListarTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_buscar);
            this.Controls.Add(this.tbl_Trajabadores);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "viewListarTrabajadores";
            this.Text = "viewListarTrabajadores";
            this.Load += new System.EventHandler(this.viewListarTrabajadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Trajabadores)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tbl_Trajabadores;
        private System.Windows.Forms.ComboBox cmb_buscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}