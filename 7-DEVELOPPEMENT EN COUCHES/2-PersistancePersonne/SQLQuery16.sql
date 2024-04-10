DROP PROCEDURE InsertPersonne

CREATE PROCEDURE InsertPersonne (@Id int OUT,@nom varchar(50),@prenom varchar(50), @age int) AS
BEGIN
INSERT INTO dbo.Personne (nom,prenom,age) VALUES (@nom,@prenom,@age)
SET @Id = SCOPE_IDENTITY()
END


