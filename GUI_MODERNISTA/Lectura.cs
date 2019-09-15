using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Globalization;

namespace GUI_MODERNISTA
{

    public partial class Lectura : Form
    {
        Boolean permitir = true;
        //OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\Desktop-bb68mi8\documentos de agua todos los pueblos\SISTEMA CONTROL\Tiabaya.mdb;Persist Security info = False;");
        OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\PC\Users\user\Documents\CarpetaCompartidaxd\Tiabaya.mdb;Persist Security info = False;");
        public Lectura()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            cone.Open();
            OleDbCommand command = cone.CreateCommand();
            command.CommandType = CommandType.Text;
            if (txtcodigopersona.Text != "") {
                command.CommandText = "SELECT Deuda.id_deuda,Deuda.id_persona, Persona.nombres_persona,Deuda.fecha_deuda,Deuda.pago,Deuda.lectura_deuda,Deuda.consumo,Deuda.costo FROM Deuda INNER JOIN Persona ON Deuda.id_persona = Persona.id_persona WHERE Persona.id_persona LIKE " + txtcodigopersona.Text + "";
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Ingrese algo en la casilla del Codigo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            cone.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (txtcodigopersona.Text == "")
            {
                MessageBox.Show("Introduzca algun codigo para visualizar la tabla");

            }
            else
            {
                string val = this.dataGridView1.CurrentRow.Cells[4].Value.ToString(); ;
                //txtcodigopersona.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                lblcodigoper.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker2.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtlectura.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                lblconsumo.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                lblcosto.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                /*string costo = lblcosto.Text;
                lblcosto.Text = costo.ToString("#.##");*/
                lbldeuda.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                lblcodigodeuda.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (val.Equals("True"))
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }
            }
            

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtlectura.Text == "" || txtcodigopersona.Text == "" || dateTimePicker1.Text.ToString() == "" || txtlectura.Text == "")
            {
                MessageBox.Show("Hay algun campo que no esta lleno, Porfavor revise cuidadosamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                double aux1, rptaconsumo = 0;
                double lect = 0;
                double rptacosto = 0;
                string aux;
                string id_zonaaux = "";
                lect = Convert.ToDouble(txtlectura.Text);
                cone.Open();

                //////////////////////////////////////////////////////////////////////////
                OleDbCommand command2 = cone.CreateCommand();
                command2.CommandType = CommandType.Text;
                //command2.CommandText = "SELECT id_deuda,lectura_deuda FROM DEUDA WHERE id_deuda = (select max(id_deuda) FROM Deuda)";
                command2.CommandText = "SELECT id_deuda,lectura_deuda FROM DEUDA WHERE id_deuda = (select max(id_deuda) FROM Deuda WHERE id_persona = " + txtcodigopersona.Text + ")";
                OleDbDataReader leer = command2.ExecuteReader();
                if (leer.Read() == true)
                {
                    aux1 = Convert.ToDouble(leer["lectura_deuda"].ToString());
                    rptaconsumo = lect - aux1;

                }
                else
                {
                    MessageBox.Show("Advertencia Ingreso");
                }
                ////////////////////////////////////////////////////////////////////////////////
                if (checkBox1.Checked == true)
                {
                    aux = "true";
                }
                else
                {
                    aux = "false";
                }

                //////////////////////////////////////////////////////////////////////////////
                OleDbCommand command3 = cone.CreateCommand();
                command3.CommandType = CommandType.Text;
                command3.CommandText = "SELECT id_zona FROM Persona WHERE id_persona = " + txtcodigopersona.Text;
                OleDbDataReader leer3 = command3.ExecuteReader();
                if (leer3.Read() == true)
                {
                    id_zonaaux = leer3["id_zona"].ToString();
                }
                else
                {
                    MessageBox.Show("Zona no Encontrada");
                }
                //////////////////////////////////////////////////////////////////////////////
                if (id_zonaaux == "0011" || id_zonaaux == "0012" || id_zonaaux == "0013" || id_zonaaux == "0014" || id_zonaaux == "0015" || id_zonaaux == "0016")
                {
                    rptacosto = hallarCosto2(aux, rptaconsumo);
                }
                else
                {
                    rptacosto = hallarCosto(aux, rptaconsumo);
                }
                //////////////////////////////////////////////////////////////////////////////     


                OleDbCommand command = cone.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Deuda(id_persona, monto,fecha_antigua, fecha_deuda, lectura_deuda, consumo, costo, pago, observacion) VALUES(" + txtcodigopersona.Text + ",0.0,'0','" + dateTimePicker1.Text.ToString() + "'," + txtlectura.Text + "," + rptaconsumo + "," + rptacosto + ",false,' ')";
                if (MessageBox.Show("REVISE LA LECTURA INGRESADA, ¿ES CORRECTO?", "CONFIRMAR PAGO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("REGISTRO EXITOSO, REFRESQUE PARA VER LOS CAMBIOS");
                }

                //command.ExecuteNonQuery();

                cone.Close();

            }

        }

        private double hallarCosto(string pago, double consumo)
        {
            double rptafinal = 0;
            if (pago == "true")
            {
                rptafinal = 0;
            }
            else
            {
                if (consumo < 3.01)
                {
                    rptafinal = 2.67;
                }
                else
                {
                    if (consumo > 3)
                    {
                        if (consumo < 20.01)
                        {
                            rptafinal = consumo * 1.333333;
                        }
                        else
                        {
                            if (consumo < 50.01)
                            {
                                rptafinal = 26.67 + (consumo - 20) * 2.5;
                            }
                            else
                            {
                                rptafinal = 101.67 + (consumo - 50) * 6;
                            }
                        }
                    }
                }
            }

            return rptafinal;
        }
        private double hallarCosto2(string pago, double consumo)
        {
            double rptafinal = 0;
            if (pago == "true")
            {
                rptafinal = 0;
            }
            else
            {
                if (consumo <= 3)
                {
                    rptafinal = 7.53;
                }
                else
                {
                    if (consumo <= 20)
                    {
                        if (consumo < 20.01)
                        {
                            rptafinal = consumo * 2.51;
                        }
                        else
                        {
                            rptafinal = ((consumo - 20) * 3.51) + 50.2;
                        }
                    }
                }
            }

            return rptafinal;
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (lblcodigodeuda.Text == "0000")
            {
                MessageBox.Show("El código de la Deuda no existe ya que tiene el ID 0000", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                cone.Open();
                OleDbCommand command = cone.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Deuda WHERE id_deuda = " + lblcodigodeuda.Text + "";
                if (MessageBox.Show("¿Esta seguro de que quiere borrar la deuda con el código ? " + lblcodigodeuda.Text, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("LECTURA ELIMINADA EXITOSAMENTE, REFRESQUE PARA VER LOS CAMBIOS");

                }
                cone.Close();
            }
            
            
        }

        private void Lectura_Load(object sender, EventArgs e)
        {
          

        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            if(txtcodigopersona.Text == "")
            {
                MessageBox.Show("No se puede actualizar ya que tiene que ingresar algun codigo de poblador", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cone.Open();
                OleDbCommand command = cone.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Deuda.id_deuda,Deuda.id_persona, Persona.nombres_persona,Deuda.fecha_deuda,Deuda.pago,Deuda.lectura_deuda,Deuda.consumo,Deuda.costo FROM Deuda INNER JOIN Persona ON Deuda.id_persona = Persona.id_persona WHERE Persona.id_persona LIKE " + txtcodigopersona.Text + "";
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cone.Close();
            }
           
            
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AHORA PROCEDERA A MODIFICAR, LOS UNICOS CONTROLADORES HABILITADOS SON LECTURA Y FECHA. GRACIAS");
            //NO SABEMOS SI DEJAR EL CHECK AQUI POR QUE SE PUEDEN EQUIVOCAR PERO A LA VEZ PUEDEN PAGAR DEUDAS, LO MAS ADECUADO ES QUE NO SEA EN ESTE FORM
            if(txtlectura.Text == "")
            {
                MessageBox.Show("Hay algun campo que no esta lleno, Porfavor revise cuidadosamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string aux;
                if (checkBox1.Checked == true)
                {
                    aux = "true";
                }
                else
                {
                    aux = "false";
                }
                cone.Open();
                OleDbCommand command = cone.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Deuda SET lectura_deuda = " + txtlectura.Text + ",fecha_deuda = '" + dateTimePicker1.Text.ToString() + "', pago = " + aux + " WHERE id_deuda =" + lblcodigodeuda.Text;
                command.ExecuteNonQuery();
                MessageBox.Show("MODIFICACION EXITOSA, REFRESQUE PARA VER LOS CAMBIOS");
                cone.Close();
            }
            
            
        }

        private void txtcodigopersona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtlectura_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = solonumeros(Convert.ToInt32(e.KeyChar));
            /*if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }*/
        }
        public bool solonumeros(int code)
        {
            bool resultado;

            if (code == 46 && txtlectura.Text.Contains("."))//se evalua si es punto y si es punto se rebiza si ya existe en el textbox
            {
                resultado = true;
            }
            else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evaluan las teclas validas
            {
                resultado = false;
            }
            else if (!permitir)
            {
                resultado = permitir;
            }
            else
            {
                resultado = true;
            }

            return resultado;

        }
    }
}
