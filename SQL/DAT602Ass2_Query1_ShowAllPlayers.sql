DELIMITER //
DROP PROCEDURE IF EXISTS ShowAllOnlineAndNotInGamePlayers//

CREATE PROCEDURE ShowAllOnlineAndNotInGamePlayers(prPlayerName VARCHAR (20))
BEGIN


IF prPlayerName IS NOT NULL THEN
SELECT UserName, HighScore FROM Player
WHERE NOT UserName = prPlayerName
AND IsAdmin = 0
AND IsOnline = 1
AND IsPlaying = 0 ;

END IF;

END//

DELIMITER ;

CALL ShowAllOnlineAndNotInGamePlayers('PJ Black');
