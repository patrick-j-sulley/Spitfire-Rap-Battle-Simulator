DELIMITER //

DROP PROCEDURE IF EXISTS Delete_Player//

# DOESNT WORK
#prPlayerDeletionStatus: 0 = Success, 1 = Unsuccessful (Player dosen't exist)

CREATE PROCEDURE Delete_Player(
				IN  prUserName	varchar(20),
				OUT prPlayerDeletionStatus	int1	)
BEGIN
IF EXISTS
		(
			SELECT * FROM Player
			WHERE UserName = prUserName
            AND IsPlaying = '0'

)
		
			THEN
			DELETE FROM Player;
            SET prPlayerDeletionStatus = 0 ;
			
			
ELSE
			
            SET prPlayerDeletionStatus = 1 ;
		
		END IF;



END//

DELIMITER ;

CALL Delete_Player('testuserdelete', @prPlayerDeletionStatus);

SELECT @prPlayerDeletionStatus;