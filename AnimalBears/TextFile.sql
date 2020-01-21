Create Database AnimalDB
Go

Create Table Animal
(
	AnimalID		Int			Primary Key		Identity
	, Name			varchar(20)	Not Null
	, AnimalNAme	varchar(30)	Not Null
	, Color			varchar(20)	Not Null
)
Go