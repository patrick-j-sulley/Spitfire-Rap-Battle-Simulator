DELIMITER //

DROP PROCEDURE IF EXISTS Retrieve_Game_Details//

CREATE PROCEDURE Retrieve_Game_Details(
							prGameID int)

BEGIN

		IF prGameID IS NOT NULL
		THEN
		SELECT * FROM game
		WHERE prGameID = ID;

END IF;


END//


DELIMITER ;

CALL Retrieve_Game_Details('13');
