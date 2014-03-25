
CREATE PROCEDURE loc_InsLocation
	@Name varchar(50),
    @Latitude varchar(50),
    @Longitude varchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;
	
	insert into loc_Location (Name,Latitude,Longitude)
    values (@Name,@Latitude,@Longitude)

END



