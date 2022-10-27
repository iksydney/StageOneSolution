using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsAndImplementations
{
    public class Repository : IRepository
    {
        private readonly string _about = "About.json";
        public Repository()
        {
        }
        public async Task<AboutMe> GetAboutMe()
        {
            var filePath = Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()), "Entities", _about);

            var aboutMe =  await Seeder.ReadJson<AboutMe>(filePath);
            return aboutMe;
        }
    }
}
