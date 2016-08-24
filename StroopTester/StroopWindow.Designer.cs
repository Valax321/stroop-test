namespace StroopTester
{
    partial class StroopWindow
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
            this.panelIntro = new System.Windows.Forms.Panel();
            this.radioButtonGroup3 = new System.Windows.Forms.RadioButton();
            this.radioButtonGroup2 = new System.Windows.Forms.RadioButton();
            this.radioButtonGroup1 = new System.Windows.Forms.RadioButton();
            this.radioButtonControl = new System.Windows.Forms.RadioButton();
            this.lblHowtoPlay = new System.Windows.Forms.Label();
            this.lblSpacebarHint = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelPlay = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTestCount = new System.Windows.Forms.Label();
            this.labelWordRead = new System.Windows.Forms.Label();
            this.timerGameTime = new System.Windows.Forms.Timer(this.components);
            this.timerWaitStart = new System.Windows.Forms.Timer(this.components);
            this.lblCountDownTimer = new System.Windows.Forms.Label();
            this.buttonOptRed = new System.Windows.Forms.Button();
            this.buttonOptBlue = new System.Windows.Forms.Button();
            this.buttonOptGreen = new System.Windows.Forms.Button();
            this.buttonOptOrange = new System.Windows.Forms.Button();
            this.buttonOptPurple = new System.Windows.Forms.Button();
            this.panelScores = new System.Windows.Forms.Panel();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.panelIntro.SuspendLayout();
            this.panelPlay.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelScores.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIntro
            // 
            this.panelIntro.Controls.Add(this.radioButtonGroup3);
            this.panelIntro.Controls.Add(this.radioButtonGroup2);
            this.panelIntro.Controls.Add(this.radioButtonGroup1);
            this.panelIntro.Controls.Add(this.radioButtonControl);
            this.panelIntro.Controls.Add(this.lblHowtoPlay);
            this.panelIntro.Controls.Add(this.lblSpacebarHint);
            this.panelIntro.Controls.Add(this.lblTitle);
            this.panelIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIntro.Location = new System.Drawing.Point(0, 0);
            this.panelIntro.Name = "panelIntro";
            this.panelIntro.Size = new System.Drawing.Size(734, 533);
            this.panelIntro.TabIndex = 0;
            // 
            // radioButtonGroup3
            // 
            this.radioButtonGroup3.AutoSize = true;
            this.radioButtonGroup3.Location = new System.Drawing.Point(624, 407);
            this.radioButtonGroup3.Name = "radioButtonGroup3";
            this.radioButtonGroup3.Size = new System.Drawing.Size(67, 17);
            this.radioButtonGroup3.TabIndex = 4;
            this.radioButtonGroup3.Text = "Setting 4";
            this.radioButtonGroup3.UseVisualStyleBackColor = true;
            // 
            // radioButtonGroup2
            // 
            this.radioButtonGroup2.AutoSize = true;
            this.radioButtonGroup2.Location = new System.Drawing.Point(486, 407);
            this.radioButtonGroup2.Name = "radioButtonGroup2";
            this.radioButtonGroup2.Size = new System.Drawing.Size(67, 17);
            this.radioButtonGroup2.TabIndex = 5;
            this.radioButtonGroup2.Text = "Setting 3";
            this.radioButtonGroup2.UseVisualStyleBackColor = true;
            // 
            // radioButtonGroup1
            // 
            this.radioButtonGroup1.AutoSize = true;
            this.radioButtonGroup1.Location = new System.Drawing.Point(179, 407);
            this.radioButtonGroup1.Name = "radioButtonGroup1";
            this.radioButtonGroup1.Size = new System.Drawing.Size(67, 17);
            this.radioButtonGroup1.TabIndex = 4;
            this.radioButtonGroup1.Text = "Setting 2";
            this.radioButtonGroup1.UseVisualStyleBackColor = true;
            // 
            // radioButtonControl
            // 
            this.radioButtonControl.AutoSize = true;
            this.radioButtonControl.Location = new System.Drawing.Point(55, 407);
            this.radioButtonControl.Name = "radioButtonControl";
            this.radioButtonControl.Size = new System.Drawing.Size(67, 17);
            this.radioButtonControl.TabIndex = 3;
            this.radioButtonControl.Text = "Setting 1";
            this.radioButtonControl.UseVisualStyleBackColor = true;
            // 
            // lblHowtoPlay
            // 
            this.lblHowtoPlay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowtoPlay.Location = new System.Drawing.Point(91, 300);
            this.lblHowtoPlay.Name = "lblHowtoPlay";
            this.lblHowtoPlay.Size = new System.Drawing.Size(551, 154);
            this.lblHowtoPlay.TabIndex = 2;
            this.lblHowtoPlay.Text = "A colored word will appear on-screen. You must click the color of the word from t" +
    "he choices below.";
            // 
            // lblSpacebarHint
            // 
            this.lblSpacebarHint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpacebarHint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSpacebarHint.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpacebarHint.Location = new System.Drawing.Point(12, 454);
            this.lblSpacebarHint.Name = "lblSpacebarHint";
            this.lblSpacebarHint.Size = new System.Drawing.Size(710, 33);
            this.lblSpacebarHint.TabIndex = 1;
            this.lblSpacebarHint.Text = "Click here to begin";
            this.lblSpacebarHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSpacebarHint.Click += new System.EventHandler(this.lblSpacebarHint_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 169);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(728, 85);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Stroop Effect";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPlay
            // 
            this.panelPlay.Controls.Add(this.tableLayoutPanel1);
            this.panelPlay.Controls.Add(this.labelTestCount);
            this.panelPlay.Controls.Add(this.labelWordRead);
            this.panelPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlay.Location = new System.Drawing.Point(0, 0);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(734, 533);
            this.panelPlay.TabIndex = 3;
            this.panelPlay.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66722F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66722F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66722F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66722F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66722F));
            this.tableLayoutPanel1.Controls.Add(this.buttonOptPurple, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOptOrange, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOptGreen, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOptBlue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOptRed, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 407);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(710, 63);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // labelTestCount
            // 
            this.labelTestCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTestCount.AutoSize = true;
            this.labelTestCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestCount.Location = new System.Drawing.Point(663, 9);
            this.labelTestCount.Name = "labelTestCount";
            this.labelTestCount.Size = new System.Drawing.Size(59, 25);
            this.labelTestCount.TabIndex = 1;
            this.labelTestCount.Text = "1 of 6";
            this.labelTestCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWordRead
            // 
            this.labelWordRead.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWordRead.ForeColor = System.Drawing.Color.Red;
            this.labelWordRead.Location = new System.Drawing.Point(12, 208);
            this.labelWordRead.Name = "labelWordRead";
            this.labelWordRead.Size = new System.Drawing.Size(710, 65);
            this.labelWordRead.TabIndex = 0;
            this.labelWordRead.Text = "Green";
            this.labelWordRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerGameTime
            // 
            this.timerGameTime.Interval = 1;
            this.timerGameTime.Tick += new System.EventHandler(this.timerGameTime_Tick);
            // 
            // timerWaitStart
            // 
            this.timerWaitStart.Interval = 1000;
            this.timerWaitStart.Tick += new System.EventHandler(this.timerWaitStart_Tick);
            // 
            // lblCountDownTimer
            // 
            this.lblCountDownTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountDownTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDownTimer.Location = new System.Drawing.Point(0, 0);
            this.lblCountDownTimer.Name = "lblCountDownTimer";
            this.lblCountDownTimer.Size = new System.Drawing.Size(734, 533);
            this.lblCountDownTimer.TabIndex = 6;
            this.lblCountDownTimer.Text = "3";
            this.lblCountDownTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCountDownTimer.Visible = false;
            // 
            // buttonOptRed
            // 
            this.buttonOptRed.BackColor = System.Drawing.Color.Red;
            this.buttonOptRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOptRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptRed.Location = new System.Drawing.Point(3, 3);
            this.buttonOptRed.Name = "buttonOptRed";
            this.buttonOptRed.Size = new System.Drawing.Size(135, 57);
            this.buttonOptRed.TabIndex = 0;
            this.buttonOptRed.UseVisualStyleBackColor = false;
            this.buttonOptRed.Click += new System.EventHandler(this.buttonOptRed_Click);
            // 
            // buttonOptBlue
            // 
            this.buttonOptBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonOptBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOptBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptBlue.Location = new System.Drawing.Point(144, 3);
            this.buttonOptBlue.Name = "buttonOptBlue";
            this.buttonOptBlue.Size = new System.Drawing.Size(135, 57);
            this.buttonOptBlue.TabIndex = 1;
            this.buttonOptBlue.UseVisualStyleBackColor = false;
            this.buttonOptBlue.Click += new System.EventHandler(this.buttonOptBlue_Click);
            // 
            // buttonOptGreen
            // 
            this.buttonOptGreen.BackColor = System.Drawing.Color.Green;
            this.buttonOptGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOptGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptGreen.Location = new System.Drawing.Point(285, 3);
            this.buttonOptGreen.Name = "buttonOptGreen";
            this.buttonOptGreen.Size = new System.Drawing.Size(135, 57);
            this.buttonOptGreen.TabIndex = 2;
            this.buttonOptGreen.UseVisualStyleBackColor = false;
            this.buttonOptGreen.Click += new System.EventHandler(this.buttonOptGreen_Click);
            // 
            // buttonOptOrange
            // 
            this.buttonOptOrange.BackColor = System.Drawing.Color.Orange;
            this.buttonOptOrange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOptOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptOrange.Location = new System.Drawing.Point(426, 3);
            this.buttonOptOrange.Name = "buttonOptOrange";
            this.buttonOptOrange.Size = new System.Drawing.Size(135, 57);
            this.buttonOptOrange.TabIndex = 3;
            this.buttonOptOrange.UseVisualStyleBackColor = false;
            this.buttonOptOrange.Click += new System.EventHandler(this.buttonOptOrange_Click);
            // 
            // buttonOptPurple
            // 
            this.buttonOptPurple.BackColor = System.Drawing.Color.Purple;
            this.buttonOptPurple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOptPurple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptPurple.Location = new System.Drawing.Point(567, 3);
            this.buttonOptPurple.Name = "buttonOptPurple";
            this.buttonOptPurple.Size = new System.Drawing.Size(140, 57);
            this.buttonOptPurple.TabIndex = 4;
            this.buttonOptPurple.UseVisualStyleBackColor = false;
            this.buttonOptPurple.Click += new System.EventHandler(this.buttonOptPurple_Click);
            // 
            // panelScores
            // 
            this.panelScores.Controls.Add(this.textBoxResults);
            this.panelScores.Controls.Add(this.lblScoreTitle);
            this.panelScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScores.Location = new System.Drawing.Point(0, 0);
            this.panelScores.Name = "panelScores";
            this.panelScores.Size = new System.Drawing.Size(734, 533);
            this.panelScores.TabIndex = 3;
            this.panelScores.Visible = false;
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTitle.Location = new System.Drawing.Point(12, 104);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(710, 56);
            this.lblScoreTitle.TabIndex = 0;
            this.lblScoreTitle.Text = "Results";
            this.lblScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxResults
            // 
            this.textBoxResults.BackColor = System.Drawing.Color.White;
            this.textBoxResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResults.Location = new System.Drawing.Point(12, 249);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.ReadOnly = true;
            this.textBoxResults.Size = new System.Drawing.Size(710, 238);
            this.textBoxResults.TabIndex = 1;
            this.textBoxResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StroopWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 533);
            this.Controls.Add(this.panelScores);
            this.Controls.Add(this.panelPlay);
            this.Controls.Add(this.lblCountDownTimer);
            this.Controls.Add(this.panelIntro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StroopWindow";
            this.Text = "Stroop Effect";
            this.panelIntro.ResumeLayout(false);
            this.panelIntro.PerformLayout();
            this.panelPlay.ResumeLayout(false);
            this.panelPlay.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelScores.ResumeLayout(false);
            this.panelScores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIntro;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSpacebarHint;
        private System.Windows.Forms.Label lblHowtoPlay;
        private System.Windows.Forms.Panel panelPlay;
        private System.Windows.Forms.Label labelWordRead;
        private System.Windows.Forms.Label labelTestCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtonGroup3;
        private System.Windows.Forms.RadioButton radioButtonGroup2;
        private System.Windows.Forms.RadioButton radioButtonGroup1;
        private System.Windows.Forms.RadioButton radioButtonControl;
        private System.Windows.Forms.Timer timerGameTime;
        private System.Windows.Forms.Timer timerWaitStart;
        private System.Windows.Forms.Label lblCountDownTimer;
        private System.Windows.Forms.Button buttonOptRed;
        private System.Windows.Forms.Button buttonOptPurple;
        private System.Windows.Forms.Button buttonOptOrange;
        private System.Windows.Forms.Button buttonOptGreen;
        private System.Windows.Forms.Button buttonOptBlue;
        private System.Windows.Forms.Panel panelScores;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.TextBox textBoxResults;
    }
}

