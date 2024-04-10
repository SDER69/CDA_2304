DROP PROCEDURE InsertEgg

CREATE PROCEDURE InsertEgg (@Id int OUT,@hauteurEnCms float,@largeurEnCms float, @typeChocolat varchar(50)) AS
BEGIN
INSERT INTO dbo.Egg (hauteurEnCm,largeurEnCm,typeChocolat) VALUES (@hauteurEnCms,@largeurEnCms,@typeChocolat)
SET @Id = SCOPE_IDENTITY()
END


DECLARE @var int
EXECUTE InsertEgg @Id=@var OUTPUT, @hauteurEnCms=15 , @largeurEnCms=10 , @typeChocolat='caramel';
SELECT @var as RETOURID

