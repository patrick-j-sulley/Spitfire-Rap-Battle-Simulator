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
    public partial class FrmEditPlayer : Form
    {
        public FrmEditPlayer()
        {
            InitializeComponent();

        }

        private Byte _AdminStatus;

        private frmAdminMenu _PrevForm;

        private FrmChangePassword _ChangePasswordFrm;

        private string _Username;

        private string _OldHighScore;

        private void FrmEditPlayer_Load(object sender, EventArgs e)
        {

            DataTable lcPlayerDetails = ClsDBConnection.SProcTable("ShowDetailsOfPlayer", new Dictionary<string, object>

            { ["prPlayerName"] = ClsAdminMenu._Username });

            TxtUsername.Text = lcPlayerDetails.Rows[0]["UserName"].ToString();

            TxtHighScore.Text = lcPlayerDetails.Rows[0]["HighScore"].ToString();

            _Username = TxtUsername.Text;

            TxtUsername.Enabled = false;

            _OldHighScore = TxtHighScore.Text;

        }

        private void AdminStatusCheck()
        {

            if (CbAdministrator.Checked == true)
            {
                _AdminStatus = 1;
            }
            else
            {
                _AdminStatus = 0;
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _PrevForm = new frmAdminMenu();
            _PrevForm.ShowDialog();
            this.Close();
        }

        private void btnConfirmChanges_Click(object sender, EventArgs e)
        {

            DialogResult lcEditPlayerDetailRequestResult = MessageBox.Show("Press OK to Edit Player Details", "Edit Player Details", MessageBoxButtons.OKCancel);
            if (lcEditPlayerDetailRequestResult == DialogResult.OK)
            {
                AdminStatusCheck();
                EditPlayerDetails();
            }
        }

        private void EditPlayerDetails()
        {

            byte lcResult = Convert.ToByte(ClsDBConnection.DbFunction("Update_Player_Details", new Dictionary<string, object>
            { ["prUserName"] = _Username, ["prOldHighScore"] = _OldHighScore,
                ["prNewHighScore"] = TxtHighScore.Text, ["prAdminStatus"] = _AdminStatus }));

            DialogResult lcEditPlayerDetailResult = MessageBox.Show("Press OK to go back to the admin menu", "Player Details Successfully Changed", MessageBoxButtons.OK);

            this.Visible = false;
            _PrevForm = new frmAdminMenu();
            _PrevForm.ShowDialog();
            this.Close();

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            _ChangePasswordFrm = new FrmChangePassword();
            _ChangePasswordFrm.ShowDialog();
        }
    }
}
