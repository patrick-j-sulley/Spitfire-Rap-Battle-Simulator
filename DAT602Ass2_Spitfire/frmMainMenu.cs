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
    partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private frmLogin _PrevForm;

        private frmGameProcess _NextForm;

        private string _ChallengedPlayer;

        private Int32 _GameID;



        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            TmrPlayerListRefresh.Start();
            TmrPlayerChallengeStatus.Start();

            lblUserloggedin.Text = "Logged In As " + ClsLogin._Username;

            DataTable lcOnlinePlayers = ClsDBConnection.SProcTable("ShowAllOnlineAndNotInGamePlayers", new Dictionary<string, object>

            { ["prPlayerName"] = ClsLogin._Username });

            lbOnlinePlayers.DataSource = null;

            lbOnlinePlayers.DataSource = (from DataRow lcRow in lcOnlinePlayers.Rows

                                          select lcRow["UserName"] + "\t" + lcRow["HighScore"]).ToList();

            btnChallengePlayer.Enabled = false;

        }

        private void TmrPlayerListRefresh_Tick(object sender, EventArgs e)
        {
            try
            {
                int lcCurrentSelection = lbOnlinePlayers.SelectedIndex;

                DataTable lcOnlinePlayers = ClsDBConnection.SProcTable("ShowAllOnlineAndNotInGamePlayers", new Dictionary<string, object>

                { ["prPlayerName"] = ClsLogin._Username });

                lbOnlinePlayers.DataSource = null;

                lbOnlinePlayers.DataSource = (from DataRow lcRow in lcOnlinePlayers.Rows

                                              select lcRow["UserName"] + "\t" + lcRow["HighScore"]).ToList();

                lbOnlinePlayers.SelectedIndex = lcCurrentSelection;
            }
            catch
            {
                lbOnlinePlayers.DataSource = null;
            }


        }

        private void TmrPlayerChallengeStatus_Tick(object sender, EventArgs e)
        {

            byte lcResult = Convert.ToByte(ClsDBConnection.DbFunction("Player_Challenged_Status", new Dictionary<string, object>
            { ["prUserName"] = ClsLogin._Username }));
            switch (lcResult)
            { 
                case (1):
                {
                        TmrPlayerChallengeStatus.Stop();
                        TmrPlayerListRefresh.Stop();
                        DataTable lcPlayer2Game = ClsDBConnection.SProcTable("Player2_Game_ID_Retrieve", new Dictionary<string, object>
                        { ["prPlayer2Name"] = ClsLogin._Username });
                        _GameID = Convert.ToInt32(lcPlayer2Game.Rows[0]["ID"]);
                        ClsGameProcess._GameID = _GameID;
                        this.Visible = false;
                        _NextForm = new frmGameProcess();
                        _NextForm.ShowDialog();
                        this.Close();

                    }
                    break;
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult lcLogoutResult = MessageBox.Show("Are you sure you would like to logout?", "Logout Requested", MessageBoxButtons.YesNo);
            if (lcLogoutResult == DialogResult.Yes)
            {

                lcUserLogout();


            }

        }

        private void lcUserLogout()
        {

            byte lcResult = Convert.ToByte(ClsDBConnection.DbFunction("User_Logout", new Dictionary<string, object>
            { ["prUserName"] = ClsLogin._Username }));
            switch (lcResult)
            {
                case (1):
                    MessageBox.Show("Press OK to go back to the Login Menu", "Logout Successful", MessageBoxButtons.OK);
                    this.Visible = false;
                    _PrevForm = new frmLogin();
                    _PrevForm.ShowDialog();
                    this.Close();
                    break;

                case (2):
                    MessageBox.Show("This account is already logged out, please contact an admin for assistance.", "Error: Logout Unsuccessful", MessageBoxButtons.OK);
                    break;
            }

        }

        private void btnChallengePlayer_Click(object sender, EventArgs e)
        {

            string lcChallengedPlayer = lbOnlinePlayers.SelectedItem.ToString();

            _ChallengedPlayer = lcChallengedPlayer.Split('\t').FirstOrDefault();

            DialogResult lcChallengeResult = MessageBox.Show("Are you sure you would like to initiate lyrical combat with" + " " + _ChallengedPlayer, "You Have Requested to Challenge" + " " + _ChallengedPlayer, MessageBoxButtons.YesNo);
            if (lcChallengeResult == DialogResult.Yes)
            {
                //try
                //{
                    byte lcResult = Convert.ToByte(ClsDBConnection.DbFunction("User_GameCheck", new Dictionary<string, object>
                    { ["prUserName"] = ClsLogin._Username }));
                    switch (lcResult)
                    {

                        case (1):
                            MessageBox.Show("Please contact an admin to resolve this issue", "Error! You Are Already In a Game.", MessageBoxButtons.OK);
                            break;

                        case (2):
                            ChallengedPlayerGameCheck();
                            StartUpNewGame();
                            ClsGameProcess._GameID = _GameID;
                            this.Visible = false;
                            _NextForm = new frmGameProcess();
                            _NextForm.ShowDialog();
                            this.Close();
                            break;
                    }
                //}
                //catch
                //{
                //    //MessageBox.Show("Please try again", "Error! Game Challenge Unsuccessful.", MessageBoxButtons.OK);

                //}


            }
        }

        private void ChallengedPlayerGameCheck()
        {

            byte lcResult = Convert.ToByte(ClsDBConnection.DbFunction("User_GameCheck", new Dictionary<string, object>
            { ["prUserName"] = _ChallengedPlayer }));
            switch (lcResult)
            {

                case (1):
                    MessageBox.Show("Select another player and try again.", _ChallengedPlayer + " " + "Is Already In A Game", MessageBoxButtons.OK);
                    break;

            }


        }

        private void StartUpNewGame()
        {

            byte lcResult = Convert.ToByte(ClsDBConnection.DbFunction("User_GameStart", new Dictionary<string, object>
            { ["prUserName1"] = ClsLogin._Username, ["prUserName2"] = _ChallengedPlayer }));

            _GameID = lcResult;

        }

        private void lbOnlinePlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnChallengePlayer.Enabled = true;
        }
    }
}

