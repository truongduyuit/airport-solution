using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirPort
{
    public partial class frm : Form
    {
        private AirPortClass airPort;
        private Gate gateA, gateB, gateC;
        private int aCount, bCount, cCount;
        private Timer runtime, looptime;

        public frm()
        {
            InitializeComponent();

            airPort = AirPortClass.GetInstance();
            gateA = AirPortClass.GetInstance().gates[0];
            gateB = AirPortClass.GetInstance().gates[1];
            gateC = AirPortClass.GetInstance().gates[2];


            runtime = new Timer();
            runtime.Interval = 1000;
            runtime.Tick += Runtime_Tick;

            looptime = new Timer();
            looptime.Interval = Constand.LOOP_TIME;
            looptime.Tick += Looptime_Tick;
        }

        private void btnRunPause_Click(object sender, EventArgs e)
        {
            if (runtime.Enabled)
            {
                runtime.Stop();
                looptime.Stop();
                btnRunPause.Text = "Run";
            }
            else
            {
                runtime.Start();
                looptime.Start();
                btnRunPause.Text = "Pause";
            }
        }

        private void Looptime_Tick(object sender, EventArgs e)
        {
            // Tạo hành khách
            airPort.RandomPassenger();
        }

        private void Runtime_Tick(object sender, EventArgs e)
        {
            // Clear hành khách
            RemoveControl();

            // Phần thời gian xử lý thông tin hành khách
            airPort.CountDownProcessTime();

            // Hiển thị hành khách
            ShowPassengers();

            // Xuất thời gian xử lý của hành khách hiện tại còn lại
            GateAProcessTimeRest.Text = gateA.currentProcessTime.ToString();
            GateBProcessTimeRest.Text = gateB.currentProcessTime.ToString();
            GateCProcessTimeRest.Text = gateC.currentProcessTime.ToString();

            // Dồn hành khách
            airPort.TranferPassenger();
        }

        private void ShowPassengers()
        {
            aCount = gateA.passengers.Count;
            bCount = gateB.passengers.Count;
            cCount = gateC.passengers.Count;

            if (aCount > 0)
            {
                if (aCount <= 3)
                {
                    for (int i = 0; i < aCount; i++)
                    {
                        try
                        {
                            Passenger passenger = gateA.passengers[i];
                            ShowAPassenger(160, 50 + 100 * i, passenger.avatar);
                        }
                        catch { }
                    }
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        try
                        {
                            Passenger passenger = gateA.passengers[i];
                            ShowAPassenger(160, 50 + 100 * i, passenger.avatar);
                        }
                        catch { }
                    }
                }

                btnRestA.Text = aCount - Constand.PASSENGER_SHOW_MAX > 0 ? (aCount - Constand.PASSENGER_SHOW_MAX).ToString() : "0";
            }

            if (bCount > 0)
            {
                if (bCount <= 3)
                {
                    for (int i = 0; i < bCount; i++)
                    {
                        try
                        {
                            Passenger passenger = gateB.passengers[i];
                            ShowAPassenger(350, 50 + 100 * i, passenger.avatar);
                        }
                        catch { }
                    }
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        try
                        {
                            Passenger passenger = gateB.passengers[i];
                            ShowAPassenger(350, 50 + 100 * i, passenger.avatar);
                        }
                        catch { }
                    }
                }

                btnRestB.Text = bCount - Constand.PASSENGER_SHOW_MAX > 0 ? (bCount - Constand.PASSENGER_SHOW_MAX).ToString() : "0";
            }

            if (gateC.passengers.Count > 0)
            {
                if (cCount <= 3)
                {
                    for (int i = 0; i < cCount; i++)
                    {
                        try
                        {
                            Passenger passenger = gateC.passengers[i];
                            ShowAPassenger(530, 50 + 100 * i, passenger.avatar);
                        }
                        catch { }
                    }
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Passenger passenger = gateC.passengers[i];
                        ShowAPassenger(530, 50 + 100 * i, passenger.avatar);
                    }
                }

                btnRestC.Text = cCount - Constand.PASSENGER_SHOW_MAX > 0 ? (cCount - Constand.PASSENGER_SHOW_MAX).ToString() : "0";
            }
        }

        private void ShowAPassenger(int x, int y, string avatar)
        {
            CircularButton btn = new CircularButton();
            btn.Size = new Size(Constand.PASSENGER_AVATAR_SIZE_X, Constand.PASSENGER_AVATAR_SIZE_Y);
            btn.Location = new Point(x, y);

            btn.BackgroundImage = new Bitmap(Application.StartupPath + avatar);
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            panelMain.Controls.Add(btn);
        }

        public void RemoveControl()
        {
            panelMain.Controls.Clear();
        }

    }
}
