using System;

namespace Project_Manager
{
    public partial class Form1
    {
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpbx_data_tab.Visible = false;

            if (tabControl1.SelectedTab == tabControl1.TabPages["tab_people"])
            {
                grpbx_data_tab.Visible = true;
                grpbx_data_tab.BringToFront();
                grpbx_peoples_worked_hours.Visible = false;
                grpbx_peoples_worked_hours.SendToBack();
                btn_Save_Chart_Image.Visible = false;
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tab_input_updates"])
            {
                grpbx_data_tab.Visible = false;
                grpbx_data_tab.SendToBack();
                grpbx_peoples_worked_hours.Visible = false;
                grpbx_peoples_worked_hours.SendToBack();
                btn_Save_Chart_Image.Visible = false;
            }


            if (tabControl1.SelectedTab == tabControl1.TabPages["tab_people_worked_hours"])
            {
                grpbx_data_tab.Visible = false;
                grpbx_data_tab.SendToBack();
                grpbx_peoples_worked_hours.Visible = true;
                grpbx_peoples_worked_hours.BringToFront();
                btn_Save_Chart_Image.Visible = true;
            }

        }







    }
}