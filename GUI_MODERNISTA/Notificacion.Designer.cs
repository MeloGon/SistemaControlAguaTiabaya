namespace GUI_MODERNISTA
{
    partial class Notificacion
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbloque = new System.Windows.Forms.TextBox();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNotificacion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbloquefin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(466, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "NOTIFICACIÓN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtbloque);
            this.groupBox1.Controls.Add(this.reportViewer2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnNotificacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbloquefin);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(44, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1001, 537);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GENERE UNA NOTIFICACION";
            // 
            // txtbloque
            // 
            this.txtbloque.Location = new System.Drawing.Point(164, 27);
            this.txtbloque.Margin = new System.Windows.Forms.Padding(2);
            this.txtbloque.Name = "txtbloque";
            this.txtbloque.Size = new System.Drawing.Size(56, 20);
            this.txtbloque.TabIndex = 16;
            // 
            // reportViewer2
            // 
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "GUI_MODERNISTA.Notificacion2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(518, 89);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(461, 348);
            this.reportViewer2.TabIndex = 14;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 89);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(461, 348);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "TEXTO :";
            // 
            // btnNotificacion
            // 
            this.btnNotificacion.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNotificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificacion.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNotificacion.Location = new System.Drawing.Point(709, 27);
            this.btnNotificacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnNotificacion.Name = "btnNotificacion";
            this.btnNotificacion.Size = new System.Drawing.Size(270, 44);
            this.btnNotificacion.TabIndex = 6;
            this.btnNotificacion.Text = "GENERAR NOTIFICACION";
            this.btnNotificacion.UseVisualStyleBackColor = false;
            this.btnNotificacion.Click += new System.EventHandler(this.btnNotificacion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "INICIO BLOQUE";
            // 
            // txtbloquefin
            // 
            this.txtbloquefin.Location = new System.Drawing.Point(472, 27);
            this.txtbloquefin.Margin = new System.Windows.Forms.Padding(2);
            this.txtbloquefin.Name = "txtbloquefin";
            this.txtbloquefin.Size = new System.Drawing.Size(56, 20);
            this.txtbloquefin.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(353, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "FIN BLOQUE";
            // 
            // Notificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notificacion";
            this.Text = "Notificacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNotificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbloquefin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.TextBox txtbloque;
        private System.Windows.Forms.Label label4;
    }
}