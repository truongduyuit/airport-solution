namespace AirPort
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnGateA = new System.Windows.Forms.Button();
            this.btnGateB = new System.Windows.Forms.Button();
            this.btnGateC = new System.Windows.Forms.Button();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.GateCProcessTimeRest = new AirPort.CircularButton();
            this.GateBProcessTimeRest = new AirPort.CircularButton();
            this.GateAProcessTimeRest = new AirPort.CircularButton();
            this.SuspendLayout();
            // 
            // btnGateA
            // 
            this.btnGateA.Location = new System.Drawing.Point(155, 112);
            this.btnGateA.Name = "btnGateA";
            this.btnGateA.Size = new System.Drawing.Size(100, 50);
            this.btnGateA.TabIndex = 2;
            this.btnGateA.Text = "A";
            this.btnGateA.UseVisualStyleBackColor = true;
            // 
            // btnGateB
            // 
            this.btnGateB.Location = new System.Drawing.Point(357, 112);
            this.btnGateB.Name = "btnGateB";
            this.btnGateB.Size = new System.Drawing.Size(100, 50);
            this.btnGateB.TabIndex = 4;
            this.btnGateB.Text = "B";
            this.btnGateB.UseVisualStyleBackColor = true;
            // 
            // btnGateC
            // 
            this.btnGateC.Location = new System.Drawing.Point(573, 112);
            this.btnGateC.Name = "btnGateC";
            this.btnGateC.Size = new System.Drawing.Size(100, 50);
            this.btnGateC.TabIndex = 6;
            this.btnGateC.Text = "C";
            this.btnGateC.UseVisualStyleBackColor = true;
            // 
            // timerCountDown
            // 
            this.timerCountDown.Interval = 1000;
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(155, 228);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(574, 414);
            this.panelMain.TabIndex = 8;
            // 
            // GateCProcessTimeRest
            // 
            this.GateCProcessTimeRest.Location = new System.Drawing.Point(679, 112);
            this.GateCProcessTimeRest.Name = "GateCProcessTimeRest";
            this.GateCProcessTimeRest.Size = new System.Drawing.Size(50, 50);
            this.GateCProcessTimeRest.TabIndex = 7;
            this.GateCProcessTimeRest.Text = "0";
            this.GateCProcessTimeRest.UseVisualStyleBackColor = true;
            // 
            // GateBProcessTimeRest
            // 
            this.GateBProcessTimeRest.Location = new System.Drawing.Point(463, 112);
            this.GateBProcessTimeRest.Name = "GateBProcessTimeRest";
            this.GateBProcessTimeRest.Size = new System.Drawing.Size(50, 50);
            this.GateBProcessTimeRest.TabIndex = 5;
            this.GateBProcessTimeRest.Text = "0";
            this.GateBProcessTimeRest.UseVisualStyleBackColor = true;
            // 
            // GateAProcessTimeRest
            // 
            this.GateAProcessTimeRest.Location = new System.Drawing.Point(261, 112);
            this.GateAProcessTimeRest.Name = "GateAProcessTimeRest";
            this.GateAProcessTimeRest.Size = new System.Drawing.Size(50, 50);
            this.GateAProcessTimeRest.TabIndex = 3;
            this.GateAProcessTimeRest.Text = "0";
            this.GateAProcessTimeRest.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.GateCProcessTimeRest);
            this.Controls.Add(this.btnGateC);
            this.Controls.Add(this.GateBProcessTimeRest);
            this.Controls.Add(this.btnGateB);
            this.Controls.Add(this.GateAProcessTimeRest);
            this.Controls.Add(this.btnGateA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "MÔ HÌNH XỬ LÝ THÔNG TIN HÀNH KHÁCH";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGateA;
        private CircularButton GateAProcessTimeRest;
        private CircularButton GateBProcessTimeRest;
        private System.Windows.Forms.Button btnGateB;
        private CircularButton GateCProcessTimeRest;
        private System.Windows.Forms.Button btnGateC;
        private System.Windows.Forms.Timer timerCountDown;
        private System.Windows.Forms.Panel panelMain;
    }
}

