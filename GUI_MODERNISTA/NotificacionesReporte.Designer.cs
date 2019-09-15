namespace GUI_MODERNISTA
{
    partial class NotificacionesReporte
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
            this.btnNotificacion = new System.Windows.Forms.Button();
            this.txtid_persona = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TiabayaDataSet = new GUI_MODERNISTA.TiabayaDataSet();
            this.DeudaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeudaTableAdapter = new GUI_MODERNISTA.TiabayaDataSetTableAdapters.DeudaTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.TiabayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeudaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNotificacion
            // 
            this.btnNotificacion.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNotificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificacion.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNotificacion.Location = new System.Drawing.Point(767, 50);
            this.btnNotificacion.Name = "btnNotificacion";
            this.btnNotificacion.Size = new System.Drawing.Size(224, 54);
            this.btnNotificacion.TabIndex = 6;
            this.btnNotificacion.Text = "NOTIFICACION";
            this.btnNotificacion.UseVisualStyleBackColor = false;
            this.btnNotificacion.Click += new System.EventHandler(this.btnNotificacion_Click);
            // 
            // txtid_persona
            // 
            this.txtid_persona.Location = new System.Drawing.Point(276, 68);
            this.txtid_persona.Name = "txtid_persona";
            this.txtid_persona.Size = new System.Drawing.Size(112, 22);
            this.txtid_persona.TabIndex = 5;
            this.txtid_persona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_persona_KeyPress);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DeudaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_MODERNISTA.ReportNotificacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(264, 191);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(893, 486);
            this.reportViewer1.TabIndex = 7;
            // 
            // TiabayaDataSet
            // 
            this.TiabayaDataSet.DataSetName = "TiabayaDataSet";
            this.TiabayaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DeudaBindingSource
            // 
            this.DeudaBindingSource.DataMember = "Deuda";
            this.DeudaBindingSource.DataSource = this.TiabayaDataSet;
            // 
            // DeudaTableAdapter
            // 
            this.DeudaTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(95, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "CODIGO POBLADOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(614, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "NOTIFICACIÓN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNotificacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtid_persona);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(166, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1093, 657);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GENERE UNA NOTIFICACION";
            // 
            // NotificacionesReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1440, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificacionesReporte";
            this.Text = "NotificacionesReporte";
            this.Load += new System.EventHandler(this.NotificacionesReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TiabayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeudaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNotificacion;
        private System.Windows.Forms.TextBox txtid_persona;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DeudaBindingSource;
        private TiabayaDataSet TiabayaDataSet;
        private TiabayaDataSetTableAdapters.DeudaTableAdapter DeudaTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}