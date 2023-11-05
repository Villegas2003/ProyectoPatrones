CREATE PROCEDURE CRE_ForeCast
(
	@FC_Date dateTime,
	@FC_MaxTemperature float,
	@FC_MinTemperature float,
	@FC_Condition NVARCHAR(100)
)
AS
BEGIN
	insert into ForeCast(Date, MaxTemperature, MinTemperature, Condition)
	values(@FC_Date, @FC_MaxTemperature, @FC_MinTemperature, @FC_Condition)
END

