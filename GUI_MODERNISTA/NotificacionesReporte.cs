using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    public partial class NotificacionesReporte : Form
    {
        OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\GORO-LAP\Users\RODRIGO\Desktop\Compartir\Tiabaya.mdb;Persist Security info = False;");
        //OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\PC\Users\user\Documents\CarpetaCompartidaxd\Tiabaya.mdb;Persist Security info = False;");
        public NotificacionesReporte()
        {
            InitializeComponent();
        }

        private void NotificacionesReporte_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNotificacion_Click(object sender, EventArgs e)
        {
            if(txtid_persona.Text == "")
            {
                MessageBox.Show("No se puede generar la notificacion. Ingrese un codigo de poblador", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string nombre = "";
                string direccion = "";
                string comite = "";
                string manzana = "";
                string lote = "";
                string fecha_deuda = "";
                string fecha_corte = "";
                string fecha_actual = "";
                cone.Open();
                OleDbCommand command = cone.CreateCommand();
                command.CommandType = CommandType.Text;
                //command.CommandText = "SELECT nombres_persona FROM Persona WHERE id_persona = " + txtid_persona.Text;
                command.CommandText = "SELECT Persona.nombres_persona,Zona.nombre_zona,Persona.comite_zona,Persona.manzana_zona,Persona.lote_zona FROM Persona INNER JOIN Zona ON Persona.id_zona = Zona.id_zona WHERE id_persona = " + txtid_persona.Text;
                OleDbDataReader leer = command.ExecuteReader();
                if (leer.Read() == true)
                {
                    nombre = leer["nombres_persona"].ToString();
                    direccion = leer["nombre_zona"].ToString();
                    comite = leer["comite_zona"].ToString();
                    manzana = leer["manzana_zona"].ToString();
                    lote = leer["lote_zona"].ToString();
                }
                else
                {
                    MessageBox.Show("Error");
                }

                fecha_actual = DateTime.Now.ToString("dd/MM/yyyy");
                DateTime fecha = Convert.ToDateTime(fecha_actual, new CultureInfo("es-ES"));
                fecha = fecha.AddDays(2);
                fecha_corte = fecha.ToString("dd/MM/yyyy");
                ///////////////////////////////////////////////////////////////////////////////
                OleDbCommand command2 = cone.CreateCommand();
                command2.CommandType = CommandType.Text;
                command2.CommandText = "SELECT min(fecha_deuda) as FechaAntigua FROM Deuda WHERE id_persona = " + txtid_persona.Text + " AND pago=false";
                OleDbDataReader leer2 = command2.ExecuteReader();
                if (leer2.Read() == true)
                {
                    fecha_deuda = leer2["FechaAntigua"].ToString();
                    // DateTime fecha2 = Convert.ToDateTime(fecha_deuda, new CultureInfo("es-ES"));
                    //fecha_deuda = fecha2.ToString("dd/MM/yyyy");
                }
                else
                {
                    MessageBox.Show("Error");
                }

                if (fecha_deuda == "")
                {
                    MessageBox.Show("No existe Deuda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //DateTime fecha2 = Convert.ToDateTime(fecha_deuda, new CultureInfo("es-ES"));
                    DateTime fecha2 = Convert.ToDateTime(fecha_deuda);
                    fecha_deuda = fecha2.ToString("dd/MM/yyyy");
                }

                ReportParameter[] parametros = new ReportParameter[8];
                parametros[0] = new ReportParameter("ReportParameter1", nombre);
                parametros[1] = new ReportParameter("dire", direccion);
                parametros[2] = new ReportParameter("comite", comite);
                parametros[3] = new ReportParameter("manzana", manzana);
                parametros[4] = new ReportParameter("lote", lote);
                parametros[5] = new ReportParameter("fecha_corte", fecha_corte);
                parametros[6] = new ReportParameter("fecha_actual", fecha_actual);
                parametros[7] = new ReportParameter("fecha_deuda", fecha_deuda);
                reportViewer1.LocalReport.SetParameters(parametros);
                this.reportViewer1.RefreshReport();
                cone.Close();
            }
            
        }

        private void txtid_persona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
