CREATE PROCEDURE UPD_FORECAST
(
	@FC_Date DATETIME,
	@FC_MaxTemperature float,
	@FC_MinTemperature float,
	@FC_Condition NVARCHAR(100)
)	
AS
BEGIN
	UPDATE CRE_ForeCast
	set
	Date = @FC_Date,
	MaxTemperature = @FC_MaxTemperature,
	MinTemperature = @FC_MinTemperature,
	Condition = @FC_Condition
END

