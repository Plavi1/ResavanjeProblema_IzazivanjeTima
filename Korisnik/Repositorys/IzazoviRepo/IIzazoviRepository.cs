using Korisnik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korisnik.Repositorys.IzazoviRepo
{
    public interface IIzazoviRepository
    {
        IEnumerable<Izazovi> SviIzazovi();
        Task<Izazovi> GetIzazovi(int id);
        Task<Izazovi> AddIzazovi(Izazovi izazovi);
        Task<Izazovi> UpdateIzazovi(Izazovi izazovPromena);
        Task<Izazovi> Delete(int id);
    }
}