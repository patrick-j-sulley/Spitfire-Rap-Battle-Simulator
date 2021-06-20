DELIMITER //

DROP PROCEDURE IF EXISTS Player2_Game_ID_Retrieve//

CREATE PROCEDURE Player2_Game_ID_Retrieve(
							prPlayer2Name varchar(20))
BEGIN	
			IF prPlayer2Name IS NOT NULL
            THEN
            SELECT ID FROM game
            WHERE prPlayer2Name = PlayerUserName2;

END IF;
                        
END//

DELIMITER ;

CALL Player2_Game_ID_Retrieve('testuser2');

