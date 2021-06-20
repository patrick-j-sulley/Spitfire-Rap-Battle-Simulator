DELIMITER //

DROP FUNCTION IF EXISTS User_Delete//

#Return: 1 = User Has Been Successfully Deleted, 2 = User Deletion Unsuccessful 

CREATE FUNCTION  User_Delete(
				  prUserName	varchar(20)) RETURNS TINYINT
				  
	BEGIN
    
		IF prUserName IS NOT NULL
        THEN
        DELETE FROM Player 
        WHERE UserName = prUserName;
		RETURN 1;
		
        ELSE
        RETURN 2;
			
END IF;


END//

DELIMITER ;

SELECT User_Delete ('newuser');