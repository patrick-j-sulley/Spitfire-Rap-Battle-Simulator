DELIMITER //

DROP PROCEDURE IF EXISTS Update_Player_Details//

#prUpdatePlayerDetailStatus = 1 - Success

CREATE PROCEDURE Update_Player_Details(
					IN prPlayerOldUserName varchar(20),
                    IN prPlayerNewUserName varchar(20),
                    IN prPlayerOldPassword varchar(16),
                    IN prPlayerNewPassword varchar(16),
					OUT prUpdatePlayerDetailStatus	INT1)
BEGIN	
       IF EXISTS
       (
            SELECT * FROM player
			WHERE UserName = prPlayerOldUserName
			AND UserPassword = prPlayerOldPassword
            )
            THEN
            SET prUpdatePlayerDetailStatus = 1 ;
            UPDATE Player
            SET UserName = prPlayerNewUserName,
            UserPassword = prPlayerNewPassword
            WHERE UserName = prPlayerOldUserName
			AND UserPassword = prPlayerOldPassword;
         
		#Attempt at doing a status check / confirmation
		#ELSEIF EXISTS 			
			#(
            #SELECT * FROM player
			#WHERE UserName = prPlayerNewUserName
            #AND UserPassword = prPlayerNewPassword	
            #)
            #THEN
            #SET prUpdatePlayerDetailStatus = 1 ;
            
		END IF;
                        
END//

DELIMITER ;

CALL Update_Player_Details('editthisname','editedname','editthispassword','editedpassword', @prUpdatePlayerDetailStatus);

#SELECT * FROM dat602ass1_test.player;
SELECT @prUpdatePlayerDetailStatus;
