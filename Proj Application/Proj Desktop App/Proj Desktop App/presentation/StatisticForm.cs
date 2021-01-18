using K4os.Hash.xxHash;
using Proj_Desktop_App.logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proj_Desktop_App.presentation
{
    public partial class StatisticForm : Form
    {
        StatisticStorage statistic;
        public StatisticForm(DepartmentStorage deptStorage)
        {
            InitializeComponent();
            statistic = new StatisticStorage(deptStorage);
            Initialize_Department_ComboBox(deptStorage);
            DateTime date = DateTime.Today;
            DateTimePickerStartingDate.Value = new DateTime(date.Year, 1, 1);
            DateTimePickerEndingDate.Value = date;
            ShowTopTenSellingOfThePeriod(DateTimePickerStartingDate.Value, DateTimePickerEndingDate.Value,true);
        }

        private void Initialize_Department_ComboBox(DepartmentStorage deptStorage)
        {
            cbDepartment.Items.Add("ALL");
            foreach (Department x in deptStorage.GetSellingDepartments())
            {
                cbDepartment.Items.Add(x.Name);
            }
            cbDepartment.Text = "ALL";
        }
        public void ShowTopTenSellingOfThePeriod(DateTime StartingDate,DateTime EndingDate,bool Sorted)
        {
            List<Sale> SaleHistory = new List<Sale>();
            try
            {
                if (cbDepartment.Text == "ALL") 
                {
                    if (statistic.GetSellingData(StartingDate, EndingDate) == null)
                    {
                        return;
                    }
                    else
                    {
                        SaleHistory.AddRange(statistic.GetSellingData(StartingDate, EndingDate));
                    }
                }
                else 
                {

                    if (statistic.GetSellingData(StartingDate, EndingDate) == null)
                    {
                        return;
                    }
                    else
                    {
                        SaleHistory.AddRange(statistic.GetSellingDataByDepartment(StartingDate, EndingDate, cbDepartment.Text));
                    }
                }
                if (SaleHistory.Count >= 10)
                {
                    SaleHistory = SaleHistory.Take(10).ToList();
                    TopTenProductStatisticChart.Titles.Add("Top 10 Produts From " + StartingDate.ToString("yyyy-MM-dd") + " To " + EndingDate.ToString("yyyy-MM-dd") +" On Department : "+cbDepartment.Text);
                }
                else { TopTenProductStatisticChart.Titles.Add("Top " + SaleHistory.Count + " Produt(s) From " + StartingDate.ToString("yyyy-MM-dd") + " To " + EndingDate.ToString("yyyy-MM-dd") + " On Department : " + cbDepartment.Text); }
                TopTenProductStatisticChart.Legends.Clear();
                TopTenProductStatisticChart.Series.Clear();
                TopTenProductStatisticChart.Series.Add("Sale");
                TopTenProductStatisticChart.Series["Sale"].ChartType = SeriesChartType.Bar;
                TopTenProductStatisticChart.Titles.Clear();
                if (Sorted == true) { SaleHistory.Sort(); }
                for (int i = 0; i < SaleHistory.Count; i++)
                {
                    TopTenProductStatisticChart.Series["Sale"].Points.AddXY(SaleHistory[i].ProductName +"("+ SaleHistory[i].Departmentname+")", SaleHistory[i].SoldAmount);
                    TopTenProductStatisticChart.Series["Sale"].Points[i].IsValueShownAsLabel = true;
                }
                //TopTenProductStatisticChart.Series.Clear();
                //TopTenProductStatisticChart.Series.Add("Floor One");
                //TopTenProductStatisticChart.Series["Floor One"].ChartType = SeriesChartType.Bar;
                //TopTenProductStatisticChart.Titles.Clear();
                //if (Sorted == true) { SaleHistory.Sort(); }
                //for (int i = 0; i < SaleHistory.Count; i++)
                //{
                //    TopTenProductStatisticChart.Series["Floor One"].Points.AddXY("Floor One", SaleHistory[i].SoldAmount);
                //    TopTenProductStatisticChart.Series["Floor One"].Points[i].Label = SaleHistory[i].ProductName + " -- "+SaleHistory[i].SoldAmount;
                //    TopTenProductStatisticChart.Series["Floor One"].Points[i].IsValueShownAsLabel = true;
                //}

                //TopTenProductStatisticChart.Series.Add("Floor Two");
                //TopTenProductStatisticChart.Series["Floor Two"].ChartType = SeriesChartType.Bar;
                //TopTenProductStatisticChart.Series["Floor Two"].Points.AddXY("Test Product A",80);


                //TopTenProductStatisticChart.Series.Add("Floor Three");
                //TopTenProductStatisticChart.Series["Floor Three"].ChartType = SeriesChartType.Bar;
                //TopTenProductStatisticChart.Series["Floor Three"].Points.AddXY("Text Product B", 99);



                //TopTenProductStatisticChart.Series.Add("Floor Four");
                //TopTenProductStatisticChart.Series["Floor Four"].ChartType = SeriesChartType.Bar;
                //TopTenProductStatisticChart.Series["Floor Four"].Points.AddXY("Test Product C", 87);

            }
            catch
            {
                MessageBox.Show("Data does not exist");
            }
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            ShowTopTenSellingOfThePeriod(DateTimePickerStartingDate.Value, DateTimePickerEndingDate.Value,true);
        }
    }
}
