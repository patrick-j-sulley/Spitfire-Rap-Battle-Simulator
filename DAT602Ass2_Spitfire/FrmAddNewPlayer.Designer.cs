namespace DAT602Ass2_Spitfire
{
    partial class FrmAddNewPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddNewPlayer));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.CbAdmin = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCreatePlayer = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Most Wazted", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(0, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Player";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(129, 96);
            this.TxtUsername.MaxLength = 20;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(200, 22);
            this.TxtUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(129, 137);
            this.TxtPassword.MaxLength = 16;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(200, 22);
            this.TxtPassword.TabIndex = 3;
            // 
            // CbAdmin
            // 
            this.CbAdmin.AutoSize = true;
            this.CbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.CbAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbAdmin.ForeColor = System.Drawing.Color.White;
            this.CbAdmin.Location = new System.Drawing.Point(129, 178);
            this.CbAdmin.Name = "CbAdmin";
            this.CbAdmin.Size = new System.Drawing.Size(166, 27);
            this.CbAdmin.TabIndex = 4;
            this.CbAdmin.Text = "Administrator";
            this.CbAdmin.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // BtnCreatePlayer
            // 
            this.BtnCreatePlayer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreatePlayer.Location = new System.Drawing.Point(9, 228);
            this.BtnCreatePlayer.Name = "BtnCreatePlayer";
            this.BtnCreatePlayer.Size = new System.Drawing.Size(156, 33);
            this.BtnCreatePlayer.TabIndex = 6;
            this.BtnCreatePlayer.Text = "Create Player";
            this.BtnCreatePlayer.UseVisualStyleBackColor = true;
            this.BtnCreatePlayer.Click += new System.EventHandler(this.BtnCreatePlayer_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(232, 228);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(97, 33);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmAddNewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(345, 273);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnCreatePlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbAdmin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmAddNewPlayer";
            this.Text = "FrmAddNewPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.CheckBox CbAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCreatePlayer;
        private System.Windows.Forms.Button BtnCancel;
    }
}