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
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CourierProject
{

    public partial class UserForm : Form
    {
        OracleConnection con;
        public String admincnic_ { get; set; }
        public UserForm()
        {
            InitializeComponent();
           


        }
        String imageadress = "";
        private void UserForm_Load(object sender, EventArgs e)
        {
            
            String strCon = @"DATA SOURCE=localhost:1521/orcl;USER ID=sys;PASSWORD=Admin@123;DBA PRIVILEGE=SYSDBA";
            con = new OracleConnection(strCon);
            try
            {
                con.Open();
                
                OracleCommand cmd = con.CreateCommand();
                
                cmd.CommandText = $"SELECT  ADMINCNIC, NAME_, EMAIL,PHONENO, ADRESS, GENDER, AGE,IMAGEADRESS FROM ADMIN_ ";
                
                //WHERE adminCNIC = '{admincnic_}'
                
                cmd.CommandType = CommandType.Text;
                
                cmd.ExecuteNonQuery();
                
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                
                {
                    
                    reader.Read();
                  
                    //  DataTable dataTable = new DataTable();
                    //dataTable.Load(reader);
                    
                    namelabel.Text = reader["NAME_"].ToString(); // Replace Column1 with the actual column name
                    
                    agelabel.Text = reader["AGE"].ToString();  // Assuming you have a DataGridView control named dataGridView1 on your form
                    
                    cniclabel.Text =admincnic_; // Replace Column1 with the actual column name
                    
                    emaillabel.Text = reader["EMAIL"].ToString();
                    
                    phonenolabel.Text = reader["PHONENO"].ToString(); // Replace Column1 with the actual column name
                    //adresslabel.Text = reader["ADRESS"].ToString();
                    
                    imageadress = reader["IMAGEADRESS"].ToString();
                    //adresslabel.Text = reader["ADMINCNIC"].ToString();
                   
                 //   genderlabel.Text = admincnic_ ;
                
                    adresslabel.Text = reader["adress"].ToString();
                
                }
               
                profilepic.Image = Image.FromFile(imageadress);
                
                con.Close();


            }

            catch (Exception ex)
    
            {
            
                MessageBox.Show(ex.Message);
                
            }

        }

    }

}
