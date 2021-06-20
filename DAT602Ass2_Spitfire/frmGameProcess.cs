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
    public partial class frmGameProcess : Form
    {

        private string _Player1Name; //Name of Player 1
        private string _Player2Name; //Name of Player 2

        private string _CurrentTurnPlayerName; //Name of Current Turn Player

        private int _GameRoundCounter = 1; //3 Rounds Per Game

        private int _TurnLineCounter; //Goes up to 8/9 (8 Lines per turn) then restarts back to one to prepare for new turn

        private int _PlayerTurnCounter; //Goes up to 2/3 (2 Turns per round), goes up by one when _TurnLineCounter 
                                            //reaches 8 and restarts back to one when it reaches 3

        private int _LinePoints = 0;

        private int _Player1Score = 0; //0-10 Pointes Per Line * 8 Lines Per Turn * 2 Turns Per Round * 3 Rounds = 480 Total Max Points - 0 Total Minimum Points
        private int _Player2Score = 0; //0-10 Pointes Per Line * 8 Lines Per Turn * 2 Turns Per Round * 3 Rounds = 480 Total Max Points - 0 Total Minimum Points

        private int _LineTimeLeft = 30;



        //UNUSED VARIABLES  

        //private byte _CurrentGameTurnNo = 1; //Max 12, 6 Per Player
        ////Turn No -  1, 3, 5, 7, 9, 11 = Player 1 Turns
        //// Turn No -  2, 4, 6, 8, 10, 12 = Player 2 Turns
        //private byte _CurrentGameLineNo = 1; //Max 96, 48 Per Player
        //// Line No -  1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47 = Player 1 Lines
        //// Line No -  2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48 = Player 2 Lines

        //private byte _Player1CurrentTurn; //2 Turns per Round * 3 Rounds = 6 Total Max Rounds Per Player = 12 Total
        //private byte _Player2CurrentTurn; //2 Turns per Round * 3 Rounds = 6 Total Max Rounds Per Player = 12 Total     

        //private byte _Player1LineNumber; //8 Per Turn * 2 Turns Per Round * 3 Rounds = 48 Total Max Lines Per Player
        //private byte _Player2LineNumber; //8 Per Turn * 2 Turns Per Round * 3 Rounds = 48 Total Max Lines Per Player

        //private int _LastLineID;

        //private int _OtherPlayerTurnCounter = 1;

        public frmGameProcess()
        {
            InitializeComponent();
            DataTable lcGameDetails = ClsDBConnection.SProcTable("Retrieve_Game_Details", new Dictionary<string, object>
            { ["prGameID"] = ClsGameProcess._GameID }); //Retrieve All Game Details

            _Player1Name = lcGameDetails.Rows[0]["PlayerUserName1"].ToString(); //Filling the P1 Name Label with Player 1's Name
            lblPlayer1.Text = _Player1Name;

            _Player2Name = lcGameDetails.Rows[0]["PlayerUserName2"].ToString(); //Filling the P2 Name Label with Player 2's Name
            lblPlayer2.Text = _Player2Name;

            CurrentPlayerTurnCheck_LabelUpdate();

            UpdateDisplay();

            lblUserloggedin.Text = "Logged in As: " + ClsLogin._Username;

            TmrCheckAndUpdate.Start();
            TmrChecker.Start();

            lblLineTimer.Visible = false;
            txtLine.Enabled = false;
            btnSpitLine.Enabled = false;
            TmrLineTime.Enabled = false;
            lblLineTimer.Visible = false;
            PlayerTurnCheck();
            //TmrLineTime.Start();
        }

        private void CurrentPlayerTurnCheck_LabelUpdate()
        {
            DataTable lcGameDetails = ClsDBConnection.SProcTable("Retrieve_Game_Details", new Dictionary<string, object>
            { ["prGameID"] = ClsGameProcess._GameID });

            if (Convert.ToString(lcGameDetails.Rows[0]["PlayerUserName1"]) == Convert.ToString(lcGameDetails.Rows[0]["CurrentTurnPlayer"]))
            {
                lblCurrentTurnP1.Text = "Turn:" + " " + Convert.ToString(lcGameDetails.Rows[0]["P1_CurrentTurn"]) + "/2"; //Filling the Player 1 Turn Label with Player 1's Current Turn
                lblCurrentScoreP1.Text = "Score:" + " " + Convert.ToString(lcGameDetails.Rows[0]["P1_GameScore"]); //Filling the Player 1 Score Label with Player 1's Current Score
            }
            else
            {
                lblCurrentTurnP2.Text = "Turn:" + " " + Convert.ToString(lcGameDetails.Rows[0]["P2_CurrentTurn"]) + "/2"; //Filling the Player 2 Turn Label with Player 2's Current Turn
                lblCurrentScoreP2.Text = "Score:" + " " + Convert.ToString(lcGameDetails.Rows[0]["P2_GameScore"]); //Filling the Player 2 Score Label with Player 2's Current Score
            }

        }

        private void TmrLineTime_Tick(object sender, EventArgs e)
        {

            if (_LineTimeLeft > 0)
            {
                _LineTimeLeft = _LineTimeLeft - 1;
                lblLineTimer.Text = _LineTimeLeft.ToString();
            }
            else
            {
                TmrLineTime.Stop();
                lblLineTimer.Text = "FAIL";
                //MessageBox.Show("No points will be awarded for this line.", "You Choking Now! Everybodies Joking Now!");
                TurnLineCounterUpdate();
                //PlayerTurnCounterUpdate();
                SpitLine();
                CheckLineCounter();
                UpdatePlayerScore();
                UpdateDisplay();
                _LineTimeLeft = 30;
            }
        }

        private void btnSpitLine_Click(object sender, EventArgs e)
        {
            TmrLineTime.Stop(); //Timer Stops
            LineTimerCheck(); //Checks the Timer for Points for Line
            TurnLineCounterUpdate(); //Adds +1 to the Line Counter
            SpitLine(); //Sends Line Entry to Database
            CheckLineCounter(); //Checks if Line Counter is Above 8 - If above 8 a new turn will begin
            UpdatePlayerScore(); //Updates The Player Score
            RoundEndTurnCheck();
            UpdateDisplay(); //Updates the Display
            GameOverCheck();
            _LineTimeLeft = 30; //Restarts the Counter for Line Entry

        }

        private void LineTimerCheck() //Checks Status of Timer for Points to score for line
        {

            if (_LineTimeLeft >= 27 && _LineTimeLeft < 30)
            {
                _LinePoints = 10;
            }

            else if (_LineTimeLeft >= 23 && _LineTimeLeft < 27)
            {
                _LinePoints = 9;
            }

            else if (_LineTimeLeft >= 20 && _LineTimeLeft < 23)
            {
                _LinePoints = 8;
            }

            else if (_LineTimeLeft >= 17 && _LineTimeLeft < 20)
            {
                _LinePoints = 7;
            }

            else if (_LineTimeLeft >= 14 && _LineTimeLeft < 17)
            {
                _LinePoints = 6;
            }

            else if (_LineTimeLeft >= 11 && _LineTimeLeft < 14)
            {
                _LinePoints = 5;
            }

            else if (_LineTimeLeft >= 8 && _LineTimeLeft < 11)
            {
                _LinePoints = 4;
            }

            else if (_LineTimeLeft >= 5 && _LineTimeLeft < 8)
            {
                _LinePoints = 3;
            }

            else if (_LineTimeLeft >= 2 && _LineTimeLeft < 5)
            {
                _LinePoints = 2;
            }

            else if (_LineTimeLeft > 0 && _LineTimeLeft < 2)
            {
                _LinePoints = 1;
            }

            else if (_LineTimeLeft == 0)
            {
                _LinePoints = 0;
            }
        }

        private void PlayerLineListBoxUpdate()
        {

            DataTable lcPlayer1Lines = ClsDBConnection.SProcTable("Retrieve_Player_Lines", new Dictionary<string, object>
            { ["prPlayerName"] = _Player1Name });

            DataTable lcPlayer2Lines = ClsDBConnection.SProcTable("Retrieve_Player_Lines", new Dictionary<string, object>
            { ["prPlayerName"] = _Player2Name });

            lbLinesPlayer1.DataSource = null;

            lbLinesPlayer1.DataSource = (from DataRow lcRow in lcPlayer1Lines.Rows

                                         select Convert.ToByte(lcRow["Line_Number"]) + "\t" + lcRow["Text_Field"] + "\t" + Convert.ToByte(lcRow["Points"])).ToList();

            lbLinesPlayer2.DataSource = null;

            lbLinesPlayer2.DataSource = (from DataRow lcRow in lcPlayer2Lines.Rows

                                         select Convert.ToByte(lcRow["Line_Number"]) +  "\t" + lcRow["Text_Field"] + "\t" + Convert.ToByte(lcRow["Points"])).ToList();

        }

        private void PlayerTurnCheck()
        {

            DataTable lcGameDetails = ClsDBConnection.SProcTable("Retrieve_Game_Details", new Dictionary<string, object>
            { ["prGameID"] = ClsGameProcess._GameID });

            if (ClsLogin._Username == Convert.ToString(lcGameDetails.Rows[0]["CurrentTurnPlayer"]))
            {
                _CurrentTurnPlayerName = Convert.ToString(lcGameDetails.Rows[0]["CurrentTurnPlayer"]);
                txtLine.Enabled = true;
                btnSpitLine.Enabled = true;
                TmrLineTime.Enabled = true;
                lblLineTimer.Visible = true;
                TmrLineTime.Start();
            }

        }

        private void UpdateDisplay()
        {
            DataTable lcGameDetails = ClsDBConnection.SProcTable("Retrieve_Game_Details", new Dictionary<string, object>
            { ["prGameID"] = ClsGameProcess._GameID });

            lblCurrentScoreP1.Text = "Score:" + " " + Convert.ToString(lcGameDetails.Rows[0]["P1_GameScore"]); //Filling the Current Score Label with Player 1's Score
            lblCurrentScoreP2.Text = "Score:" + " " + Convert.ToString(lcGameDetails.Rows[0]["P2_GameScore"]); //Filling the Current Score Label with Player 2's Score

            lblCurrentTurnP1.Text = "Turn:" + " " + Convert.ToString(lcGameDetails.Rows[0]["P1_CurrentTurn"]) + "/2";
            lblCurrentTurnP2.Text = "Turn:" + " " + Convert.ToString(lcGameDetails.Rows[0]["P2_CurrentTurn"]) + "/2";

            lblPlayerTurn.Text = Convert.ToString(lcGameDetails.Rows[0]["CurrentTurnPlayer"]) + "'s Turn"; //Filling the Current Player Turn Label with Player's Name

            lblRoundNo.Text = "Round:" + " " + Convert.ToString(lcGameDetails.Rows[0]["CurrentRound"]) + "/3"; //Filling the Current Round Label with Current Round

            PlayerLineListBoxUpdate();
        }

        private void CheckLineCounter()
        {
            if (_TurnLineCounter == 8)
            {
                PlayerTurnCounterUpdate();
                RoundEndTurnCheck();
                ChangePlayerTurn();
                _TurnLineCounter = 0;
            }
        }

        private void ChangePlayerTurn()
        {

            if (_CurrentTurnPlayerName == _Player1Name)
            {

                byte lcResult = Convert.ToByte(ClsDBConnection.DbFunction("Game_ChangePlayerTurn", new Dictionary<string, object>
                {
                    ["prGameID"] = ClsGameProcess._GameID,
                    ["prPlayerName"] = _Player2Name

                }));

                lblLineTimer.Visible = false;
                txtLine.Enabled = false;
                btnSpitLine.Enabled = false;
                TmrLineTime.Enabled = false;
                lblLineTimer.Visible = false;

            }
            else if (_CurrentTurnPlayerName == _Player2Name)
            {

                byte lcResult = Convert.ToByte(ClsDBConnection.DbFunction("Game_ChangePlayerTurn", new Dictionary<string, object>
                {
                    ["prGameID"] = ClsGameProcess._GameID,
                    ["prPlayerName"] = _Player1Name

                }));

                lblLineTimer.Visible = false;
                txtLine.Enabled = false;
                btnSpitLine.Enabled = false;
                TmrLineTime.Enabled = false;
                lblLineTimer.Visible = false;

            }
        }

        private void SpitLine()
        {
            int lcResult = Convert.ToInt16(ClsDBConnection.DbFunction("Player_Line_Enter", new Dictionary<string, object>
            {
                ["prGameID"] = ClsGameProcess._GameID,
                ["prPlayerName"] = ClsLogin._Username,
                ["prLineNumber"] = _TurnLineCounter,
                ["prLineText"] = txtLine.Text,
                ["prLinePoints"] = _LinePoints

            }));

            txtLine.Clear();

            //lcResult = _LastLineID;
        }

        private void TurnLineCounterUpdate() //Adds +1 to the Turn Line Counter
        {
            _TurnLineCounter = _TurnLineCounter + 1;
        }

        private void PlayerTurnCounterUpdate() //Adds +1 to the Player Turn Counter
        {

            _PlayerTurnCounter = _PlayerTurnCounter + 1;

            DataTable lcGameDetails = ClsDBConnection.SProcTable("Retrieve_Game_Details", new Dictionary<string, object>
            { ["prGameID"] = ClsGameProcess._GameID });

            if (ClsLogin._Username == Convert.ToString(lcGameDetails.Rows[0]["PlayerUserName1"]))
            {

                int lcResult = Convert.ToByte(ClsDBConnection.DbFunction("Player1_UpdateTurn", new Dictionary<string, object>
                {
                    ["prPlayer1Name"] = ClsLogin._Username,
                    ["prPlayerTurnNo"] = _PlayerTurnCounter

                }));

            }
            else if (ClsLogin._Username == Convert.ToString(lcGameDetails.Rows[0]["PlayerUserName2"]))
            {

                int lcResult = Convert.ToByte(ClsDBConnection.DbFunction("Player2_UpdateTurn", new Dictionary<string, object>
                {
                    ["prPlayer2Name"] = ClsLogin._Username,
                    ["prPlayerTurnNo"] = _PlayerTurnCounter

                }));

            }


        }


        private void txtLine_KeyPress(object sender, KeyPressEventArgs e) //Enforces Textbox to only allow letters, digits & white space
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UpdatePlayerScore()
        {

            DataTable lcGameDetails = ClsDBConnection.SProcTable("Retrieve_Game_Details", new Dictionary<string, object>
            { ["prGameID"] = ClsGameProcess._GameID });

            _Player1Score = Convert.ToInt16(lcGameDetails.Rows[0]["P1_GameScore"]);

            _Player2Score = Convert.ToInt16(lcGameDetails.Rows[0]["P2_GameScore"]);

            if (ClsLogin._Username == Convert.ToString(lcGameDetails.Rows[0]["PlayerUserName1"]))
            {

                _Player1Score = _Player1Score + _LinePoints;

                int lcResult = Convert.ToInt16(ClsDBConnection.DbFunction("Player1_UpdateScore", new Dictionary<string, object>
                {
                    ["prPlayer1Name"] = ClsLogin._Username,
                    ["prPlayerScore"] = _Player1Score

                }));


            }
            else if (ClsLogin._Username == Convert.ToString(lcGameDetails.Rows[0]["PlayerUserName2"]))
            {

                _Player2Score = _Player2Score + _LinePoints;

                int lcResult = Convert.ToInt16(ClsDBConnection.DbFunction("Player2_UpdateScore", new Dictionary<string, object>
                {
                    ["prPlayer2Name"] = ClsLogin._Username,
                    ["prPlayerScore"] = _Player2Score

                }));

            }

        }


        private void RoundEndTurnCheck()
        {


            DataTable lcGameDetails = ClsDBConnection.SProcTable("Retrieve_Game_Details", new Dictionary<string, object>
            { ["prGameID"] = ClsGameProcess._GameID });

            int lcP1Turn = Convert.ToInt16(lcGameDetails.Rows[0]["P1_CurrentTurn"]);

            int lcP2Turn = Convert.ToInt16(lcGameDetails.Rows[0]["P2_CurrentTurn"]);


            if (lcP1Turn == 2 && lcP2Turn == 2)
            {

                _PlayerTurnCounter = 0;

                RestartPlayer1Turn();
                RestartPlayer2Turn();

                GameRoundUpdate();

            }

        }

        private void RestartPlayer1Turn()
        {

            int lcResult = Convert.ToInt16(ClsDBConnection.DbFunction("Player1_UpdateTurn", new Dictionary<string, object>
            {
                ["prPlayer1Name"] = _Player1Name,
                ["prPlayerTurnNo"] = _PlayerTurnCounter

            }));

        }

        private void RestartPlayer2Turn()
        {

            int lcResult = Convert.ToInt16(ClsDBConnection.DbFunction("Player2_UpdateTurn", new Dictionary<string, object>
            {
                ["prPlayer2Name"] = _Player2Name,
                ["prPlayerTurnNo"] = _PlayerTurnCounter

            }));

        }


        private void RemoveLines()
        {

            int lcResult = Convert.ToInt16(ClsDBConnection.DbFunction("Game_RoundStart_RemoveLines", new Dictionary<string, object>
            {
                ["prGameID"] = ClsGameProcess._GameID

            }));

        }

        private void GameRoundUpdate()
        {

            _GameRoundCounter = _GameRoundCounter + 1;

            int lcResult = Convert.ToInt16(ClsDBConnection.DbFunction("Game_StartNewRound", new Dictionary<string, object>
            {
                ["prGameID"] = ClsGameProcess._GameID,
                ["prRoundNo"] = _GameRoundCounter

            }));

            RemoveLines();
            GameOverCheck();

        }

        private void GameOverCheck()
        {


            if (_GameRoundCounter == 4)
            {                
                GameWinnerCheck();                            
            }

            //CONTINUE FROM HERE, IMPLEMENT CHECK FOR ROUND NUMBER BEING 4 TO THEN DECLARE WINNER, REPLACE HIGH SCORE, END GAME ETC...

        }

        private void GameWinnerCheck()
        {
            TmrCheckAndUpdate.Stop();
            TmrLineTime.Stop();
            TmrChecker.Stop();
            lblLineTimer.Visible = false;
            txtLine.Enabled = false;
            btnSpitLine.Enabled = false;
            TmrLineTime.Enabled = false;
            lblLineTimer.Visible = false;
            RemoveLines();

            DataTable lcGameDetails = ClsDBConnection.SProcTable("Retrieve_Game_Details", new Dictionary<string, object>
            { ["prGameID"] = ClsGameProcess._GameID });

            int lcP1GameScore = Convert.ToInt16(lcGameDetails.Rows[0]["P1_GameScore"]);

            int lcP2GameScore = Convert.ToInt16(lcGameDetails.Rows[0]["P2_GameScore"]);

            if (lcP1GameScore > lcP2GameScore)
            {

                MessageBox.Show("Congratulations " + Convert.ToString(lcGameDetails.Rows[0]["PlayerUserName1"]) +
                    ", you achieved victory in the lyrical combat zone with " +
                    Convert.ToInt16(lcGameDetails.Rows[0]["P1_GameScore"]) + " points.",
                    Convert.ToString(lcGameDetails.Rows[0]["PlayerUserName1"]) + " " + "Has Won The Rap Battle!");

            }
            else if (lcP2GameScore > lcP1GameScore)
            {

                MessageBox.Show("Congratulations " + Convert.ToString(lcGameDetails.Rows[0]["PlayerUserName2"]) +
                    ", you achieved victory in the lyrical combat zone with " +
                    Convert.ToInt16(lcGameDetails.Rows[0]["P2_GameScore"]) + " points.",
                    Convert.ToString(lcGameDetails.Rows[0]["PlayerUserName2"]) + " " + "Has Won The Rap Battle!");


            }
            else if (lcP1GameScore == lcP2GameScore)
            {

                MessageBox.Show("Well Well... " + Convert.ToString(lcGameDetails.Rows[0]["PlayerUserName1"]) + " and " +
                    Convert.ToString(lcGameDetails.Rows[0]["PlayerUserName2"]) +
                    " it would appear that the clashing of both of your lyrical talents have resulted in a draw, a rematch perhaps?",
                    "Aaaaaaand it's a draw.");

            }

        }


        private void TmrUpdateDisplay_Tick(object sender, EventArgs e)
        {
            PlayerTurnCheck();
            RoundEndTurnCheck();
            UpdateDisplay();
        }

        private void TmrChecker_Tick(object sender, EventArgs e)
        {
            GameOverCheck();
        }


    }
}
