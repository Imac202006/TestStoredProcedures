CREATE PROC InsertCar
@Name nvarchar(50),
@Code nvarchar(50),
@CrtdDateTime datetime,
@LupdDateTime datetime,
@Brand nvarchar(50),
@Model nvarchar(50),
@ManufactureDate datetime,
@DelStatus nvarchar(1),
@DelDateTime datetime
AS
BEGIN
INSERT INTO Car(Name, Code, CrtdDateTime, LupdDateTime, Brand, Model, ManufactureDate, DelStatus, DelDateTime)
VALUES(@Name, @Code, @CrtdDateTime, @LupdDateTime, @Brand, @Model, @ManufactureDate, @DelStatus, @DelDateTime)
END

/*exec InsertCar 'abc', 'abc', '2/2/2020', '2/2/2020', 'Nissan', 'Almera', '2/2/2020', 'Y', '1/1/2000';*/

CREATE PROC GetAllCar
AS
BEGIN
SELECT * FROM Car
END

exec GetAllCar;

CREATE PROC UpdateCar
@CarId int,
@LupdDateTime datetime,
@Brand nvarchar(50),
@Model nvarchar(50),
@ManufactureDate datetime,
@DelStatus nvarchar(1),
@DelDateTime datetime
AS
BEGIN
UPDATE Car
SET LupdDateTime = @LupdDateTime, Brand = @Brand, Model = @Model, ManufactureDate = @ManufactureDate, DelStatus = @DelStatus, DelDateTime = @DelDateTime
WHERE Id = @CarId
END