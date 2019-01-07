
CREATE TABLE Customer
(
	--IDENTITY key starts at 1 and incements
	ID		int			Primary Key	IDENTITY
	,Name	varchar(30)	NOT NULL
)

INSERT INTO Customer 
VALUES ('Joe')
	, ('Ken')
	, ('Jim')
	, ('Pam')