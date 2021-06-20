DELIMITER //

DROP FUNCTION IF EXISTS User_IsNoLongerPlaying_StatusChange//

#Return: 1 = IsPlaying Status Change Successful 

CREATE FUNCTION User_IsNoLongerPlaying_StatusChange(
							prUserName varchar(20)) RETURNS TINYINT
BEGIN	

			IF prUserName IS NOT NULL
            THEN
            UPDATE player
            SET IsPlaying = 0
            WHERE prUserName = UserName;
            RETURN 1;
            
            
			END IF;
                        
END//

DELIMITER ;

SELECT User_IsNoLongerPlaying_StatusChange('FaZe Giger');

