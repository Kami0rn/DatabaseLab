CREATE VIEW loan_view AS
	SELECT branch_name , amount AS 'SUM(amount)'
    FROM loan
    WHERE amount > 3000 ;

#8.1
SELECT * FROM  loan_view ;
    
    
CREATE VIEW join_view AS
	SELECT account.account_number ,account.branch_name,account.balance,depositor.customer_name
    FROM account INNER JOIN depositor 
    ON account.account_number = depositor.account_number
    WHERE branch_name = 'SUT' ;


#8.2
SELECT * FROM  join_view ;


CREATE VIEW account_view AS
	SELECT account_number , branch_name , balance
	FROM account
    WHERE balance < 200
WITH CHECK OPTION ;


#8.3
SELECT * FROM  account_view ;

#8.4
INSERT INTO account_view VALUES(4, 'SUT', 500);

delimiter ^^
CREATE PROCEDURE transfer_money (
	IN amount_transfer FLOAT ,
    IN from_acc_num INT ,
    IN to_acc_num INT 
)
	BEGIN
		DECLARE errorStatus BOOLEAN DEFAULT FALSE ;
        
        START TRANSACTION ;
        BEGIN
			DECLARE EXIT HANDLER FOR NOT FOUND SET errorStatus = TRUE ;
			UPDATE account SET balance = balance-amount_transfer WHERE account_number = from_acc_num ;
            UPDATE account SET balance = balance+amount_transfer WHERE account_number = to_acc_num ;
		END ;
        
	IF errorStatus = TRUE or from_acc_num not in (select account_number from account) or to_acc_num not in (select account_number from account) THEN
		ROLLBACK ;
	ELSE
		COMMIT ;
	END IF ;
    
END^^
delimiter 

CALL lab8.transfer_money(10,1,3);

CALL lab8.transfer_money(10,1,8);

DROP PROCEDURE transfer_money ;


delimiter ^^
CREATE PROCEDURE loan_money (
	IN loan_number INT  ,
    IN b_name CHAR(9) ,
    IN amount FLOAT ,
    IN customer_name CHAR(9),
    IN acc_number INT 
    
)
	BEGIN
		DECLARE errorStatus BOOLEAN DEFAULT FALSE ;
        
        START TRANSACTION ;
        BEGIN
			DECLARE EXIT HANDLER FOR NOT FOUND SET errorStatus = TRUE ;
			INSERT INTO loan VALUES(loan_number,b_name,amount) ;
            INSERT INTO borrower VALUES(customer_name,loan_number) ;
            UPDATE branch SET asset = asset - amount WHERE branch_name = b_name ;
            UPDATE account SET balance = balance + amount WHERE account_number = acc_number ;
		END ;
        
	IF errorStatus = TRUE or acc_number NOT IN (SELECT account_number FROM account) or 
    acc_number not in (SELECT account_number FROM depositor WHERE customer_name = customer_name )THEN
		ROLLBACK ;
	ELSE
		COMMIT ;
	END IF ;
    
END^^
delimiter 
  
CALL lab8.loan_money (107,'SUT',20000,'Som',1);
  
CALL lab8.loan_money (104,'SUT',20000,'Som',5);