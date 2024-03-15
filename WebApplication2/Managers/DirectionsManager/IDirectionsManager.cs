 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Managers.DirectionsManager
{
    public interface IDirectionsManager
    {
        Task<IReadOnlyCollection<Directions>> GetAll();
        Task<Directions> Add(Directions request);

        Task<Directions> GetById(int id);

        Task UpdateById(int id, Directions request);

        Task DeleteById(int id);
    }
}
