DELIMITER //

DROP FUNCTION IF EXISTS User_Login//

#Return: 1 = Success, 2 = Unsuccessful (User Already Online)

CREATE FUNCTION  User_Login(
				  prUserName	varchar(20),
				  prUserPassword	varchar(16)) RETURNS TINYINT
				  
	BEGIN
    
		IF EXISTS
		(
			SELECT * FROM Player
			WHERE UserName = prUserName
			AND UserPassword = UNHEX(Sha2(prUserPassword, 256)) 
			AND IsOnline = 0
			
		)
		
			THEN
			UPDATE Player
			SET IsOnline = 1
			WHERE UserName = prUserName;
            RETURN 1;
            
            
            ELSE
            RETURN 2;
			
		END IF;


END//

DELIMITER ;

SELECT User_Login ('PJ Black', 'P@ssword1');
