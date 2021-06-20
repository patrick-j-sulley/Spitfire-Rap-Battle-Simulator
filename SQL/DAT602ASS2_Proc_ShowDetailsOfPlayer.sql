DELIMITER //
DROP PROCEDURE IF EXISTS ShowDetailsOfPlayer//

CREATE PROCEDURE ShowDetailsOfPlayer(prPlayerName VARCHAR (20))
BEGIN


IF prPlayerName IS NOT NULL THEN
SELECT UserName, UserPassword, HighScore, IsAdmin FROM Player
WHERE UserName = prPlayerName;


END IF;

END//

DELIMITER ;

CALL ShowDetailsOfPlayer('PJ Black');
