alter procedure uspObrisiAutora
@autorID int=null
as
delete from Autor
where AutorID=@autorID