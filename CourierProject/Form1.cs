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
    public partial class Form1 : Form
    {
        String filePath;
        OracleConnection con;
        public Form1()
        {
            InitializeComponent();
        }
        public string cnic { get; set; }
        private void SignUP_button2_Click(object sender, EventArgs e)
        {
            String cnic = cnic_textBox1.Text;
            String name = name_textBox6.Text;
            String email = email_textBox5.Text;
            String phone_no = phone_textBox4.Text;
            int age = int.Parse(age_textBox3.Text.ToString());
            String address = address_textBox7.Text;

            String gender = "";

            if(radioButton1.Checked)
            {
                gender = "MALE";

            }
            else if(radioButton2.Checked)
            {
                gender = "FEMALE";
            }

            String pass = pass_textBox9.Text;
            String confirmP = confirmP_textBox8.Text;
            

            try
            {
                con.Open();
                OracleCommand command = con.CreateCommand();
                command.CommandText = $"INSERT INTO ADMIN_ VALUES('{cnic}','{name}','{email}','{phone_no}','{address}','{pass}','{gender}',{age},'{filePath}')";
                command.CommandType = CommandType.Text;
                int row =command.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("SUCCESS");
                   
                }
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close() ;
            }
        }

        public String cnicg;
        private void Form1_Load(object sender, EventArgs e)
        {
            String strCon = @"DATA SOURCE=localhost:1521/orcl;USER ID=sys;PASSWORD=Admin@123;DBA PRIVILEGE=SYSDBA";
            con = new OracleConnection(strCon);
        }
        

        private void Load_button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(filePath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
