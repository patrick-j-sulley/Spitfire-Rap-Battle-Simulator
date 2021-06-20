DELIMITER //

DROP FUNCTION IF EXISTS User_Create//

#Return: 1 = User Created

CREATE FUNCTION  User_Create(
				  prUserName	varchar(20),
				  prUserPassword	varchar(16),
                  prAdminStatus tinyint) RETURNS TINYINT
				  
	BEGIN	
	

			INSERT INTO Player (UserName, UserPassword, IsAdmin, IsOnline, IsPlaying, HighScore)
			VALUES (prUserName, UNHEX(Sha2(prUserPassword, 256)), prAdminStatus, 0, 0, 0);
            RETURN 1;			

END//

DELIMITER 

#SELECT User_Create('LilFo','P@ssword1', 0);