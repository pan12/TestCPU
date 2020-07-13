namespace TestCPU
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTest = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.informationGrid = new System.Windows.Forms.DataGridView();
            this.testingBox = new System.Windows.Forms.GroupBox();
            this.compressTimeLabel = new System.Windows.Forms.Label();
            this.startStopButton = new System.Windows.Forms.Button();
            this.imageTimeLabel = new System.Windows.Forms.Label();
            this.labelStatusPerformance = new System.Windows.Forms.Label();
            this.labelStatusTest = new System.Windows.Forms.Label();
            this.cryptTimeLabel = new System.Windows.Forms.Label();
            this.methodBox = new System.Windows.Forms.GroupBox();
            this.hashRadio = new System.Windows.Forms.RadioButton();
            this.compressRadio = new System.Windows.Forms.RadioButton();
            this.cryptRadio = new System.Windows.Forms.RadioButton();
            this.imageRadio = new System.Windows.Forms.RadioButton();
            this.hashTimeLabel = new System.Windows.Forms.Label();
            this.performanceProgressStatusBar = new System.Windows.Forms.ProgressBar();
            this.testProgressStatusBar = new System.Windows.Forms.ProgressBar();
            this.testsWorker = new System.ComponentModel.BackgroundWorker();
            this.performanceCounter = new System.Diagnostics.PerformanceCounter();
            this.performanceTestTimer = new System.Windows.Forms.Timer(this.components);
            this.field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chartTest)).BeginInit();
            this.infoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informationGrid)).BeginInit();
            this.testingBox.SuspendLayout();
            this.methodBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTest
            // 
            this.chartTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartTest.BorderSkin.BorderWidth = 0;
            chartArea2.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea2.AxisX.Interval = 10D;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisX.MajorTickMark.LineWidth = 0;
            chartArea2.AxisX.Maximum = 100D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisX.MinorGrid.LineWidth = 0;
            chartArea2.AxisX.MinorTickMark.LineWidth = 0;
            chartArea2.AxisX.MinorTickMark.Size = 0F;
            chartArea2.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
            chartArea2.AxisY.Interval = 10D;
            chartArea2.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.ScaleView.MinSize = 100D;
            chartArea2.AxisY.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 95F;
            chartArea2.InnerPlotPosition.Width = 92F;
            chartArea2.InnerPlotPosition.X = 8F;
            chartArea2.InnerPlotPosition.Y = 5F;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 90F;
            chartArea2.Position.Width = 100F;
            chartArea2.Position.Y = 10F;
            this.chartTest.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.AutoFitMinFontSize = 8;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 10F;
            legend2.Position.Width = 80F;
            legend2.Position.X = 10F;
            this.chartTest.Legends.Add(legend2);
            this.chartTest.Location = new System.Drawing.Point(6, 193);
            this.chartTest.Name = "chartTest";
            this.chartTest.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Хеш";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series6.Legend = "Legend1";
            series6.Name = "Шифр";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Архив";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Изобр";
            this.chartTest.Series.Add(series5);
            this.chartTest.Series.Add(series6);
            this.chartTest.Series.Add(series7);
            this.chartTest.Series.Add(series8);
            this.chartTest.Size = new System.Drawing.Size(407, 194);
            this.chartTest.TabIndex = 0;
            // 
            // infoBox
            // 
            this.infoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoBox.AutoSize = true;
            this.infoBox.Controls.Add(this.informationGrid);
            this.infoBox.Location = new System.Drawing.Point(12, 12);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(368, 406);
            this.infoBox.TabIndex = 1;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Информация";
            // 
            // informationGrid
            // 
            this.informationGrid.AllowUserToAddRows = false;
            this.informationGrid.AllowUserToDeleteRows = false;
            this.informationGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.field,
            this.value});
            this.informationGrid.Location = new System.Drawing.Point(7, 20);
            this.informationGrid.Name = "informationGrid";
            this.informationGrid.ReadOnly = true;
            this.informationGrid.RowHeadersVisible = false;
            this.informationGrid.RowTemplate.ReadOnly = true;
            this.informationGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.informationGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.informationGrid.Size = new System.Drawing.Size(352, 367);
            this.informationGrid.TabIndex = 0;
            // 
            // testingBox
            // 
            this.testingBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testingBox.AutoSize = true;
            this.testingBox.Controls.Add(this.compressTimeLabel);
            this.testingBox.Controls.Add(this.startStopButton);
            this.testingBox.Controls.Add(this.imageTimeLabel);
            this.testingBox.Controls.Add(this.labelStatusPerformance);
            this.testingBox.Controls.Add(this.labelStatusTest);
            this.testingBox.Controls.Add(this.cryptTimeLabel);
            this.testingBox.Controls.Add(this.methodBox);
            this.testingBox.Controls.Add(this.hashTimeLabel);
            this.testingBox.Controls.Add(this.performanceProgressStatusBar);
            this.testingBox.Controls.Add(this.testProgressStatusBar);
            this.testingBox.Controls.Add(this.chartTest);
            this.testingBox.Location = new System.Drawing.Point(386, 12);
            this.testingBox.Name = "testingBox";
            this.testingBox.Size = new System.Drawing.Size(419, 406);
            this.testingBox.TabIndex = 2;
            this.testingBox.TabStop = false;
            this.testingBox.Text = "Тестирование";
            // 
            // compressTimeLabel
            // 
            this.compressTimeLabel.AutoSize = true;
            this.compressTimeLabel.Location = new System.Drawing.Point(177, 88);
            this.compressTimeLabel.Name = "compressTimeLabel";
            this.compressTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.compressTimeLabel.TabIndex = 4;
            // 
            // startStopButton
            // 
            this.startStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.startStopButton.Location = new System.Drawing.Point(297, 20);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(116, 104);
            this.startStopButton.TabIndex = 3;
            this.startStopButton.Text = "Начать тестирование";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // imageTimeLabel
            // 
            this.imageTimeLabel.AutoSize = true;
            this.imageTimeLabel.Location = new System.Drawing.Point(177, 111);
            this.imageTimeLabel.Name = "imageTimeLabel";
            this.imageTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.imageTimeLabel.TabIndex = 4;
            // 
            // labelStatusPerformance
            // 
            this.labelStatusPerformance.AutoSize = true;
            this.labelStatusPerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusPerformance.Location = new System.Drawing.Point(6, 141);
            this.labelStatusPerformance.Name = "labelStatusPerformance";
            this.labelStatusPerformance.Size = new System.Drawing.Size(143, 17);
            this.labelStatusPerformance.TabIndex = 2;
            this.labelStatusPerformance.Text = "Выполнение замера";
            // 
            // labelStatusTest
            // 
            this.labelStatusTest.AutoSize = true;
            this.labelStatusTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusTest.Location = new System.Drawing.Point(6, 170);
            this.labelStatusTest.Name = "labelStatusTest";
            this.labelStatusTest.Size = new System.Drawing.Size(132, 17);
            this.labelStatusTest.TabIndex = 2;
            this.labelStatusTest.Text = "Выполнение теста";
            // 
            // cryptTimeLabel
            // 
            this.cryptTimeLabel.AutoSize = true;
            this.cryptTimeLabel.Location = new System.Drawing.Point(177, 65);
            this.cryptTimeLabel.Name = "cryptTimeLabel";
            this.cryptTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.cryptTimeLabel.TabIndex = 4;
            // 
            // methodBox
            // 
            this.methodBox.Controls.Add(this.hashRadio);
            this.methodBox.Controls.Add(this.compressRadio);
            this.methodBox.Controls.Add(this.cryptRadio);
            this.methodBox.Controls.Add(this.imageRadio);
            this.methodBox.Location = new System.Drawing.Point(9, 19);
            this.methodBox.Name = "methodBox";
            this.methodBox.Size = new System.Drawing.Size(162, 108);
            this.methodBox.TabIndex = 1;
            this.methodBox.TabStop = false;
            this.methodBox.Text = "Метод тестирования";
            // 
            // hashRadio
            // 
            this.hashRadio.AutoSize = true;
            this.hashRadio.Checked = true;
            this.hashRadio.Location = new System.Drawing.Point(6, 19);
            this.hashRadio.Name = "hashRadio";
            this.hashRadio.Size = new System.Drawing.Size(94, 17);
            this.hashRadio.TabIndex = 4;
            this.hashRadio.TabStop = true;
            this.hashRadio.Text = "Хеширование";
            this.hashRadio.UseVisualStyleBackColor = true;
            // 
            // compressRadio
            // 
            this.compressRadio.AutoSize = true;
            this.compressRadio.Location = new System.Drawing.Point(6, 65);
            this.compressRadio.Name = "compressRadio";
            this.compressRadio.Size = new System.Drawing.Size(103, 17);
            this.compressRadio.TabIndex = 4;
            this.compressRadio.Text = "Архивирование";
            this.compressRadio.UseVisualStyleBackColor = true;
            // 
            // cryptRadio
            // 
            this.cryptRadio.AutoSize = true;
            this.cryptRadio.Location = new System.Drawing.Point(6, 42);
            this.cryptRadio.Name = "cryptRadio";
            this.cryptRadio.Size = new System.Drawing.Size(90, 17);
            this.cryptRadio.TabIndex = 4;
            this.cryptRadio.Text = "Шифрование";
            this.cryptRadio.UseVisualStyleBackColor = true;
            // 
            // imageRadio
            // 
            this.imageRadio.AutoSize = true;
            this.imageRadio.Location = new System.Drawing.Point(6, 88);
            this.imageRadio.Name = "imageRadio";
            this.imageRadio.Size = new System.Drawing.Size(151, 17);
            this.imageRadio.TabIndex = 4;
            this.imageRadio.Text = "Обработка изображения";
            this.imageRadio.UseVisualStyleBackColor = true;
            // 
            // hashTimeLabel
            // 
            this.hashTimeLabel.AutoSize = true;
            this.hashTimeLabel.Location = new System.Drawing.Point(177, 42);
            this.hashTimeLabel.Name = "hashTimeLabel";
            this.hashTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.hashTimeLabel.TabIndex = 4;
            // 
            // performanceProgressStatusBar
            // 
            this.performanceProgressStatusBar.Location = new System.Drawing.Point(155, 135);
            this.performanceProgressStatusBar.Name = "performanceProgressStatusBar";
            this.performanceProgressStatusBar.Size = new System.Drawing.Size(258, 23);
            this.performanceProgressStatusBar.TabIndex = 1;
            // 
            // testProgressStatusBar
            // 
            this.testProgressStatusBar.Location = new System.Drawing.Point(155, 164);
            this.testProgressStatusBar.Name = "testProgressStatusBar";
            this.testProgressStatusBar.Size = new System.Drawing.Size(258, 23);
            this.testProgressStatusBar.TabIndex = 1;
            // 
            // testsWorker
            // 
            this.testsWorker.WorkerReportsProgress = true;
            this.testsWorker.WorkerSupportsCancellation = true;
            this.testsWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.testsWorker_DoWork);
            this.testsWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.testsWorker_ProgressChanged);
            this.testsWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.testsWorker_RunWorkerCompleted);
            // 
            // performanceCounter
            // 
            this.performanceCounter.CategoryName = "Processor";
            this.performanceCounter.CounterName = "% Processor Time";
            this.performanceCounter.InstanceName = "_Total";
            // 
            // performanceTestTimer
            // 
            this.performanceTestTimer.Interval = 500;
            this.performanceTestTimer.Tick += new System.EventHandler(this.performanceTestTimer_Tick);
            // 
            // field
            // 
            this.field.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.field.HeaderText = "Поле";
            this.field.Name = "field";
            this.field.ReadOnly = true;
            // 
            // value
            // 
            this.value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value.HeaderText = "Значение";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 430);
            this.Controls.Add(this.testingBox);
            this.Controls.Add(this.infoBox);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "MainForm";
            this.Text = "TestCPU";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTest)).EndInit();
            this.infoBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.informationGrid)).EndInit();
            this.testingBox.ResumeLayout(false);
            this.testingBox.PerformLayout();
            this.methodBox.ResumeLayout(false);
            this.methodBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTest;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.GroupBox testingBox;
        private System.Windows.Forms.Label labelStatusTest;
        private System.Windows.Forms.ProgressBar testProgressStatusBar;
        private System.Windows.Forms.GroupBox methodBox;
        private System.Windows.Forms.RadioButton hashRadio;
        private System.Windows.Forms.RadioButton imageRadio;
        private System.Windows.Forms.RadioButton compressRadio;
        private System.Windows.Forms.RadioButton cryptRadio;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Label hashTimeLabel;
        private System.Windows.Forms.Label compressTimeLabel;
        private System.Windows.Forms.Label imageTimeLabel;
        private System.Windows.Forms.Label cryptTimeLabel;
        private System.Windows.Forms.DataGridView informationGrid;
        private System.ComponentModel.BackgroundWorker testsWorker;
        private System.Windows.Forms.Label labelStatusPerformance;
        private System.Windows.Forms.ProgressBar performanceProgressStatusBar;
        private System.Diagnostics.PerformanceCounter performanceCounter;
        private System.Windows.Forms.Timer performanceTestTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn field;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
    }
}

