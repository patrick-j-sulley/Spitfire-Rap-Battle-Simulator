DELIMITER //

DROP FUNCTION IF EXISTS Player_Line_Enter//

#Return: 1 = Player Line Successfully Entered

CREATE FUNCTION  Player_Line_Enter(
				  prGameID	int,
                  prPlayerName varchar(20),
                  prLineNumber tinyint (1),
                  prLineText varchar(55),
                  prLinePoints tinyint)RETURNS INT 
				  
BEGIN
    
INSERT INTO player_line(GameID, PlayerUserName, Line_Number, Text_Field, Points)
VALUES (prGameID, prPlayerName, prLineNumber, prLineText, prLinePoints);
RETURN (SELECT last_insert_id());		

END//

DELIMITER ;

SELECT Player_Line_Enter ('1', 'testuser1', '1','Your name is testuser2? Youre just an inferior sequal','10');