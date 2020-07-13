using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TestCPU
{
    public partial class MainForm : Form
    {
        TestsCPU _tests = new TestsCPU();
        bool execTest = false;
        bool execPerf = false;
        Label activeLabel;
        Series activeSeries;
        TestsCPU.typeTest typeTest;
        DateTime stopWatch;
        string completeTime;
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fillGridView();
        }

        



        private void startStopButton_Click(object sender, EventArgs e)
        {
            if (execPerf || execTest)
            {
                execPerf = false;
                execTest = false;
                stopTest();
            }
            else
            {
                startTest();
            }
        }

        private void testsWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            _tests.StartTest(testsWorker, typeTest);
        }

        private void testsWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            testProgressStatusBar.Value = e.ProgressPercentage;
            activeLabel.Text = "Выполнение " + (DateTime.Now - stopWatch).Minutes + String.Format(":{0:d2}",(DateTime.Now - stopWatch).Seconds);
        }

        private void testsWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            execTest = false;
            completeTime = (DateTime.Now - stopWatch).Minutes + String.Format(":{0:d2}", (DateTime.Now - stopWatch).Seconds);
            stopTest();
        }


        private int performanceTimerTicks = 0;
        private void performanceTestTimer_Tick(object sender, EventArgs e)
        {
            performanceTimerTicks++;
            activeSeries.Points.Add(performanceCounter.NextValue());
            performanceProgressStatusBar.Value = performanceTimerTicks;
            if (performanceTimerTicks >= 100)
            {
                stopPerformanceTestTimer();
                stopTest();
            }
        }
        private Series selectChartSeries()
        {
            if (hashRadio.Checked)
                return chartTest.Series.Single(a => a.Name == "Хеш");
            if (cryptRadio.Checked)
                return chartTest.Series.Single(a => a.Name == "Шифр");
            if (compressRadio.Checked)
                return chartTest.Series.Single(a => a.Name == "Архив");
            if (imageRadio.Checked)
                return chartTest.Series.Single(a => a.Name == "Изобр");
            return chartTest.Series.FirstOrDefault();
        }

        private void startTest()
        {
            if (hashRadio.Checked)
            {
                activeLabel = hashTimeLabel;
                typeTest = TestsCPU.typeTest.hash;
            }
            if (cryptRadio.Checked)
            {
                activeLabel = cryptTimeLabel;
                typeTest = TestsCPU.typeTest.crypt;
            }
            if (compressRadio.Checked)
            {
                activeLabel = compressTimeLabel;
                typeTest = TestsCPU.typeTest.compress;
            }
            if (imageRadio.Checked)
            {
                activeLabel = imageTimeLabel;
                typeTest = TestsCPU.typeTest.image;
            }
            execTest = true;
            execPerf = true;
            methodBox.Enabled = false;
            startStopButton.Text = "Остановить тестирование";
            stopWatch = DateTime.Now;
            activeSeries = selectChartSeries();
            activeSeries.Points.Clear();
            performanceTestTimer.Start();
            testsWorker.RunWorkerAsync(typeTest);
        }
        private void stopTest()
        {
            if (execTest || execPerf)
                return;
            testsWorker.CancelAsync();
            stopPerformanceTestTimer();

            methodBox.Enabled = true;
            testProgressStatusBar.Value = 0;
            performanceProgressStatusBar.Value = 0;
            startStopButton.Text = "Начать тестирование";
            if (_tests.cancel)
            {
                performanceTestTimer.Stop();
                performanceTimerTicks = 0;
                activeSeries.Points.Clear();
                activeLabel.Text = "Отменено";
            }
            else
            {
                activeLabel.Text = "Готово " + completeTime;
            }
        }
        private void stopPerformanceTestTimer()
        {
            performanceTestTimer.Stop();
            performanceTimerTicks = 0;
            execPerf = false;
        }
        private void fillGridView()
        {
            ManagementClass managementClass = new ManagementClass("Win32_processor");
            ManagementObjectCollection managementCollection = managementClass.GetInstances();
            PropertyDataCollection myProperties = managementClass.Properties;
            //Dictionary myPropertyResults = new Dictionary();
            foreach (var obj in managementCollection)
            {
                foreach (var myProperty in myProperties)
                {
                    informationGrid.Rows.Add(myProperty.Name.ToString(), Convert.ToString(obj.Properties[myProperty.Name].Value));
                }
            }
        }
    }

}
