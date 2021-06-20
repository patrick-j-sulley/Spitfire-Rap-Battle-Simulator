DELIMITER //

DROP FUNCTION IF EXISTS Player2_UpdateScore//

#Return: 1 = User Created

CREATE FUNCTION  Player2_UpdateScore(
				  prPlayer2Name	varchar(20),
                  prPlayerScore smallint (3)) RETURNS TINYINT
				  
	BEGIN	
	
			UPDATE game
			SET P2_GameScore = prPlayerScore
            WHERE prPlayer2Name = PlayerUserName2;
            RETURN 1;			

END//

DELIMITER 

SELECT Player2_UpdateScore('testuser2','1');