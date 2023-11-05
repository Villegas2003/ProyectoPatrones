CREATE PROCEDURE UP_CURRENTDATA
(
	@CD_TimeStamp DATETIME, 
	@CD_Temperature float,
	@CD_Condition NVARCHAR(100),
	@CD_WindSpeed FLOAT
)
AS
BEGIN
	UPDATE CRE_CURRENTDATA
	SET
	TimeStamp = @CD_TimeStamp,
	Temperature = @CD_Temperature,
	Condition = @CD_Condition,
	WindSpeed = @CD_WindSpeed
END

