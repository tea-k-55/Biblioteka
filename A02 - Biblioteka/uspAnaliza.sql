alter procedure uspAnaliza
@autorID int=null,
@period int=null
as
select year(nc.DatumUzimanja) as Godina , count(nc.KnjigaID) as Broj
from Na_Citanju nc
left join Napisali np
on nc.KnjigaID = np.KnjigaID
where np.AutorID = @autorID and(YEAR(GETDATE()) - @period < year(nc.DatumUzimanja))
group by year(nc.DatumUzimanja)                            
order by Godina
