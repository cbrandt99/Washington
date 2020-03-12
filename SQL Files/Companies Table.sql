create table Companies
(
USDOT# int primary key not null, 
Legal_Name nvarchar(100) not null,
Address nvarchar(100) not null,
OOS_Reason nvarchar(100) not null,
OOS_Date date not null,
Status nvarchar(20)
);

--drop table Companies;