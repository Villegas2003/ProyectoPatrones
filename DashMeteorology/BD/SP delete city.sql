CREATE PROCEDURE DEL_CITY
(
@C_Name NVARCHAR(100)
)
AS
BEGIN
	DECLARE @C_CityId int;
    
	SELECT @C_CityId = CityId
	FROM Cities
	where Name = @C_Name

	delete from Cities
	where CityId = @C_CityId
END

