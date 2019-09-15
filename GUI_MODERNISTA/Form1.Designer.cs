namespace GUI_MODERNISTA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnhistorico = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnrecibo = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnpagos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SubmenuReportes = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnrptpagos = new System.Windows.Forms.Button();
            this.btnrptpersonas = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnrptventa = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnlectura = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btncontacto = new System.Windows.Forms.Button();
            this.btnnotificacion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnproductos = new System.Windows.Forms.Button();
            this.btninicio = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.SubmenuReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btninicio)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(198)))), ((int)(((byte)(108)))));
            this.BarraTitulo.Controls.Add(this.label3);
            this.BarraTitulo.Controls.Add(this.label1);
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1733, 47);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(621, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(523, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "SISTEMA DE CONTROL DE LA MUNICIPALIDAD DE TIABAYA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = ".";
            this.label1.Visible = false;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Enabled = false;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1628, 7);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(33, 31);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1573, 7);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(33, 31);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Enabled = false;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1628, 7);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(33, 31);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1683, 7);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 31);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.btnhistorico);
            this.MenuVertical.Controls.Add(this.panel7);
            this.MenuVertical.Controls.Add(this.panel8);
            this.MenuVertical.Controls.Add(this.btnrecibo);
            this.MenuVertical.Controls.Add(this.panel6);
            this.MenuVertical.Controls.Add(this.btnpagos);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.SubmenuReportes);
            this.MenuVertical.Controls.Add(this.btnReportes);
            this.MenuVertical.Controls.Add(this.panel5);
            this.MenuVertical.Controls.Add(this.panel4);
            this.MenuVertical.Controls.Add(this.btnlectura);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Controls.Add(this.btncontacto);
            this.MenuVertical.Controls.Add(this.btnnotificacion);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.btnproductos);
            this.MenuVertical.Controls.Add(this.btninicio);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 47);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(293, 753);
            this.MenuVertical.TabIndex = 1;
            // 
            // btnhistorico
            // 
            this.btnhistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnhistorico.FlatAppearance.BorderSize = 0;
            this.btnhistorico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnhistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhistorico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhistorico.ForeColor = System.Drawing.Color.White;
            this.btnhistorico.Image = ((System.Drawing.Image)(resources.GetObject("btnhistorico.Image")));
            this.btnhistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhistorico.Location = new System.Drawing.Point(4, 682);
            this.btnhistorico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhistorico.Name = "btnhistorico";
            this.btnhistorico.Size = new System.Drawing.Size(289, 49);
            this.btnhistorico.TabIndex = 19;
            this.btnhistorico.Text = "HISTORICO";
            this.btnhistorico.UseVisualStyleBackColor = false;
            this.btnhistorico.Click += new System.EventHandler(this.btnhistorico_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(198)))), ((int)(((byte)(108)))));
            this.panel7.Location = new System.Drawing.Point(0, 682);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(7, 49);
            this.panel7.TabIndex = 18;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(198)))), ((int)(((byte)(108)))));
            this.panel8.Location = new System.Drawing.Point(1, 279);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(7, 49);
            this.panel8.TabIndex = 9;
            // 
            // btnrecibo
            // 
            this.btnrecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnrecibo.FlatAppearance.BorderSize = 0;
            this.btnrecibo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnrecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecibo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecibo.ForeColor = System.Drawing.Color.White;
            this.btnrecibo.Image = ((System.Drawing.Image)(resources.GetObject("btnrecibo.Image")));
            this.btnrecibo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrecibo.Location = new System.Drawing.Point(5, 278);
            this.btnrecibo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrecibo.Name = "btnrecibo";
            this.btnrecibo.Size = new System.Drawing.Size(289, 49);
            this.btnrecibo.TabIndex = 20;
            this.btnrecibo.Text = "RECIBO";
            this.btnrecibo.UseVisualStyleBackColor = false;
            this.btnrecibo.Click += new System.EventHandler(this.btnrecibo_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(198)))), ((int)(((byte)(108)))));
            this.panel6.Location = new System.Drawing.Point(0, 391);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(7, 49);
            this.panel6.TabIndex = 11;
            // 
            // btnpagos
            // 
            this.btnpagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnpagos.FlatAppearance.BorderSize = 0;
            this.btnpagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnpagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpagos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagos.ForeColor = System.Drawing.Color.White;
            this.btnpagos.Image = ((System.Drawing.Image)(resources.GetObject("btnpagos.Image")));
            this.btnpagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpagos.Location = new System.Drawing.Point(4, 391);
            this.btnpagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpagos.Name = "btnpagos";
            this.btnpagos.Size = new System.Drawing.Size(289, 49);
            this.btnpagos.TabIndex = 17;
            this.btnpagos.Text = "PAGOS";
            this.btnpagos.UseVisualStyleBackColor = false;
            this.btnpagos.Click += new System.EventHandler(this.btnpagos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(198)))), ((int)(((byte)(108)))));
            this.panel2.Location = new System.Drawing.Point(0, 505);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 49);
            this.panel2.TabIndex = 11;
            // 
            // SubmenuReportes
            // 
            this.SubmenuReportes.Controls.Add(this.panel11);
            this.SubmenuReportes.Controls.Add(this.panel10);
            this.SubmenuReportes.Controls.Add(this.btnrptpagos);
            this.SubmenuReportes.Controls.Add(this.btnrptpersonas);
            this.SubmenuReportes.Controls.Add(this.panel9);
            this.SubmenuReportes.Controls.Add(this.btnrptventa);
            this.SubmenuReportes.Location = new System.Drawing.Point(55, 555);
            this.SubmenuReportes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmenuReportes.Name = "SubmenuReportes";
            this.SubmenuReportes.Size = new System.Drawing.Size(239, 123);
            this.SubmenuReportes.TabIndex = 15;
            this.SubmenuReportes.Visible = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(198)))), ((int)(((byte)(108)))));
            this.panel11.Location = new System.Drawing.Point(0, 85);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(7, 34);
            this.panel11.TabIndex = 19;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(198)))), ((int)(((byte)(108)))));
            this.panel10.Location = new System.Drawing.Point(0, 46);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(7, 34);
            this.panel10.TabIndex = 19;
            // 
            // btnrptpagos
            // 
            this.btnrptpagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnrptpagos.FlatAppearance.BorderSize = 0;
            this.btnrptpagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnrptpagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrptpagos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrptpagos.ForeColor = System.Drawing.Color.White;
            this.btnrptpagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrptpagos.Location = new System.Drawing.Point(4, 85);
            this.btnrptpagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrptpagos.Name = "btnrptpagos";
            this.btnrptpagos.Size = new System.Drawing.Size(235, 34);
            this.btnrptpagos.TabIndex = 18;
            this.btnrptpagos.Text = "+";
            this.btnrptpagos.UseVisualStyleBackColor = false;
            this.btnrptpagos.Click += new System.EventHandler(this.btnrptpagos_Click);
            // 
            // btnrptpersonas
            // 
            this.btnrptpersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnrptpersonas.FlatAppearance.BorderSize = 0;
            this.btnrptpersonas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnrptpersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrptpersonas.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrptpersonas.ForeColor = System.Drawing.Color.White;
            this.btnrptpersonas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrptpersonas.Location = new System.Drawing.Point(4, 43);
            this.btnrptpersonas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrptpersonas.Name = "btnrptpersonas";
            this.btnrptpersonas.Size = new System.Drawing.Size(235, 34);
            this.btnrptpersonas.TabIndex = 18;
            this.btnrptpersonas.Text = "Reporte de Personas";
            this.btnrptpersonas.UseVisualStyleBackColor = false;
            this.btnrptpersonas.Click += new System.EventHandler(this.btnrptcompra_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(198)))), ((int)(((byte)(108)))));
            this.panel9.Location = new System.Drawing.Point(0, 6);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(7, 34);
            this.panel9.TabIndex = 17;
            // 
            // btnrptventa
            // 
            this.btnrptventa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnrptventa.FlatAppearance.BorderSize = 0;
            this.btnrptventa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnrptventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrptventa.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrptventa.ForeColor = System.Drawing.Color.White;
            this.btnrptventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrptventa.Location = new System.Drawing.Point(4, 6);
            this.btnrptventa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrptventa.Name = "btnrptventa";
            this.btnrptventa.Size = new System.Drawing.Size(235, 34);
            this.btnrptventa.TabIndex = 16;
            this.btnrptventa.Text = "Reporte de pagos";
            this.btnrptventa.UseVisualStyleBackColor = false;
            this.btnrptventa.Click += new System.EventHandler(this.btnrptventa_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(4, 505);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(289, 49);
            this.btnReportes.TabIndex = 13;
            this.btnReportes.Text = "REPORTE";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(198)))), ((int)(((byte)(108)))));
            this.panel5.Location = new System.Drawing.Point(0, 335);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(7, 49);
            this.panel5.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(198)))), ((int)(((byte)(108)))));
            this.panel4.Location = new System.Drawing.Point(0, 448);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 49);
            this.panel4.TabIndex = 8;
            // 
            // btnlectura
            // 
            this.btnlectura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnlectura.FlatAppearance.BorderSize = 0;
            this.btnlectura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnlectura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlectura.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlectura.ForeColor = System.Drawing.Color.White;
            this.btnlectura.Image = ((System.Drawing.Image)(resources.GetObject("btnlectura.Image")));
            this.btnlectura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlectura.Location = new System.Drawing.Point(4, 335);
            this.btnlectura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlectura.Name = "btnlectura";
            this.btnlectura.Size = new System.Drawing.Size(289, 49);
            this.btnlectura.TabIndex = 7;
            this.btnlectura.Text = "AGREGAR LEC.";
            this.btnlectura.UseVisualStyleBackColor = false;
            this.btnlectura.Click += new System.EventHandler(this.btnlectura_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(198)))), ((int)(((byte)(108)))));
            this.panel3.Location = new System.Drawing.Point(0, 222);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 49);
            this.panel3.TabIndex = 6;
            // 
            // btncontacto
            // 
            this.btncontacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btncontacto.FlatAppearance.BorderSize = 0;
            this.btncontacto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btncontacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncontacto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontacto.ForeColor = System.Drawing.Color.White;
            this.btncontacto.Image = ((System.Drawing.Image)(resources.GetObject("btncontacto.Image")));
            this.btncontacto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncontacto.Location = new System.Drawing.Point(4, 448);
            this.btncontacto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncontacto.Name = "btncontacto";
            this.btncontacto.Size = new System.Drawing.Size(289, 49);
            this.btncontacto.TabIndex = 5;
            this.btncontacto.Text = "CREAR RECIBO";
            this.btncontacto.UseVisualStyleBackColor = false;
            this.btncontacto.Click += new System.EventHandler(this.btncontacto_Click);
            // 
            // btnnotificacion
            // 
            this.btnnotificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnnotificacion.FlatAppearance.BorderSize = 0;
            this.btnnotificacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnnotificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnotificacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnotificacion.ForeColor = System.Drawing.Color.White;
            this.btnnotificacion.Image = ((System.Drawing.Image)(resources.GetObject("btnnotificacion.Image")));
            this.btnnotificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnotificacion.Location = new System.Drawing.Point(4, 222);
            this.btnnotificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnnotificacion.Name = "btnnotificacion";
            this.btnnotificacion.Size = new System.Drawing.Size(289, 49);
            this.btnnotificacion.TabIndex = 3;
            this.btnnotificacion.Text = "NOTIFICACION";
            this.btnnotificacion.UseVisualStyleBackColor = false;
            this.btnnotificacion.Click += new System.EventHandler(this.btnnotificacion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(198)))), ((int)(((byte)(108)))));
            this.panel1.Location = new System.Drawing.Point(0, 165);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 49);
            this.panel1.TabIndex = 2;
            // 
            // btnproductos
            // 
            this.btnproductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnproductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproductos.FlatAppearance.BorderSize = 0;
            this.btnproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproductos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductos.ForeColor = System.Drawing.Color.White;
            this.btnproductos.Image = ((System.Drawing.Image)(resources.GetObject("btnproductos.Image")));
            this.btnproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproductos.Location = new System.Drawing.Point(4, 165);
            this.btnproductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(289, 49);
            this.btnproductos.TabIndex = 1;
            this.btnproductos.Text = "CONSULTAS";
            this.btnproductos.UseVisualStyleBackColor = false;
            this.btnproductos.Click += new System.EventHandler(this.btnproductos_Click);
            // 
            // btninicio
            // 
            this.btninicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninicio.Image = ((System.Drawing.Image)(resources.GetObject("btninicio.Image")));
            this.btninicio.Location = new System.Drawing.Point(0, 0);
            this.btninicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(293, 158);
            this.btninicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btninicio.TabIndex = 0;
            this.btninicio.TabStop = false;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Location = new System.Drawing.Point(293, 47);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1500, 753);
            this.panelContenedor.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1733, 800);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.SubmenuReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btninicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.PictureBox btninicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnlectura;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btncontacto;
        private System.Windows.Forms.Button btnnotificacion;
        private System.Windows.Forms.Panel SubmenuReportes;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnrptpagos;
        private System.Windows.Forms.Button btnrptpersonas;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnrptventa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnhistorico;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnpagos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnrecibo;
        private System.Windows.Forms.Label label3;
    }
}

