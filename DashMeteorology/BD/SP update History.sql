CREATE PROCEDURE UPD_HISTORY
(
	@H_Date DATETIME,
	@H_MaxTemperature float,
	@H_MinTemperature float,
	@H_Condition NVARCHAR(100)
)	
AS
BEGIN
	UPDATE CRE_HISTORY
	set
	Date = @H_Date,
	MaxTemperature = @H_MaxTemperature,
	MinTemperature = @H_MinTemperature,
	Condition = @H_Condition
END

