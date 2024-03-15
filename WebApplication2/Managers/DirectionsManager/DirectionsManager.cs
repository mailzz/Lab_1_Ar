using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Managers.DirectionsManager
{
    public class DirectionsManager : IDirectionsManager
    {
        private readonly UniversityContext db = new UniversityContext();
        public DirectionsManager()
        {

        }
        public async Task<Directions> Add(Directions directions)
        {
            db.directions.Add(directions);//из context
            await db.SaveChangesAsync();
            return directions;
        }

        public async Task DeleteById(int id)
        {
            var directions = await this.GetById(id);
            db.directions.Remove(directions);
            await db.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<Directions>> GetAll()
        {
            var collection = await db.directions.ToListAsync();
            return collection;
        }

        public async Task<Directions> GetById(int id)
        {
            return await db.directions.FirstOrDefaultAsync(a => a.DirectionsId == id);
        }

        public async Task UpdateById(int id, Directions directions)
        {
            var dire = await this.GetById(id);
            dire.group = directions.group;
            dire.nubmer = directions.nubmer;
            await db.SaveChangesAsync();
        }
    }
}
