CREATE TABLE carriers (
  Number int primary key identity NOT NULL,
  DotNumber int NOT NULL,
  CarrierName varchar(150) NOT NULL,
  Address varchar(150) NOT NULL,
  OOS_Reason varchar(150) NOT NULL,
  OOS_Date varchar(75) NOT NULL,
  Status varchar(35) DEFAULT NULL
)