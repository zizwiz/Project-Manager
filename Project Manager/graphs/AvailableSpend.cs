using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_Manager
{
    public partial class Form1
    {





        private void btn_available_spend_chart_draw_Click(object sender, EventArgs e)
        {
            DrawAvailableSpendChart();
        }

        private void DrawAvailableSpendChart()
        {
            ClearChart(chrt_available_spend);

            Series AvailableToSpend = chrt_available_spend.Series.Add("Available to Spend");
            AvailableToSpend.ChartType = SeriesChartType.FastLine;
            Series ActualSpend = chrt_available_spend.Series.Add("Actual Spend");
            ActualSpend.ChartType = SeriesChartType.FastLine;
            Series AverageToSpend = chrt_available_spend.Series.Add("Average to Spend");
            AverageToSpend.ChartType = SeriesChartType.FastLine;

            chrt_available_spend.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chrt_available_spend.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chrt_available_spend.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chrt_available_spend.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chrt_available_spend.ChartAreas[0].AxisX.IsMarginVisible = false; //start it at the first item


            //draw the ave weekly available client spend
            int numWeeks = int.Parse(dgv_finance_csv_data.Rows[0].Cells[5].Value.ToString());
            double AveWeeklySpend = int.Parse(dgv_finance_csv_data.Rows[0].Cells[6].Value.ToString()) / numWeeks;
            
            for (int i = 0; i < numWeeks + 1; i++)
            {
                AverageToSpend.Points.AddXY(i, AveWeeklySpend);
            }


            for (int i = 0; i < dgv_finance_csv_data.RowCount; i++)
            {
                ActualSpend.Points.AddXY(i, int.Parse(dgv_finance_csv_data.Rows[i].Cells[7].Value.ToString()));
            }

            int asd = (numWeeks - dgv_finance_csv_data.RowCount)+2;

            for (int i = asd; i < numWeeks+1; i++)
            {
               // ActualSpend.Points.AddXY(i, int.Parse(dgv_finance_csv_data.Rows[dgv_finance_csv_data.RowCount-1].Cells[9].Value.ToString()));
                AvailableToSpend.Points.AddXY(i, int.Parse(dgv_finance_csv_data.Rows[dgv_finance_csv_data.RowCount - 1].Cells[9].Value.ToString()));
            }
        }

        private void btn_available_spend_chart_clear_Click(object sender, EventArgs e)
        {
            ClearChart(chrt_available_spend);
        }

        private void btn_available_spend_chart_save_Click(object sender, EventArgs e)
        {
            SaveChartAsImage(chrt_available_spend);
        }

        private void chrt_available_spend_MouseMove(object sender, MouseEventArgs e)
        {
            ShowToolTipValues(chrt_available_spend, e);
        }
    }
}
