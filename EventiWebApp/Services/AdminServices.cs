using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.Repositories;

namespace EventiWebApp.Services
{
    public class AdminServices
    {
        public AdminRepository _adminRepository;

        public AdminServices(AdminRepository adminRepostiory)
        {
            _adminRepository = adminRepostiory;
        }
        public IEnumerable<Models.Korisnici> GetAllKorisnici()
        {
            return _adminRepository.GetAllKorisnici();
        }
        public void DeleteKorisnik(int id)
        {
            _adminRepository.DeleteKorisnik(id);
        }
        public IEnumerable<Models.Eventi> GetAllEventi()
        {
            return _adminRepository.GetAllEventi();
        }
        public void DeleteEvent(int id)
        {
            _adminRepository.DeleteEvent(id);
        }

    }
}
