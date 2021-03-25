using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MegaCalculator.App_Data.StudCalculator.Data;
using Microsoft.EntityFrameworkCore;
using NaturalSort.Extension;

namespace MegaCalculator.App_Data.StudCalculator.Repository
{
    public class DbWorkGost33259
    {
        private readonly ApplicationContext _db;

        public DbWorkGost33259(ApplicationContext db)
        {
            _db = db;
        }

        public async Task<IQueryable<string>> ExecGost33259()
        {
            var execution33259 = await _db.GOSTs.Where(p => p.Exec_GOST33259 != null).Select(p => p.Exec_GOST33259).ToListAsync(); 
            return execution33259.AsQueryable();
        }

        public async Task<IQueryable<string>> ExecutionPn33259()
        {
            var pn = await _db.Execution_All.Select(p => p.PN).Distinct().ToListAsync();
            var pnSort = pn.OrderBy(p => p, StringComparison.OrdinalIgnoreCase.WithNaturalSort());
            return pnSort.AsQueryable();
        }

        public async Task<IQueryable<string>> ExecutionDn33259()
        {
            var dn = await _db.Execution_All.Select(p => p.DN).Distinct().ToListAsync();
            var dnSort = dn.OrderBy(p => p, StringComparison.OrdinalIgnoreCase.WithNaturalSort());
            return dnSort.AsQueryable();
        }

        public async Task<IQueryable<string>> ExecutionType33259()
        {
            var typeGost33259 = await _db.GOSTs.Select(p => p.Style).Where(p => p == "Тип 11").ToListAsync();
            return typeGost33259.AsQueryable();
        }

        public string ExecutionThicknessFlangeTheard1(string pn, string dn)
        {
            var executionThicknessFlangeTheard1 = _db.Type_11.Where(p => p.PN == pn && p.DN == dn).Select(p => p.Thread_1).First().ToString();
            return executionThicknessFlangeTheard1;
        }

        public double ExecutionThicknessFlangeb1(string pn, string dn)
        {
            var executionThicknessFlangeb1 = Convert.ToDouble(_db.Type_11.Where(p => p.PN == pn && p.DN == dn).Select(p => p.b_1).First());
            return executionThicknessFlangeb1;
        }

        public double ExecutionThicknessFlangen_type1(string pn, string dn)
        {
            var executionThicknessFlangenType1 = Convert.ToDouble(_db.Type_11.Where(p => p.PN == pn && p.DN == dn).Select(p => p.n_type1).First());
            return executionThicknessFlangenType1;
        }
    }
}
