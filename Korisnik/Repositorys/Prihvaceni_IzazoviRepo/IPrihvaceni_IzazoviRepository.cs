using Korisnik.Areas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korisnik.Repositorys.Prihvaceni_IzazoviRepo
{
    public interface IPrihvaceni_IzazoviRepository
    {
        IEnumerable<Prihvaceni_Izazovi> SviIzazovi();
        Task<Prihvaceni_Izazovi> GetIzazovi(int id);
        Task<Prihvaceni_Izazovi> AddIzazovi(Prihvaceni_Izazovi izazovi);
        Task<Prihvaceni_Izazovi> UpdateIzazovi(Prihvaceni_Izazovi izazovPromena);
        Task<Prihvaceni_Izazovi> Delete(int id);
    }
}
