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
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();

            DataTable lcPlayerDetails = ClsDBConnection.SProcTable("ShowDetailsOfPlayer", new Dictionary<string, object>

            { ["prPlayerName"] = ClsAdminMenu._Username });

            _Username = lcPlayerDetails.Rows[0]["UserName"].ToString();
        }

        private string _Username;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                byte lcResult = Convert.ToByte(ClsDBConnection.DbFunction("Update_Player_Password", new Dictionary<string, object>
                { ["prUserName"] = _Username, ["prNewPassword"] = txtNewPassword.Text }));

                MessageBox.Show("Press Ok to Go Back to the Edit Player Form", "Password Change Successful!");
                this.Visible = false;
                this.Close();


            }
            catch
            {
                MessageBox.Show("Please enter a Password with correct formatting and Try Again.", "Error! Password Change Unsuccessful");
            }

        }


        }
    }

