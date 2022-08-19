alter procedure uspAutorPolja
@autorID int=null
as
select AutorID, Ime, Prezime, FORMAT(DatumRodjenja, 'dd/MM/yyyy') as DatumRodjenja
from Autor
where AutorID=@autorID