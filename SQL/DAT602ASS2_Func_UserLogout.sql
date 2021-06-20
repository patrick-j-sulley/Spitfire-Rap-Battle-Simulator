DELIMITER //

DROP FUNCTION IF EXISTS User_Logout//

#Return: 1 = Success, 2 = Unsuccessful (User Already Logged Out)

CREATE FUNCTION  User_Logout(
				  prUserName	varchar(20)) RETURNS TINYINT
				  
	BEGIN
    
		IF EXISTS
		(
			SELECT * FROM Player
			WHERE UserName = prUserName
			AND IsOnline = 1
			
		)
		
			THEN
			UPDATE Player
			SET IsOnline = 0
            WHERE UserName = prUserName;
            RETURN 1;
            
            
            ELSE
            RETURN 2;
			
		END IF;



END//

DELIMITER ;

SELECT User_Logout ('PJ Black');

