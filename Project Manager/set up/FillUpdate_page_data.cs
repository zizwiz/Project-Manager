using System;
using System.ComponentModel;
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

        private void btn_update_add_data_Click(object sender, EventArgs e)
        {
            int num_rows = dgv_csv_data.RowCount;

            bool checkFlag = true;

            //Check through the CSV to see if data is already available
            //NOTE: pulling back from CSV make sure you CAST to a string first

            for (int i = 0; i < num_rows; i++)
            {
                if (dgv_csv_data.Rows[i].Cells[2].Value.ToString() == dateTimePicker1.Value.ToShortDateString() &&
                    dgv_csv_data.Rows[i].Cells[3].Value.ToString() == cmbobx_update_name.SelectedItem.ToString())
                {
                    checkFlag = false; //it exists
                    MsgBox.Show("That date and name have already been filled in", "Problem", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    break;
                }
            }


            if (checkFlag) //only add if data is not already been entered
            {

                dgv_csv_data.Rows.Add();

                dgv_csv_data.Rows[num_rows].Cells[0].Value =
                    lbl_project_name.Text.Substring(lbl_project_name.Text.IndexOf(' ') + 1);
                dgv_csv_data.Rows[num_rows].Cells[1].Value =
                    lbl_project_phase.Text.Substring(lbl_project_phase.Text.IndexOf(' ') + 1);
                dgv_csv_data.Rows[num_rows].Cells[2].Value = dateTimePicker1.Value.ToShortDateString();
                dgv_csv_data.Rows[num_rows].Cells[3].Value = cmbobx_update_name.SelectedItem;
                dgv_csv_data.Rows[num_rows].Cells[4].Value = cmbobx_update_id.SelectedItem;
                dgv_csv_data.Rows[num_rows].Cells[5].Value = txtbx_update_projected_hours.Text;
                dgv_csv_data.Rows[num_rows].Cells[6].Value = txtbx_update_completed_hours.Text;
                dgv_csv_data.Rows[num_rows].Cells[7].Value = txtbx_updated_income.Text;


                //Sort by name then by date
                dgv_csv_data.Sort(dgv_csv_data.Columns[3], ListSortDirection.Ascending);
                dgv_csv_data.Sort(dgv_csv_data.Columns[2], ListSortDirection.Descending);

            }

        }
    }
}