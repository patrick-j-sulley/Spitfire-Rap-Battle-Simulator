ShowAllOnlineAndNotInGamePlayers

DELIMITER //
DROP PROCEDURE IF EXISTS ShowAllOnlineAndNotInGamePlayers//

CREATE PROCEDURE ShowAllOnlineAndNotInGamePlayers(prPlayerName VARCHAR (20))
BEGIN

SELECT * FROM Player
WHERE NOT UserName = prPlayerName
AND IsOnline = 1
AND IsPlaying = 0;


END//

DELIMITER ;

CALL ShowAllOnlineAndNotInGamePlayers('admin');
