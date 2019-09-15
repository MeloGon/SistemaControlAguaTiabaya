using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace GUI_MODERNISTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(500);
            InitializeComponent();
            t.Abort();
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.WindowState = FormWindowState.Maximized;

        }

        //Para comenzar con el Splash
        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btninicio_Click(null ,e);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
        }

        private void btnrptventa_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new RegistroPagos());
            SubmenuReportes.Visible = false;
        }

        private void btnrptcompra_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormHija(new PersonasImpresion());
        }

        private void btnrptpagos_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
           
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Consulta());
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new inicio());
        }

        private void btncontacto_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Contacto());
        }

        private void btnnotificacion_Click(object sender, EventArgs e)
        {
            //AbrirFormHija(new NotificacionesReporte());
            AbrirFormHija(new Notificacion());
        }
        
        private void btnhistorico_Click(object sender, EventArgs e)
        {
            //\\Desktop-bb68mi8\documentos de agua todos los pueblos\SISTEMA CONTROL\Tiabaya.mdb
            Process.Start(@"\\Desktop-bb68mi8\documentos de agua todos los pueblos\SISTEMA CONTROL\historico1.xlsx");
            Process.Start(@"\\Desktop-bb68mi8\documentos de agua todos los pueblos\SISTEMA CONTROL\historico2.xlsx");
            Process.Start(@"\\Desktop-bb68mi8\documentos de agua todos los pueblos\SISTEMA CONTROL\historico3.xlsx");
            Process.Start(@"\\Desktop-bb68mi8\documentos de agua todos los pueblos\SISTEMA CONTROL\historico4.xlsx");

            //Process.Start(@"\\PC\Users\user\Documents\CarpetaCompartidaxd\RECIBO DE AGUA Jóvenes de  San José, Juan Pablo II, Patasagua Alto, Alto San José,  Alto Tunales, Alto Santa Rita  abril 2019.xlsx");

        }

        private void btnlectura_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Lectura());
        }

        private void btnpagos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Pagos());
        }
        private void backup()
        {
            string dbFileName = "Tiabaya.mdb";
            string CurrentDatabasePath = Path.Combine(Environment.CurrentDirectory, dbFileName);
            string backTimeStamp = Path.GetFileNameWithoutExtension(dbFileName) + "_" + DateTime.Now.ToString("MM-dd-yyyy-HH-mm-ss") + Path.GetExtension(dbFileName);
            string destFileName = backTimeStamp;
            destFileName = Path.Combine(@"\\Desktop-bb68mi8\documentos de agua todos los pueblos\SISTEMA CONTROL\Respaldo\", destFileName);
            if (File.Exists(destFileName))
            {
                File.Delete(destFileName);
            }
            else
            {
                File.Copy(CurrentDatabasePath, destFileName, true);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            String fechahora = "22/07/2019 10:00:00";
            String fechahora1 = "19/08/2019 10:00:00";
            String fechahora2 = "23/09/2019 10:00:00";
            String fechahora3 = "21/10/2019 10:00:00";
            String fechahora4 = "18/11/2019 10:00:00";
            String fechahora5 = "16/12/2019 10:00:00";

            //DateTime fecha = Convert.ToDateTime(dateTimePicker1.Text, new CultureInfo("es-ES"));
            label1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            if (label1.Text == fechahora || label1.Text == fechahora1 || label1.Text == fechahora2 || label1.Text == fechahora3 || label1.Text == fechahora4 || label1.Text == fechahora5)
            {
                backup();
            }
        }

        private void btnrecibo_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ReporteRecibo());
        }
    }
}
