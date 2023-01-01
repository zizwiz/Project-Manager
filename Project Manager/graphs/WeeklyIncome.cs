using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_Manager
{
    public partial class Form1
    {
        private void btn_weekly_income_chart_draw_Click(object sender, EventArgs e)
        {
            ClearPeoplesWorkedHoursChart(chrt_weekly_income);

            Series WeeklyIncome = chrt_weekly_income.Series.Add("Weekly Income");
            WeeklyIncome.ChartType = SeriesChartType.FastLine;
            Series SpendLine = chrt_weekly_income.Series.Add("Spend Line");
            SpendLine.ChartType = SeriesChartType.FastLine;

            chrt_weekly_income.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chrt_weekly_income.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chrt_weekly_income.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chrt_weekly_income.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chrt_weekly_income.ChartAreas[0].AxisX.IsMarginVisible = false; //start it at the first item

            //draw the weekly available client spend
            int numWeeks = int.Parse(dgv_finance_csv_data.Rows[0].Cells[5].Value.ToString());
            double WeeklySpend = int.Parse(dgv_finance_csv_data.Rows[0].Cells[6].Value.ToString()) / numWeeks;
            double WeeklySpendValue = 0;

            for (int i = 0; i < numWeeks+1; i++)
            {
                SpendLine.Points.AddXY(i, WeeklySpendValue);
                WeeklySpendValue += WeeklySpend;
            }
            

            //draw the weekly income from peoples work
            int numRowCount = dgv_finance_csv_data.RowCount;
            double WeeklyIncomeValue = 0;

            for (int j = 0; j < numRowCount; j++)
            {
                WeeklyIncomeValue += int.Parse(dgv_finance_csv_data.Rows[j].Cells[7].Value.ToString());
                WeeklyIncome.Points.AddXY(j, WeeklyIncomeValue);
            }
            
            
            




            //Allow the chart to be zoomable.
            ZoomChart(chrt_weekly_income, "ChartArea1");
        }

        private void chrt_weekly_income_MouseMove(object sender, MouseEventArgs e)
        {
            ShowToolTipValues(chrt_weekly_income, e);
        }

        private void btn_weekly_income_chart_clear_Click(object sender, EventArgs e)
        {
            ClearPeoplesWorkedHoursChart(chrt_weekly_income);
        }

        private void btn_weekly_income_chart_save_Click(object sender, EventArgs e)
        {
            SaveChartAsImage(chrt_weekly_income);
        }

    }
}