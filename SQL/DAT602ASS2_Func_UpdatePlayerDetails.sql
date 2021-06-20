DELIMITER //

DROP FUNCTION IF EXISTS Update_Player_Details//

#prUpdatePlayerDetailStatus = 1 - Success, 2 = Unsuccessful (Invalid data entry)

CREATE FUNCTION Update_Player_Details(
							prUserName varchar(20),
                            prOldHighScore smallint(3),
                            prNewHighScore smallint(3),
                            prAdminStatus tinyint(1)) RETURNS TINYINT
BEGIN	

			IF prUserName IS NOT NULL
            THEN
            UPDATE Player
            SET HighScore = prNewHighScore,
            IsAdmin = prAdminStatus
            WHERE
            UserName = prUserName
            AND HighScore = prOldHighScore;			
            RETURN 1;
            
            
			END IF;
                        
END//

DELIMITER ;

SELECT Update_Player_Details('testuser1','320', '310','0');

