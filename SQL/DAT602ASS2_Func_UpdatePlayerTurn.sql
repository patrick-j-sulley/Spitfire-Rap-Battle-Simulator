DELIMITER //

DROP FUNCTION IF EXISTS Game_ChangePlayerTurn//

#Return: 1 = User Created

CREATE FUNCTION  Game_ChangePlayerTurn(
				  prGameID int,
				  prPlayerName	varchar(20)) RETURNS TINYINT
				  
	BEGIN	
	
			UPDATE game
			SET CurrentTurnPlayer = prPlayerName
            WHERE prGameID = ID;
            RETURN 1;			

END//

DELIMITER 

SELECT Game_ChangePlayerTurn('1','testuser1');