CREATE PROCEDURE CRE_CURRENTDATA
(
	@CD_TimeStamp dateTime,
	@CD_Temperature float,
	@CD_Humidity int,
	@CD_Condition int,
	@CD_WindSpeed float
)
AS
BEGIN
	insert into CurrentData(TimeStamp, Temperature, Humidity, Condition, WindSpeed)
	values (@CD_TimeStamp, @CD_Temperature, @CD_Humidity, @CD_Condition, @CD_WindSpeed)
END

