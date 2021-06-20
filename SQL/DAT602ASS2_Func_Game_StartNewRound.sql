DELIMITER //

DROP FUNCTION IF EXISTS Game_StartNewRound//

#Return: 1 = User Created

CREATE FUNCTION  Game_StartNewRound(
				  prGameID	INT,
                  prRoundNo tinyint) RETURNS TINYINT
				  
	BEGIN	
	
			UPDATE game
			SET CurrentRound = prRoundNo, CurrentTurn = 0, P1_CurrentTurn = 0, P2_CurrentTurn = 0
            WHERE prGameID = ID;
            RETURN 1;			

END//

DELIMITER 

SELECT Game_StartNewRound('10','2');