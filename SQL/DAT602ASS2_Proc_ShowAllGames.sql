DELIMITER //
DROP PROCEDURE IF EXISTS ShowAllRunningGames//

CREATE PROCEDURE ShowAllRunningGames(prPlaceholder varchar (1))
BEGIN

SELECT ID, PlayerUserName1, PlayerUserName2 FROM game

END;

END//

DELIMITER ;

CALL ShowAllRunningGames('*');
