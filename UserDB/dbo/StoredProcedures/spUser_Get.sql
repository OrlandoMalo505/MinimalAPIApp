CREATE PROCEDURE [dbo].[spUser_Get]	
	@Id int
AS
begin
	select *
	from dbo.[User]
	where Id=@Id
	end
