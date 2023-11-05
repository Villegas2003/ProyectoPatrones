CREATE PROCEDURE DEL_ForeCast
(
	@ForeCastId int
)
AS
BEGIN
	DELETE FROM ForeCast
	where ForecastId = @ForeCastId
END

