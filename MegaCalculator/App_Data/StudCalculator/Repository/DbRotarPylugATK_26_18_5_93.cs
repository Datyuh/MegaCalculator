using System;
using System.Collections.Generic;
using System.Linq;
using MegaCalculator.App_Data.StudCalculator.Data;
using NaturalSort.Extension;

namespace MegaCalculator.App_Data.StudCalculator.Repository
{
    public class DbRotarPylugATK_26_18_5_93
    {
        private readonly ApplicationContext _db;

        public List<string> ExecuteAtk_26_18_5_93()
        {
            var executeAtk2618593 = new List<string>(_db.ATK_26_18_5_93.Select(p => p.Style)).Distinct().AsParallel();
            var executeSortAtk2618593 = new List<string>(executeAtk2618593
                .OrderBy(p => p, StringComparison.OrdinalIgnoreCase.WithNaturalSort()).AsParallel());
            return executeSortAtk2618593;
        }

        public double Executeb(string pn, string dn, string style)
        {
            try
            {
                var executedb = Convert.ToDouble(_db.ATK_26_18_5_93.Where(p => p.PN == pn && p.DN == dn && p.Style == style).Select(p => p.b)
                    .First());
                return executedb;
            }
            catch (InvalidOperationException)
            {
                return 0;
            }
        }
    }
}