using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    public partial class PersonasImpresion : Form
    {
        //OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\Desktop-bb68mi8\documentos de agua todos los pueblos\SISTEMA CONTROL\Tiabaya.mdb;Persist Security info = False;");
        //OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\Desktop-bb68mi8\documentos de agua todos los pueblos\SISTEMA CONTROL\Tiabaya.mdb;Persist Security info = False;");
        //OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\GORO-LAP\Users\RODRIGO\Desktop\Compartir\Tiabaya.mdb;Persist Security info = False;");
        OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\PC\Users\user\Documents\CarpetaCompartidaxd\Tiabaya.mdb;Persist Security info = False;");
        string nombrezona = "";
        public PersonasImpresion()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void PersonasImpresion_Load(object sender, EventArgs e)
        {
            cone.Open();
            OleDbCommand command = cone.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Persona";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            da.Fill(dt);
            PersonaBindingSource.DataSource = dt;
            //////////////////////////////////////////////////////////////////
            /*string zona = "";
            OleDbCommand command2 = cone.CreateCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "SELECT id_zona FROM Persona";
            OleDbDataReader leer = command2.ExecuteReader();
            if (leer.Read() == true)
            {
                zona = leer["id_zona"].ToString();
            }
            else
            {
                MessageBox.Show("Error 1");
            }
            
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("prueba1", zona);
            reportViewer1.LocalReport.SetParameters(parametros);*/
            cone.Close();
            // TODO: esta línea de código carga datos en la tabla 'TiabayaDataSet.Persona' Puede moverla o quitarla según sea necesario.
           // this.PersonaTableAdapter.Fill(this.TiabayaDataSet.Persona);

            this.reportViewer1.RefreshReport();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            cone.Open();
            OleDbCommand command = cone.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Persona INNER JOIN Zona ON Zona.id_zona = Persona.id_zona Where Zona.nombre_zona = '"+nombrezona+"'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            da.Fill(dt);
            PersonaBindingSource.DataSource = dt;
            cone.Close();
            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboBox1.SelectedIndex;
            txtzona.Text = indice.ToString();
            nombrezona = comboBox1.Items[indice].ToString();
        }
    }
}
