﻿namespace GUI_MODERNISTA
{
    partial class ReporteRecibo
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
            this.btnNotificacion = new System.Windows.Forms.Button();
            this.txtid_persona = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbloquefin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbloque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNotificacion
            // 
            this.btnNotificacion.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNotificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificacion.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNotificacion.Location = new System.Drawing.Point(693, 21);
            this.btnNotificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNotificacion.Name = "btnNotificacion";
            this.btnNotificacion.Size = new System.Drawing.Size(249, 39);
            this.btnNotificacion.TabIndex = 9;
            this.btnNotificacion.Text = "GENERAR RECIBOS";
            this.btnNotificacion.UseVisualStyleBackColor = false;
            this.btnNotificacion.Click += new System.EventHandler(this.btnNotificacion_Click);
            // 
            // txtid_persona
            // 
            this.txtid_persona.Enabled = false;
            this.txtid_persona.Location = new System.Drawing.Point(1148, 22);
            this.txtid_persona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid_persona.Name = "txtid_persona";
            this.txtid_persona.Size = new System.Drawing.Size(79, 22);
            this.txtid_persona.TabIndex = 8;
            this.txtid_persona.Visible = false;
            this.txtid_persona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_persona_KeyPress);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_MODERNISTA.ReportRecibo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(43, 124);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(901, 521);
            this.reportViewer1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(571, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 31);
            this.label8.TabIndex = 56;
            this.label8.Text = "GENERAR RECIBO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(956, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "CODIGO DE POBLADOR";
            this.label1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbloquefin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbloque);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnNotificacion);
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(216, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(983, 677);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GENERE SU RECIBO";
            // 
            // txtbloquefin
            // 
            this.txtbloquefin.Location = new System.Drawing.Point(543, 32);
            this.txtbloquefin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbloquefin.Name = "txtbloquefin";
            this.txtbloquefin.Size = new System.Drawing.Size(79, 22);
            this.txtbloquefin.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(357, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "FIN DEL BLOQUE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 78);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 22);
            this.textBox1.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "MES / AÑO";
            // 
            // txtbloque
            // 
            this.txtbloque.Location = new System.Drawing.Point(231, 32);
            this.txtbloque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbloque.Name = "txtbloque";
            this.txtbloque.Size = new System.Drawing.Size(79, 22);
            this.txtbloque.TabIndex = 59;
            this.txtbloque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbloque_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "INICIO DE BLOQUE";
            // 
            // ReporteRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1440, 753);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid_persona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReporteRecibo";
            this.Text = "ReporteRecibo";
            this.Load += new System.EventHandler(this.ReporteRecibo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNotificacion;
        private System.Windows.Forms.TextBox txtid_persona;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbloque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbloquefin;
        private System.Windows.Forms.Label label4;
    }
}