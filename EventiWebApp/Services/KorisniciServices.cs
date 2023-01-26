using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.Repositories;
using EventiWebApp.DbModels;

namespace EventiWebApp.Services
{
    public class KorisniciServices
    {
        public KorisniciRepository _korisniciRepository;

        public KorisniciServices(KorisniciRepository korisniciRepostiory)
        {
            _korisniciRepository = korisniciRepostiory;
        }

    }
}
