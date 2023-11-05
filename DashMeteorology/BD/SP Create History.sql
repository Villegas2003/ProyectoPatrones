CREATE PROCEDURE CRE_HISTORY
(
	@H_Date DATETIME,
	@H_MaxTemperature float,
	@H_MinTemperature float,
	@H_Condition NVARCHAR(100)
)
AS
BEGIN
	insert into History (Date, MaxTemperature, MinTemperature, Condition)
	values(@H_Date, @H_MaxTemperature, @H_MinTemperature, @H_Condition)
END

