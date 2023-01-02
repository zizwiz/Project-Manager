using System;
using System.ComponentModel;
using System.Windows.Forms;
using CenteredMessagebox;

namespace Project_Manager
{
    public partial class Form1
    {
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

                dgv_finance_csv_data.Rows[num_rows].Cells[9].Value =
                    int.Parse(dgv_finance_csv_data.Rows[num_rows].Cells[8].Value.ToString()) /
                    int.Parse(dgv_finance_csv_data.Rows[num_rows].Cells[5].Value.ToString());


                //Sort by date
                dgv_finance_csv_data.Sort(dgv_finance_csv_data.Columns[2], ListSortDirection.Descending);
            }

        }

        private void btn_save_finance_csv_file_Click(object sender, EventArgs e)
        {
            SaveCSVFile(dgv_finance_csv_data, "finance");
        }
    }
}