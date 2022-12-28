using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_Manager
{
    public partial class Form1
    {
        private void btn_draw_hours_chart_Click(object sender, EventArgs e)
        {
            DrawPeoplesWorkedHoursChart();
        }

        private void DrawPeoplesWorkedHoursChart()
        {
            ClearPeoplesWorkedHoursChart();

            Series projected = chrt_peoples_work_hours.Series.Add("Projected Hours");
            Series acheived = chrt_peoples_work_hours.Series.Add("Acheived Hours");
            chrt_peoples_work_hours.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chrt_peoples_work_hours.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chrt_peoples_work_hours.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chrt_peoples_work_hours.ChartAreas[0].AxisX.MinorGrid.Enabled = false;


            //get each person by ID in turn
            foreach (string id in cmbobx_update_id.Items)
            {
                double projected_hours = 0.0;
                double acheived_hours = 0.0;

                //loop through the datagridview and extract the hours for said person.
                foreach (DataGridViewRow row in dgv_csv_data.Rows)
                {
                    if (row.Cells[4].Value.ToString() == id)
                    {
                        projected_hours += double.Parse(row.Cells[5].Value.ToString());
                        acheived_hours += double.Parse(row.Cells[6].Value.ToString());
                    }
                }
                
                //Draw the data into the graph
                projected.Points.AddXY(id, projected_hours);
                acheived.Points.AddXY(id, acheived_hours);
            }

            //Allow the chart to be zoomable.
            ZoomChart(chrt_peoples_work_hours, "ChartArea1");
        }

        private void btn_clear_hours_chart_Click(object sender, EventArgs e)
        {
            ClearPeoplesWorkedHoursChart();
        }

        private void ClearPeoplesWorkedHoursChart()
        {
            foreach (var series in chrt_peoples_work_hours.Series)
            {
                series.Points.Clear();
            }

            chrt_peoples_work_hours.Series.Clear();
        }

        //Show the Values in a tooltip
        private void chrt_peoples_work_hours_MouseMove(object sender, MouseEventArgs e)
        {
            ShowToolTipValues(chrt_peoples_work_hours, e);
        }

        //Save the chart as an image
        private void btn_Save_Chart_Image_Click(object sender, EventArgs e)
        {
            SaveChartAsImage(chrt_peoples_work_hours);
        }
    }
}