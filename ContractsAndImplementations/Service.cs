using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsAndImplementations
{
    public class Service : IService
    {
        private readonly IRepository _repository;
        public Service(IRepository repo)
        {
            _repository = repo;
        }
        public async Task<AboutMe> GetAboutMe()
        {
            var about  = await _repository.GetAboutMe();
            return about;
        }
    }
}
