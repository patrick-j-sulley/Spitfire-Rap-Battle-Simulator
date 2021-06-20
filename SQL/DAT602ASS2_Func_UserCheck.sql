DELIMITER //

DROP FUNCTION IF EXISTS User_Check//

#Return: 1 = User Exists, 2 = User Doesn't Exist

CREATE FUNCTION  User_Check(
				  prUserName	varchar(20)) RETURNS TINYINT
				  
	BEGIN
    
		IF EXISTS
		(
			SELECT * FROM Player
			WHERE UserName = prUserName
            
            )
            THEN
            RETURN 1;
			
		
        
            ELSE
		    RETURN 2;
            
		
			
END IF;


END//

DELIMITER ;

SELECT User_Check ('admin');
