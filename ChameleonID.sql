-- Function for finding confidence level

-- Confidence levels are as followings
-- 1: The company has the same address and geolocation, and is under a different name.
-- 2: The company meets the general requirements, and the new company was added within a year.
-- 3: The company meets the general requirements, and the new company was added within 6 months.
-- 4: The company meets the general requirements, and the new company was added within 3 months.
-- 5: The company meets the general requirements, and the new company was added within a month.

create or alter function GetConfidenceLevel(@addDate date, @oosDate date)
returns int
as
begin
	
	-- Confidence Level set to integer
	declare @confidenceLevel int

	-- Set variable based on value calculated
	set @confidenceLevel =
	case
		when @oosDate > DateAdd(MONTH, -1, @addDate) then 5
		when @oosDate > DateAdd(MONTH, -3, @addDate) then 4
		when @oosDate > DateAdd(MONTH, -6, @addDate) then 3
		when @oosDate > DateAdd(MONTH, -12, @addDate) then 2
		else 1
	end

	return @confidenceLevel

end

go


-- Query for Finding Potential 

-- Select values from previous table and calculate Confidence Level
select *, dbo.GetConfidenceLevel(Date_Registered, Date_OoS) as Confidence_Level from 
(select
-- Name Information + Contact
LegalName as Current_Name, CarrierName as Former_Name, Telephone as Contact_Number, EmailAddress as Contact_Email,
-- Registration Date (Converted from DateTime2 to Date)
CONVERT(date, AddDate) as Date_Registered,
-- Registration Date (Converted using substrings to properly format date based on what was provided)
CONVERT(date, SUBSTRING(carriers.OOS_Date, 7, 4) + '-' + SUBSTRING(OOS_Date, 1, 2) + '-' + SUBSTRING(OOS_DATE, 4, 2)) as Date_OoS, 
-- Address Data
active_carriers.PHYStreet as Street_Address, active_carriers.PHYCity as City, active_carriers.PHYState as State, active_carriers.PHYZip as ZipCode,
-- GeoLocation
active_carriers.Latitude, active_carriers.Longitude
-- Joins tables on address data and geolocation, which is needed to identify locations where companies existed at the same location.
from active_carriers join carriers on active_carriers.Latitude = carriers.Latitude and active_carriers.Longitude = carriers.Longitude and active_carriers.PHYStreet = carriers.StreetAddress and active_carriers.PHYCity = carriers.City) as CarrierTable
-- Name must not be the same, date registered must be after the OoS date.
where Current_Name != Former_Name and Date_Registered > Date_OoS