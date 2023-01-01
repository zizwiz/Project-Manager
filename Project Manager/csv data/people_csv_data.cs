using System;
using System.ComponentModel;
using System.Windows.Forms;
using CenteredMessagebox;

namespace Project_Manager
{
    public partial class Form1
    {
        private void btn_save_people_csv_file_Click(object sender, EventArgs e)
        {
            SaveCSVFile(dgv_people_csv_data, "people");
        }

        private void btn_add_csv_column_Click(object sender, EventArgs e)
        {
            ColumnName columnNamePopup = new ColumnName(); //get a new Dialog
            columnNamePopup.ShowDialog();
            string ColName = columnNamePopup.EnteredText; //get the new name
            columnNamePopup.Dispose();

            dgv_people_csv_data.Columns.Add(ColName, ColName);

            dgv_people_csv_data.ClearSelection();//clear what is already selected

            int nRowIndex = 0;
            int nColumnIndex = dgv_people_csv_data.Columns.Count - 1;

            //scroll down to last column top cell.
            dgv_people_csv_data.FirstDisplayedScrollingColumnIndex = nColumnIndex;
            dgv_people_csv_data.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;
            dgv_people_csv_data.CurrentCell = dgv_people_csv_data.Rows[nRowIndex].Cells[nColumnIndex];
        }


        private void btn_add_csv_row_Click(object sender, EventArgs e)
        {
            dgv_people_csv_data.Rows.Add(); //add the row
            dgv_people_csv_data.ClearSelection();//clear what is already selected

            int nRowIndex = dgv_people_csv_data.Rows.Count - 1;
            int nColumnIndex = 0;

            //scroll down to last row first cell.
            dgv_people_csv_data.FirstDisplayedScrollingRowIndex = nRowIndex;
            dgv_people_csv_data.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;
            dgv_people_csv_data.CurrentCell = dgv_people_csv_data.Rows[nRowIndex].Cells[nColumnIndex];
        }

        private void btn_add_people_data_Click(object sender, EventArgs e)
        {
            int num_rows = dgv_people_csv_data.RowCount;

            bool checkFlag = true;

            //Check through the CSV to see if data is already available
            //NOTE: pulling back from CSV make sure you CAST to a string first

            for (int i = 0; i < num_rows; i++)
            {
                if (dgv_people_csv_data.Rows[i].Cells[2].Value.ToString() == dateTimePicker1.Value.ToShortDateString() &&
                    dgv_people_csv_data.Rows[i].Cells[3].Value.ToString() == cmbobx_update_name.SelectedItem.ToString())
                {
                    checkFlag = false; //it exists
                    MsgBox.Show("That date and name have already been filled in", "Problem", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    break;
                }
            }


            if (checkFlag) //only add if data is not already been entered
            {

                dgv_people_csv_data.Rows.Add();

                dgv_people_csv_data.Rows[num_rows].Cells[0].Value =
                    lbl_project_name.Text.Substring(lbl_project_name.Text.IndexOf(' ') + 1);
                dgv_people_csv_data.Rows[num_rows].Cells[1].Value =
                    lbl_project_phase.Text.Substring(lbl_project_phase.Text.IndexOf(' ') + 1);
                dgv_people_csv_data.Rows[num_rows].Cells[2].Value = dateTimePicker1.Value.ToShortDateString();
                dgv_people_csv_data.Rows[num_rows].Cells[3].Value = cmbobx_update_name.SelectedItem;
                dgv_people_csv_data.Rows[num_rows].Cells[4].Value = cmbobx_update_id.SelectedItem;
                dgv_people_csv_data.Rows[num_rows].Cells[5].Value = txtbx_update_projected_hours.Text;
                dgv_people_csv_data.Rows[num_rows].Cells[6].Value = txtbx_update_completed_hours.Text;
                dgv_people_csv_data.Rows[num_rows].Cells[7].Value = txtbx_updated_income.Text;

                //Sort by name then by date
                dgv_people_csv_data.Sort(dgv_people_csv_data.Columns[3], ListSortDirection.Ascending);
                dgv_people_csv_data.Sort(dgv_people_csv_data.Columns[2], ListSortDirection.Descending);

            }

        }
    }
}