namespace Proj_Desktop_App.presentation
{
    partial class StatisticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DateTimePickerStartingDate = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerEndingDate = new System.Windows.Forms.DateTimePicker();
            this.TopTenProductStatisticChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGetGraph = new System.Windows.Forms.Button();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TopTenProductStatisticChart)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimePickerStartingDate
            // 
            this.DateTimePickerStartingDate.Location = new System.Drawing.Point(47, 66);
            this.DateTimePickerStartingDate.Name = "DateTimePickerStartingDate";
            this.DateTimePickerStartingDate.Size = new System.Drawing.Size(223, 20);
            this.DateTimePickerStartingDate.TabIndex = 2;
            // 
            // DateTimePickerEndingDate
            // 
            this.DateTimePickerEndingDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateTimePickerEndingDate.Location = new System.Drawing.Point(797, 66);
            this.DateTimePickerEndingDate.Name = "DateTimePickerEndingDate";
            this.DateTimePickerEndingDate.Size = new System.Drawing.Size(223, 20);
            this.DateTimePickerEndingDate.TabIndex = 3;
            // 
            // TopTenProductStatisticChart
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.TopTenProductStatisticChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TopTenProductStatisticChart.Legends.Add(legend1);
            this.TopTenProductStatisticChart.Location = new System.Drawing.Point(47, 92);
            this.TopTenProductStatisticChart.Name = "TopTenProductStatisticChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.TopTenProductStatisticChart.Series.Add(series1);
            this.TopTenProductStatisticChart.Size = new System.Drawing.Size(973, 346);
            this.TopTenProductStatisticChart.TabIndex = 6;
            this.TopTenProductStatisticChart.Text = "chart1";
            // 
            // btnGetGraph
            // 
            this.btnGetGraph.Location = new System.Drawing.Point(742, 65);
            this.btnGetGraph.Name = "btnGetGraph";
            this.btnGetGraph.Size = new System.Drawing.Size(49, 21);
            this.btnGetGraph.TabIndex = 7;
            this.btnGetGraph.Text = "Search";
            this.btnGetGraph.UseVisualStyleBackColor = true;
            this.btnGetGraph.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(435, 65);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(259, 21);
            this.cbDepartment.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Department : ";
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 595);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.btnGetGraph);
            this.Controls.Add(this.TopTenProductStatisticChart);
            this.Controls.Add(this.DateTimePickerEndingDate);
            this.Controls.Add(this.DateTimePickerStartingDate);
            this.Name = "StatisticForm";
            this.Text = "StatisticForm";
            ((System.ComponentModel.ISupportInitialize)(this.TopTenProductStatisticChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DateTimePickerStartingDate;
        private System.Windows.Forms.DateTimePicker DateTimePickerEndingDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart TopTenProductStatisticChart;
        private System.Windows.Forms.Button btnGetGraph;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label1;
    }
}