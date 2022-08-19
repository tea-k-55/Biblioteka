alter procedure uspAutor
as
select AutorID as Sifra, Ime, Prezime, FORMAT(DatumRodjenja, 'dd/MM/yyyy') as DatumRodjenja, Adresa
from Autor