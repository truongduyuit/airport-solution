namespace AirPort
{
    partial class frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm));
            this.panel = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.circularButton1 = new AirPort.CircularButton();
            this.GateCProcessTimeRest = new AirPort.CircularButton();
            this.GateBProcessTimeRest = new AirPort.CircularButton();
            this.GateAProcessTimeRest = new AirPort.CircularButton();
            this.circularButton6 = new AirPort.CircularButton();
            this.circularButton5 = new AirPort.CircularButton();
            this.circularButton4 = new AirPort.CircularButton();
            this.btnRestA = new AirPort.CircularButton();
            this.btnRestC = new AirPort.CircularButton();
            this.btnRestB = new AirPort.CircularButton();
            this.btnRunPause = new AirPort.CircularButton();
            this.panel.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.btnRunPause);
            this.panel.Controls.Add(this.btnRestC);
            this.panel.Controls.Add(this.btnRestB);
            this.panel.Controls.Add(this.btnRestA);
            this.panel.Controls.Add(this.panelMain);
            this.panel.Controls.Add(this.GateCProcessTimeRest);
            this.panel.Controls.Add(this.GateBProcessTimeRest);
            this.panel.Controls.Add(this.GateAProcessTimeRest);
            this.panel.Controls.Add(this.circularButton6);
            this.panel.Controls.Add(this.circularButton5);
            this.panel.Controls.Add(this.circularButton4);
            this.panel.Location = new System.Drawing.Point(400, 40);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1120, 760);
            this.panel.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.circularButton1);
            this.panelMain.Location = new System.Drawing.Point(0, 97);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1120, 515);
            this.panelMain.TabIndex = 15;
            // 
            // circularButton1
            // 
            this.circularButton1.BackColor = System.Drawing.Color.Navy;
            this.circularButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.circularButton1.Location = new System.Drawing.Point(222, 660);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(50, 50);
            this.circularButton1.TabIndex = 14;
            this.circularButton1.Text = "10";
            this.circularButton1.UseVisualStyleBackColor = false;
            // 
            // GateCProcessTimeRest
            // 
            this.GateCProcessTimeRest.BackColor = System.Drawing.Color.Navy;
            this.GateCProcessTimeRest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GateCProcessTimeRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GateCProcessTimeRest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GateCProcessTimeRest.Location = new System.Drawing.Point(800, 50);
            this.GateCProcessTimeRest.Name = "GateCProcessTimeRest";
            this.GateCProcessTimeRest.Size = new System.Drawing.Size(50, 50);
            this.GateCProcessTimeRest.TabIndex = 11;
            this.GateCProcessTimeRest.Text = "0";
            this.GateCProcessTimeRest.UseVisualStyleBackColor = false;
            // 
            // GateBProcessTimeRest
            // 
            this.GateBProcessTimeRest.BackColor = System.Drawing.Color.Navy;
            this.GateBProcessTimeRest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GateBProcessTimeRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GateBProcessTimeRest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GateBProcessTimeRest.Location = new System.Drawing.Point(550, 50);
            this.GateBProcessTimeRest.Name = "GateBProcessTimeRest";
            this.GateBProcessTimeRest.Size = new System.Drawing.Size(50, 50);
            this.GateBProcessTimeRest.TabIndex = 10;
            this.GateBProcessTimeRest.Text = "0";
            this.GateBProcessTimeRest.UseVisualStyleBackColor = false;
            // 
            // GateAProcessTimeRest
            // 
            this.GateAProcessTimeRest.BackColor = System.Drawing.Color.Navy;
            this.GateAProcessTimeRest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GateAProcessTimeRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GateAProcessTimeRest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GateAProcessTimeRest.Location = new System.Drawing.Point(300, 50);
            this.GateAProcessTimeRest.Name = "GateAProcessTimeRest";
            this.GateAProcessTimeRest.Size = new System.Drawing.Size(50, 50);
            this.GateAProcessTimeRest.TabIndex = 9;
            this.GateAProcessTimeRest.Text = "0";
            this.GateAProcessTimeRest.UseVisualStyleBackColor = false;
            // 
            // circularButton6
            // 
            this.circularButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularButton6.BackgroundImage")));
            this.circularButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton6.Location = new System.Drawing.Point(700, 0);
            this.circularButton6.Name = "circularButton6";
            this.circularButton6.Size = new System.Drawing.Size(100, 100);
            this.circularButton6.TabIndex = 8;
            this.circularButton6.Text = "C";
            this.circularButton6.UseVisualStyleBackColor = true;
            // 
            // circularButton5
            // 
            this.circularButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularButton5.BackgroundImage")));
            this.circularButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton5.Location = new System.Drawing.Point(450, 0);
            this.circularButton5.Name = "circularButton5";
            this.circularButton5.Size = new System.Drawing.Size(100, 100);
            this.circularButton5.TabIndex = 7;
            this.circularButton5.Text = "B";
            this.circularButton5.UseVisualStyleBackColor = true;
            // 
            // circularButton4
            // 
            this.circularButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularButton4.BackgroundImage")));
            this.circularButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton4.Location = new System.Drawing.Point(200, 0);
            this.circularButton4.Name = "circularButton4";
            this.circularButton4.Size = new System.Drawing.Size(100, 100);
            this.circularButton4.TabIndex = 6;
            this.circularButton4.Text = "A";
            this.circularButton4.UseVisualStyleBackColor = true;
            // 
            // btnRestA
            // 
            this.btnRestA.BackColor = System.Drawing.Color.Red;
            this.btnRestA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRestA.Location = new System.Drawing.Point(230, 654);
            this.btnRestA.Name = "btnRestA";
            this.btnRestA.Size = new System.Drawing.Size(50, 50);
            this.btnRestA.TabIndex = 17;
            this.btnRestA.Text = "0";
            this.btnRestA.UseVisualStyleBackColor = false;
            // 
            // btnRestC
            // 
            this.btnRestC.BackColor = System.Drawing.Color.Red;
            this.btnRestC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRestC.Location = new System.Drawing.Point(730, 654);
            this.btnRestC.Name = "btnRestC";
            this.btnRestC.Size = new System.Drawing.Size(50, 50);
            this.btnRestC.TabIndex = 19;
            this.btnRestC.Text = "0";
            this.btnRestC.UseVisualStyleBackColor = false;
            // 
            // btnRestB
            // 
            this.btnRestB.BackColor = System.Drawing.Color.Red;
            this.btnRestB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRestB.Location = new System.Drawing.Point(480, 654);
            this.btnRestB.Name = "btnRestB";
            this.btnRestB.Size = new System.Drawing.Size(50, 50);
            this.btnRestB.TabIndex = 20;
            this.btnRestB.Text = "0";
            this.btnRestB.UseVisualStyleBackColor = false;
            // 
            // btnRunPause
            // 
            this.btnRunPause.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRunPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRunPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunPause.Location = new System.Drawing.Point(1012, 0);
            this.btnRunPause.Name = "btnRunPause";
            this.btnRunPause.Size = new System.Drawing.Size(100, 100);
            this.btnRunPause.TabIndex = 21;
            this.btnRunPause.Text = "Run";
            this.btnRunPause.UseVisualStyleBackColor = false;
            this.btnRunPause.Click += new System.EventHandler(this.btnRunPause_Click);
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel);
            this.Name = "frm";
            this.Text = "MÔ HÌNH XỬ LÝ THÔNG TIN HÀNH KHÁCH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private CircularButton circularButton6;
        private CircularButton circularButton5;
        private CircularButton circularButton4;
        private CircularButton GateCProcessTimeRest;
        private CircularButton GateBProcessTimeRest;
        private CircularButton GateAProcessTimeRest;
        private System.Windows.Forms.Panel panelMain;
        private CircularButton circularButton1;
        private CircularButton btnRestA;
        private CircularButton btnRestC;
        private CircularButton btnRestB;
        private CircularButton btnRunPause;
    }
}