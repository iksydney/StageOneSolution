using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsAndImplementations
{
    public interface IRepository
    {
        Task<AboutMe> GetAboutMe();
    }
}
