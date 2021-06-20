namespace DAT602Ass2_Spitfire
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChallengePlayer = new System.Windows.Forms.Button();
            this.lbOnlinePlayers = new System.Windows.Forms.ListBox();
            this.lblUserloggedin = new System.Windows.Forms.Label();
            this.lblOnlinePlayers = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.TmrPlayerListRefresh = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TmrPlayerChallengeStatus = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(106, 24);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "<< Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChallengePlayer
            // 
            this.btnChallengePlayer.BackColor = System.Drawing.Color.GreenYellow;
            this.btnChallengePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChallengePlayer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChallengePlayer.Location = new System.Drawing.Point(126, 339);
            this.btnChallengePlayer.Name = "btnChallengePlayer";
            this.btnChallengePlayer.Size = new System.Drawing.Size(146, 42);
            this.btnChallengePlayer.TabIndex = 1;
            this.btnChallengePlayer.Text = "Challenge";
            this.btnChallengePlayer.UseVisualStyleBackColor = false;
            this.btnChallengePlayer.Click += new System.EventHandler(this.btnChallengePlayer_Click);
            // 
            // lbOnlinePlayers
            // 
            this.lbOnlinePlayers.FormattingEnabled = true;
            this.lbOnlinePlayers.HorizontalScrollbar = true;
            this.lbOnlinePlayers.ItemHeight = 16;
            this.lbOnlinePlayers.Location = new System.Drawing.Point(67, 201);
            this.lbOnlinePlayers.Name = "lbOnlinePlayers";
            this.lbOnlinePlayers.Size = new System.Drawing.Size(268, 132);
            this.lbOnlinePlayers.Sorted = true;
            this.lbOnlinePlayers.TabIndex = 2;
            this.lbOnlinePlayers.SelectedIndexChanged += new System.EventHandler(this.lbOnlinePlayers_SelectedIndexChanged);
            // 
            // lblUserloggedin
            // 
            this.lblUserloggedin.AutoSize = true;
            this.lblUserloggedin.BackColor = System.Drawing.Color.Gold;
            this.lblUserloggedin.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUserloggedin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserloggedin.Location = new System.Drawing.Point(134, 0);
            this.lblUserloggedin.Name = "lblUserloggedin";
            this.lblUserloggedin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserloggedin.Size = new System.Drawing.Size(266, 16);
            this.lblUserloggedin.TabIndex = 3;
            this.lblUserloggedin.Text = "Logged In As Username111111111111";
            this.lblUserloggedin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOnlinePlayers
            // 
            this.lblOnlinePlayers.AutoSize = true;
            this.lblOnlinePlayers.BackColor = System.Drawing.Color.Transparent;
            this.lblOnlinePlayers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnlinePlayers.ForeColor = System.Drawing.Color.White;
            this.lblOnlinePlayers.Location = new System.Drawing.Point(122, 156);
            this.lblOnlinePlayers.Name = "lblOnlinePlayers";
            this.lblOnlinePlayers.Size = new System.Drawing.Size(150, 23);
            this.lblOnlinePlayers.TabIndex = 4;
            this.lblOnlinePlayers.Text = "Online Players";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(12, 41);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(376, 118);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // TmrPlayerListRefresh
            // 
            this.TmrPlayerListRefresh.Tick += new System.EventHandler(this.TmrPlayerListRefresh_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(189, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "High Score";
            // 
            // TmrPlayerChallengeStatus
            // 
            this.TmrPlayerChallengeStatus.Tick += new System.EventHandler(this.TmrPlayerChallengeStatus_Tick);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 393);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblOnlinePlayers);
            this.Controls.Add(this.lblUserloggedin);
            this.Controls.Add(this.lbOnlinePlayers);
            this.Controls.Add(this.btnChallengePlayer);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMainMenu";
            this.Text = "Spitfire! Rap Battle Simulator";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChallengePlayer;
        private System.Windows.Forms.ListBox lbOnlinePlayers;
        private System.Windows.Forms.Label lblOnlinePlayers;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblUserloggedin;
        private System.Windows.Forms.Timer TmrPlayerListRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer TmrPlayerChallengeStatus;
    }
}