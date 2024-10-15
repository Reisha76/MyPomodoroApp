namespace MyPomodoroApp
{
    partial class PomodoroApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PomodoroApp));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownSecs = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMins = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHrs = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEndPeriod = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.groupBoxBreak = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numBreakSecs = new System.Windows.Forms.NumericUpDown();
            this.numBreakMins = new System.Windows.Forms.NumericUpDown();
            this.numBreakHrs = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnHideSettings = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSessionsCounter = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTimeStudied = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHrs)).BeginInit();
            this.groupBoxBreak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBreakSecs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreakMins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreakHrs)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(372, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(257, 37);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Pomodoro Timer";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(444, 323);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 50);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(581, 323);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(101, 50);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(394, 132);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(220, 55);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "00:25:00";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDownSecs);
            this.groupBox1.Controls.Add(this.numericUpDownMins);
            this.groupBox1.Controls.Add(this.numericUpDownHrs);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(819, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 179);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(39, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "*Optimum study period = 25mins";
            // 
            // numericUpDownSecs
            // 
            this.numericUpDownSecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSecs.Location = new System.Drawing.Point(171, 82);
            this.numericUpDownSecs.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownSecs.Name = "numericUpDownSecs";
            this.numericUpDownSecs.Size = new System.Drawing.Size(48, 22);
            this.numericUpDownSecs.TabIndex = 4;
            this.numericUpDownSecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownSecs.ValueChanged += new System.EventHandler(this.numericUpDownSecs_ValueChanged);
            // 
            // numericUpDownMins
            // 
            this.numericUpDownMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMins.Location = new System.Drawing.Point(99, 82);
            this.numericUpDownMins.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownMins.Name = "numericUpDownMins";
            this.numericUpDownMins.Size = new System.Drawing.Size(48, 22);
            this.numericUpDownMins.TabIndex = 3;
            this.numericUpDownMins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMins.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownMins.ValueChanged += new System.EventHandler(this.numericUpDownMins_ValueChanged);
            // 
            // numericUpDownHrs
            // 
            this.numericUpDownHrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownHrs.Location = new System.Drawing.Point(27, 82);
            this.numericUpDownHrs.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownHrs.Name = "numericUpDownHrs";
            this.numericUpDownHrs.Size = new System.Drawing.Size(48, 22);
            this.numericUpDownHrs.TabIndex = 2;
            this.numericUpDownHrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownHrs.ValueChanged += new System.EventHandler(this.numericUpDownHrs_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hours";
            // 
            // btnEndPeriod
            // 
            this.btnEndPeriod.BackColor = System.Drawing.Color.Gray;
            this.btnEndPeriod.ImageKey = "arrowImg.png";
            this.btnEndPeriod.ImageList = this.imageList1;
            this.btnEndPeriod.Location = new System.Drawing.Point(581, 400);
            this.btnEndPeriod.Name = "btnEndPeriod";
            this.btnEndPeriod.Size = new System.Drawing.Size(101, 50);
            this.btnEndPeriod.TabIndex = 5;
            this.btnEndPeriod.UseVisualStyleBackColor = false;
            this.btnEndPeriod.Click += new System.EventHandler(this.btnEndPeriod_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "arrowImg.png");
            this.imageList1.Images.SetKeyName(1, "settingsIcon.png");
            this.imageList1.Images.SetKeyName(2, "settingsNEW.png");
            this.imageList1.Images.SetKeyName(3, "timerIcon.png");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(589, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "End Session";
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ImageKey = "(none)";
            this.btnSettings.ImageList = this.imageList1;
            this.btnSettings.Location = new System.Drawing.Point(307, 323);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(101, 50);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.Text = "Show Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // groupBoxBreak
            // 
            this.groupBoxBreak.BackColor = System.Drawing.Color.White;
            this.groupBoxBreak.Controls.Add(this.label7);
            this.groupBoxBreak.Controls.Add(this.numBreakSecs);
            this.groupBoxBreak.Controls.Add(this.numBreakMins);
            this.groupBoxBreak.Controls.Add(this.numBreakHrs);
            this.groupBoxBreak.Controls.Add(this.label9);
            this.groupBoxBreak.Controls.Add(this.label10);
            this.groupBoxBreak.Controls.Add(this.label11);
            this.groupBoxBreak.Controls.Add(this.label12);
            this.groupBoxBreak.Controls.Add(this.label13);
            this.groupBoxBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBreak.Location = new System.Drawing.Point(819, 323);
            this.groupBoxBreak.Name = "groupBoxBreak";
            this.groupBoxBreak.Size = new System.Drawing.Size(256, 179);
            this.groupBoxBreak.TabIndex = 13;
            this.groupBoxBreak.TabStop = false;
            this.groupBoxBreak.Text = "Break Settings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(43, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "*Optimum break period = 5mins";
            // 
            // numBreakSecs
            // 
            this.numBreakSecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBreakSecs.Location = new System.Drawing.Point(171, 82);
            this.numBreakSecs.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numBreakSecs.Name = "numBreakSecs";
            this.numBreakSecs.Size = new System.Drawing.Size(48, 22);
            this.numBreakSecs.TabIndex = 4;
            this.numBreakSecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numBreakSecs.ValueChanged += new System.EventHandler(this.numBreakSecs_ValueChanged);
            // 
            // numBreakMins
            // 
            this.numBreakMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBreakMins.Location = new System.Drawing.Point(99, 82);
            this.numBreakMins.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numBreakMins.Name = "numBreakMins";
            this.numBreakMins.Size = new System.Drawing.Size(48, 22);
            this.numBreakMins.TabIndex = 3;
            this.numBreakMins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numBreakMins.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBreakMins.ValueChanged += new System.EventHandler(this.numBreakMins_ValueChanged);
            // 
            // numBreakHrs
            // 
            this.numBreakHrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBreakHrs.Location = new System.Drawing.Point(27, 82);
            this.numBreakHrs.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numBreakHrs.Name = "numBreakHrs";
            this.numBreakHrs.Size = new System.Drawing.Size(48, 22);
            this.numBreakHrs.TabIndex = 2;
            this.numBreakHrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numBreakHrs.ValueChanged += new System.EventHandler(this.numBreakHrs_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(81, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(153, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(165, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Seconds";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(90, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Minutes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Hours";
            // 
            // btnHideSettings
            // 
            this.btnHideSettings.BackColor = System.Drawing.Color.Red;
            this.btnHideSettings.ForeColor = System.Drawing.Color.White;
            this.btnHideSettings.Location = new System.Drawing.Point(895, 530);
            this.btnHideSettings.Name = "btnHideSettings";
            this.btnHideSettings.Size = new System.Drawing.Size(116, 41);
            this.btnHideSettings.TabIndex = 14;
            this.btnHideSettings.Text = "Hide Settings";
            this.btnHideSettings.UseVisualStyleBackColor = false;
            this.btnHideSettings.Click += new System.EventHandler(this.btnHideSettings_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "Session number:";
            // 
            // lblSessionsCounter
            // 
            this.lblSessionsCounter.AutoSize = true;
            this.lblSessionsCounter.Location = new System.Drawing.Point(131, 28);
            this.lblSessionsCounter.Name = "lblSessionsCounter";
            this.lblSessionsCounter.Size = new System.Drawing.Size(14, 16);
            this.lblSessionsCounter.TabIndex = 16;
            this.lblSessionsCounter.Text = "1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblTimeStudied);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lblSessionsCounter);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(25, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 105);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your Stats";
            // 
            // lblTimeStudied
            // 
            this.lblTimeStudied.AutoSize = true;
            this.lblTimeStudied.Location = new System.Drawing.Point(111, 62);
            this.lblTimeStudied.Name = "lblTimeStudied";
            this.lblTimeStudied.Size = new System.Drawing.Size(85, 16);
            this.lblTimeStudied.TabIndex = 18;
            this.lblTimeStudied.Text = "0hr(s) 00mins";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 16);
            this.label15.TabIndex = 17;
            this.label15.Text = "Time studied:";
            // 
            // PomodoroApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1135, 637);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnHideSettings);
            this.Controls.Add(this.groupBoxBreak);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEndPeriod);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PomodoroApp";
            this.Text = "PomdoroTimer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHrs)).EndInit();
            this.groupBoxBreak.ResumeLayout(false);
            this.groupBoxBreak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBreakSecs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreakMins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreakHrs)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEndPeriod;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NumericUpDown numericUpDownSecs;
        private System.Windows.Forms.NumericUpDown numericUpDownMins;
        private System.Windows.Forms.NumericUpDown numericUpDownHrs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.GroupBox groupBoxBreak;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numBreakSecs;
        private System.Windows.Forms.NumericUpDown numBreakMins;
        private System.Windows.Forms.NumericUpDown numBreakHrs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnHideSettings;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSessionsCounter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTimeStudied;
        private System.Windows.Forms.Label label15;
    }
}