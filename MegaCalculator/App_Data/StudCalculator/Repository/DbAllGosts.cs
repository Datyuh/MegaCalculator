using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using MegaCalculator.App_Data.StudCalculator.Data;
using Microsoft.EntityFrameworkCore;

namespace MegaCalculator.App_Data.StudCalculator.Repository
{
    public class DbAllGosts
    {
        private readonly ApplicationContext _db;

        public DbAllGosts(ApplicationContext db)
        {
            _db = db;
        }

        public async Task<IQueryable<string>> AllGostFromBase()
        {
            var allGostFromBase = await _db.GOSTs.Where(p => p.GOST != null && p.GOST != "ГОСТ 33259-2015 Ряд 2")
                .Select(p => p.GOST).ToListAsync();
            return allGostFromBase.AsQueryable();
        }
    }
}
