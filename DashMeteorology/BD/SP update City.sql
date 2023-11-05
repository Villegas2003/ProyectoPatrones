CREATE PROCEDURE UP_CITY
(
	@C_Name  NVARCHAR(100),
	@C_COUNTRY nvarchar(100),
	@C_LATITUDE float,
	@C_LONGITUDE float
)
AS
BEGIN
	update CRE_CITY
	set 
	Name = @C_Name,
	Country = @C_COUNTRY,
	Latitude = @C_LATITUDE,
	Longitude = @C_LONGITUDE		
END

