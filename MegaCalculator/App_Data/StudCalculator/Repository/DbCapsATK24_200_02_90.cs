using System;
using System.Collections.Generic;
using System.Linq;
using MegaCalculator.App_Data.StudCalculator.Data;
using NaturalSort.Extension;

namespace MegaCalculator.App_Data.StudCalculator.Repository
{
    public class DbCapsAtk242000290
    {
        private readonly ApplicationContext _db;

        public List<string> DbCapsCollection()
        {
            var allCaps = new List<string>(_db.GOSTs.Where(p => true).Select(p => p.Caps));
            return allCaps;
        }

        public List<string> ExecuteAtk24_200_02_90()
        {
            var executeAtk242000290 = new List<string>(_db.ATK_24_200_02_90.Select(p => p.Style)).Distinct();
            var executeSortAtk242000290 = new List<string>(executeAtk242000290.OrderBy(p => p, StringComparison.OrdinalIgnoreCase.WithNaturalSort()));
            return executeSortAtk242000290;
        }

        public double Executedb(string pn, string dn, string style)
        {
            try
            {
                var executeAtk242000290B = Convert.ToDouble(_db.ATK_24_200_02_90.Where(p => p.PN == pn && p.DN == dn && p.Style == style)
                    .Select(p => p.b).First());
                return executeAtk242000290B;
            }
            catch (InvalidOperationException)
            {
                return double.NaN;
            }
        }
    }
}