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
     String cnic = LoginForm.cnic ;
        public UserForm()
        {
            InitializeComponent();
           

        }
        
        String imageadress ;
        private void UserForm_Load(object sender, EventArgs e)
        {
            
            String strCon = @"DATA SOURCE=localhost:1521/orcl;USER ID=sys;PASSWORD=Admin@123;DBA PRIVILEGE=SYSDBA";
            con = new OracleConnection(strCon);
            try
            {
                con.Open();
                
                OracleCommand cmd = con.CreateCommand();
                
                cmd.CommandText = $"SELECT  ADMINCNIC, aNAME_, aEMAIL,aPHONENO, aADRESS, aGENDER, aAGE,IMAGEADRESS FROM ADMIN_ where adminCNIC = '{cnic}'";
                
                //WHERE adminCNIC = '{admincnic_}'
                
                cmd.CommandType = CommandType.Text;
                
                cmd.ExecuteNonQuery();
                
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                
                {
                    
                    reader.Read();

                    //  DataTable dataTable = new DataTable();
                    //dataTable.Load(reader);
                    
                    namelabel.Text = reader["aNAME_"].ToString(); // Replace Column1 with the actual column name
                    
                    agelabel.Text = reader["aAGE"].ToString();  // Assuming you have a DataGridView control named dataGridView1 on your form
                    
                    cniclabel.Text =cnic; // Replace Column1 with the actual column name
                    
                    emaillabel.Text = reader["aEMAIL"].ToString();
                    
                    phonenolabel.Text = reader["aPHONENO"].ToString(); // Replace Column1 with the actual column name
                    
                    adresslabel.Text = reader["aADRESS"].ToString();
                    
                    imageadress = reader["IMAGEADRESS"].ToString();
                   
                    genderlabel.Text = reader["aGENDER"].ToString() ;
                
                    adresslabel.Text = reader["aadress"].ToString();
                
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
