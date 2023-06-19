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

namespace CourierProject
{
    public partial class CourierForm : Form
    { String status;
        OracleConnection con;
        public CourierForm()
        {
            InitializeComponent();
        }

        private void CourierForm_Load(object sender, EventArgs e)
        {
            String strCon = @"DATA SOURCE=localhost:1521/orcl;USER ID=sys;PASSWORD=Admin@123;DBA PRIVILEGE=SYSDBA";
            con = new OracleConnection(strCon);
        }

        private void veiwButton_Click(object sender, EventArgs e)
        {





            try
            {

                con.Open();

                OracleCommand cmd = con.CreateCommand();

                cmd.CommandText = $"SELECT c.status , s.sname_ , r.rname_ , s.saddress , r.radress , c.senddate, c.receivedate FROM courier_ c  JOIN sender_ s ON c.senderCNIC = s.senderCNIC JOIN receiver_ r ON c.receiverCNIC = r.receiverCNIC where c.courierid ='{courierID.Text}' ";

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

                    sendDate.Text = reader["senddate"].ToString();

                    receiveDate.Text = reader["receivedate"].ToString();

                }

                con.Close();



            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }



        }

        private void receiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OracleCommand command = con.CreateCommand();
                command.CommandText = $"UPDATE courier_ SET status = ' delivered ' WHERE courierid ='{courierID.Text}'";
                command.CommandType = CommandType.Text;
                int row = command.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("courier delivered SUCCESS");
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

                cmd.CommandText = $"SELECT status from courier_ where courierid = '{courierID.Text}'";

                //WHERE adminCNIC = '{admincnic_}'

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)

                {

                    reader.Read();

                    //  DataTable dataTable = new DataTable();
                    //dataTable.Load(reader);

                    status = reader["status"].ToString(); // Replace Column1 with the actual column name

                    
                }

                con.Close();



            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }
            

            }
        }
    }

