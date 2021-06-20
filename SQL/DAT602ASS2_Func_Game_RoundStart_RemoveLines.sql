DELIMITER //

DROP FUNCTION IF EXISTS Game_RoundStart_RemoveLines//

#Return: 1 = User Created

CREATE FUNCTION  Game_RoundStart_RemoveLines(
				  prGameID	INT) RETURNS TINYINT
				  
	BEGIN	
	
			DELETE FROM player_line
			WHERE prGameID = GameID;
            RETURN 1;			

END//

DELIMITER 

SELECT Game_RoundStart_RemoveLines('3');