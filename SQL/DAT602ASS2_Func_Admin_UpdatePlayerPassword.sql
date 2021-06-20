DELIMITER //

DROP FUNCTION IF EXISTS Update_Player_Password//

#prUpdatePlayerDetailStatus = 1 - Success , 2 - Unsuccessful 

CREATE FUNCTION Update_Player_Password(
							prUserName varchar(20),
                            prNewPassword varchar(16)) RETURNS TINYINT
BEGIN	

			IF prUserName IS NOT NULL
            THEN
            UPDATE Player
            SET UserPassword = UNHEX(Sha2(prNewPassword, 256))
            WHERE
            UserName = prUserName;			
            RETURN 1;
            
            ELSE
            RETURN 2;
            
			END IF;
                        
END//

DELIMITER ;

SELECT Update_Player_Password('Yung Skrrt','Poopy');

