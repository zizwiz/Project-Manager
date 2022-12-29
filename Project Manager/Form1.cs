using System;
using System.Reflection;
using System.Windows.Forms;

namespace Project_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpbx_data_tab.Visible = false;

            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            HideTabs();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_open_csv_Click(object sender, EventArgs e)
        {

        }
    }
}
