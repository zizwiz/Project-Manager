using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_Manager
{
    public partial class Form1
    {
        Point? prevPosition;
        ToolTip tooltip = new ToolTip();

        private void ShowToolTipValues(Chart myChart, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = myChart.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint); // set ChartElementType.PlottingArea for full area, not only DataPoints
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint) // set ChartElementType.PlottingArea for full area, not only DataPoints
                {
                    var yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);
                    tooltip.Show(((int)yVal).ToString(), myChart, pos.X, pos.Y - 15);
                }
            }
        }


        private void SaveChartAsImage(Chart chartToSave)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image Files|*.png|Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff";
            saveFileDialog.Title = "Save Chart Image As file";
            saveFileDialog.DefaultExt = ".png";
            saveFileDialog.FileName = "Sample.png";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {

                    var imgFormats = new Dictionary<string, ChartImageFormat>()
                    {
                        {".bmp", ChartImageFormat.Bmp},
                        {".gif", ChartImageFormat.Gif},
                        {".jpg", ChartImageFormat.Jpeg},
                        {".jpeg", ChartImageFormat.Jpeg},
                        {".png", ChartImageFormat.Png},
                        {".tiff", ChartImageFormat.Tiff},
                    };
                    
                    var fileExt = System.IO.Path.GetExtension(saveFileDialog.FileName).ToString().ToLower();
                    
                    if (imgFormats.ContainsKey(fileExt))
                    {
                        chartToSave.SaveImage(saveFileDialog.FileName, imgFormats[fileExt]);
                    }
                    else
                    {
                        throw new Exception(String.Format("Only image formats '{0}' supported", string.Join(", ", imgFormats.Keys)));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void ZoomChart(Chart chartToZoom, string chartAreaToZoom)
        {
            ChartArea zoomChartArea = chartToZoom.ChartAreas[chartAreaToZoom]; // get hold of chart

            // enable autoscroll
            zoomChartArea.AxisX.ScaleView.Zoomable = true;
            zoomChartArea.CursorX.AutoScroll = true;
            zoomChartArea.CursorX.IsUserSelectionEnabled = true; //adds reset button on left
            zoomChartArea.AxisX.ScaleView.SmallScrollSize = 100;
        }

        private void ClearChart(Chart myChart)
        {
            foreach (var series in myChart.Series)
            {
                series.Points.Clear();
            }

            myChart.Series.Clear();
        }
    }
}