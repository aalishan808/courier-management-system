using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CourierProject
{
    
    public partial class ReceiverForm : Form
    {
        OracleConnection con;
        public ReceiverForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String adminCNIC = LoginForm.cnic;







            try
            {
                con.Open();
                OracleCommand command = con.CreateCommand();
                command.CommandText = $"UPDATE courier_ SET receivedate = '{receivedatetextBox1.Text}' WHERE courierid =1";
                command.CommandType = CommandType.Text;
                int row = command.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("courier receive date SUCCESS");
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("courier receive date exception " + ex.Message);
                con.Close();
            }













            try
            {
                con.Open();

                OracleCommand cmd = con.CreateCommand();

                cmd.CommandText = $"SELECT c.courierid, c.status, s.sname_, r.rname_, s.saddress, r.radress, c.senddate FROM courier_ c JOIN sender_ s ON c.senderCNIC = s.senderCNIC JOIN receiver_ r ON c.receiverCNIC = r.receiverCNIC WHERE c.courierid = '{courierID.Text}'";

                //WHERE adminCNIC = '{admincnic_}'

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)

                {

                    reader.Read();

                    //  DataTable dataTable = new DataTable();
                    //dataTable.Load(reader);

                    statuslabel.Text = reader["status"].ToString(); // Replace Column1 with the actual column name

                    sendernamelabel.Text = reader["sname_"].ToString();  // Assuming you have a DataGridView control named dataGridView1 on your form

                    receivernamelabel.Text = reader["rname_"].ToString(); // Replace Column1 with the actual column name

                    fromlabel.Text = reader["saddress"].ToString();

                    tolabel.Text = reader["radress"].ToString(); // Replace Column1 with the actual column name

                    senddatelabel.Text = reader["senddate"].ToString();

                }

                con.Close();



            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }





        }

        private void ReceiverForm_Load(object sender, EventArgs e)
        {
            String strCon = @"DATA SOURCE=localhost:1521/orcl;USER ID=sys;PASSWORD=Admin@123;DBA PRIVILEGE=SYSDBA";
            con = new OracleConnection(strCon);
        }

        private void receivedButton_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                OracleCommand command = con.CreateCommand();
                command.CommandText = $"UPDATE courier_ SET status = ' received ' WHERE courierid ='{courierID.Text}'";
                command.CommandType = CommandType.Text;
                int row = command.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("courier received SUCCESS");
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("courier receive date exception " + ex.Message);
                con.Close();
            }
        }
    }
}
