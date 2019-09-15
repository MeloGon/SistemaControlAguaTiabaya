namespace GUI_MODERNISTA
{
    partial class PersonasImpresion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TiabayaDataSet = new GUI_MODERNISTA.TiabayaDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtzona = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PersonaTableAdapter = new GUI_MODERNISTA.TiabayaDataSetTableAdapters.PersonaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiabayaDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonaBindingSource
            // 
            this.PersonaBindingSource.DataMember = "Persona";
            this.PersonaBindingSource.DataSource = this.TiabayaDataSet;
            // 
            // TiabayaDataSet
            // 
            this.TiabayaDataSet.DataSetName = "TiabayaDataSet";
            this.TiabayaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(393, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(289, 25);
            this.label8.TabIndex = 81;
            this.label8.Text = "REPORTE DE PERSONAS";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReporte.Location = new System.Drawing.Point(512, 18);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(214, 59);
            this.btnReporte.TabIndex = 78;
            this.btnReporte.Text = "REPORTE";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtzona);
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnReporte);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(153, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(761, 483);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESAR ZONA DE LAS PERSONAS";
            // 
            // txtzona
            // 
            this.txtzona.AutoSize = true;
            this.txtzona.Location = new System.Drawing.Point(338, 40);
            this.txtzona.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtzona.Name = "txtzona";
            this.txtzona.Size = new System.Drawing.Size(10, 13);
            this.txtzona.TabIndex = 80;
            this.txtzona.Text = ".";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PersonaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_MODERNISTA.ImpresionPersonas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(26, 97);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(700, 368);
            this.reportViewer1.TabIndex = 79;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AAHH PATASAGUA ALTO",
            "PUEBLO J. PATASAGUA",
            "PUEBLO J. JUAN PABLO II",
            "PUEBLO J. ALTO SAN JOSE",
            "PUEBLO J. ALTO SANTA RITA",
            "PUEBLO T. LOS TUNALES",
            "PUEBLO JOVEN SAN JOSE",
            "TIABAYA AV. VA BELANUNDE",
            "CALLE LOS PERALES",
            "VILLA ESPERANZA",
            "AA.HH.VIRGEN DE LAS PEÑAS",
            "PEÑA GRANDE",
            "PAMPAS NUEVAS",
            "ASOC. NUEVA TIABAYA HUAYRONDO",
            "VIRGEN DE LAS PEÑAS AMPLIACION",
            "FUNDO LAS SALAS"});
            this.comboBox1.Location = new System.Drawing.Point(86, 40);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(177, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "ZONA : ";
            // 
            // PersonaTableAdapter
            // 
            this.PersonaTableAdapter.ClearBeforeFill = true;
            // 
            // PersonasImpresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1066, 574);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PersonasImpresion";
            this.Text = "PersonasImpresion";
            this.Load += new System.EventHandler(this.PersonasImpresion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiabayaDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource PersonaBindingSource;
        private TiabayaDataSet TiabayaDataSet;
        private TiabayaDataSetTableAdapters.PersonaTableAdapter PersonaTableAdapter;
        private System.Windows.Forms.Label txtzona;
    }
}