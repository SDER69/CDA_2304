DROP PROCEDURE InsertChat

CREATE PROCEDURE InsertChat (@numero_puce int,@nom varchar(50),@age int,@race int) AS
BEGIN
INSERT INTO dbo.CHATS (numero_puce,nom,age,race) VALUES (@Numero_Puce,@Nom,@Age,@Race)
SET @Numero_Puce = SCOPE_IDENTITY()
END