create table carriers(
Number int primary key identity not null,
DotNumber int not null,
CarrierName varchar(150) not null,
StreetAddress varchar(150) not null,
City varchar(150) not null,
StateAddress varchar(150) not null,
Zipcode varchar(150) not null,
OOS_Reason varchar(150) not null,
OOS_Date varchar(75) not null,
Status varchar(35),
Latitude varchar(100),
Longitude varchar(100)
);

--drop table carriers;