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

            try
            {
                FillUpdateComboBoxes(); //fill names and ID's
            }
            catch (Exception exc)
            {
                //There are no names or IDs to fill.
                MessageBox.Show("Something is wrong Grommit");
            }

            }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        
    }
}
