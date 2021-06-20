DELIMITER //

DROP FUNCTION IF EXISTS Player1_UpdateTurn//

#Return: 1 = User Created

CREATE FUNCTION  Player1_UpdateTurn(
				  prPlayer1Name	varchar(20),
                  prPlayerTurnNo tinyint (2)) RETURNS TINYINT
				  
	BEGIN	
	
			UPDATE game
			SET P1_CurrentTurn = prPlayerTurnNo
            WHERE prPlayer1Name = PlayerUserName1;
            RETURN 1;			

END//

DELIMITER 

SELECT Player1_UpdateTurn('testuser1','1');