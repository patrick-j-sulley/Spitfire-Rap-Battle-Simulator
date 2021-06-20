DELIMITER //

DROP FUNCTION IF EXISTS Admin_DeleteGame//

#Return: 1 = Game Delete Successful

CREATE FUNCTION  Admin_DeleteGame(
				  prGameID	int) RETURNS TINYINT
				  
	BEGIN
    
		IF prGameID IS NOT NULL
        THEN
        DELETE FROM game
        WHERE ID = prGameID;
		RETURN 1;
		
END IF;


END//

DELIMITER ;

SELECT Admin_DeleteGame ('19');