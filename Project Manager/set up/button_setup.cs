using System;

namespace Project_Manager
{
    public partial class Form1
    {
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_save_finance_csv_file.Visible = false;
            btn_save_people_csv_file.Visible = false;
            btn_open_project.Visible = false;

            if (tabControl1.SelectedTab == tabControl1.TabPages["tab_people"])
            {
                btn_save_people_csv_file.Visible = true;
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tab_input_updates"])
            {
                btn_open_project.Visible = true;
            }
            
            if (tabControl1.SelectedTab == tabControl1.TabPages["tab_finance"])
            {
                btn_save_finance_csv_file.Visible = true;
            }

        }
    }
}