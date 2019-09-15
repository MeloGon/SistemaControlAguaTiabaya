using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    public partial class Pagos : Form
    {
        DateTime fecha_de_validacion = Convert.ToDateTime("01/06/2019");
        Boolean permitir = true;
        OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\Desktop-bb68mi8\documentos de agua todos los pueblos\SISTEMA CONTROL\Tiabaya.mdb;Persist Security info = False;");
        //OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\GORO-LAP\Users\RODRIGO\Desktop\Compartir\Tiabaya.mdb;Persist Security info = False;");
        //OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\PC\Users\user\Documents\CarpetaCompartidaxd\Tiabaya.mdb;Persist Security info = False;");
        public Pagos()
        {

            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            double deudaanterior = 0;
            if (txtcodigopoblador.Text == "")
            {
                MessageBox.Show("Para buscar tiene que ingresar un codigo. Ingrese un codigo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                double montototal = 0;
                cone.Open();
                OleDbCommand command2 = cone.CreateCommand();
                command2.CommandType = CommandType.Text;
                command2.CommandText = "SELECT sum(costo) as DeudaTotal FROM Deuda WHERE id_persona = " + txtcodigopoblador.Text;
                OleDbDataReader leer = command2.ExecuteReader();
                if (leer.Read() == true)
                {
                    montototal = Convert.ToDouble(leer["DeudaTotal"].ToString());
                }
                else
                {
                    MessageBox.Show("Error papu");
                }
                //////////////////////////////////////////////////////////
                OleDbCommand command5 = cone.CreateCommand();
                command5.CommandType = CommandType.Text;
                command5.CommandText = "SELECT TOP 1 monto FROM Deuda WHERE id_persona = " + txtcodigopoblador.Text;
                OleDbDataReader leer3 = command5.ExecuteReader();
                if (leer3.Read() == true)
                {

                    deudaanterior = Convert.ToDouble(leer3["monto"].ToString());
                }
                else
                {
                    MessageBox.Show("Error");
                }
                montototal = montototal + deudaanterior;
                lbldeudatotal.Text = Convert.ToString(montototal);
                //lbldeudatotal.Text = Convert.ToString(montototal);


                OleDbCommand command = cone.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Deuda.id_deuda,Deuda.id_persona, Persona.nombres_persona,Deuda.fecha_deuda,Deuda.pago,Deuda.costo,Deuda.monto,Deuda.fecha_antigua FROM Deuda INNER JOIN Persona ON Deuda.id_persona = Persona.id_persona WHERE Persona.id_persona LIKE " + txtcodigopoblador.Text + " AND Deuda.pago = false";
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cone.Close();
            }


        }


        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            if (txtcodigopoblador.Text == "")
            {
                MessageBox.Show("Introduzca algun codigo para visualizar la tabla");
            }
            else
            {
                string val = this.dataGridView1.CurrentRow.Cells[4].Value.ToString(); ;
                txtcodigopoblador.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                lblcosto.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                lbltickettotal.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                lbliddeuda.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ///////
                txtfechaantigua.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                /////
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

        private void btnpagar_Click(object sender, EventArgs e)
        {
            double deudaanterior = 0;
            if (lblcosto.Text == "" || txtpagos.Text == "" || lbliddeuda.Text == "")
            {
                MessageBox.Show("Para generar un ticket y realizar un pago, tiene que escoger una deuda. Escoja una deuda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                double cambio = 0;
                double monto = 0;
                double pagocon = 0;
                double resultado = 0;
                double montototal = 0;
                checkBox1.Checked = true;
                cone.Open();

                //cambio = Convert.ToDouble(lblcambio.Text);
                monto = double.Parse(lbltickettotal.Text);
                pagocon = double.Parse(txtpagos.Text);
                lblpagocon.Text = txtpagos.Text;

                if (pagocon > monto)
                {
                    resultado = pagocon - monto;
                }
                else
                {
                    resultado = 0;
                }
                lblcambio.Text = resultado.ToString();


                if (MessageBox.Show("REVISE EL TICKET DE PAGO, ¿ES CORRECTO?", "CONFIRMAR PAGO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    OleDbCommand command3 = cone.CreateCommand();
                    command3.CommandType = CommandType.Text;
                    command3.CommandText = "UPDATE Deuda SET pago = true,costo = 0 WHERE id_deuda =" + lbliddeuda.Text;
                    command3.ExecuteNonQuery();
                    ////////////////////////////////////////////////////////
                    OleDbCommand command4 = cone.CreateCommand();
                    command4.CommandType = CommandType.Text;
                    command4.CommandText = "INSERT INTO Recibo(id_persona,id_deuda,fecha_actual,pago_recibo,observaciones) VALUES (" + txtcodigopoblador.Text + "," + lbliddeuda.Text + ",'" + DateTime.Now.ToString("dd/MM/yyyy") + "'," + lbltickettotal.Text + ",'" + txtobservacion.Text + "')";
                    command4.ExecuteNonQuery();
                    ////////////////////////////////////////////////////////
                    OleDbCommand command2 = cone.CreateCommand();
                    command2.CommandType = CommandType.Text;
                    command2.CommandText = "SELECT sum(costo) as DeudaTotal FROM Deuda WHERE id_persona = " + txtcodigopoblador.Text;
                    OleDbDataReader leer = command2.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        montototal = Convert.ToDouble(leer["DeudaTotal"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    lbldeudatotal.Text = Convert.ToString(montototal);
                    MessageBox.Show("PAGO REALIZADO EXITOSAMENTE");
                    lbliddeuda.Text = "";
                    ///////////////////////////////////////////////////////////
                    /* OleDbCommand command5 = cone.CreateCommand();
                     command5.CommandType = CommandType.Text;
                     command5.CommandText = "SELECT TOP 1 monto FROM Deuda WHERE id_persona = " + txtcodigopoblador.Text;
                     OleDbDataReader leer3 = command5.ExecuteReader();
                     if (leer3.Read() == true)
                     {
                        deudaanterior = Convert.ToDouble(leer["monto"].ToString());
                     }
                     else
                     {
                         MessageBox.Show("Error");
                     }
                     montototal = montototal + deudaanterior;
                     lbldeudatotal.Text = Convert.ToString(montototal);
                     MessageBox.Show("PAGO REALIZADO EXITOSAMENTE");
                     lbliddeuda.Text = "";*/
                }
                cone.Close();
                ///////////////////////////////////////////////////////////////
                //  recibio = Convert.ToDouble(txtRecibio.Text);
                //montototal = montototal - recibio;
                //txtDeudaTotal.Text = Convert.ToString(montototal);
            }



        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            if (txtcodigopoblador.Text == "")
            {
                MessageBox.Show("No se puede actualizar ya que tiene que ingresar algun codigo de poblador", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                double montototal = 0;
                cone.Open();
                OleDbCommand command2 = cone.CreateCommand();
                command2.CommandType = CommandType.Text;
                command2.CommandText = "SELECT sum(costo) as DeudaTotal FROM Deuda WHERE id_persona = " + txtcodigopoblador.Text;
                OleDbDataReader leer = command2.ExecuteReader();
                if (leer.Read() == true)
                {
                    montototal = Convert.ToDouble(leer["DeudaTotal"].ToString());
                }
                else
                {
                    MessageBox.Show("Error");
                }
                lbldeudatotal.Text = Convert.ToString(montototal);


                OleDbCommand command = cone.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Deuda.id_deuda,Deuda.id_persona, Persona.nombres_persona,Deuda.fecha_deuda,Deuda.pago,Deuda.costo,Deuda.monto FROM Deuda INNER JOIN Persona ON Deuda.id_persona = Persona.id_persona WHERE Persona.id_persona LIKE " + txtcodigopoblador.Text + " AND Deuda.pago = false";
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                cone.Close();
            }


        }

        private void txtcodigopoblador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtpagos_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
             {
                 MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 e.Handled = true;
                 return;
             }*/
            e.Handled = solonumeros(Convert.ToInt32(e.KeyChar));

        }
        public bool solonumeros(int code)
        {
            bool resultado;

            if (code == 46 && txtpagos.Text.Contains("."))//se evalua si es punto y si es punto se rebiza si ya existe en el textbox
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

        private void btnpagodemonto_Click(object sender, EventArgs e)
        {
            double deudaanterior = 0;
            if (lblcosto.Text == "" || txtpagos.Text == "" || lbliddeuda.Text == "" || txtnummeses.Text =="")
            {
                MessageBox.Show("Para generar un ticket o realizar un pago, tiene que escoger una deuda o bien asegurarse de haber llenado los campos correspondientes. Escoja una deuda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //esta en el rango
                double cambio = 0;
                double monto = 0;
                double pagocon = 0;
                double resultado = 0;
                double montototal = 0;
                double drpta = 0;
                string srpta = "";
                double drpta1 = 0;
                string srpta1 = "";
                double pago = 0;
                double pago1 = 0;
                ///////////////////////////////
                string fecha_antigua = "";
                int pago_meses = 0;
                ///////////////////////////////
                checkBox1.Checked = true;
                cone.Open();

                //cambio = Convert.ToDouble(lblcambio.Text);
                monto = double.Parse(lbltickettotal.Text);
                pagocon = double.Parse(txtpagos.Text);
                lblpagocon.Text = txtpagos.Text;

                if (pagocon > monto)
                {
                    resultado = pagocon - monto;
                }
                else
                {
                    resultado = 0;
                }
                lblcambio.Text = resultado.ToString();

                if (MessageBox.Show("ESTA APUNTO DE PROCEDER AL PAGO DE UN MONTO, QUE ES UNA DEUDA HASTA ANTES DE LA IMPLEMENTACION DEL SISTEMA", "CONFIRMAR PAGO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    OleDbCommand command2 = cone.CreateCommand();
                    command2.CommandType = CommandType.Text;
                    command2.CommandText = "SELECT TOP 1 monto as DeudaTotal FROM Deuda WHERE id_persona =" + txtcodigopoblador.Text;
                    // command2.CommandText = "SELECT sum(costo) as DeudaTotal FROM Deuda WHERE id_persona = " + txtcodigopoblador.Text;
                    OleDbDataReader leer = command2.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        montototal = Convert.ToDouble(leer["DeudaTotal"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                    pago = Convert.ToDouble(txtpagos.Text);

                    if (pago <= montototal)
                    {
                        drpta = montototal - pago;
                        srpta = Convert.ToString(drpta);
                    }
                    else
                    {
                        srpta = "0";
                    }

                    //////////////////////////////////////Prueba de Deudasss////////////////////////////////////
                    fecha_antigua = txtfechaantigua.Text.ToString();
                    if (fecha_antigua != "")
                    {
                        if(fecha_antigua == "0")
                        {
                            MessageBox.Show("No existe deuda anterior ...");
                        }
                        else {
                            //practicamente seria lo mismo que fecha antigua
                            DateTime fechaanuel = Convert.ToDateTime(txtfechaantigua.Text);
                            if (fechaanuel < fecha_de_validacion)
                            {
                                DateTime fecha = Convert.ToDateTime(fecha_antigua);
                                pago_meses = Convert.ToInt32(txtnummeses.Text.ToString());
                                fecha = fecha.AddMonths(pago_meses);
                                DateTime fecha_comparar = Convert.ToDateTime(fecha);
                                if (fecha_comparar <= fecha_de_validacion)
                                {
                                    txtfechaantigua.Text = fecha.ToString("dd/MM/yyyy");
                                    OleDbCommand command3 = cone.CreateCommand();
                                    command3.CommandType = CommandType.Text;
                                    command3.CommandText = "UPDATE Deuda SET monto = " + srpta.ToString() + ",fecha_antigua = '" + fecha.ToString("dd/MM/yyyy") + "' WHERE id_deuda =" + lbliddeuda.Text;
                                    command3.ExecuteNonQuery();
                                    ////////////////////
                                    OleDbCommand command4 = cone.CreateCommand();
                                    command4.CommandType = CommandType.Text;

                                    pago1 = Convert.ToDouble(txtpagos.Text);
                                    if (pago1 >= montototal)
                                    {
                                        drpta1 = montototal;
                                        srpta1 = Convert.ToString(drpta1);
                                    }
                                    else
                                    {
                                        srpta1 = Convert.ToString(pago1);
                                    }

                                    /////////////////////////////////////////////////////////
                                    command4.CommandText = "INSERT INTO Recibo(id_persona,id_deuda,fecha_actual,pago_recibo,observaciones) VALUES (" + txtcodigopoblador.Text + "," + lbliddeuda.Text + ",'" + DateTime.Now.ToString("dd/MM/yyyy") + "'," + srpta1.ToString() + ",'" + txtobservacion.Text + "')";
                                    command4.ExecuteNonQuery();
                                    /////////////rpta = montotal-txtpago convertido en double
                                    lbldeudatotal.Text = Convert.ToString(montototal);
                                    MessageBox.Show("PAGO DE MONTO(DEUDA RAIZ) REALIZADO EXITOSAMENTE");
                                    lbliddeuda.Text = "";




                                }
                                else { MessageBox.Show("Recuerde que las deudas o montos estan hasta la fecha de instalacion del sistema que es hasta el mes de Junio (06)"); }

                            }
                            else
                            {
                                MessageBox.Show("Los meses que ha pagado estan fuera de rango de la deuda anterior");
                            }
                        }
                        
                    }
                    else if (fecha_antigua == "0")
                    {
                        MessageBox.Show("La fecha antigua es nula");
                    }
                    else
                    {
                        MessageBox.Show("No existe deuda anterior");
                    }
                    //AQUI IBA EL COMMAND4 HASTA LBLIDDEUDA.TEXT = ""

                }
                else
                {
                    Console.Write("Cancelo operacion");
                }
                cone.Close();



            }

        }

        private void txtnummeses_KeyPress(object sender, KeyPressEventArgs e)
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
