using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAT602Ass2_Spitfire
{
     partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private string prUsername;

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private frmMainMenu _NextForm;

        private frmAdminMenu _NextAdminForm;

        private void btnLogin_Click(object sender, EventArgs e) // put in case statements
        {

            lcUserCheck();

        }

        private void lcUserCheck()
        {

            byte lcResult = Convert.ToByte(ClsDBConnection.DbFunction("User_Check", new Dictionary<string, object>
            { ["prUserName"] = txtUsername.Text}));

            switch (lcResult)
            {
                case (1):
                    lcAdminCheck();
                break;



                case (2):
                DialogResult lcNoUserDialogResult = MessageBox.Show("Would you like to create a Spitfire profile with the Username and Password you just entered? (You will be logged into the game if you do so)", "User Not Detected", MessageBoxButtons.YesNo);
                if (lcNoUserDialogResult == DialogResult.Yes)
                {
                    lcUserRegister();
                }
                break;

            }

        }

        private void lcUserLogin()
        {

            DialogResult lcCheckDialogResult = MessageBox.Show("Press OK to Login to Spitfire", "User Detected", MessageBoxButtons.OK);


            byte lcResult = Convert.ToByte(ClsDBConnection.DbFunction("User_Login", new Dictionary<string, object>
            { ["prUserName"] = txtUsername.Text, ["prUserPassword"] = txtPassword.Text }));

            switch (lcResult)
            {
                case (1):
                    prUsername = txtUsername.Text;
                    ClsLogin._Username = prUsername;
                    this.Visible = false;
                    _NextForm = new frmMainMenu();
                    _NextForm.ShowDialog();
                    this.Close();
                    break;

                case (2):
                    {
                        MessageBox.Show("User Already Online.", "Login Unsuccessful", MessageBoxButtons.OK);
                    }
                break;
            }
        }

        private void lcUserRegister()
        {
            byte lcResult = Convert.ToByte(ClsDBConnection.DbFunction("User_Register", new Dictionary<string, object>
            { ["prUserName"] = txtUsername.Text, ["prUserPassword"] = txtPassword.Text }));
            switch(lcResult)
            {
                case (1):
                MessageBox.Show("Press OK to login to Spitfire.", "User Registration Successful!", MessageBoxButtons.OK);
                lcUserLogin();
                break;

            }
        }

        private void lcAdminCheck()
        {

            byte lcResult = Convert.ToByte(ClsDBConnection.DbFunction("Admin_Check", new Dictionary<string, object>
            { ["prUserName"] = txtUsername.Text}));
            switch (lcResult)
            {
                case (1):
                    lcAdminLogin();
                    break;

                case (2):

                    lcUserLogin();
               break;


            }

        }

        private void lcAdminLogin()
        {

            DialogResult lcCheckDialogResult = MessageBox.Show("Press OK to Login to the Spitfire Admin Menu", "Admin Detected", MessageBoxButtons.OK);


            byte lcResult = Convert.ToByte(ClsDBConnection.DbFunction("User_Login", new Dictionary<string, object>
            { ["prUserName"] = txtUsername.Text, ["prUserPassword"] = txtPassword.Text }));

            switch (lcResult)
            {
                case (1):
                    prUsername = txtUsername.Text;
                    ClsLogin._Username = prUsername;
                    this.Visible = false;
                    _NextAdminForm = new frmAdminMenu();
                    _NextAdminForm.ShowDialog();
                    this.Close();
                    break;

                case (2):
                    {
                        MessageBox.Show("Admin Already Online.", "Login Unsuccessful", MessageBoxButtons.OK);
                    }
                    break;
            }
        }


    }
}

    

