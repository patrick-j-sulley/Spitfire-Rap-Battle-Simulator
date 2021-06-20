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
    public partial class frmAdminMenu : Form
    {
        public frmAdminMenu()
        {
            InitializeComponent();
        }

        private frmLogin _PrevForm;

        private FrmAddNewPlayer _NewPlayerForm;

        private FrmEditPlayer _NewEditPlayerForm;

        private string _GameID;

        private string _PlayerName1;

        private string _PlayerName2;

        private string _PlayerNameNotPlaying;


        private void frmAdminMenu_Load(object sender, EventArgs e)
        {
            lblAdminLogged.Text = "Logged In As " + ClsLogin._Username;
            TmrOnlinePlayersRefresh.Start();
            TmrRunningGamesRefresh.Start();
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


        private void btnAddNewPlayer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _NewPlayerForm = new FrmAddNewPlayer();
            _NewPlayerForm.ShowDialog();
            this.Close();
        }

        private void btnUpdatePlayerData_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            ClsAdminMenu._Username = lbOnlinePlayers.GetItemText(lbOnlinePlayers.SelectedItem);
            _NewEditPlayerForm = new FrmEditPlayer();
            _NewEditPlayerForm.ShowDialog();
            this.Close();
        }

        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult lcPlayerDeletionResult = MessageBox.Show("Are you sure you would like to permanently delete this player? This action cannot be undone.", "Player Deletion Requested", MessageBoxButtons.YesNo);
                if (lcPlayerDeletionResult == DialogResult.Yes)
                {

                    byte lcResult = Convert.ToByte(ClsDBConnection.DbFunction("User_Delete", new Dictionary<string, object>
                    { ["prUserName"] = lbOnlinePlayers.GetItemText(lbOnlinePlayers.SelectedItem) }));
                    MessageBox.Show("Press OK to Continue", "Player Successfully Deleted", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Press OK to Go Back", "Error! Player Deletion Unsuccessful", MessageBoxButtons.OK);
            }
        }

        private void TmrOnlinePlayersRefresh_Tick(object sender, EventArgs e)
        {
            try
            {
                int lcCurrentSelection = lbOnlinePlayers.SelectedIndex;

                DataTable lcOnlinePlayers = ClsDBConnection.SProcTable("ShowAllOnlinePlayers", new Dictionary<string, object>

                { ["prPlayerName"] = ClsLogin._Username });

                lbOnlinePlayers.DataSource = null;

                lbOnlinePlayers.DataSource = (from DataRow lcRow in lcOnlinePlayers.Rows

                                              select lcRow["UserName"]).ToList();


                lbOnlinePlayers.SelectedIndex = lcCurrentSelection;
            }
            catch
            {
                lbOnlinePlayers.DataSource = null;
            }
        }

        private void TmrRunningGamesRefresh_Tick(object sender, EventArgs e)
        {
            try
            {
                int lcCurrentSelection = lbRunningGames.SelectedIndex;

                DataTable lcRunningGames = ClsDBConnection.SProcTable("ShowAllRunningGames", new Dictionary<string, object>

                { ["prPlaceholder"] = "*" });

                lbRunningGames.DataSource = null;

                lbRunningGames.DataSource = (from DataRow lcRow in lcRunningGames.Rows

                                             select lcRow["ID"] + " " + "\t" + lcRow["PlayerUserName1"] + "\t" + lcRow["PlayerUserName2"]).ToList();


                lbRunningGames.SelectedIndex = lcCurrentSelection;
            }
            catch
            {
                lbRunningGames.DataSource = null;
            }
        }

        private void btnKillGame_Click(object sender, EventArgs e)
        {
            string lcGame = lbRunningGames.SelectedItem.ToString();

            _GameID = lcGame.Split(' ').FirstOrDefault();

            DialogResult lcPlayerDeletionResult = MessageBox.Show("Are you sure you would like to kill this game process? This action cannot be undone.", "Kill Game Process Requested", MessageBoxButtons.YesNo);
            if (lcPlayerDeletionResult == DialogResult.Yes)
                try
                {
                    RetrieveGamePlayerNames();
                    KillGame();
                    _PlayerNameNotPlaying = _PlayerName1;
                    SetPlayerStatusNotPlaying();
                    _PlayerNameNotPlaying = _PlayerName2;
                    SetPlayerStatusNotPlaying();
                    MessageBox.Show("Press OK to Continue", "Game Process Successfully Killed", MessageBoxButtons.OK);

                }
                catch
                {
                    MessageBox.Show("Press OK to Go Back", "Error! Game Deletion Unsuccessful", MessageBoxButtons.OK);

                }

        }

        private void KillGame()
        {
                byte lcResult = Convert.ToByte(ClsDBConnection.DbFunction("Admin_DeleteGame", new Dictionary<string, object>
                { ["prGameID"] = _GameID }));
        }

        private void RetrieveGamePlayerNames()
        {
            DataTable lcGamePlayerNames = ClsDBConnection.SProcTable("Game_PlayerName_Retrieve", new Dictionary<string, object>

            { ["prGameID"] = _GameID }); 

            _PlayerName1 = (lcGamePlayerNames.Rows[0]["PlayerUserName1"].ToString());

            _PlayerName2 = (lcGamePlayerNames.Rows[0]["PlayerUserName2"].ToString());
        }

        private void SetPlayerStatusNotPlaying()
        {

            byte lcResult = Convert.ToByte(ClsDBConnection.DbFunction("User_IsNoLongerPlaying_StatusChange", new Dictionary<string, object>
            { ["prUserName"] = _PlayerNameNotPlaying }));

        }


    }
}

