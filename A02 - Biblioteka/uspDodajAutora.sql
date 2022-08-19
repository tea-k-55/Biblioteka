alter procedure uspDodajAutora
@autorID int = null,
@ime nvarchar(50) = null,
@prezime nvarchar(50) = null,
@datumRodj datetime = null
as
insert into Autor(AutorID, Ime, Prezime, DatumRodjenja)
values (@autorID ,@ime, @prezime, @datumRodj)