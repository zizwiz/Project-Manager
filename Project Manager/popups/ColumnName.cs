using System;
using System.Reflection;
using System.Windows.Forms;

namespace Project_Manager
{
    public partial class ColumnName : Form
    {
        public ColumnName()
        {
            InitializeComponent();
        }

        private void ColumnName_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number
        }

        public string EnteredText
        {
            get { return (txtbx_column_name.Text); }
        }

        private void btn_column_name_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
