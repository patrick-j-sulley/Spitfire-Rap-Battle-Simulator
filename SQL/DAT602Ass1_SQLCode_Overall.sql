#_________________________________________________________________________________________________
# Demonstration of the database creation using DDL/SQL code.
#_________________________________________________________________________________________________

CREATE TABLE Player (
  UserName   varchar(20) NOT NULL PRIMARY KEY, 
  UserPassword varchar(16) NOT NULL, 
  HighScore smallint(3),
  IsAdmin tinyint(1),
  IsOnline tinyint(1),
  IsPlaying tinyint(1)
  );
  
CREATE TABLE Game (
  Id  INT NOT NULL AUTO_INCREMENT PRIMARY KEY, 
  P1_GameScore smallint(3), 
  P2_GameScore smallint(3), 
  CurrentRound tinyint(1),
  CurrentTurn tinyint(1),
  PlayerUserName1 varchar(20),
  PlayerUserName2 varchar(20),
  FOREIGN KEY (PlayerUserName1) REFERENCES Player(UserName), 
  FOREIGN KEY (PlayerUserName2) REFERENCES Player(UserName)
  );
  
CREATE TABLE Player_Line (
  ID    INT NOT NULL AUTO_INCREMENT PRIMARY KEY, 
  GameID Int,
  PlayerUserName varchar(20),
  Line_Number tinyint(1),
  Text_Field varchar(55),
  Points tinyint(2),
  FOREIGN KEY(GameID) REFERENCES Game(ID),
  FOREIGN KEY(PlayerUserName) REFERENCES Player(UserName)
  );
#_________________________________________________________________________________________________
# Demonstration of populating your database using SQL code and/or importing CSV files. 
#_________________________________________________________________________________________________
  
INSERT INTO Player
(UserName, UserPassword, IsAdmin, IsOnline, IsPlaying)
VALUES('admin','P@ssword1', '1', '0', '0');

INSERT INTO Player
(UserName, UserPassword, HighScore, IsAdmin, IsOnline, IsPlaying)
VALUES('testuser1','P@ssword1', '320', '0', '1', '1');

INSERT INTO Player
(UserName, UserPassword, HighScore, IsAdmin, IsOnline, IsPlaying)
VALUES('testuser2','P@ssword1','230', '0', '1', '1');

INSERT INTO Player
(UserName, UserPassword, HighScore, IsAdmin, IsOnline, IsPlaying)
VALUES('testuser3','P@ssword1','180', '0', '1', '1');

INSERT INTO Player
(UserName, UserPassword, HighScore, IsAdmin, IsOnline, IsPlaying)
VALUES('testuser4','P@ssword1','400', '0', '1', '1');

INSERT INTO Game 
(P1_GameScore, P2_GameScore, CurrentRound, CurrentTurn, PlayerUserName1, PlayerUserName2)
VALUES('0','0','1','1','testuser1','testuser2');

INSERT INTO Game 
(P1_GameScore, P2_GameScore, CurrentRound, CurrentTurn, PlayerUserName1, PlayerUserName2)
VALUES('0','0','1','1','testuser3','testuser4');


#_________________________________________________________________________________________________
# Demonstration of at least 5 queries, essential in your application, using DML/SQL code.
#_________________________________________________________________________________________________

#1: Show All Players

DELIMITER //
DROP PROCEDURE IF EXISTS ShowAllPlayers//
CREATE PROCEDURE ShowAllPlayers(prPlayerName VARCHAR (20))
BEGIN

#DECLARE lcCounter INT1;
#SET lcCounter = 1;

IF prPlayerName IS NOT NULL THEN
SELECT UserName, HighScore FROM Player
WHERE UserName != 'prCurrentPlayerName';

END IF;

END//

DELIMITER ;

CALL ShowAllPlayers('*');


#2: Login

DELIMITER //

DROP PROCEDURE IF EXISTS User_Login//

#prLoginStatus: 0 = Success, 1 = User Dosen't Exists, 2 = Create New User

CREATE PROCEDURE  User_Login(
				  IN  prUserName	varchar(20),
				  IN prUserPassword	varchar(16),
				  OUT prLoginStatus	int1)
				  
	BEGIN
		IF EXISTS
		(
			SELECT * FROM Player
			WHERE UserName = prUserName
			AND UserPassword = prUserPassword
			AND IsOnline = 0
			
		)
		
			THEN
			SET prLoginStatus = 0;
			UPDATE Player
			SET IsOnline = 1 ;
			
		
		ELSEIF EXISTS
		(
			SELECT * FROM player
			WHERE UserName = prUserName
		)
			THEN
			SET prLoginStatus = 1 ;
			
		ELSE
		
			SET prLoginStatus = 2 ;
			
		END IF;



END//

DELIMITER ;

CALL User_Login ('admin', 'P@ssword1', @prLoginResult);

SELECT @prLoginResult;

#4: Register Player

DELIMITER //

DROP PROCEDURE IF EXISTS User_Register

CREATE PROCEDURE  User_Register(
				  )
				  
	BEGIN
		
		END IF;



END//

DELIMITER ;

CALL User_Register ();

SELECT @inserthere;

#4: Delete Player

DELIMITER //

DROP PROCEDURE IF EXISTS User_Delete

CREATE PROCEDURE  User_Delete(
				  IN  prUserName	varchar(20)
				  OUT prSuccessfulUserDelete int1)
				  
	BEGIN
		IF EXISTS
		(
			SELECT * FROM Player
			WHERE Name = prUserName
			
		)
		
			THEN
			DELETE FROM Player
			WHERE Name = prUserName
            SET prSuccessfulUserDelete = 1 ;
			
			
		END IF;



END//

DELIMITER ;

CALL User_Delete ('testuser1', 'P@ssword1', @prSuccessfulUserDelete);

SELECT @prSuccessfulUserDelete;


#5: Player Line Input
# http://mysql-0v34c10ck.blogspot.com/2011/05/random-number-range-picker.html
DELIMITER //

DROP PROCEDURE IF EXISTS Player_Line_Input

CREATE PROCEDURE  Player_Line_Input(
                    IN prTextField varchar(55)
                    minRange INT
                    maxRange INT
                    OUT prPoints tinyint(2)
BEGIN 

 DECLARE pick INT;
 SET pick = minRange + FLOOR(RAND() * (maxRange - minRange + 1));
 RETURN pick;
 
 pick = prPoints


END//

DELIMITER ;

CALL Player_Line_Input ('This line dosent even matter, cause its just a test', 0, 11, @prPointsResult);

SELECT @prPointsResult;


