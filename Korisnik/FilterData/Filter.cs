﻿using Korisnik.Areas.Identity.Data;
using Korisnik.Models;
using Korisnik.Repositorys.IzazoviRepo;
using Korisnik.Repositorys.OgranicenjaRepo;
using Korisnik.Repositorys.Prihvaceni_IzazoviRepo;
using System.Collections.Generic;
using System.Linq;

namespace Korisnik.Filteri
{
    public class Filter : IFilter 
    { 
        private readonly IKorisnikRepository korisnikRepository;
        private readonly IIzazoviRepository izazoviRepository;
        private readonly IPrihvaceni_IzazoviRepository prihvaceniIzazovi;
        private readonly IOgranicenjaRepository ogranicenjaRepository;

        public Filter(IKorisnikRepository korisnikRepository,
                      IIzazoviRepository izazoviRepository,
                      IPrihvaceni_IzazoviRepository prihvaceniIzazovi,
                      IOgranicenjaRepository ogranicenjaRepository)
        {
            
            this.korisnikRepository = korisnikRepository;
            this.izazoviRepository = izazoviRepository;
            this.prihvaceniIzazovi = prihvaceniIzazovi;
            this.ogranicenjaRepository = ogranicenjaRepository;
        }

        //---------------------------------------------Filter Tabele u Posalji/Izazov--------------------------------------------------------------------------------------------------
        

        //SREDITI BOLJE 
        public IEnumerable<ApplicationKorisnik> PosaljiIzazovFilterTabele(string idUlogovanog)
        {                            
            var lista = korisnikRepository.SviKorisnici().Where(a => a.Id != idUlogovanog);                        // Svi korisnici izuzev ulogovanog korisnika
            var izazvaoUlogovani = izazoviRepository.SviIzazovi().Where(b => b.IdIzazivaoca == idUlogovanog);      // Svi izazovi gde se Id ulogovanog slaze sa Id-jem izazivaoca 
            var izazvanUlogovani = izazoviRepository.SviIzazovi().Where(c => c.IdIzazavanog == idUlogovanog);      // Svi izazovi gde se Id ulogovanog slaze sa Id-jem izazvanog
            var prihvatioUlogovani = prihvaceniIzazovi.SviIzazovi().Where(d => d.IdIzazavanog == idUlogovanog);    // Svi prihvaceni izazovi gde se Id ulogovanog slaze sa Id-jem izazvanog
            var prihvacenUlogovani = prihvaceniIzazovi.SviIzazovi().Where(e => e.IdIzazivaoca == idUlogovanog);    // Svi prihvaceni izazovi gde se Id ulogovanog slaze sa Id-jem izazivaoca
            var ogranicenja = ogranicenjaRepository.SvaOgranicenja().Where(f => f.IdKorisnika == idUlogovanog);    // Sva ogranicenja administratora 


            foreach (var item in izazvaoUlogovani)                                               // {--
            {                                                                                    // {--      Filtrira sve ID-jeve izazvanih
                lista = lista.Where(e => e.Id != item.IdIzazavanog);                             // {--        koje je ulogovani izazvao
            }                                                                                    // {--
           
            foreach (var item in izazvanUlogovani)                                               // {--
            {                                                                                    // {--      Filtrira sve ID-jeve izazivalaca 
                lista = lista.Where(e => e.Id != item.IdIzazivaoca);                             // {--       koji su poslali izazov ulogovanom
            }                                                                                    // {--

            foreach (var item in prihvatioUlogovani)                                             // {--
            {                                                                                    // {--      Filtrira sve ID-jeve izazivalaca 
                lista = lista.Where(e => e.Id != item.IdIzazivaoca);                             // {--       koji su poslali ulogovanom izazov
            }                                                                                    // {--
            
            foreach (var item in prihvacenUlogovani)                                             // {--
            {                                                                                    // {--      Filtrira sve ID-jeve izazvanih 
                lista = lista.Where(e => e.Id != item.IdIzazavanog);                             // {--       kojima je ulogovani poslao izazov
            }                                                                                    // {--

            foreach(var item in ogranicenja)
            {
                lista = lista.Where(e => e.Id != item.IdSaKojimOgranicavamKorisnika);
            }

            lista = lista.Where(e => e.UserName != "Admin@admin.com");                           // Filtriramo admina 

            return lista;
        }
    }
}
