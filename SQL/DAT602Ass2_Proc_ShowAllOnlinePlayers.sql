DELIMITER //
DROP PROCEDURE IF EXISTS ShowAllOnlinePlayers//

CREATE PROCEDURE ShowAllOnlinePlayers(prPlayerName VARCHAR (20))
BEGIN

SELECT * FROM Player
WHERE NOT UserName = prPlayerName
AND IsOnline = 1;


END//

DELIMITER ;

CALL ShowAllOnlinePlayers('admin');
