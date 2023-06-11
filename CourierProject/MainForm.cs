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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void LOADFORM(Form form)
        {
            if(main_panel3.Controls.Count > 0)
            {
                main_panel3.Controls.RemoveAt(0);
            }
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            main_panel3.Controls.Add(form);
            main_panel3.Tag = form;
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LOADFORM(new CourierForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LOADFORM(new SenderForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LOADFORM(new ReceiverForm());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LOADFORM(new UserForm());
        }
    }
}
