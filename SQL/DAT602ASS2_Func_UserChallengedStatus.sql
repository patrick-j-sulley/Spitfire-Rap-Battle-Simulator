DELIMITER //

DROP FUNCTION IF EXISTS Player_Challenged_Status//

#Return: 0 = Player Has Not Been Challenged, 1 = Player Has Been Challenged

CREATE FUNCTION Player_Challenged_Status(
							prUserName varchar(20)) RETURNS TINYINT
BEGIN	

            IF (SELECT count(0) FROM game
            WHERE
            PlayerUserName2 = prUserName ) > 0  
            THEN
            Return 1;
            
            ELSE
            RETURN 0;
            
			END IF;
                        
END//

DELIMITER ;

SELECT Player_Challenged_Status('testuser4');

