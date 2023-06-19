using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace CourierProject
{
    public partial class SenderForm : Form
    {
        public static String courierid;
        public static String sendercnic;
        public static String receivercninc;
        OracleConnection con;

        public SenderForm()
        {
            InitializeComponent();
        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            //sender
            String sendername = senderName.Text;
            String senderage = senderAge.Text;
            String sendergender = sendergendercomboBox2.SelectedItem.ToString(); ;

            String senderemail = senderEmail.Text;
            String senderphoneno = senderEmail.Text;
            String senderAdress = senderadress.Text;
             sendercnic = senderCNICtextBox4.Text;

            //receiver
            String receivername = receiverName.Text;
            String receiverAge = receiverage.Text;
            String receivergender = receivergendercomboBox3.SelectedItem.ToString();

            String receiveremail = receiverEmail.Text;
            String receiverphoneno = receiverPhoneno.Text;
            String receiveradress = receiverAdress.Text;
             receivercninc = receiverCNIC.Text;

            //Courier 
            courierid = courierID.Text;
            String courierstatus = "";
            if (sentradioButton2.Checked)
            {
                courierstatus = "sent";
            }
            else
            {
                courierstatus = "not sent";
            }
            String courierweight = courierWeight.Text;
            String couriersendDate = senddatetextBox1.Text;


            //entering data into sender

            try
            {
                con.Open();
                OracleCommand command = con.CreateCommand();
                command.CommandText = $"INSERT INTO sender_ VALUES('{sendercnic}','{sendername}','{sendergender}','{senderemail}','{senderphoneno}','{senderage}','{LoginForm.cnic}','{senderAdress}')";
                command.CommandType = CommandType.Text;
                int row = command.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("sender SUCCESS");
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("sender exception " + ex.Message);
                con.Close();
            }
            //entering data into receiver

            try
            {
                con.Open();
                OracleCommand command = con.CreateCommand();
                command.CommandText = $"INSERT INTO receiver_ VALUES('{receivercninc}','{receivername}','{receiverAge}','{receivergender}','{receiveremail}','{receiverphoneno}','{LoginForm.cnic}','{receiveradress}')";
                command.CommandType = CommandType.Text;
                int row = command.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("receiver SUCCESS");
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("receiver exception " + ex.Message);
                con.Close();
            }


            //entering data into courier

            try
            {
                con.Open();
                OracleCommand command = con.CreateCommand();
                command.CommandText = $"INSERT INTO courier_ VALUES('{courierid}','{LoginForm.cnic}','{receivercninc}','{sendercnic}','{courierstatus}','{courierweight}','{couriersendDate}','2010,22,30')";
                command.CommandType = CommandType.Text;
                int row = command.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("courier SUCCESS");
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("courier exception " + ex.Message);
                con.Close();
            }

            


        }
            private void SenderForm_Load(object sender, EventArgs e)
            {
                String strCon = @"DATA SOURCE=localhost:1521/orcl;USER ID=sys;PASSWORD=Admin@123;DBA PRIVILEGE=SYSDBA";
                con = new OracleConnection(strCon);
            }
        
    }
}
