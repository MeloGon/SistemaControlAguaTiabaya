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
    public partial class RegistroPagos : Form
    {
        OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\Desktop-bb68mi8\documentos de agua todos los pueblos\SISTEMA CONTROL\Tiabaya.mdb;Persist Security info = False;");
        //OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\GORO-LAP\Users\RODRIGO\Desktop\Compartir\Tiabaya.mdb;Persist Security info = False;");
        //OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\PC\Users\user\Documents\CarpetaCompartidaxd\Tiabaya.mdb;Persist Security info = False;");
        public RegistroPagos()
        {
            InitializeComponent();
        }

        private void RegistroPagos_Load(object sender, EventArgs e)
        {
            cone.Open();
            OleDbCommand command = cone.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Recibo WHERE fecha_actual BETWEEN '" + dateTimePicker1.Text.ToString() + "' AND '" + dateTimePicker2.Text.ToString() + "'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            da.Fill(dt);
            ReciboBindingSource.DataSource = dt;
            cone.Close();

            // TODO: esta línea de código carga datos en la tabla 'TiabayaDataSet.Recibo' Puede moverla o quitarla según sea necesario.
            this.ReciboTableAdapter.Fill(this.TiabayaDataSet.Recibo);

            this.reportViewer1.RefreshReport();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            cone.Open();
            OleDbCommand command = cone.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Recibo WHERE fecha_actual BETWEEN '" + dateTimePicker1.Text.ToString() + "' AND '" + dateTimePicker2.Text.ToString() + "'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            da.Fill(dt);
            ReciboBindingSource.DataSource = dt;
            cone.Close();

            // TODO: esta línea de código carga datos en la tabla 'TiabayaDataSet.Recibo' Puede moverla o quitarla según sea necesario.
            this.ReciboTableAdapter.Fill(this.TiabayaDataSet.Recibo);

            this.reportViewer1.RefreshReport();
        }
    }
}
