DELIMITER //

DROP FUNCTION IF EXISTS Admin_Check// 

#Return: 1 = Admin Detected, 2 = Admin Not Detected

CREATE FUNCTION  Admin_Check(
				  prUserName	varchar(20)) RETURNS TINYINT
				  
	BEGIN
    
		IF EXISTS
			(
			SELECT * FROM Player
            WHERE UserName = prUserName
            AND IsAdmin = 1
            )
            THEN
            RETURN 1;
			
            
            ELSE
		    RETURN 2;
			
END IF;

END//

DELIMITER ;

SELECT Admin_Check ('admin');
