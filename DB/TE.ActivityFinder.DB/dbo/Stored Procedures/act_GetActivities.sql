
CREATE PROCEDURE act_GetActivities
	
AS
BEGIN
	
	
	SET NOCOUNT ON;
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;

    select ActivityId,ActivityTypeId,LocationId,Name,StartDT,EndDT,IsActive from act_Activity
	
END