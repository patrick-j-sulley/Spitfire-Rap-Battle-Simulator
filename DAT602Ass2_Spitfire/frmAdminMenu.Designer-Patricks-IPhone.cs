namespace DAT602Ass2_Spitfire
{
    partial class frmAdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMenu));
            this.lbRunningGames = new System.Windows.Forms.ListBox();
            this.lbOnlinePlayers = new System.Windows.Forms.ListBox();
            this.btnKillGame = new System.Windows.Forms.Button();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.btnAddNewPlayer = new System.Windows.Forms.Button();
            this.btnUpdatePlayerData = new System.Windows.Forms.Button();
            this.lblRunningGames = new System.Windows.Forms.Label();
            this.lblOnlinePlayers = new System.Windows.Forms.Label();
            this.lblAdminLogged = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblAdminMenu = new System.Windows.Forms.Label();
            this.TmrOnlinePlayersRefresh = new System.Windows.Forms.Timer(this.components);
            this.TmrRunningGamesRefresh = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRunningGames
            // 
            this.lbRunningGames.FormattingEnabled = true;
            this.lbRunningGames.ItemHeight = 16;
            this.lbRunningGames.Location = new System.Drawing.Point(12, 135);
            this.lbRunningGames.Name = "lbRunningGames";
            this.lbRunningGames.Size = new System.Drawing.Size(301, 148);
            this.lbRunningGames.TabIndex = 0;
            // 
            // lbOnlinePlayers
            // 
            this.lbOnlinePlayers.FormattingEnabled = true;
            this.lbOnlinePlayers.ItemHeight = 16;
            this.lbOnlinePlayers.Location = new System.Drawing.Point(319, 135);
            this.lbOnlinePlayers.Name = "lbOnlinePlayers";
            this.lbOnlinePlayers.Size = new System.Drawing.Size(295, 148);
            this.lbOnlinePlayers.TabIndex = 1;
            // 
            // btnKillGame
            // 
            this.btnKillGame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKillGame.Location = new System.Drawing.Point(15, 289);
            this.btnKillGame.Name = "btnKillGame";
            this.btnKillGame.Size = new System.Drawing.Size(298, 41);
            this.btnKillGame.TabIndex = 2;
            this.btnKillGame.Text = "Kill Game";
            this.btnKillGame.UseVisualStyleBackColor = true;
            this.btnKillGame.Click += new System.EventHandler(this.btnKillGame_Click);
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePlayer.Location = new System.Drawing.Point(319, 289);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(295, 41);
            this.btnRemovePlayer.TabIndex = 3;
            this.btnRemovePlayer.Text = "Remove Player";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // btnAddNewPlayer
            // 
            this.btnAddNewPlayer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPlayer.Location = new System.Drawing.Point(15, 336);
            this.btnAddNewPlayer.Name = "btnAddNewPlayer";
            this.btnAddNewPlayer.Size = new System.Drawing.Size(298, 46);
            this.btnAddNewPlayer.TabIndex = 4;
            this.btnAddNewPlayer.Text = "Add a New Player";
            this.btnAddNewPlayer.UseVisualStyleBackColor = true;
            this.btnAddNewPlayer.Click += new System.EventHandler(this.btnAddNewPlayer_Click);
            // 
            // btnUpdatePlayerData
            // 
            this.btnUpdatePlayerData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePlayerData.Location = new System.Drawing.Point(319, 337);
            this.btnUpdatePlayerData.Name = "btnUpdatePlayerData";
            this.btnUpdatePlayerData.Size = new System.Drawing.Size(295, 45);
            this.btnUpdatePlayerData.TabIndex = 5;
            this.btnUpdatePlayerData.Text = "Update Player Data";
            this.btnUpdatePlayerData.UseVisualStyleBackColor = true;
            this.btnUpdatePlayerData.Click += new System.EventHandler(this.btnUpdatePlayerData_Click);
            // 
            // lblRunningGames
            // 
            this.lblRunningGames.AutoSize = true;
            this.lblRunningGames.BackColor = System.Drawing.Color.Transparent;
            this.lblRunningGames.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunningGames.ForeColor = System.Drawing.Color.White;
            this.lblRunningGames.Location = new System.Drawing.Point(80, 93);
            this.lblRunningGames.Name = "lblRunningGames";
            this.lblRunningGames.Size = new System.Drawing.Size(164, 23);
            this.lblRunningGames.TabIndex = 6;
            this.lblRunningGames.Text = "Running Games";
            // 
            // lblOnlinePlayers
            // 
            this.lblOnlinePlayers.AutoSize = true;
            this.lblOnlinePlayers.BackColor = System.Drawing.Color.Transparent;
            this.lblOnlinePlayers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnlinePlayers.ForeColor = System.Drawing.Color.White;
            this.lblOnlinePlayers.Location = new System.Drawing.Point(385, 93);
            this.lblOnlinePlayers.Name = "lblOnlinePlayers";
            this.lblOnlinePlayers.Size = new System.Drawing.Size(150, 23);
            this.lblOnlinePlayers.TabIndex = 7;
            this.lblOnlinePlayers.Text = "Online Players";
            this.lblOnlinePlayers.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAdminLogged
            // 
            this.lblAdminLogged.AutoSize = true;
            this.lblAdminLogged.BackColor = System.Drawing.Color.Gold;
            this.lblAdminLogged.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAdminLogged.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAdminLogged.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminLogged.Location = new System.Drawing.Point(527, 0);
            this.lblAdminLogged.Name = "lblAdminLogged";
            this.lblAdminLogged.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAdminLogged.Size = new System.Drawing.Size(99, 34);
            this.lblAdminLogged.TabIndex = 8;
            this.lblAdminLogged.Text = "Logged In As\r\nUsername";
            this.lblAdminLogged.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(12, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(109, 36);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "<< Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblAdminMenu
            // 
            this.lblAdminMenu.AutoSize = true;
            this.lblAdminMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminMenu.ForeColor = System.Drawing.Color.Gold;
            this.lblAdminMenu.Location = new System.Drawing.Point(200, 30);
            this.lblAdminMenu.Name = "lblAdminMenu";
            this.lblAdminMenu.Size = new System.Drawing.Size(294, 55);
            this.lblAdminMenu.TabIndex = 10;
            this.lblAdminMenu.Text = "Admin Menu";
            // 
            // TmrOnlinePlayersRefresh
            // 
            this.TmrOnlinePlayersRefresh.Tick += new System.EventHandler(this.TmrOnlinePlayersRefresh_Tick);
            // 
            // TmrRunningGamesRefresh
            // 
            this.TmrRunningGamesRefresh.Tick += new System.EventHandler(this.TmrRunningGamesRefresh_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Player 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(139, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Player 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(316, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Username";
            // 
            // frmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(626, 413);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdminMenu);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblAdminLogged);
            this.Controls.Add(this.lblOnlinePlayers);
            this.Controls.Add(this.lblRunningGames);
            this.Controls.Add(this.btnUpdatePlayerData);
            this.Controls.Add(this.btnAddNewPlayer);
            this.Controls.Add(this.btnRemovePlayer);
            this.Controls.Add(this.btnKillGame);
            this.Controls.Add(this.lbOnlinePlayers);
            this.Controls.Add(this.lbRunningGames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAdminMenu";
            this.Text = "Admin Menu";
            this.Load += new System.EventHandler(this.frmAdminMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRunningGames;
        private System.Windows.Forms.ListBox lbOnlinePlayers;
        private System.Windows.Forms.Button btnKillGame;
        private System.Windows.Forms.Button btnRemovePlayer;
        private System.Windows.Forms.Button btnAddNewPlayer;
        private System.Windows.Forms.Button btnUpdatePlayerData;
        private System.Windows.Forms.Label lblRunningGames;
        private System.Windows.Forms.Label lblOnlinePlayers;
        private System.Windows.Forms.Label lblAdminLogged;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblAdminMenu;
        private System.Windows.Forms.Timer TmrOnlinePlayersRefresh;
        private System.Windows.Forms.Timer TmrRunningGamesRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}