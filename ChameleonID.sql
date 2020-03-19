select * from 
(select DISTINCT LegalName as Current_Name, CarrierName as Former_Name, 
CONVERT(date, AddDate) as Date_Registered,
CONVERT(date, SUBSTRING(carriers.OOS_Date, 7, 4) + '-' + SUBSTRING(OOS_Date, 1, 2) + '-' + SUBSTRING(OOS_DATE, 4, 2)) as Date_OoS, 
active_carriers.PHYStreet as Street_Address, active_carriers.PHYCity as City, active_carriers.PHYState as State, active_carriers.PHYZip as ZipCode
from active_carriers join carriers on active_carriers.Latitude = carriers.Latitude and active_carriers.Longitude = carriers.Longitude and active_carriers.PHYStreet = carriers.StreetAddress and active_carriers.PHYCity = carriers.City) as CarrierTable
where Current_Name != Former_Name and DateAdded > DateOoS 
