using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    public partial class Notificacion : Form
    {
        int cont1 = 1;
        int cont = 0;
        OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\Desktop-bb68mi8\documentos de agua todos los pueblos\SISTEMA CONTROL\Tiabaya.mdb;Persist Security info = False;");
        //OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\PC\Users\user\Documents\CarpetaCompartidaxd\Tiabaya.mdb;Persist Security info = False;");
        //OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\KEVYN\Documents\PRUEBATIABAYA\Tiabaya.mdb;Persist Security info = False;");
        // OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\Desktop-bb68mi8\documentos de agua todos los pueblos\SISTEMA CONTROL\Tiabaya.mdb;Persist Security info = False;");
        public Notificacion()
        {
            InitializeComponent();
        }

        private void btnNotificacion_Click(object sender, EventArgs e)
        {
            if (txtbloque.Text == "" || txtbloquefin.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Necesita ingresar un bloque de codigos tanto de inicio como final, o ingresar algun texto dentro de la notificacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cont1 = Convert.ToInt32(txtbloquefin.Text);
                cont = Convert.ToInt32(txtbloque.Text);
                for (int i = cont; i <= cont1; i++)
                {
                    string nombre = "";
                    string direccion = "";
                    string comite = "";
                    string manzana = "";
                    string lote = "";
                    string fecha_deuda = "";
                    string fecha_corte = "";
                    string fecha_actual = "";
                    string texto = "";
                    cone.Open();
                    OleDbCommand command = cone.CreateCommand();
                    command.CommandType = CommandType.Text;
                    //command.CommandText = "SELECT nombres_persona FROM Persona WHERE id_persona = " + txtid_persona.Text;
                    command.CommandText = "SELECT Persona.nombres_persona,Zona.nombre_zona,Persona.comite_zona,Persona.manzana_zona,Persona.lote_zona FROM Persona INNER JOIN Zona ON Persona.id_zona = Zona.id_zona WHERE id_persona = " + i;
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
                        Console.Write("error");
                        //MessageBox.Show("Error");
                    }

                    fecha_actual = DateTime.Now.ToString("dd/MM/yyyy");
                    DateTime fecha = Convert.ToDateTime(fecha_actual);
                    fecha = fecha.AddDays(2);
                    fecha_corte = fecha.ToString("dd/MM/yyyy");
                    /////////////////////////////////Se agrego esto//////////////////////////////////////////////
                    string fecha_antigua = "";
                    string aux_fecha = "";
                    string aux_fecha2 = "";
                    OleDbCommand command6 = cone.CreateCommand();
                    command6.CommandType = CommandType.Text;
                    command6.CommandText = "SELECT TOP 1 fecha_deuda,pago,fecha_antigua FROM Deuda WHERE id_persona = " + i;
                    OleDbDataReader leer6 = command6.ExecuteReader();
                    if (leer6.Read() == true)
                    {
                        fecha_antigua = leer6["fecha_antigua"].ToString();
                        aux_fecha = leer6["pago"].ToString();
                        aux_fecha2 = leer6["fecha_deuda"].ToString();
                    }
                    else
                    {
                        Console.Write("error");
                        //MessageBox.Show("Error 6");
                    }
                    if (fecha_antigua != "0")
                    {
                        if (fecha_antigua == "")
                        {
                            //MessageBox.Show("Esta era lo de la fecha antigua");
                            Console.Write("error");
                        }
                        else
                        {
                            DateTime fecha_antigua2 = Convert.ToDateTime(fecha_antigua);
                            fecha_antigua = fecha_antigua2.ToString("dd/MM/yyyy");
                        }

                    }
                    else
                    {
                        //////Esta parte agregamos///////
                        //MessageBox.Show("No existe deuda anterior al mes de Junio");
                        OleDbCommand command7 = cone.CreateCommand();
                        command7.CommandType = CommandType.Text;
                        command7.CommandText = "SELECT TOP 1 fecha_deuda FROM Deuda WHERE id_persona = " + i + " AND pago = false ORDER BY fecha_deuda";
                        OleDbDataReader leer7 = command7.ExecuteReader();
                        if (leer7.Read() == true)
                        {
                            fecha_antigua = leer7["fecha_deuda"].ToString();
                            DateTime fecha_antigua3 = Convert.ToDateTime(fecha_antigua);
                            fecha_antigua = fecha_antigua3.ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            //MessageBox.Show("No posee deudas pendientes");
                            Console.Write("error");
                        }

                    }
                    ///////////////////////////////////////////////////////////////////////////////
                    /*OleDbCommand command2 = cone.CreateCommand();
                    command2.CommandType = CommandType.Text;
                    command2.CommandText = "SELECT min(fecha_deuda) as FechaAntigua FROM Deuda WHERE id_persona = " + i + " AND pago=false";
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
                    }*/
                    texto = textBox1.Text.ToString();

                    ReportParameter[] parametros = new ReportParameter[9];
                    if (nombre != "" && direccion != "" && comite != "" && manzana != "" && lote != "" && fecha_corte != "" && fecha_actual != "" && fecha_antigua != ""
                         && texto != "")
                    {
                        parametros[0] = new ReportParameter("ReportParameter1", nombre);
                        parametros[1] = new ReportParameter("dire", direccion);
                        parametros[2] = new ReportParameter("comite", comite);
                        parametros[3] = new ReportParameter("manzana", manzana);
                        parametros[4] = new ReportParameter("lote", lote);
                        parametros[5] = new ReportParameter("fecha_corte", fecha_corte);
                        parametros[6] = new ReportParameter("fecha_actual", fecha_actual);
                        parametros[7] = new ReportParameter("fecha_deuda", fecha_antigua);
                        parametros[8] = new ReportParameter("texto", texto);
                        reportViewer2.LocalReport.SetParameters(parametros);
                        //reportViewer1.LocalReport.SetParameters(parametros);
                        cone.Close();
                        this.reportViewer2.RefreshReport();
                        //File.WriteAllBytes(@"C:\Users\user\Desktop\notificacion" + i + ".pdf", reportViewer2.LocalReport.Render("PDF"));
                        //OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\Desktop-bb68mi8\documentos de agua todos los pueblos\SISTEMA CONTROL\Tiabaya.mdb;Persist Security info = False;");
                        File.WriteAllBytes(@"\\Desktop-bb68mi8\documentos de agua todos los pueblos\SISTEMA CONTROL\Notificaciones\notificacion" + i + ".pdf", reportViewer2.LocalReport.Render("PDF"));
                    }
                    else
                    {
                        //MessageBox.Show("la huevada mas grande");
                        Console.Write("error");
                    }

                }
                MessageBox.Show("Notificaciones Generadas y guardados exitosamente !");

            }
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
