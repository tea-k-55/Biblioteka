create procedure uspDodajAutora
as
select AutorID as Sifra, Ime+' '+Prezime as PunoIme
from Autor
order by Ime