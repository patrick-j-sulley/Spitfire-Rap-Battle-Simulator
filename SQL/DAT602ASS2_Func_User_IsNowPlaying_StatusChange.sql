DELIMITER //

DROP FUNCTION IF EXISTS User_IsNowPlaying_StatusChange//

#Return: 1 = IsPlaying Status Change Successful 

CREATE FUNCTION User_IsNowPlaying_StatusChange(
							prUserName varchar(20)) RETURNS TINYINT
BEGIN	

			IF prUserName IS NOT NULL
            THEN
            UPDATE player
            SET IsPlaying = 1
            WHERE prUserName = UserName;
            RETURN 1;
            
            
			END IF;
                        
END//

DELIMITER ;

SELECT User_IsNowPlaying_StatusChange('Most Palone');

