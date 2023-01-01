using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using CenteredMessagebox;

namespace Project_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpbx_data_tab.Visible = false;

            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            HideTabs();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //save csv files
            // SaveCSVFile(dgv_finance_csv_data);
            // SaveCSVFile(dgv_people_csv_data);

            Close();
        }

        private void btn_open_project_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Open People File.",
                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string OpenFileName = openFileDialog1.FileName;
                lbl_update_file_in_use.Text += OpenFileName;
                DataGridView myDataGridView = dgv_people_csv_data;

                //loop twice to get both the CSV files into their respective DataGridViews.
                // CSV for People and CSV for Finance.
                
                for (int i = 0; i < 2; i++)
                {
                    try
                    {
                        // Get the data.
                        string[,] values = LoadCsv(OpenFileName);
                        int num_rows = values.GetUpperBound(0) + 1;
                        int num_cols = values.GetUpperBound(1) + 1;


                        // Display the data to show we have it.

                        // Make column headers.
                        // For this example, we assume the first row
                        // contains the column names.


                        myDataGridView.Columns.Clear();
                        for (int c = 0; c < num_cols; c++)
                            myDataGridView.Columns.Add(values[0, c], values[0, c]);

                        // Add the data.
                        for (int r = 1; r < num_rows; r++)
                        {
                            myDataGridView.Rows.Add();
                            for (int c = 0; c < num_cols; c++)
                            {
                                myDataGridView.Rows[r - 1].Cells[c].Value = values[r, c];
                            }
                        }

                        //// Make the columns autosize.
                        foreach (DataGridViewColumn col in myDataGridView.Columns)
                            //col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        if (i == 0)
                        {
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
                        }
                        else if (i == 1)
                        {
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

                        }

                        // if first populate the people stuff
                        //if second then populate the finance stuff

                    }
                    catch (Exception exception)
                    {
                        MsgBox.Show(exception.ToString(), "Cannot Open file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // change items for second time round loop
                    // Check if the file exists second time it is project_finance.csv


                    string fn = Path.GetFileNameWithoutExtension(OpenFileName);

                    fn = fn.Substring(0, fn.IndexOf('_'));
                    string dn = Path.GetDirectoryName(OpenFileName);

                    OpenFileName = dn + "\\" + fn + "_finance.csv";

                    if (File.Exists(OpenFileName))
                    {
                        //extract the project name to add ot the new file.

                        lbl_finance_file_in_use.Text += OpenFileName;
                        myDataGridView = dgv_finance_csv_data;
                    }
                    else
                    {
                        MsgBox.Show("Check the finance file exists", "File missing", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        break;
                    }
                }

                ShowTabs();
              
            }
        }
    }
}
