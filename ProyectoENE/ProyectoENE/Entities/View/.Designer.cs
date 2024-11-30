namespace ProyectoENE.Entities.View
{
    partial class ViewAgregarSueldos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_horas = new System.Windows.Forms.TextBox();
            this.txt_horas_extra = new System.Windows.Forms.TextBox();
            this.cbo_afp = new System.Windows.Forms.ComboBox();
            this.cbo_salud = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sueldo_Liquido = new System.Windows.Forms.TextBox();
            this.txt_sueldo_Bruto = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cbo_Rut = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.volverToolStripMenuItem.Text = "Cerrar Sesion";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Horas Trabajadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Horas Extras";
            // 
            // txt_horas
            // 
            this.txt_horas.Location = new System.Drawing.Point(224, 75);
            this.txt_horas.Name = "txt_horas";
            this.txt_horas.Size = new System.Drawing.Size(118, 20);
            this.txt_horas.TabIndex = 14;
            this.txt_horas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_horas_KeyPress);
            // 
            // txt_horas_extra
            // 
            this.txt_horas_extra.Location = new System.Drawing.Point(224, 115);
            this.txt_horas_extra.Name = "txt_horas_extra";
            this.txt_horas_extra.Size = new System.Drawing.Size(118, 20);
            this.txt_horas_extra.TabIndex = 15;
            this.txt_horas_extra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_horas_extra_KeyPress);
            // 
            // cbo_afp
            // 
            this.cbo_afp.FormattingEnabled = true;
            this.cbo_afp.Items.AddRange(new object[] {
            "CUPRUM",
            "MODELO",
            "CAPITAL",
            "PROVIDA"});
            this.cbo_afp.Location = new System.Drawing.Point(481, 75);
            this.cbo_afp.Name = "cbo_afp";
            this.cbo_afp.Size = new System.Drawing.Size(124, 21);
            this.cbo_afp.TabIndex = 16;
            this.cbo_afp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_afp_KeyPress);
            // 
            // cbo_salud
            // 
            this.cbo_salud.FormattingEnabled = true;
            this.cbo_salud.Items.AddRange(new object[] {
            "FONASA",
            "CONSALUD,",
            "MASVIDA",
            "BANMEDICA"});
            this.cbo_salud.Location = new System.Drawing.Point(481, 129);
            this.cbo_salud.Name = "cbo_salud";
            this.cbo_salud.Size = new System.Drawing.Size(124, 21);
            this.cbo_salud.TabIndex = 17;
            this.cbo_salud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_salud_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sueldo Bruto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sueldo Liquido";
            // 
            // txt_sueldo_Liquido
            // 
            this.txt_sueldo_Liquido.Location = new System.Drawing.Point(517, 249);
            this.txt_sueldo_Liquido.Name = "txt_sueldo_Liquido";
            this.txt_sueldo_Liquido.Size = new System.Drawing.Size(118, 20);
            this.txt_sueldo_Liquido.TabIndex = 20;
            this.txt_sueldo_Liquido.TextChanged += new System.EventHandler(this.txt_sueldo_Liquido_TextChanged);
            this.txt_sueldo_Liquido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sueldo_Liquido_KeyPress);
            // 
            // txt_sueldo_Bruto
            // 
            this.txt_sueldo_Bruto.Location = new System.Drawing.Point(517, 209);
            this.txt_sueldo_Bruto.Name = "txt_sueldo_Bruto";
            this.txt_sueldo_Bruto.Size = new System.Drawing.Size(118, 20);
            this.txt_sueldo_Bruto.TabIndex = 21;
            this.txt_sueldo_Bruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sueldo_Bruto_KeyPress);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(63, 180);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(66, 29);
            this.btn_calcular.TabIndex = 22;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 29);
            this.button2.TabIndex = 23;
            this.button2.Text = "Listar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(63, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 41);
            this.button3.TabIndex = 24;
            this.button3.Text = "Limpiar Campos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(63, 219);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(66, 29);
            this.btn_guardar.TabIndex = 25;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            this.btn_guardar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_guardar_KeyPress);
            // 
            // cbo_Rut
            // 
            this.cbo_Rut.FormattingEnabled = true;
            this.cbo_Rut.Location = new System.Drawing.Point(368, 22);
            this.cbo_Rut.Name = "cbo_Rut";
            this.cbo_Rut.Size = new System.Drawing.Size(149, 21);
            this.cbo_Rut.TabIndex = 1;
            this.cbo_Rut.SelectedIndexChanged += new System.EventHandler(this.cbo_Rut_SelectedIndexChanged);
            this.cbo_Rut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_Rut_KeyPress);
            // 
            // ViewAgregarSueldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbo_Rut);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_sueldo_Bruto);
            this.Controls.Add(this.txt_sueldo_Liquido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_salud);
            this.Controls.Add(this.cbo_afp);
            this.Controls.Add(this.txt_horas_extra);
            this.Controls.Add(this.txt_horas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ViewAgregarSueldos";
            this.Text = "ViewAgregarUsuario2";
            this.Load += new System.EventHandler(this.ViewAgregarSueldos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_horas;
        private System.Windows.Forms.TextBox txt_horas_extra;
        private System.Windows.Forms.ComboBox cbo_afp;
        private System.Windows.Forms.ComboBox cbo_salud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sueldo_Liquido;
        private System.Windows.Forms.TextBox txt_sueldo_Bruto;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox cbo_Rut;
    }
}