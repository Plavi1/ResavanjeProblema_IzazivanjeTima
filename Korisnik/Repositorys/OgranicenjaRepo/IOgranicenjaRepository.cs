using Korisnik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korisnik.Repositorys.OgranicenjaRepo
{
    public interface IOgranicenjaRepository
    {
        IEnumerable<Ogranicenja> SvaOgranicenja();
        Task<Ogranicenja> AddOgranicenje(Ogranicenja ogranici);
        Task<Ogranicenja> Delete(int id);
        Task<Ogranicenja> NadjiOgranicenje(int id);
    }
}
