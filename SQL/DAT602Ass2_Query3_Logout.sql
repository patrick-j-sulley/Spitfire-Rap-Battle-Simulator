DELIMITER //

DROP PROCEDURE IF EXISTS User_Logout//

#prLogoutStatus: 1 = Success, 2 = Unsuccessful (User Already Logged Out)

CREATE PROCEDURE  User_Logout(
				  IN  prUserName	varchar(20),
				  OUT prLogoutStatus	int1)
				  
	BEGIN
		IF EXISTS
		(
			SELECT * FROM Player
			WHERE UserName = prUserName
			AND IsOnline = 1
			
		)
		
			THEN
			SET prLogoutStatus = 1 ;
			UPDATE Player
			SET IsOnline = 0 ;
			
            ELSE
		
			SET prLogoutStatus = 2 ;
			
		END IF;



END//

DELIMITER ;

CALL User_Logout ('admin', @prLogoutResult);

SELECT @prLogoutResult;