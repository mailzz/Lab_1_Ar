using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Managers.SectionsManager
{
    public class SectionsManager : ISectionsManager
    {
        private readonly UniversityContext db = new UniversityContext();
        public SectionsManager()
        {

        }
        public async Task<Sections> Add(Sections sections)
        {
            db.sections.Add(sections);//из context
            await db.SaveChangesAsync();
            return sections;
        }

        public async Task DeleteById(int id)
        {
            var sections = await this.GetById(id);
            db.sections.Remove(sections);
            await db.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<Sections>> GetAll()
        {
            var collection = await db.sections.ToListAsync();
            return collection;
        }

        public async Task<Sections> GetById(int id)
        {
            return await db.sections.FirstOrDefaultAsync(a => a.SectionsId == id);
        }

        public async Task UpdateById(int id, Sections sections)
        {
            var sect = await this.GetById(id);
            sect.Name = sections.Name;
            sect.Number = sections.Number;
            await db.SaveChangesAsync();
        }
    }
}
