using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Managers.SectionsManager
{
    public interface ISectionsManager
    {
        Task<IReadOnlyCollection<Sections>> GetAll();
        Task<Sections> Add(Sections request);

        Task<Sections> GetById(int id);

        Task UpdateById(int id, Sections request);

        Task DeleteById(int id);
    }
}
