DELIMITER //

DROP PROCEDURE IF EXISTS User_Login//

#prLoginStatus: 1 = Success, 2 = Unsuccessful (User Already Online or User Doesn't Exist)

CREATE PROCEDURE  User_Login(
				  IN  prUserName	varchar(20),
				  IN prUserPassword	varchar(16),
				  OUT prLoginStatus	int1)
				  
	BEGIN
		IF EXISTS
		(
			SELECT * FROM Player
			WHERE UserName = prUserName
			AND UserPassword = prUserPassword
			AND IsOnline = 0
			
		)
		
			THEN
			SET prLoginStatus = 1;
			UPDATE Player
			SET IsOnline = 1 ;
            
            ELSE
		
			SET prLoginStatus = 2 ;
            
            END IF;
			



END//

DELIMITER ;

CALL User_Login ('admin', 'P@ssword1', @prLoginResult);

SELECT @prLoginResult;