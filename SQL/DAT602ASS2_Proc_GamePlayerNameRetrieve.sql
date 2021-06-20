DELIMITER //

DROP PROCEDURE IF EXISTS Game_PlayerName_Retrieve//

CREATE PROCEDURE Game_PlayerName_Retrieve(
							prGameID int)
BEGIN	
			IF prGameID IS NOT NULL
            THEN
            SELECT PlayerUserName1, PlayerUserName2 FROM game
            WHERE prGameID = ID;

END IF;
                        
END//

DELIMITER ;

CALL Game_PlayerName_Retrieve('13');

