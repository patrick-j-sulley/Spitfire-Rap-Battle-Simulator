DELIMITER //

DROP FUNCTION IF EXISTS User_GameStart//

#Return: 1 = Game Start Successful

CREATE FUNCTION  User_GameStart(
				  prUserName1	varchar(20),
                  prUserName2	varchar(20)) RETURNS int
				  
	BEGIN
    
		IF prUserName1 IS NOT NULL
        AND prUserName2 IS NOT NULL
        THEN
        INSERT INTO game (P1_GameScore, P2_GameScore, CurrentRound, CurrentTurn, CurrentTurnPlayer, PlayerUserName1, PlayerUserName2, P1_CurrentTurn, P2_CurrentTurn)
        VALUES
        (0, 0, 1, 0, prUserName1, prUserName1, prUserName2, 0, 0);
		RETURN (SELECT last_insert_id());
		
END IF;


END//

DELIMITER ;

SELECT User_GameStart ('testuser1','testuser2');