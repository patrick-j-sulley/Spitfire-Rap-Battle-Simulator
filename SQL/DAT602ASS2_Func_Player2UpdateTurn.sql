DELIMITER //

DROP FUNCTION IF EXISTS Player2_UpdateTurn//

#Return: 1 = User Created

CREATE FUNCTION  Player2_UpdateTurn(
				  prPlayer2Name	varchar(20),
                  prPlayerTurnNo tinyint (2)) RETURNS TINYINT
				  
	BEGIN	
	
			UPDATE game
			SET P2_CurrentTurn = prPlayerTurnNo
            WHERE prPlayer2Name = PlayerUserName2;
            RETURN 1;			

END//

DELIMITER 

SELECT Player2_UpdateTurn('testuser2','1');