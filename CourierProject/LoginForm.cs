using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Oracle.ManagedDataAccess.Client;

namespace CourierProject
{
    public partial class LoginForm : Form
    {
        OracleConnection con;
        public static String cnic;
        public LoginForm()
        {
            InitializeComponent();
            
           

        }
       
        private void signup_button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }
       
        private void login_button1_Click(object sender, EventArgs e)
        {
           
            String email = textBox1.Text;
            String password = textBox2.Text;
            cnic = cnictextbox.Text;
            String pas = "";
            String email_ = "";
            String admincnic = "";
            try
            {
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = $"SELECT * FROM ADMIN_ WHERE aemail='{email}' AND apassword_ = '{password}'AND adminCNIC = '{cnic}'";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                OracleDataReader reader = cmd.ExecuteReader();
                
                if (reader.HasRows)

                {

                    reader.Read();
                    pas = reader["apassword_"].ToString();
                    email_ = reader["aemail"].ToString();
                    admincnic = reader["adminCNIC"].ToString() ;
                    cnic = admincnic;
                    UserForm f1 = new UserForm() ;
                    
                    if (email == email_ &&  pas == password && cnic == admincnic){
                        
                        MainForm form1 = new MainForm();
                        form1.Show();
                    }
                    else{
                        cor.Text = "wrong data";
                    
                    }
                    con.Close();
                    //  DataTable dataTable = new DataTable();
                    //dataTable.Load(reader);


                    
                }


                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void LoginForm_Load(object sender, EventArgs e)
        {
            String strCon = @"DATA SOURCE=localhost:1521/orcl;USER ID=sys;PASSWORD=Admin@123;DBA PRIVILEGE=SYSDBA";
            con = new OracleConnection(strCon);
        }
    }
}
