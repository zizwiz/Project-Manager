namespace Project_Manager
{
    public partial class Form1
    {

        private void HideTabs()
        {
            //We remove this tab and only insert it when we get more data
            tabControl1.TabPages.Remove(tab_update_people); 
            tabControl1.TabPages.Remove(tab_people_worked_hours);
            tabControl1.TabPages.Remove(tab_update_finance);

        }

        private void ShowTabs()
        {
            //Now go and show the Update tab
            tabControl1.TabPages.Insert(0, tab_update_people); //put into position 0
            tabControl1.TabPages.Insert(4, tab_people_worked_hours);
            tabControl1.TabPages.Insert(3, tab_update_finance);

        }


    }
}