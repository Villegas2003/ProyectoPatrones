CREATE PROCEDURE DEL_HISTORY
(
	@HistoryId int 
)
AS
BEGIN
	delete from History
	where HistoryId = @HistoryId
END

