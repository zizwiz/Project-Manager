using System;
using System.Windows.Forms;
using CenteredMessagebox;

namespace Project_Manager
{
    public partial class Form1
    {

        private void cmbobx_update_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbobx_update_id.SelectedIndex = cmbobx_update_name.SelectedIndex;
        }

        private void cmbobx_update_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbobx_update_name.SelectedIndex = cmbobx_update_id.SelectedIndex;
        }

        /// <summary>
        /// This is where we add additional people and save them to the CSV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_add_person_Click(object sender, EventArgs e)
        {
            AdditionalNames addionalNamePopup = new AdditionalNames(); //get a new Dialog
            addionalNamePopup.ShowDialog();
            string AdditionalName = addionalNamePopup.AdditionalNameText; //get the new name

            if (AdditionalName != "")
            {
                int pos = AdditionalName.IndexOf(',');
                string AName = AdditionalName.Substring(0, pos);
                string AID = AdditionalName.Substring(pos + 1);

                if (!cmbobx_update_name.Items.Contains(AName))
                {
                    //get data
                    cmbobx_update_name.Items.Add(AName);
                    cmbobx_update_id.Items.Add(AID);

                    //Select data
                    cmbobx_update_name.SelectedItem = AName;
                    cmbobx_update_id.SelectedItem = AID;
                }
                else
                {
                    MsgBox.Show("That name already exists", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            addionalNamePopup.Dispose();
        }
    }
}