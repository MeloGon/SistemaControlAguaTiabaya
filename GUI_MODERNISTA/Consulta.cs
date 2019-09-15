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
    public partial class Consulta : Form
    {
        string aux = "";
        string cod_zona = "";
        //OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\Desktop-bb68mi8\documentos de agua todos los pueblos\SISTEMA CONTROL\Tiabaya.mdb;Persist Security info = False;");
        //OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\KEVYN\Documents\PRUEBATIABAYA\Tiabaya.mdb;Persist Security info = False;");
        //OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\GORO-LAP\Users\RODRIGO\Desktop\Compartir\Tiabaya.mdb;Persist Security info = False;");
        OleDbConnection cone = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\PC\Users\user\Documents\CarpetaCompartidaxd\Tiabaya.mdb;Persist Security info = False;");
        public Consulta()
        {
            InitializeComponent();
            btnbuscar.Enabled = false;
            btnAgregar.Enabled = false;
            txtcodigo.Enabled = false;
            txtnombre.Enabled = false;
            comboBox1.Text = "SELECCIONE UNA ZONA";
        }

        private void btnfiltro_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                btnbuscar.Enabled = true;
                txtnombre.Enabled = false;
                txtcodigo.Enabled = true;
                txtnombre.Clear();
                txtcodigo.Clear();
            }
            if (radioButton1.Checked)
            {
                txtcodigo.Enabled = false;
                txtnombre.Enabled = true;
                txtnombre.Clear();
                txtcodigo.Clear();
            }
        }

        private void txtnombre_KeyUp(object sender, KeyEventArgs e)
        {
            cone.Open();
            OleDbCommand command = cone.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select Persona.id_persona,Persona.nombres_persona,Persona.dni,Persona.num_medidor,Persona.tiene_medidor,Zona.nombre_zona,Persona.comite_zona,Persona.manzana_zona,Persona.lote_zona FROM Persona INNER JOIN Zona ON Persona.id_zona = Zona.id_zona WHERE nombres_persona LIKE'%" + txtnombre.Text + "%'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cone.Close();

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            cone.Open();
            OleDbCommand command = cone.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select Persona.id_persona,Persona.nombres_persona,Persona.dni,Persona.num_medidor,Persona.tiene_medidor,Zona.nombre_zona,Persona.comite_zona,Persona.manzana_zona,Persona.lote_zona FROM Persona INNER JOIN Zona ON Persona.id_zona = Zona.id_zona WHERE Persona.id_persona = " + txtcodigo.Text + "";
            //command.CommandText = "Select * FROM Persona WHERE id_persona = " + txtcodigo.Text + "";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cone.Close();
        }
        /*
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox3.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        */

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            if(txtcodigo.Text == "" && txtnombre.Text =="")
            {
                MessageBox.Show("Introduzca algun codigo o nombre para visualizar la tabla");

            }else
            {
                string val = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtnombre.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtnromedidor.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                // cbtmedidor.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtpueblo.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtcomite.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtmanzana.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtlote.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtdni.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                if (val.Equals("True"))
                {
                    cbtmedidor.Checked = true;
                }
                else
                {
                    cbtmedidor.Checked = false;
                }
            }
          
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btntodos_Click(object sender, EventArgs e)
        {
            cone.Open();
            OleDbCommand command = cone.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select Persona.id_persona,Persona.nombres_persona,Persona.dni,Persona.num_medidor,Persona.tiene_medidor,Zona.nombre_zona,Persona.comite_zona,Persona.manzana_zona,Persona.lote_zona FROM Persona INNER JOIN Zona ON Persona.id_zona = Zona.id_zona";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cone.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cone.Open();
            OleDbCommand command = cone.CreateCommand();
            command.CommandType = CommandType.Text;
            if (checkBox1.Checked == true)
            {
                aux = "true";
            }
            else
            {
                aux = "false";
            }
            command.CommandText = "INSERT INTO Persona(id_zona,nombres_persona,dni,num_medidor,tiene_medidor,comite_zona,manzana_zona,lote_zona) VALUES('" + cod_zona + "','" + txtipoblador.Text + "','" + txtidni.Text + "','" + txtinumedidor.Text + "'," + aux + ",'" + txticomite.Text + "','" + txtimanzana.Text + "','" + txtilote.Text + "')";
            if(txtipoblador.Text=="" || comboBox1.Text=="" ||txticomite.Text=="" ||txtimanzana.Text=="" || txtilote.Text=="" || txtinumedidor.Text=="" || txtidni.Text == "")
            {
                MessageBox.Show("Algunos campos estan vacios porfavor revise nuevamente ...");
            }else
            {
                if (MessageBox.Show("REVISE LOS DATOS INGRESADOS, ¿ES CORRECTO?", "CONFIRMAR REGISTRO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("REGISTRO EXITOSO");
                }
                else
                {
                    Console.Write("Selecciono NO");
                }
            }
            
            cone.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int indice = comboBox1.SelectedIndex;
            if (indice == 0)
            {
                cod_zona = "0001";
            }
            if (indice == 1)
            {
                cod_zona = "0002";
            }
            if (indice == 2)
            {
                cod_zona = "0003";
            }
            if (indice == 3)
            {
                cod_zona = "0004";
            }
            if (indice == 4)
            {
                cod_zona = "0005";
            }
            if (indice == 5)
            {
                cod_zona = "0006";
            }
            if (indice == 6)
            {
                cod_zona = "0007";
            }
            if (indice == 7)
            {
                cod_zona = "0008";
            }
            if (indice == 8)
            {
                cod_zona = "0009";
            }
            if (indice == 9)
            {
                cod_zona = "0010";
            }
            if (indice == 10)
            {
                cod_zona = "0011";
            }
            if (indice == 11)
            {
                cod_zona = "0012";
            }
            if (indice == 12)
            {
                cod_zona = "0013";
            }
            if (indice == 13)
            {
                cod_zona = "0014";
            }
            if (indice == 14)
            {
                cod_zona = "0015";
            }
            if (indice == 15)
            {
                cod_zona = "0016";
            }
            if (indice == 16)
            {
                cod_zona = "0017";
            }
            if (indice == 17)
            {
                cod_zona = "0018";
            }
            if (indice == 18)
            {
                cod_zona = "0019";
            }
            if (indice == 19)
            {
                cod_zona = "0020";
            }
            if (indice == 20)
            {
                cod_zona = "0021";
            }
            if (indice == 21)
            {
                cod_zona = "0022";
            }
            if (indice == 22)
            {
                cod_zona = "0023";
            }
            if (indice == 23)
            {
                cod_zona = "0024";
            }
        }

        private void rbAgregar_CheckedChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
        }
    }
}
