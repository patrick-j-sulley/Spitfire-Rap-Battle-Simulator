DELIMITER //

DROP FUNCTION IF EXISTS User_GameCheck//

#Return: 1 = User Is Already in a Game, 2 = User is Currently Not in a Game

CREATE FUNCTION  User_GameCheck(
				  prUserName	varchar(20)) RETURNS TINYINT
				  
	BEGIN
    
		IF EXISTS
        (
        SELECT * FROM Game 
        WHERE PlayerUserName1 = prUserName
        OR PlayerUserName2 = prUserName
        )
		THEN
		RETURN 1;
		
        ELSE
        RETURN 2;
        
			
END IF;


END//

DELIMITER ;

SELECT User_GameCheck ('admin');