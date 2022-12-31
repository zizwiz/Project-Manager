using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CenteredMessagebox;

namespace Project_Manager
{
    public partial class Form1
    {
        // dgv_csv_data

        private void btn_open_people_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Open CSV Data",
                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //First we load in the Data file regarding peoples hours

                    //Load filename into the update page so we can use it later
                    lbl_update_file_in_use.Text += openFileDialog1.FileName;

                    // Get the data.
                    string[,] values = LoadCsv(openFileDialog1.FileName);
                    int num_rows = values.GetUpperBound(0) + 1;
                    int num_cols = values.GetUpperBound(1) + 1;

                    lbl_project_name.Text += values[1, 0];
                    lbl_project_phase.Text += values[1, 1];

                    // Display the data to show we have it.

                    // Make column headers.
                    // For this example, we assume the first row
                    // contains the column names.
                    dgv_people_csv_data.Columns.Clear();
                    for (int c = 0; c < num_cols; c++)
                        dgv_people_csv_data.Columns.Add(values[0, c], values[0, c]);

                    // Add the data.
                    for (int r = 1; r < num_rows; r++)
                    {
                        dgv_people_csv_data.Rows.Add();
                        for (int c = 0; c < num_cols; c++)
                        {
                            dgv_people_csv_data.Rows[r - 1].Cells[c].Value = values[r, c];
                        }
                    }

                    //// Make the columns autosize.
                    foreach (DataGridViewColumn col in dgv_people_csv_data.Columns)
                        //col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    //////////////////////////////////////////////////////
                    /// Now lets populate the combo boxes on update page
                    /// //////////////////////////////////////////////////

                    // Add the data.
                    for (int r = 1; r < values.GetUpperBound(0) + 1; r++)
                    {
                        if (!cmbobx_update_name.Items.Contains(values[r, 3]))
                        {
                            cmbobx_update_name.Items.Add(values[r, 3]);
                            cmbobx_update_id.Items.Add(values[r, 4]);
                            cmbobx_update_name.SelectedIndex = 0;
                        }
                    }

                   //Now go and show the Update tab
                            ShowTabs();

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
        }

        private void btn_save_csv_file_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save CSV Files";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sb = new StringBuilder();

                    var headers = dgv_people_csv_data.Columns.Cast<DataGridViewColumn>();
                    sb.AppendLine(string.Join(",", headers.Select(column => column.HeaderText).ToArray()));

                    foreach (DataGridViewRow row in dgv_people_csv_data.Rows)
                    {
                        var cells = row.Cells.Cast<DataGridViewCell>();
                        sb.AppendLine(string.Join(",", cells.Select(cell => cell.Value).ToArray()));
                    }

                    StreamWriter file = new StreamWriter(saveFileDialog1.FileName);

                    file.WriteLine(sb.ToString()); // "sb" is the StringBuilder
                    file.Close();

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
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