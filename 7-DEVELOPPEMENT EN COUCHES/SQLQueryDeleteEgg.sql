
DROP PROCEDURE DeleteEgg
CREATE PROCEDURE DeleteEgg (@Id int, @ok bit OUT) AS
SET @ok = 0
DELETE FROM dbo.Egg WHERE Id=@Id
IF ((SELECT COUNT(*) FROM Egg WHERE Id=@Id)=0)  SET @ok = 1  

DECLARE @var bit
EXECUTE DeleteEgg @Id=12, @ok=@var OUTPUT;

SELECT @var as RETOURID


