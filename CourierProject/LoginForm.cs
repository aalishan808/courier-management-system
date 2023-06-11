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
using Oracle.ManagedDataAccess.Client;

namespace CourierProject
{
    public partial class LoginForm : Form
    {
        OracleConnection con;
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
            String admincnic = cnictextbox.Text;
            try
            {
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = $"SELECT * FROM ADMIN_ WHERE email='{email}' AND password_ = '{password}'AND adminCNIC = '{admincnic}'";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                UserForm f = new UserForm();
                f.admincnic_ = admincnic;
                MainForm form = new MainForm();
                form.Show();
                
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
