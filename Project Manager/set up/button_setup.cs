using System;

namespace Project_Manager
{
    public partial class Form1
    {
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpbx_data_tab.Visible = false;

            btn_save_finance_csv_file.Visible = false;
            btn_save_people_csv_file.Visible = false;

            if (tabControl1.SelectedTab == tabControl1.TabPages["tab_people"])
            {
                btn_save_people_csv_file.Visible = true;
                grpbx_data_tab.Visible = true;
                grpbx_data_tab.BringToFront();
                
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tab_input_updates"])
            {
                grpbx_data_tab.Visible = false;
                grpbx_data_tab.SendToBack();
               
            }


            if (tabControl1.SelectedTab == tabControl1.TabPages["tab_finance"])
            {
                btn_save_finance_csv_file.Visible = true;
                grpbx_data_tab.Visible = false;
                grpbx_data_tab.SendToBack();
               
            }

        }
    }
}