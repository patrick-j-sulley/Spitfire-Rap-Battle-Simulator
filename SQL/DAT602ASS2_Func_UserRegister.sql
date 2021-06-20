DELIMITER //

DROP FUNCTION IF EXISTS User_Register//

#Return: 1 = User Created

CREATE FUNCTION  User_Register(
				  prUserName	varchar(20),
				  prUserPassword	varchar(16)) RETURNS TINYINT
				  
	BEGIN	
	
		
			INSERT INTO Player (UserName, UserPassword, IsAdmin, IsOnline, IsPlaying)
			VALUES (prUserName, UNHEX(Sha2(prUserPassword, 256)), 0, 0, 0);
            RETURN 1;
            

END//

DELIMITER 

#SELECT User_Register ('newuser', 'newpassword');
