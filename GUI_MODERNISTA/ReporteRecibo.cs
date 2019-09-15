using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    public partial class ReporteRecibo : Form
    {
        int cont = 0;
        int cont1 = 0;
        //OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\KEVYN\Documents\PRUEBATIABAYA\Tiabaya.mdb;Persist Security info = False;");
        //OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\GORO-LAP\Users\RODRIGO\Desktop\Compartir\Tiabaya.mdb;Persist Security info = False;");
        OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\Desktop-bb68mi8\documentos de agua todos los pueblos\SISTEMA CONTROL\Tiabaya.mdb;Persist Security info = False;");
        //OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\PC\Users\user\Documents\CarpetaCompartidaxd\Tiabaya.mdb;Persist Security info = False;");
        public ReporteRecibo()
        {
            InitializeComponent();
        }

        private void ReporteRecibo_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void btnNotificacion_Click(object sender, EventArgs e)
        {
            if (txtbloque.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("No se puede generar el recibo. Ingrese un codigo de poblador y un MES/AÑO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cont = Convert.ToInt32(txtbloque.Text);
                cont1 = Convert.ToInt32(txtbloquefin.Text);
                for (int i = cont; i <= cont1; i++)
                {
                    string mes = "";
                    string persona = "";
                    string nombre_zona = "";
                    string comite = "";
                    string manzana = "";
                    string lote = "";
                    string num_medidor = "";
                    string total_consumo = ""; //Ultimo valor del costo de la ultima fecha
                    string deuda = ""; //Sumatoria de deudas el total de deuda - total_consumo
                    string total_deuda = "";  //Suma entre total_consumo y deuda
                    string consumo_anterior = ""; //lectura de el mes anterior
                    string consumo_actual = "";  //lectura del mes actual
                    string consumo_mensual = "";  //restar actual con anterior
                    string fecha_anterior = ""; //fecha del mes anterior
                    string fecha_actual = ""; //fecha del mes actual
                    string fecha_final = ""; //fecha final del mes
                    double consumo = 0;
                    double deuda_total = 0;
                    double deuda_parcial = 0;
                    double lectura_antr = 0;
                    double lectura_act = 0;
                    double consumo_men = 0;
                    double totaldeladeuda = 0;
                    double totaldeladeuda1 = 0;
                    string fecha_antigua = "";
                    cone.Open();
                    OleDbCommand command = cone.CreateCommand();
                    command.CommandType = CommandType.Text;
                    /////////////////////////////////////////////////////////////////////////////
                    command.CommandText = "SELECT Persona.nombres_persona,Zona.nombre_zona,Persona.comite_zona,Persona.manzana_zona,Persona.lote_zona,Persona.num_medidor FROM Persona INNER JOIN Zona ON Persona.id_zona = Zona.id_zona WHERE id_persona = " + i;
                    OleDbDataReader leer = command.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        persona = leer["nombres_persona"].ToString();
                        nombre_zona = leer["nombre_zona"].ToString();
                        comite = leer["comite_zona"].ToString();
                        manzana = leer["manzana_zona"].ToString();
                        lote = leer["lote_zona"].ToString();
                        num_medidor = leer["num_medidor"].ToString();
                    }
                    else
                    {
                        Console.Write("Error1");
                        //MessageBox.Show("Error 1");
                    }
                    ///////////////////////////////////////
                    //mes = DateTime.Now.ToString("MMMM yyyy");
                    mes = textBox1.Text.ToString();
                    ////////////////////////////////////////////////
                    OleDbCommand command2 = cone.CreateCommand();
                    command2.CommandType = CommandType.Text;
                    ///seleccionamos la ultima deuda que existe en la persona///////
                    command2.CommandText = "SELECT costo,lectura_deuda,fecha_deuda FROM Deuda WHERE id_persona = " + i + " AND fecha_deuda=(SELECT MAX(fecha_deuda) FROM Deuda WHERE id_persona =" + i + ")";
                    OleDbDataReader leer2 = command2.ExecuteReader();
                    if (leer2.Read() == true)
                    {
                        total_consumo = leer2["costo"].ToString();
                        totaldeladeuda = Convert.ToDouble(leer2["costo"].ToString());
                        consumo = Convert.ToDouble(leer2["costo"].ToString());
                        consumo_actual = leer2["lectura_deuda"].ToString();
                        lectura_act = Convert.ToDouble(leer2["lectura_deuda"].ToString());
                        fecha_actual = leer2["fecha_deuda"].ToString();
                    }
                    else
                    {
                        Console.Write("Error1");
                        //MessageBox.Show("Error 2");
                    }
                    /////////////////////////////////////////////////////////////////////////
                    OleDbCommand command3 = cone.CreateCommand();
                    command3.CommandType = CommandType.Text;
                    /////////Seleccionamos la deuda total de una persona//////
                    command3.CommandText = "SELECT sum(costo) as DeudaTotal FROM Deuda WHERE id_persona = " + i;
                    OleDbDataReader leer3 = command3.ExecuteReader();
                    if (leer3.Read() == true)
                    {
                        total_deuda = leer3["DeudaTotal"].ToString();
                        if (total_deuda == "")
                        {
                            MessageBox.Show("El cliente "+i+" no existe");
                        }
                        else
                        {
                            deuda_total = Convert.ToDouble(leer3["DeudaTotal"].ToString());
                        }
                        
                    }
                    else
                    {
                        Console.Write("Error1");
                        //MessageBox.Show("Error 3");
                    }

                    //deuda_parcial = deuda_total - consumo;
                    //deuda = Convert.ToString(deuda_parcial);

                    ///////////////////////////////////////////////////////////////////////////
                    OleDbCommand command4 = cone.CreateCommand();
                    command4.CommandType = CommandType.Text;
                    command4.CommandText = "SELECT TOP 1 lectura_deuda,fecha_deuda,costo FROM Deuda WHERE fecha_deuda < (SELECT MAX(fecha_deuda) FROM Deuda WHERE id_persona =" + i + ") AND id_persona =" + i + " ORDER BY fecha_deuda DESC ";
                    //command4.CommandText = "SELECT TOP 1 lectura_deuda,fecha_deuda FROM Deuda WHERE fecha_deuda < (SELECT MAX(fecha_deuda) FROM Deuda) AND id_persona =" + txtid_persona.Text + " ORDER BY fecha_deuda DESC ";
                    OleDbDataReader leer4 = command4.ExecuteReader();
                    if (leer4.Read() == true)
                    {
                        consumo_anterior = leer4["lectura_deuda"].ToString();
                        lectura_antr = Convert.ToDouble(leer4["lectura_deuda"].ToString());
                        fecha_anterior = leer4["fecha_deuda"].ToString();
                        deuda = leer4["costo"].ToString();
                        double deudas = Convert.ToDouble(deuda);
                    }
                    else
                    {
                        Console.Write("Error1");
                        //MessageBox.Show("Error 4");
                    }
                    consumo_men = lectura_act - lectura_antr;
                    consumo_mensual = Convert.ToString(consumo_men);
                    //////////////////////////////////////////////////////////////////////////
                    /////////////////////////////
                    //Se debe primero sacar el monto de la primera sentencia y sumarla con lo deuda 
                    ///////////////////////////////////////////////////////
                    OleDbCommand command5 = cone.CreateCommand();
                    command5.CommandType = CommandType.Text;
                    command5.CommandText = "SELECT TOP 1 monto FROM Deuda WHERE id_persona = " + i;
                    //command4.CommandText = "SELECT TOP 1 lectura_deuda,fecha_deuda FROM Deuda WHERE fecha_deuda < (SELECT MAX(fecha_deuda) FROM Deuda) AND id_persona =" + txtid_persona.Text + " ORDER BY fecha_deuda DESC ";
                    OleDbDataReader leer5 = command5.ExecuteReader();
                    if (leer5.Read() == true)
                    {
                        deuda_parcial = Convert.ToDouble(leer5["monto"].ToString());
                    }
                    else
                    {
                        Console.Write("Error1");
                        //MessageBox.Show("Error 5");
                    }

                    deuda = Convert.ToString(deuda_parcial);
                    //deuda_parcial = deudas + deuda_parcial;
                    totaldeladeuda1 = deuda_parcial + totaldeladeuda;
                    total_deuda = Convert.ToString(totaldeladeuda1);
                    //deuda = Convert.ToString(deuda_parcial);


                    //Primero obtenemos el día actual
                    DateTime date = DateTime.Now;

                    //Asi obtenemos el primer dia del mes actual
                    DateTime oPrimerDiaDelMes = new DateTime(date.Year, date.Month, 1);

                    //Y de la siguiente forma obtenemos el ultimo dia del mes
                    //agregamos 1 mes al objeto anterior y restamos 1 día.
                    DateTime oUltimoDiaDelMes = oPrimerDiaDelMes.AddMonths(1).AddDays(-1);
                    fecha_final = oUltimoDiaDelMes.ToString("dd/MM/yyyy");


                    if (fecha_anterior == "")
                    {
                        //MessageBox.Show("No existe Deuda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Console.Write("No existe Deuda");
                    }
                    else
                    {
                        DateTime fecha1 = Convert.ToDateTime(fecha_actual);
                        DateTime fecha2 = Convert.ToDateTime(fecha_anterior);
                        fecha_actual = fecha1.ToString("dd/MM/yyyy");
                        fecha_anterior = fecha2.ToString("dd/MM/yyyy");
                    }

                    //////////////////////// se agrego una cosa mas////////////////////////////
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
                        Console.Write("Error1");
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
                            fecha_antigua = fecha_antigua2.ToString("MMMM yyyy");
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
                            fecha_antigua = fecha_antigua3.ToString("MMMM yyyy");
                        }
                        else
                        {
                            Console.Write("Error1");
                            //MessageBox.Show("No posee deudas pendientes");
                        }

                    }
                    //////////////////////////////////////////////////////////////////////////
                    ReportParameter[] parametros = new ReportParameter[17];
                    if(mes!="" && persona!="" && nombre_zona!="" && comite!="" && manzana!="" && lote!="" && num_medidor!="" && total_consumo!=""
                        && deuda!="" && total_deuda!="" && consumo_anterior!="" && consumo_actual!="" && consumo_mensual!="" && fecha_anterior!=""
                        & fecha_actual!="" && fecha_final!="" && fecha_antigua!="")
                    {
                        parametros[0] = new ReportParameter("mes", mes);
                        parametros[1] = new ReportParameter("persona", persona);
                        parametros[2] = new ReportParameter("nombre_pueblo", nombre_zona);
                        parametros[3] = new ReportParameter("comite", comite);
                        parametros[4] = new ReportParameter("manzana", manzana);
                        parametros[5] = new ReportParameter("lote", lote);
                        parametros[6] = new ReportParameter("num_medidor", num_medidor);
                        parametros[7] = new ReportParameter("total_consumo", total_consumo);
                        parametros[8] = new ReportParameter("deuda", deuda);
                        parametros[9] = new ReportParameter("total_deuda", total_deuda);
                        parametros[10] = new ReportParameter("consumo_anterior", consumo_anterior);
                        parametros[11] = new ReportParameter("consumo_actual", consumo_actual);
                        parametros[12] = new ReportParameter("consumo_mensual", consumo_mensual);
                        parametros[13] = new ReportParameter("fecha_anterior", fecha_anterior);
                        parametros[14] = new ReportParameter("fecha_actual", fecha_actual);
                        parametros[15] = new ReportParameter("fecha_final", fecha_final);
                        //////
                        parametros[16] = new ReportParameter("fecha_antigua", fecha_antigua);
                        ///////
                        
                        reportViewer1.LocalReport.SetParameters(parametros);
                        cone.Close();
                        this.reportViewer1.RefreshReport();
                        //OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\Desktop-bb68mi8\documentos de agua todos los pueblos\SISTEMA CONTROL\Tiabaya.mdb;Persist Security info = False;");
                        File.WriteAllBytes(@"\\Desktop-bb68mi8\documentos de agua todos los pueblos\SISTEMA CONTROL\Recibos\recibo" + i + ".pdf", reportViewer1.LocalReport.Render("PDF"));


                    }
                    else
                    {
                        //MessageBox.Show("la huevada mas grande");
                        Console.Write("error");
                    }
                    
                    //reportViewer1.LocalReport.SetParameters(parametros);
                    //File.WriteAllBytes(@"C:\Users\user\Desktop\recibo" + i + ".pdf", reportViewer1.LocalReport.Render("PDF"));
                }
                MessageBox.Show("Recibos Generados y guardados exitosamente !");
                

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

        private void txtbloque_KeyPress(object sender, KeyPressEventArgs e)
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
