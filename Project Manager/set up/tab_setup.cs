﻿namespace Project_Manager
{
    public partial class Form1
    {

        private void HideTabs()
        {
            //We remove this tab and only insert it when we get more data
            tabControl1.TabPages.Remove(tab_update); 

        }

        private void ShowTabs()
        {
            //Now go and show the Update tab
            tabControl1.TabPages.Insert(0, tab_update); //put into position 0

        }


    }
}