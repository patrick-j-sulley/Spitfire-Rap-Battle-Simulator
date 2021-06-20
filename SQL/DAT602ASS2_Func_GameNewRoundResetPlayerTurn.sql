DELIMITER //

DROP FUNCTION IF EXISTS Game_NewRound_ResetPlayer1Turn//

#Return: 1 = User Created

CREATE FUNCTION  Game_NewRound_ResetPlayer1Turn(
				  prGameID	INT,
                  prTurnReset smallint) RETURNS TINYINT
				  
	BEGIN	
	
			UPDATE game
			SET P1_CurrentTurn = prTurnReset
            WHERE prGameID = ID;
            RETURN 1;			

END//

DELIMITER 

SELECT Game_NewRound_ResetPlayer1Turn('1','1');