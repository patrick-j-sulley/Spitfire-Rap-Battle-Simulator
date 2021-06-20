DELIMITER //

DROP FUNCTION IF EXISTS Player1_UpdateScore//

#Return: 1 = User Created

CREATE FUNCTION  Player1_UpdateScore(
				  prPlayer1Name	varchar(20),
                  prPlayerScore smallint (3)) RETURNS TINYINT
				  
	BEGIN	
	
			UPDATE game
			SET P1_GameScore = prPlayerScore
            WHERE prPlayer1Name = PlayerUserName1;
            RETURN 1;			

END//

DELIMITER 

SELECT Player1_UpdateScore('testuser1','1');