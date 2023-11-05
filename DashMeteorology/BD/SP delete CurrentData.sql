CREATE PROCEDURE DEL_CURRENTDATA
(
	@DataId int
)
AS
BEGIN
	delete from CurrentData
	where DataId = @DataId
END

