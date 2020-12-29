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
        Izazovi GetIzazovi(int id);
        Izazovi AddIzazovi(Izazovi izazovi);
        Izazovi UpdateIzazovi(Izazovi izazovPromena);
        Izazovi Delete(int id);
    }
}