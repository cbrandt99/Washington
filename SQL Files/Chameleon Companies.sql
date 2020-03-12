select c.Number, c.DotNumber, c.CarrierName, ac.LegalName, c.StreetAddress, c.City, c.StateAddress, ac.PHYStreet, ac.PHYCity, ac.PHYState, c.Latitude, c.Longitude, ac.latitude, ac.longitude 
from carriers c
join active_carriers ac
on c.CarrierName = ac.LegalName
--where c.DotNumber != ac.DotNumber; --and c.latitude != ac.latitude and c.longitude != ac.longitude;

select * from carriers c
join active_carriers ac
on c.DotNumber = ac.DotNumber
--where c.;

select * from carriers;
select * from active_carriers;