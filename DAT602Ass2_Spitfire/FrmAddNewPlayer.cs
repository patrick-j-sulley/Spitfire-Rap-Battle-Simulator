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
    public partial class FrmAddNewPlayer : Form
    {
        public FrmAddNewPlayer()
        {
            InitializeComponent();
        }

        private frmAdminMenu _PrevForm;

        private Byte _AdminStatus;

        private void AdminStatusCheck()
        {

            if (CbAdmin.Checked == true)
            {
                _AdminStatus = 1;
            }
            else
            {
                _AdminStatus = 0;
            }

        }

        private void UserCreate()
        {
            byte lcResult = Convert.ToByte(ClsDBConnection.DbFunction("User_Create", new Dictionary<string, object>
            {
                ["prUserName"] = TxtUsername.Text,
                ["prUserPassword"] = TxtPassword.Text,
                ["prAdminStatus"] = _AdminStatus
            }));
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _PrevForm = new frmAdminMenu();
            _PrevForm.ShowDialog();
            this.Close();
        }

        private void BtnCreatePlayer_Click(object sender, EventArgs e)
        {
            DialogResult lcCreatePlayerResult = MessageBox.Show("Press OK to Add a New Player", "New Player Creation", MessageBoxButtons.OKCancel);
            if (lcCreatePlayerResult == DialogResult.OK)
            {
                byte lcResult = Convert.ToByte(ClsDBConnection.DbFunction("User_Check", new Dictionary<string, object>
                {
                    ["prUserName"] = TxtUsername.Text
                }));

                switch (lcResult)
                {
                    case (1):
                        DialogResult lcUserAlreadyExistsDialogResult = MessageBox.Show("Please enter unique player details and try again.", "Player Already Exists", MessageBoxButtons.OK);
                        break;

                    case (2):
                        AdminStatusCheck();
                        UserCreate();
                        DialogResult lcSuccessfulUserCreateDialogResult = MessageBox.Show("A New Player has been Created.", "Player Creation Successful", MessageBoxButtons.OK);
                        this.Visible = false;
                        _PrevForm = new frmAdminMenu();
                        _PrevForm.ShowDialog();
                        this.Close();
                        break;





                }
            }
        }
    }
}
