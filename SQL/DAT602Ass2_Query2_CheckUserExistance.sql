DELIMITER //

DROP PROCEDURE IF EXISTS Check_User_Existance//

#prLoginStatus: 0 = Success, 1 = User Dosen't Exists, 2 = Create New User

CREATE PROCEDURE  Check_User_Existance(
				  IN  prUserName	varchar(20),
				  IN prUserPassword	varchar(16),
				  OUT prUserExistanceStatus	int1)
				  
	BEGIN
		IF EXISTS
		(
			SELECT * FROM Player
			WHERE UserName = prUserName
			AND UserPassword = prUserPassword
			
		)
		
			THEN
			SET prUserExistanceStatus = 1;

		END IF;
        
		IF NOT EXISTS
		(
			SELECT * FROM player
			WHERE UserName = prUserName
		)
			THEN
			SET prUserExistanceStatus = 2 ;
					
			
		END IF;



END//

DELIMITER ;

CALL Check_User_Existance ('admin', 'P@ssword1', @prUserExistanceStatus);

SELECT @prUserExistanceStatus;