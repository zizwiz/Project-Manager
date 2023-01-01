namespace Project_Manager
{
    public partial class Form1
    {

        private void HideTabs()
        {
            //We remove this tab and only insert it when we get more data
            //tabControl1.TabPages.Remove(tab_input_updates); 
            //tabControl1.TabPages.Remove(tab_people_worked_hours);
            //tabControl1.TabPages.Remove(tab_finance);

            tabControl1.Visible = false;
        }

        private void ShowTabs()
        {
            //Now go and show the Update tab
          //  tabControl1.TabPages.Insert(0, tab_input_updates); //put into position 0
            // 1 = tab_people
            //tabControl1.TabPages.Insert(2, tab_finance);
            //tabControl1.TabPages.Insert(3, tab_people_worked_hours);
            // 4 = 
            // 5 = 

            tabControl1.Visible = true;
        }


    }
}