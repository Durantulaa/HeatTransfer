using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace HeatTransfer
{
    public partial class MainForm : Form
    {
        private int temp;
        private int time;
        private int startTime = 1; //second
        private int maxBallTemp = 100; //°C
        private int minBallTemp = -20; //°C
        private int maxTime = 180; //second
        private int ballPointY = 300;
        private int ballEndPointY = 300;


        private double BallRidius = 0.01; //  radius of the ball in meters
        private double HeatCapacityOfStell = 0.45; //  J/g°C
        //private double densityOfBall = 7.8; //density of steel in g/cm^3
        private double thermalConducivityOfSteel = 50.2; //  w/m°C
        private double mass = 0.0103;//kg

        private Dictionary<int, int> resultItems = new Dictionary<int, int>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.startTime = 1;
            String steelBallTemp = txtSteelBallTemp.Text;
            String chooseTime = txtChooseTime.Text;
            int temp;
            if (!int.TryParse(steelBallTemp, out temp) || temp >= maxBallTemp || temp <= minBallTemp)
            {
                MessageBox.Show("The ball temp between -20°C - 100°C, please correct your type and try again.", "Invalid input");
                txtSteelBallTemp.Clear();
                return;
            }
            this.temp = temp;

            int time;
            if (!int.TryParse(chooseTime, out time) || time >= maxTime || time <= 0)
            {
                MessageBox.Show("Please choose the time between 1 to 180 seconds, please correct your type and try again.", "Invalid input");
                txtChooseTime.Clear();
                return;
            }
            this.time = time;

            this.btnStart.Enabled = false;
            this.btnReset.Enabled = false;

            showResult();

            tmrAnimation.Start();

        }
        
        private List<ResultItem> caculatedResult()
        {
            //caculate the surface area of the ball
            double ballSurfaceArea = 4 * Math.PI * Math.Pow(BallRidius, 2);

            List<ResultItem> result = new List<ResultItem>();
            double prevTemp = this.temp;
            double deltaT = 100 - this.temp;
            double heatTransfer = HeatCapacityOfStell * mass * deltaT; //0.45*0.0103*80 = 50.2*0.00126(t-20)

            for (int i = 1; i <= this.time; i++)
            {
                

                double balltemp1 = heatTransfer / ( thermalConducivityOfSteel * ballSurfaceArea) + prevTemp;

                prevTemp = balltemp1;
                deltaT = deltaT - i;
                heatTransfer = HeatCapacityOfStell * mass * deltaT;


                int balltemp3 = (int)balltemp1;
                ResultItem item = new ResultItem(i, balltemp3);

                result.Add(item);
                this.resultItems.Add(i, balltemp3);
                 
            }
            
            return result;
        }

        private void showResult()
        {
            List<ResultItem> resultItemList = caculatedResult();
            
            dgvResult.DataSource = resultItemList;

            //save to csv file need to open with Excel
            using(StreamWriter writer = new StreamWriter("result.csv"))
            {
                writer.WriteLine("Time,BallTemp");
                foreach (ResultItem data in resultItemList)
                {
                    writer.WriteLine(data.ToString());
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            this.txtChooseTime.Clear();
            this.txtSteelBallTemp.Clear();
            this.animation1.ballPositionY = 0;
            this.animation1.displayTemp("");
            this.resultItems.Clear();
            this.dgvResult.DataSource = this.resultItems;
            this.lblDisplayTime.Text = "";
        }
        
        private void tmrAnimation_Tick(object sender, EventArgs e)
        {
            if (this.animation1.ballPositionY < this.ballEndPointY)
            {
                this.animation1.ballPositionY += 20;
                this.animation1.Refresh();
            } else
            {
                tmrAnimation.Stop();
                tmrTempAnimation.Start();
            }
        }
        
        private void tmrTempAnimation_Tick(object sender, EventArgs e)
        {
            if (this.startTime <= this.time)
            {
                this.lblDisplayTime.Text = this.startTime.ToString();
                this.animation1.displayTemp("Ball temp: " + this.resultItems[this.startTime].ToString() + "°C");
                if (this.dgvResult.SelectedRows.Count > 0)
                {
                    this.dgvResult.SelectedRows[0].Selected = false;
                }
                this.dgvResult.Rows[this.startTime - 1].Selected = true;
                this.startTime++;
            }
            else
            {
                tmrTempAnimation.Stop();
                this.btnStart.Enabled = true;
                this.btnReset.Enabled = true;
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Heat transfer program allow user type in the steel ball initial temperature and the time period, " +
                "and  provide an opportunity to observe how the temperature of the ball changes over time as it equilibrates with the surrounding water. " +
                "when you click start button, this program will use this data to calculate the change in temperature over time. " +
                "By analyzing the temperature data, we can gain a better understanding of the heat transfer properties of the steel ball " +
                "and how it responds to changes in its environment. ");
        }

   
    }
}
