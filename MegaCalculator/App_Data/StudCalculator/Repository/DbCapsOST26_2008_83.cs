using System;
using System.Collections.Generic;
using System.Linq;
using MegaCalculator.App_Data.StudCalculator.Data;
using NaturalSort.Extension;

namespace MegaCalculator.App_Data.StudCalculator.Repository
{
    public class DbCapsOST26_2008_83
    {
        private readonly ApplicationContext _db;

        public List<string> ExecuteOst26_2008_83()
        {
            var executeOst26200883 = new List<string>(_db.OST26_2008_83.Select(p => p.Figure)).Distinct().AsParallel();
            var executeSortOst26200883 = new List<string>(executeOst26200883
                .OrderBy(p => p, StringComparison.OrdinalIgnoreCase.WithNaturalSort()).AsParallel());
            return executeSortOst26200883;
        }
    }
}