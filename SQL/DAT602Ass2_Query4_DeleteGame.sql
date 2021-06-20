DELIMITER //

DROP PROCEDURE IF EXISTS Delete_Game//

#prGameDeletionStatus = 1 - Success, 2 = Unsuccessful (Game Doesn't Exist)

CREATE PROCEDURE Delete_Game(
					IN prGameID INT,
					OUT prGameDeletionStatus	INT1)
BEGIN	

		IF EXISTS
        (
        SELECT * FROM GAME
        WHERE Game.Id = prGameID
        )
        THEN
        DELETE FROM Game
		WHERE Game.Id = prGameID;
		SET prGameDeletionStatus = 1 ;
        
        ELSE
        
        SET prGameDeletionStatus = 2 ;
        
        END IF;
END//

DELIMITER ;

CALL Delete_Game(2, @PrGameDeletionStatus);

SELECT @PrGameDeletionStatus;
