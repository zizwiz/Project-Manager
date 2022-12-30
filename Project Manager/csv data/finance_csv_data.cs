using System;
using System.Windows.Forms;

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
                    //First we load in the Data file regarding peoples hours

                    //Load filename into the update page so we can use it later
                    lbl_finance_file_in_use.Text += openFileDialog1.FileName;

                    // Get the data.
                    string[,] values = LoadCsv(openFileDialog1.FileName);
                    int num_rows = values.GetUpperBound(0) + 1;
                    int num_cols = values.GetUpperBound(1) + 1;

                    lbl_project_finance_name.Text += values[1, 0];
                    lbl_project_finance_phase.Text += values[1, 1];

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

                    if (DateTime.TryParse(dgv_finance_csv_data.Rows[0].Cells[3].Value.ToString(), out addDate))
                    {
                        lbl_project_end.Text += addDate.AddDays(Int32.Parse(dgv_finance_csv_data.Rows[0].Cells[4].Value.ToString()) * 7).ToShortDateString();
                    }
                    
                    lbl_project_time_remaining.Text +=
                        Math.Abs((DateTime.Now
                            .Subtract(addDate.AddDays(
                                int.Parse(dgv_finance_csv_data.Rows[0].Cells[4].Value.ToString()) * 7)).Days) / 7)
                        + " weeks";
                    
                    lbl_project_value.Text += Convert.ToInt32(dgv_finance_csv_data.Rows[0].Cells[6].Value).ToString("C0");
                    
                    txtbx_project_income.Text = Convert.ToInt32(dgv_finance_csv_data.Rows[num_rows-2].Cells[7].Value).ToString("C0");
                    
                    lbl_project_money_remaining.Text += Convert.ToInt32(dgv_finance_csv_data.Rows[num_rows-2].Cells[8].Value).ToString("C0");


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
    }
}