using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CenteredMessagebox;

namespace Project_Manager
{
    public partial class Form1
    {


        // Load a CSV file into an array of rows and columns.
        // Assume there may be blank lines but every line has
        // the same number of fields.
        private string[,] LoadCsv(string filename)
        {
            // Get the file's text.
            string whole_file = File.ReadAllText(filename);

            // Split into lines.
            whole_file = whole_file.Replace('\n', '\r');
            string[] lines = whole_file.Split(new char[] { '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            // See how many rows and columns there are.
            int num_rows = lines.Length;
            int num_cols = lines[0].Split(',').Length;

            // Allocate the data array.
            string[,] values = new string[num_rows, num_cols];

            // Load the array.
            for (int r = 0; r < num_rows; r++)
            {
                string[] line_r = lines[r].Split(',');
                for (int c = 0; c < num_cols; c++)
                {
                    values[r, c] = line_r[c];
                }
            }

            // Return the values.
            return values;
        }

        private void SaveCSVFile(DataGridView myDataGridView, string myType)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // choose correct heading for the save files dialog
            if (myType == "finance")
            {
                saveFileDialog1.Title = "Enter Name to save Finance CSV Files";
            }
            else if (myType == "people")
            {
                saveFileDialog1.Title = "Enter Name to save People CSV Files";
            }
            else
            {
                saveFileDialog1.Title = "Save CSV Files";
            }
            
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sb = new StringBuilder();

                    var headers = myDataGridView.Columns.Cast<DataGridViewColumn>();
                    sb.AppendLine(string.Join(",", headers.Select(column => column.HeaderText).ToArray()));

                    foreach (DataGridViewRow row in myDataGridView.Rows)
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
                    MsgBox.Show(exception.ToString(), "Save file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearCSV(DataGridView myDataGridView)
        {
           myDataGridView.Rows.Clear();
            myDataGridView.Refresh();
        }

    }
}

