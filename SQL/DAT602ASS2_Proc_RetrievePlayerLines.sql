DELIMITER //

DROP PROCEDURE IF EXISTS Retrieve_Player_Lines//

CREATE PROCEDURE Retrieve_Player_Lines(
							prPlayerName varchar(20))

BEGIN

		SELECT Line_Number, Text_Field, Points FROM player_line
		WHERE prPlayerName = PlayerUserName;


END//


DELIMITER ;

CALL Retrieve_Player_Lines('testuser1');
