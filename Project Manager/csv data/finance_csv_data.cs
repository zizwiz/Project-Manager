using System;
using System.ComponentModel;
using System.Windows.Forms;
using CenteredMessagebox;

namespace Project_Manager
{
    public partial class Form1
    {
        private void btn_open_finance_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Open Finance File.",
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
                    //Load filename into the update page so we can use it later
                    lbl_finance_file_in_use.Text += openFileDialog1.FileName;

                    // Get the data.
                    string[,] values = LoadCsv(openFileDialog1.FileName);
                    int num_rows = values.GetUpperBound(0) + 1;
                    int num_cols = values.GetUpperBound(1) + 1;

                    
                    // Display the data to show we have it.

                    // Make column headers.
                    // For this example, we assume the first row
                    // contains the column names.


                    dgv_finance_csv_data.Columns.Clear();
                    for (int c = 0; c < num_cols; c++)
                        dgv_finance_csv_data.Columns.Add(values[0, c], values[0, c]);

                    // Add the data.
                    for (int r = 1; r < num_rows; r++)
                    {
                        dgv_finance_csv_data.Rows.Add();
                        for (int c = 0; c < num_cols; c++)
                        {
                            dgv_finance_csv_data.Rows[r - 1].Cells[c].Value = values[r, c];
                        }
                    }

                    //// Make the columns autosize.
                    foreach (DataGridViewColumn col in dgv_finance_csv_data.Columns)
                        //col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    //////////////////////////////////////////////////////
                    /// Now lets populate the combo boxes on update page
                    /// //////////////////////////////////////////////////

                    // Add the data.
                    lbl_project_start.Text += dgv_finance_csv_data.Rows[0].Cells[3].Value.ToString();
                    lbl_project_duration.Text += dgv_finance_csv_data.Rows[0].Cells[4].Value.ToString() + " weeks";

                    DateTime addDate;

                    //When is end date?
                    if (DateTime.TryParse(dgv_finance_csv_data.Rows[0].Cells[3].Value.ToString(), out addDate))
                    {
                        lbl_project_end.Text += addDate.AddDays(Int32.Parse(dgv_finance_csv_data.Rows[0].Cells[4].Value.ToString()) * 7).ToShortDateString();
                    }

                    lbl_project_value.Text += Convert.ToInt32(dgv_finance_csv_data.Rows[0].Cells[6].Value).ToString("C0");
                    lbl_project_money_remaining.Text += Convert.ToInt32(dgv_finance_csv_data.Rows[num_rows - 2].Cells[8].Value).ToString("C0");


                    //Now go and show the Update tab
                    //   ShowTabs();

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
        }

        private void btn_add_finance_data_Click(object sender, EventArgs e)
        {
            DateTime addDate;
            int num_rows = dgv_finance_csv_data.RowCount; // how many rows before we add a new one.
            bool checkFlag = true;

            //Check through the CSV to see if data is already available
            //NOTE: pulling back from CSV make sure you CAST to a string first

            for (int i = 0; i < num_rows; i++)
            {
                if (dgv_finance_csv_data.Rows[i].Cells[2].Value.ToString() == dateTimePicker1.Value.ToShortDateString())
                {
                    checkFlag = false; //it exists
                    MsgBox.Show("That date and has already been filled in", "Problem", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    break;
                }
            }


            if (checkFlag) //only add if data is not already been entered
            {
                dgv_finance_csv_data.Rows.Add(); //Add new row.

                dgv_finance_csv_data.Rows[num_rows].Cells[0].Value =
                    dgv_finance_csv_data.Rows[0].Cells[0].Value; //project name
                dgv_finance_csv_data.Rows[num_rows].Cells[1].Value =
                    dgv_finance_csv_data.Rows[0].Cells[1].Value; //Project phase
                dgv_finance_csv_data.Rows[num_rows].Cells[2].Value =
                    dateTimePicker1.Value.ToShortDateString(); //todays date
                dgv_finance_csv_data.Rows[num_rows].Cells[3].Value =
                    dgv_finance_csv_data.Rows[0].Cells[3].Value; //Start Date
                dgv_finance_csv_data.Rows[num_rows].Cells[4].Value =
                    dgv_finance_csv_data.Rows[0].Cells[4].Value; //Duration in weeks

                if (DateTime.TryParse(dgv_finance_csv_data.Rows[0].Cells[3].Value.ToString(),
                        out addDate)) //how long left in weeks
                {

                    dgv_finance_csv_data.Rows[num_rows].Cells[5].Value = Math.Abs((DateTime.Now
                        .Subtract(addDate.AddDays(
                            int.Parse(dgv_finance_csv_data.Rows[0].Cells[4].Value.ToString()) * 7)).Days) / 7);
                }

                dgv_finance_csv_data.Rows[num_rows].Cells[6].Value =
                    dgv_finance_csv_data.Rows[0].Cells[6].Value; // total in kitty
                dgv_finance_csv_data.Rows[num_rows].Cells[7].Value =
                    txtbx_project_income.Text; // amount we made this week

                //how much is left in kitty
                dgv_finance_csv_data.Rows[num_rows].Cells[8].Value =
                    (double.Parse(dgv_finance_csv_data.Rows[num_rows - 1].Cells[8].Value.ToString()) -
                     double.Parse(txtbx_project_income.Text)).ToString();

                //Sort by date
                dgv_people_csv_data.Sort(dgv_people_csv_data.Columns[2], ListSortDirection.Descending);
            }

        }
    }
}