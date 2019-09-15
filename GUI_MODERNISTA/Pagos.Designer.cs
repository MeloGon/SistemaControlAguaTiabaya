namespace GUI_MODERNISTA
{
    partial class Pagos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagos));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnpagar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcodigopoblador = new System.Windows.Forms.TextBox();
            this.lblcosto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpagos = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtobservacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbliddeuda = new System.Windows.Forms.Label();
            this.lbldeudatotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblcambio = new System.Windows.Forms.Label();
            this.lblpagocon = new System.Windows.Forms.Label();
            this.lbltickettotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnrefrescar = new System.Windows.Forms.Button();
            this.btnpagodemonto = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.txtfechaantigua = new System.Windows.Forms.TextBox();
            this.txtnummeses = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(141, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "DEUDAS NO PAGADAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "CODIGO DE POBLADOR";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(109, 128);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(230, 67);
            this.btnbuscar.TabIndex = 46;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(106, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "COSTO";
            // 
            // btnpagar
            // 
            this.btnpagar.BackColor = System.Drawing.Color.Red;
            this.btnpagar.FlatAppearance.BorderSize = 0;
            this.btnpagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnpagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpagar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagar.ForeColor = System.Drawing.Color.White;
            this.btnpagar.Location = new System.Drawing.Point(868, 469);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(158, 65);
            this.btnpagar.TabIndex = 54;
            this.btnpagar.Text = "GENERAR TICKET Y PAGAR";
            this.btnpagar.UseVisualStyleBackColor = false;
            this.btnpagar.Click += new System.EventHandler(this.btnpagar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(434, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 25);
            this.label8.TabIndex = 55;
            this.label8.Text = "PAGAR DEUDA";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 20);
            this.dateTimePicker1.TabIndex = 58;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(109, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 79);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESAR FECHA";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(109, 348);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(206, 21);
            this.checkBox1.TabIndex = 60;
            this.checkBox1.Text = "MARCAR SI REALIZA PAGO";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(50, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(502, 301);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(417, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 359);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SELECCIONE";
            // 
            // txtcodigopoblador
            // 
            this.txtcodigopoblador.Location = new System.Drawing.Point(241, 88);
            this.txtcodigopoblador.Name = "txtcodigopoblador";
            this.txtcodigopoblador.Size = new System.Drawing.Size(98, 20);
            this.txtcodigopoblador.TabIndex = 61;
            this.txtcodigopoblador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigopoblador_KeyPress);
            // 
            // lblcosto
            // 
            this.lblcosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcosto.ForeColor = System.Drawing.Color.White;
            this.lblcosto.Location = new System.Drawing.Point(258, 319);
            this.lblcosto.Name = "lblcosto";
            this.lblcosto.Size = new System.Drawing.Size(81, 24);
            this.lblcosto.TabIndex = 63;
            this.lblcosto.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(106, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "CUANTO RECIBIO EN s/.";
            // 
            // txtpagos
            // 
            this.txtpagos.Location = new System.Drawing.Point(269, 385);
            this.txtpagos.Name = "txtpagos";
            this.txtpagos.Size = new System.Drawing.Size(75, 20);
            this.txtpagos.TabIndex = 65;
            this.txtpagos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpagos_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtobservacion);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(417, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 156);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OBSERVACIONES";
            // 
            // txtobservacion
            // 
            this.txtobservacion.Location = new System.Drawing.Point(15, 19);
            this.txtobservacion.Multiline = true;
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtobservacion.Size = new System.Drawing.Size(193, 121);
            this.txtobservacion.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(674, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "SUMA TOTAL DE DEUDAS";
            // 
            // lbliddeuda
            // 
            this.lbliddeuda.AutoSize = true;
            this.lbliddeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbliddeuda.ForeColor = System.Drawing.Color.White;
            this.lbliddeuda.Location = new System.Drawing.Point(941, 15);
            this.lbliddeuda.Name = "lbliddeuda";
            this.lbliddeuda.Size = new System.Drawing.Size(0, 17);
            this.lbliddeuda.TabIndex = 67;
            // 
            // lbldeudatotal
            // 
            this.lbldeudatotal.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeudatotal.ForeColor = System.Drawing.Color.Red;
            this.lbldeudatotal.Location = new System.Drawing.Point(694, 469);
            this.lbldeudatotal.Name = "lbldeudatotal";
            this.lbldeudatotal.Size = new System.Drawing.Size(158, 44);
            this.lbldeudatotal.TabIndex = 68;
            this.lbldeudatotal.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(658, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 36);
            this.label9.TabIndex = 69;
            this.label9.Text = "S/";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.lblcambio);
            this.groupBox4.Controls.Add(this.lblpagocon);
            this.groupBox4.Controls.Add(this.lbltickettotal);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(109, 432);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 156);
            this.groupBox4.TabIndex = 67;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TICKET";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkOrange;
            this.label14.Location = new System.Drawing.Point(146, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 18);
            this.label14.TabIndex = 78;
            this.label14.Text = "s/.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkOrange;
            this.label15.Location = new System.Drawing.Point(146, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 18);
            this.label15.TabIndex = 77;
            this.label15.Text = "s/.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkOrange;
            this.label16.Location = new System.Drawing.Point(146, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 18);
            this.label16.TabIndex = 76;
            this.label16.Text = "s/.";
            // 
            // lblcambio
            // 
            this.lblcambio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcambio.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblcambio.Location = new System.Drawing.Point(172, 85);
            this.lblcambio.Name = "lblcambio";
            this.lblcambio.Size = new System.Drawing.Size(59, 23);
            this.lblcambio.TabIndex = 75;
            this.lblcambio.Text = "00.00";
            // 
            // lblpagocon
            // 
            this.lblpagocon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpagocon.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblpagocon.Location = new System.Drawing.Point(172, 53);
            this.lblpagocon.Name = "lblpagocon";
            this.lblpagocon.Size = new System.Drawing.Size(59, 23);
            this.lblpagocon.TabIndex = 74;
            this.lblpagocon.Text = "00.00";
            // 
            // lbltickettotal
            // 
            this.lbltickettotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltickettotal.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbltickettotal.Location = new System.Drawing.Point(172, 19);
            this.lbltickettotal.Name = "lbltickettotal";
            this.lbltickettotal.Size = new System.Drawing.Size(59, 23);
            this.lbltickettotal.TabIndex = 73;
            this.lbltickettotal.Text = "00.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 72;
            this.label10.Text = "SU CAMBIO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 71;
            this.label7.Text = "PAGO CON";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "TOTAL DE DEUDA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(978, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 88;
            this.label11.Text = "REFRESCAR";
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.BackColor = System.Drawing.Color.Transparent;
            this.btnrefrescar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrefrescar.BackgroundImage")));
            this.btnrefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrefrescar.FlatAppearance.BorderSize = 0;
            this.btnrefrescar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnrefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefrescar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefrescar.ForeColor = System.Drawing.Color.White;
            this.btnrefrescar.Location = new System.Drawing.Point(1000, 25);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(24, 24);
            this.btnrefrescar.TabIndex = 87;
            this.btnrefrescar.UseVisualStyleBackColor = false;
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click);
            // 
            // btnpagodemonto
            // 
            this.btnpagodemonto.BackColor = System.Drawing.Color.Red;
            this.btnpagodemonto.FlatAppearance.BorderSize = 0;
            this.btnpagodemonto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnpagodemonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpagodemonto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagodemonto.ForeColor = System.Drawing.Color.White;
            this.btnpagodemonto.Location = new System.Drawing.Point(868, 550);
            this.btnpagodemonto.Name = "btnpagodemonto";
            this.btnpagodemonto.Size = new System.Drawing.Size(158, 51);
            this.btnpagodemonto.TabIndex = 89;
            this.btnpagodemonto.Text = "PAGAR DEUDA ANTERIOR";
            this.toolTip1.SetToolTip(this.btnpagodemonto, "EL poblador tiene una deuda antes de que el sistema sea construido. Este boton si" +
        "rve para saldarla");
            this.btnpagodemonto.UseVisualStyleBackColor = false;
            this.btnpagodemonto.Click += new System.EventHandler(this.btnpagodemonto_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(661, 550);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 90;
            this.label12.Text = "FECHA";
            this.label12.Visible = false;
            // 
            // txtfechaantigua
            // 
            this.txtfechaantigua.Location = new System.Drawing.Point(730, 550);
            this.txtfechaantigua.Margin = new System.Windows.Forms.Padding(2);
            this.txtfechaantigua.Name = "txtfechaantigua";
            this.txtfechaantigua.Size = new System.Drawing.Size(122, 20);
            this.txtfechaantigua.TabIndex = 91;
            this.txtfechaantigua.Visible = false;
            // 
            // txtnummeses
            // 
            this.txtnummeses.Location = new System.Drawing.Point(730, 570);
            this.txtnummeses.Margin = new System.Windows.Forms.Padding(2);
            this.txtnummeses.Name = "txtnummeses";
            this.txtnummeses.Size = new System.Drawing.Size(122, 20);
            this.txtnummeses.TabIndex = 93;
            this.txtnummeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnummeses_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(661, 570);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 17);
            this.label13.TabIndex = 92;
            this.label13.Text = "MESES";
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.txtnummeses);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtfechaantigua);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnpagodemonto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnrefrescar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbldeudatotal);
            this.Controls.Add(this.lbliddeuda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtpagos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblcosto);
            this.Controls.Add(this.txtcodigopoblador);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagos";
            this.Text = "Pagos";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnpagar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcodigopoblador;
        private System.Windows.Forms.Label lblcosto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpagos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtobservacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbliddeuda;
        private System.Windows.Forms.Label lbldeudatotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblcambio;
        private System.Windows.Forms.Label lblpagocon;
        private System.Windows.Forms.Label lbltickettotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnrefrescar;
        private System.Windows.Forms.Button btnpagodemonto;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtfechaantigua;
        private System.Windows.Forms.TextBox txtnummeses;
        private System.Windows.Forms.Label label13;
    }
}