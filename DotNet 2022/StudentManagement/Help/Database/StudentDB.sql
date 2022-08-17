create DATABASE StudentDB

Use StudentDB

select * from dbo.Students

CREATE TABLE dbo.Students
(
StudentId int not null IDENTITY(1,1) CONSTRAINT StudentId PRIMARY KEY,
StudentName nvarchar(150),
EmailAddress nvarchar(150),
City nvarchar(150),
CreationDate datetime,
CreatedBy int
)

Create PROC dbo.GetStudentList
as
begin
SELECT * FROM Students
end

Create PROC dbo.InsertStudent
(
@StudentName nvarchar(150),
@EmailAddress nvarchar(150),
@City nvarchar(150),
@CreationDate datetime,
@CreatedBy int
)
as
begin try
	INSERT INTO Students(StudentName, EmailAddress, City, CreationDate, CreatedBy)
	VALUES(@StudentName, @EmailAddress, @City,GETDATE(),@CreatedBy)
	SELECT 'Save Successfully' as Response
end try
begin catch
	SELECT ERROR_MESSAGE() as Response
end catch


Create PROC dbo.DeleteStudent
(
@StudentId int
)
as
begin try
	DELETE FROM Students WHERE StudentId=@StudentId
	SELECT 'Delete Successfully' as Response
end try
begin catch
	SELECT ERROR_MESSAGE() as Response
end catch


Create PROC dbo.UpdateStudent
(
@StudentName nvarchar(150),
@EmailAddress nvarchar(150),
@City nvarchar(150),
@CreatedBy int,
@StudentId int
)
as
begin try
	UPDATE Students SET StudentName=@StudentName, EmailAddress=@EmailAddress,
	City=@City, CreatedBy=@CreatedBy WHERE StudentId=@StudentId
	SELECT 'UPDATE Successfully' as Response
end try
begin catch
	SELECT ERROR_MESSAGE() as Response
end catch


SELECT GETDATE()