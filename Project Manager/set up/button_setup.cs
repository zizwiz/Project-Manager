using System;

namespace Project_Manager
{
    public partial class Form1
    {


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpbx_data_tab.Visible = false;


            if (tabControl1.SelectedTab == tabControl1.TabPages["tab_data"])
            {
                grpbx_data_tab.Visible = true;
            }
            
        }







    }
}