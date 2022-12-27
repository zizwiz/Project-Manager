using System;
using System.Reflection;
using System.Windows.Forms;

namespace Project_Manager
{
    public partial class AdditionalNames : Form
    {
        private bool Flag = false;
        public AdditionalNames()
        {
            InitializeComponent();
        }

        private void AdditionalNames_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number
        }

        public string AdditionalNameText
        {
            get
            {
                if (Flag)
                {
                    return "";
                }
                else
                {
                    return (txtbx_additional_name.Text + "," + txtbx_additional_ID.Text);
                }
            }
        }
   

        private void btn_additional_name_clear_Click(object sender, EventArgs e)
        {
            txtbx_additional_ID.Text = txtbx_additional_name.Text = "";
        }

        private void btn_additional_name_add_Click(object sender, EventArgs e)
        {
            if ((txtbx_additional_ID.Text != "") && (txtbx_additional_name.Text != ""))
            {
                Close();
            }
            else
            {
                MessageBox.Show("No data to add click Exit to close if this is correct");
            }
        }

        private void AdditionalNames_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Flag)
            {
                e.Cancel = false;
            }
            else if ((txtbx_additional_ID.Text == "") || (txtbx_additional_name.Text == ""))
            {
                e.Cancel = true; //no data so do not close
                MessageBox.Show("Add some data or click Exit button to close");
            }
            
        }

        private void btn_additional_exit_Click(object sender, EventArgs e)
        {
            Flag = true;
            Close();
        }
    }
}
