DELIMITER $$

DROP FUNCTION IF EXISTS Player_Line_Score$$

CREATE FUNCTION  Player_Line_Score(
                    prTextField varchar(55),
                    minRange INT,
                    maxRange INT) RETURNS int(10)
BEGIN
 DECLARE pick INT;
 SET pick = minRange + FLOOR(RAND() * (maxRange - minRange + 1));
 RETURN pick;
END $$

DELIMITER ;

SELECT dat602ass1_test.Player_Line_Score('This line doesnt even matter, cause its just a test', 1, 10);

