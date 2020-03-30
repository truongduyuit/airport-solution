using System.Drawing;
using System.Windows.Forms;

namespace AirPort
{
    public partial class frmMain : Form
    {
        //private bool pause = false;
        private AirPortClass airPort;
        private Gate gateA, gateB, gateC;
        private int aCount, bCount, cCount;

        public frmMain()
        {
            InitializeComponent();

            airPort = AirPortClass.GetInstance();
            gateA = AirPortClass.GetInstance().gates[0];
            gateB = AirPortClass.GetInstance().gates[1];
            gateC = AirPortClass.GetInstance().gates[2];

            timerCountDown.Start();
        }

        private void timerCountDown_Tick(object sender, System.EventArgs e)
        {

            // Phần thời gian xử lý thông tin hành khách
            airPort.CountDownProcessTime();

            // Clear hành khách
            RemoveControl();

            // Tạo hành khách
            airPort.RandomPassenger();

            // Hiển thị hành khách
            aCount = gateA.passengers.Count;
            bCount = gateB.passengers.Count;
            cCount = gateC.passengers.Count;

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
            //// Gate A
            if (aCount > 0)
            {               
                if (aCount <= 3)
                {
                    for (int i = 0; i < cCount -1; i++)
                    {
                        try
                        {
                            Passenger passenger = gateA.passengers[i];
                            ShowAPassenger(3, 3 + 80 * i, GetBackgroundColor(passenger), passenger.avatar);
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
                            ShowAPassenger(3, 3 + 80 * i, GetBackgroundColor(passenger), passenger.avatar);
                        }
                        catch { }
                    }
                }
                
            }

            if (bCount > 0)
            {
                if (bCount <= 3)
                {
                    for (int i = 0; i < cCount; i++)
                    {
                        try
                        {
                            Passenger passenger = gateB.passengers[i];
                            ShowAPassenger(202, 3 + 80 * i, GetBackgroundColor(passenger), passenger.avatar);
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
                            ShowAPassenger(202, 3 + 80 * i, GetBackgroundColor(passenger), passenger.avatar);
                        }
                        catch { }
                    }
                }               
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
                            ShowAPassenger(401, 3 + 80 * i, GetBackgroundColor(passenger), passenger.avatar);
                        }
                        catch { }
                    }
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Passenger passenger = gateC.passengers[i];
                        ShowAPassenger(401, 3 + 80 * i, GetBackgroundColor(passenger), passenger.avatar);
                    }
                }               
            }
        }

        private void ShowAPassenger(int x, int y, Color color, string avatar)
        {
            CircularButton btn = new CircularButton();
            btn.Size = new Size(Constand.PASSENGER_AVATAR_SIZE_X, Constand.PASSENGER_AVATAR_SIZE_Y);
            btn.Location = new Point(x, y);
            btn.BackColor = color;          

            btn.BackgroundImage = new Bitmap(Application.StartupPath + avatar);
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            panelMain.Controls.Add(btn);
        }

        public void RemoveControl()
        {
            panelMain.Controls.Clear();
        }

        public Color GetBackgroundColor(Passenger passenger)
        {
            if (passenger.type == Constand.CUSTOMER_TYPE_LIST[0])
            {
                return Color.Red;
            }
            else if (passenger.type == Constand.CUSTOMER_TYPE_LIST[1])
            {
                return Color.Blue;
            }
            else
            {
                return Color.Green;
            }
        }
    }
}
