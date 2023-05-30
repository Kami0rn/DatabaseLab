---1---
DELIMITER $$
CREATE PROCEDURE getAccountCustomer()
BEGIN
	SELECT * FROM account inner join depositor inner join customer
    on account.account_number = depositor.account_number
    and depositor.customer_name = customer.customer_name ;
END $$
DELIMITER 
CALL lab7.getAccountCustomer ;


---2---
DELIMITER $$
CREATE PROCEDURE getTotalAsset ()
BEGIN
	DECLARE totalAsset int default 0;
	select SUM(asset)
    into totalAsset
    From branch ;
    
    Select totalAsset ;
END $$
DELIMITER 

CALL lab7.getTotalAsset ;

---3---
DELIMITER $$
CREATE PROCEDURE getAssetAvgBalance (
	IN b_name VARCHAR(20),
    OUT b_asset FLOAT ,
    OUT avg_a_balnce FLOAT)
BEGIN 
	SELECT branch.asset,avg(account.balance)
    into b_asset ,avg_a_balnce
    from account inner join branch
    on account.branch_name = branch.branch_name and branch.branch_name = b_name ;
END $$
DELIMITER 

CALL lab7.getAssetAvgBalance('Mall',@b_asset,@avg_a_balnce);
SELECT @b_asset ,@avg_a_balnce

---4---
DELIMITER $$
CREATE PROCEDURE checkAccountStatus (
	IN a_number INT,
    OUT a_status VARCHAR(10))
BEGIN
	DECLARE a_blance int ;
    DECLARE a_loan int ;
    SELECT account.balance , SUM(loan.amount) 
    INTO a_blance,a_loan
    FROM account inner join loan 
    WHERE account_number = a_number and account.branch_name = loan.branch_name;
	
    if a_blance > a_loan THEN
		SET a_status = 'OK';
	elseif a_loan IS NULL THEN
		SET a_status = 'OK' ;
	elseif a_blance = a_loan THEN
		SET a_status = 'Warning';
	elseif a_blance < a_loan THEN
		SET a_status = 'CriticaL';
	else 
		SET a_status = 'NULL' ;
	END IF;
END $$
DELIMITER 

SET @a_number = 2 ;
CALL lab7.checkAccountStatus(@a_number,@a_status);
SELECT @a_number,@a_status;


---5---
DELIMITER $$
CREATE PROCEDURE InsertAccountCustomer (
	IN a_number INT ,
    IN b_name VARCHAR(50),
    IN balance INT ,
    IN c_name VARCHAR(50),
    IN c_street VARCHAR(50),
    IN c_city VARCHAR(50))
BEGIN
	DECLARE EXIT HANDLER FOR 1062
    BEGIN 
		SELECT CONCAT('Duplicate key (',a_number,') occurred') AS message;
    END ;
	INSERT INTO account VALUES(a_number,b_name,balance);
    INSERT INTO customer VALUES(c_name,c_street,c_city);
END $$
DELIMITER 

CALL lab7.InsertAccountCustomer(3,'SUT',300,'Nun','University','Korat');
    
    
-----------------------2-----------------------
DELIMITER $$
CREATE FUNCTION GenAccountNumber (
	In_NUM int )
    RETURNS int 
    DETERMINISTIC
BEGIN 
	DECLARE O_num INT ;
    SET O_num = In_num + 100 ;
    RETURN (O_num) ; 
END $$
DELIMITER 

INSERT INTO account VALUES(GenAccountNumber(5),'SUT',3000);

--------2-2----------
DELIMITER $$
CREATE FUNCTION BranchNameToID (
	branch_name VARCHAR(50))
    RETURNS VARCHAR(50)
    DETERMINISTIC
BEGIN
	IF branch_name = 'SUT' THEN
    RETURN ('0001') ;
    ELSEIF branch_name = 'Mall' THEN
    RETURN ('0002');
    END IF;
END $$
DELIMITER 

SELECT 
	BranchNameToID(branch_name),
    branch_name,
    branch_city,
    asset
FROM
	branch ;
    
