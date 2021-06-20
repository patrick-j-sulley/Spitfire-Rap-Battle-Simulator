namespace DAT602Ass2_Spitfire
{
    partial class frmGameProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameProcess));
            this.gbGameTab = new System.Windows.Forms.GroupBox();
            this.lblUserloggedin = new System.Windows.Forms.Label();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.lblRoundNo = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblLineNoP1 = new System.Windows.Forms.Label();
            this.lbLinesPlayer1 = new System.Windows.Forms.ListBox();
            this.lblLineEntryP1 = new System.Windows.Forms.Label();
            this.lblLinePointsP1 = new System.Windows.Forms.Label();
            this.lblLineScoreP2 = new System.Windows.Forms.Label();
            this.lblLineEntryP2 = new System.Windows.Forms.Label();
            this.lbLinesPlayer2 = new System.Windows.Forms.ListBox();
            this.lblLineNoP2 = new System.Windows.Forms.Label();
            this.lblCurrentScoreP1 = new System.Windows.Forms.Label();
            this.lblCurrentTurnP1 = new System.Windows.Forms.Label();
            this.lblCurrentScoreP2 = new System.Windows.Forms.Label();
            this.lblCurrentTurnP2 = new System.Windows.Forms.Label();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.btnSpitLine = new System.Windows.Forms.Button();
            this.lblLineTimer = new System.Windows.Forms.Label();
            this.TmrLineTime = new System.Windows.Forms.Timer(this.components);
            this.TmrCheckAndUpdate = new System.Windows.Forms.Timer(this.components);
            this.TmrChecker = new System.Windows.Forms.Timer(this.components);
            this.gbGameTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGameTab
            // 
            this.gbGameTab.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbGameTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbGameTab.BackgroundImage")));
            this.gbGameTab.Controls.Add(this.lblUserloggedin);
            this.gbGameTab.Controls.Add(this.lblPlayerTurn);
            this.gbGameTab.Controls.Add(this.lblRoundNo);
            this.gbGameTab.Controls.Add(this.lblPlayer2);
            this.gbGameTab.Controls.Add(this.lblPlayer1);
            this.gbGameTab.Controls.Add(this.pictureBox1);
            this.gbGameTab.Controls.Add(this.pictureBox2);
            this.gbGameTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbGameTab.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGameTab.Location = new System.Drawing.Point(12, 12);
            this.gbGameTab.Name = "gbGameTab";
            this.gbGameTab.Size = new System.Drawing.Size(954, 299);
            this.gbGameTab.TabIndex = 0;
            this.gbGameTab.TabStop = false;
            // 
            // lblUserloggedin
            // 
            this.lblUserloggedin.AutoSize = true;
            this.lblUserloggedin.BackColor = System.Drawing.Color.Gold;
            this.lblUserloggedin.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUserloggedin.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserloggedin.Location = new System.Drawing.Point(510, 19);
            this.lblUserloggedin.Name = "lblUserloggedin";
            this.lblUserloggedin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserloggedin.Size = new System.Drawing.Size(441, 28);
            this.lblUserloggedin.TabIndex = 9;
            this.lblUserloggedin.Text = "Logged In As Username111111111111";
            this.lblUserloggedin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.BackColor = System.Drawing.Color.White;
            this.lblPlayerTurn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTurn.Location = new System.Drawing.Point(311, 248);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(337, 48);
            this.lblPlayerTurn.TabIndex = 8;
            this.lblPlayerTurn.Text = "Username\'s Turn!";
            this.lblPlayerTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoundNo
            // 
            this.lblRoundNo.AutoSize = true;
            this.lblRoundNo.BackColor = System.Drawing.Color.White;
            this.lblRoundNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRoundNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundNo.Location = new System.Drawing.Point(6, 18);
            this.lblRoundNo.Name = "lblRoundNo";
            this.lblRoundNo.Size = new System.Drawing.Size(110, 27);
            this.lblRoundNo.TabIndex = 5;
            this.lblRoundNo.Text = "Round: 0/3";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.BackColor = System.Drawing.Color.Red;
            this.lblPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayer2.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(637, 264);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(317, 35);
            this.lblPlayer2.TabIndex = 2;
            this.lblPlayer2.Text = "WWWWWWWWWWWWWWWWWWWW";
            this.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.BackColor = System.Drawing.Color.Chartreuse;
            this.lblPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayer1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(0, 264);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(317, 35);
            this.lblPlayer1.TabIndex = 1;
            this.lblPlayer1.Text = "WWWWWWWWWWWWWWWWWWWW";
            this.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-21, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 327);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(529, -17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(425, 315);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // lblLineNoP1
            // 
            this.lblLineNoP1.AutoSize = true;
            this.lblLineNoP1.BackColor = System.Drawing.Color.Transparent;
            this.lblLineNoP1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineNoP1.ForeColor = System.Drawing.Color.White;
            this.lblLineNoP1.Location = new System.Drawing.Point(12, 326);
            this.lblLineNoP1.Name = "lblLineNoP1";
            this.lblLineNoP1.Size = new System.Drawing.Size(57, 20);
            this.lblLineNoP1.TabIndex = 3;
            this.lblLineNoP1.Text = "Line #";
            // 
            // lbLinesPlayer1
            // 
            this.lbLinesPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLinesPlayer1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinesPlayer1.FormattingEnabled = true;
            this.lbLinesPlayer1.ItemHeight = 15;
            this.lbLinesPlayer1.Location = new System.Drawing.Point(12, 346);
            this.lbLinesPlayer1.Name = "lbLinesPlayer1";
            this.lbLinesPlayer1.Size = new System.Drawing.Size(468, 272);
            this.lbLinesPlayer1.TabIndex = 4;
            // 
            // lblLineEntryP1
            // 
            this.lblLineEntryP1.AutoSize = true;
            this.lblLineEntryP1.BackColor = System.Drawing.Color.Transparent;
            this.lblLineEntryP1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineEntryP1.ForeColor = System.Drawing.Color.White;
            this.lblLineEntryP1.Location = new System.Drawing.Point(75, 326);
            this.lblLineEntryP1.Name = "lblLineEntryP1";
            this.lblLineEntryP1.Size = new System.Drawing.Size(91, 20);
            this.lblLineEntryP1.TabIndex = 5;
            this.lblLineEntryP1.Text = "Line Entry";
            // 
            // lblLinePointsP1
            // 
            this.lblLinePointsP1.AutoSize = true;
            this.lblLinePointsP1.BackColor = System.Drawing.Color.Transparent;
            this.lblLinePointsP1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinePointsP1.ForeColor = System.Drawing.Color.White;
            this.lblLinePointsP1.Location = new System.Drawing.Point(384, 326);
            this.lblLinePointsP1.Name = "lblLinePointsP1";
            this.lblLinePointsP1.Size = new System.Drawing.Size(96, 20);
            this.lblLinePointsP1.TabIndex = 6;
            this.lblLinePointsP1.Text = "Line Score";
            // 
            // lblLineScoreP2
            // 
            this.lblLineScoreP2.AutoSize = true;
            this.lblLineScoreP2.BackColor = System.Drawing.Color.Transparent;
            this.lblLineScoreP2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineScoreP2.ForeColor = System.Drawing.Color.White;
            this.lblLineScoreP2.Location = new System.Drawing.Point(870, 326);
            this.lblLineScoreP2.Name = "lblLineScoreP2";
            this.lblLineScoreP2.Size = new System.Drawing.Size(96, 20);
            this.lblLineScoreP2.TabIndex = 10;
            this.lblLineScoreP2.Text = "Line Score";
            // 
            // lblLineEntryP2
            // 
            this.lblLineEntryP2.AutoSize = true;
            this.lblLineEntryP2.BackColor = System.Drawing.Color.Transparent;
            this.lblLineEntryP2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineEntryP2.ForeColor = System.Drawing.Color.White;
            this.lblLineEntryP2.Location = new System.Drawing.Point(555, 326);
            this.lblLineEntryP2.Name = "lblLineEntryP2";
            this.lblLineEntryP2.Size = new System.Drawing.Size(91, 20);
            this.lblLineEntryP2.TabIndex = 9;
            this.lblLineEntryP2.Text = "Line Entry";
            // 
            // lbLinesPlayer2
            // 
            this.lbLinesPlayer2.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinesPlayer2.FormattingEnabled = true;
            this.lbLinesPlayer2.ItemHeight = 15;
            this.lbLinesPlayer2.Location = new System.Drawing.Point(500, 344);
            this.lbLinesPlayer2.Name = "lbLinesPlayer2";
            this.lbLinesPlayer2.Size = new System.Drawing.Size(466, 274);
            this.lbLinesPlayer2.TabIndex = 8;
            // 
            // lblLineNoP2
            // 
            this.lblLineNoP2.AutoSize = true;
            this.lblLineNoP2.BackColor = System.Drawing.Color.Transparent;
            this.lblLineNoP2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineNoP2.ForeColor = System.Drawing.Color.White;
            this.lblLineNoP2.Location = new System.Drawing.Point(496, 326);
            this.lblLineNoP2.Name = "lblLineNoP2";
            this.lblLineNoP2.Size = new System.Drawing.Size(57, 20);
            this.lblLineNoP2.TabIndex = 7;
            this.lblLineNoP2.Text = "Line #";
            // 
            // lblCurrentScoreP1
            // 
            this.lblCurrentScoreP1.AutoSize = true;
            this.lblCurrentScoreP1.BackColor = System.Drawing.Color.Chartreuse;
            this.lblCurrentScoreP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentScoreP1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScoreP1.Location = new System.Drawing.Point(63, 644);
            this.lblCurrentScoreP1.Name = "lblCurrentScoreP1";
            this.lblCurrentScoreP1.Size = new System.Drawing.Size(139, 36);
            this.lblCurrentScoreP1.TabIndex = 9;
            this.lblCurrentScoreP1.Text = "Score: 0";
            // 
            // lblCurrentTurnP1
            // 
            this.lblCurrentTurnP1.AutoSize = true;
            this.lblCurrentTurnP1.BackColor = System.Drawing.Color.Chartreuse;
            this.lblCurrentTurnP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentTurnP1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTurnP1.Location = new System.Drawing.Point(63, 682);
            this.lblCurrentTurnP1.Name = "lblCurrentTurnP1";
            this.lblCurrentTurnP1.Size = new System.Drawing.Size(146, 36);
            this.lblCurrentTurnP1.TabIndex = 11;
            this.lblCurrentTurnP1.Text = "Turn: 0/2";
            // 
            // lblCurrentScoreP2
            // 
            this.lblCurrentScoreP2.AutoSize = true;
            this.lblCurrentScoreP2.BackColor = System.Drawing.Color.Red;
            this.lblCurrentScoreP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentScoreP2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScoreP2.Location = new System.Drawing.Point(770, 642);
            this.lblCurrentScoreP2.Name = "lblCurrentScoreP2";
            this.lblCurrentScoreP2.Size = new System.Drawing.Size(139, 36);
            this.lblCurrentScoreP2.TabIndex = 12;
            this.lblCurrentScoreP2.Text = "Score: 0";
            // 
            // lblCurrentTurnP2
            // 
            this.lblCurrentTurnP2.AutoSize = true;
            this.lblCurrentTurnP2.BackColor = System.Drawing.Color.Red;
            this.lblCurrentTurnP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentTurnP2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTurnP2.Location = new System.Drawing.Point(770, 680);
            this.lblCurrentTurnP2.Name = "lblCurrentTurnP2";
            this.lblCurrentTurnP2.Size = new System.Drawing.Size(146, 36);
            this.lblCurrentTurnP2.TabIndex = 13;
            this.lblCurrentTurnP2.Text = "Turn: 0/2";
            // 
            // txtLine
            // 
            this.txtLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLine.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLine.Location = new System.Drawing.Point(215, 683);
            this.txtLine.MaxLength = 55;
            this.txtLine.Multiline = true;
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(549, 47);
            this.txtLine.TabIndex = 14;
            this.txtLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLine_KeyPress);
            // 
            // btnSpitLine
            // 
            this.btnSpitLine.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpitLine.Location = new System.Drawing.Point(215, 738);
            this.btnSpitLine.Name = "btnSpitLine";
            this.btnSpitLine.Size = new System.Drawing.Size(549, 33);
            this.btnSpitLine.TabIndex = 15;
            this.btnSpitLine.Text = "Spit Your Line!";
            this.btnSpitLine.UseVisualStyleBackColor = true;
            this.btnSpitLine.Click += new System.EventHandler(this.btnSpitLine_Click);
            // 
            // lblLineTimer
            // 
            this.lblLineTimer.BackColor = System.Drawing.Color.Black;
            this.lblLineTimer.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineTimer.ForeColor = System.Drawing.Color.Lime;
            this.lblLineTimer.Location = new System.Drawing.Point(412, 624);
            this.lblLineTimer.Name = "lblLineTimer";
            this.lblLineTimer.Size = new System.Drawing.Size(154, 56);
            this.lblLineTimer.TabIndex = 16;
            this.lblLineTimer.Text = "30";
            this.lblLineTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TmrLineTime
            // 
            this.TmrLineTime.Interval = 1000;
            this.TmrLineTime.Tick += new System.EventHandler(this.TmrLineTime_Tick);
            // 
            // TmrCheckAndUpdate
            // 
            this.TmrCheckAndUpdate.Interval = 50;
            this.TmrCheckAndUpdate.Tick += new System.EventHandler(this.TmrUpdateDisplay_Tick);
            // 
            // TmrChecker
            // 
            this.TmrChecker.Tick += new System.EventHandler(this.TmrChecker_Tick);
            // 
            // frmGameProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(978, 776);
            this.Controls.Add(this.lblLineTimer);
            this.Controls.Add(this.btnSpitLine);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.lblCurrentTurnP2);
            this.Controls.Add(this.lblCurrentScoreP2);
            this.Controls.Add(this.lblCurrentTurnP1);
            this.Controls.Add(this.lblCurrentScoreP1);
            this.Controls.Add(this.lblLineScoreP2);
            this.Controls.Add(this.lblLineEntryP2);
            this.Controls.Add(this.lbLinesPlayer2);
            this.Controls.Add(this.lblLineNoP2);
            this.Controls.Add(this.lblLinePointsP1);
            this.Controls.Add(this.lblLineEntryP1);
            this.Controls.Add(this.lbLinesPlayer1);
            this.Controls.Add(this.lblLineNoP1);
            this.Controls.Add(this.gbGameTab);
            this.Name = "frmGameProcess";
            this.Text = "Spitfire! Rap Battle Simulator";
            this.gbGameTab.ResumeLayout(false);
            this.gbGameTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGameTab;
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Label lblRoundNo;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblLineNoP1;
        private System.Windows.Forms.ListBox lbLinesPlayer1;
        private System.Windows.Forms.Label lblLineEntryP1;
        private System.Windows.Forms.Label lblLinePointsP1;
        private System.Windows.Forms.Label lblLineScoreP2;
        private System.Windows.Forms.Label lblLineEntryP2;
        private System.Windows.Forms.ListBox lbLinesPlayer2;
        private System.Windows.Forms.Label lblLineNoP2;
        private System.Windows.Forms.Label lblCurrentScoreP1;
        private System.Windows.Forms.Label lblCurrentTurnP1;
        private System.Windows.Forms.Label lblCurrentScoreP2;
        private System.Windows.Forms.Label lblCurrentTurnP2;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.Button btnSpitLine;
        private System.Windows.Forms.Label lblLineTimer;
        private System.Windows.Forms.Timer TmrLineTime;
        private System.Windows.Forms.Timer TmrCheckAndUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUserloggedin;
        private System.Windows.Forms.Timer TmrChecker;
    }
}