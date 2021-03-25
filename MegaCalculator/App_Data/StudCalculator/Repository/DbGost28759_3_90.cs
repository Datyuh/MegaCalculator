using System;
using System.Collections.Generic;
using System.Linq;
using MegaCalculator.App_Data.StudCalculator.Data;
using NaturalSort.Extension;

namespace MegaCalculator.App_Data.StudCalculator.Repository
{
    class DbGost28759_3_90
    {
        private readonly ApplicationContext _db;

        public List<string> ExecutePnCollection()
        {
            var executePnCollection = new List<string>(_db.GOST_28759_3_90.Select(p => p.PN).Where(p => p != null).Distinct());
            var executeSortPnCollection = new List<string>(executePnCollection.OrderBy(p => p, StringComparison.OrdinalIgnoreCase.WithNaturalSort()));
            return executeSortPnCollection;
        }

        public List<string> ExecuteExecutionsCollection()
        {
            var executeExecutionsCollection = new List<string>(_db.GOSTs.Select(p => p.Exec_GOST28759_3).Where(p => p != null));
            var executeSortExecutionsCollection = new List<string>(executeExecutionsCollection.OrderBy(p => p, StringComparison.OrdinalIgnoreCase.WithNaturalSort()));
            return executeSortExecutionsCollection;
        }

        public List<string> ExecuteDnCollection()
        {
            var executeDnCollection = new List<string>(_db.GOST_28759_3_90.Select(p => p.DN).Where(p => p != null).Distinct());
            var executeSortDnCollection = new List<string>(executeDnCollection.OrderBy(p => p, StringComparison.OrdinalIgnoreCase.WithNaturalSort()));
            return executeSortDnCollection;
        }

        public double ExecutedBFromGost28759390(string pn, string dn)
        {
            var executedBFromGost28759390 = Convert.ToDouble(_db.GOST_28759_3_90.Where(p => p.PN == pn && p.DN == dn).Select(p => p.b).First());
            return executedBFromGost28759390;
        }

        public string ExecutionThicknessFlangeTheard(string pn, string dn)
        {
            var executionThicknessFlangeTheard = _db.GOST_28759_3_90.Where(p => p.PN == pn && p.DN == dn).Select(p => p.Thread).First();
            return executionThicknessFlangeTheard;
        }

        public double ExecutionThicknessFlangeN(string pn, string dn)
        {
            var executionThicknessFlangenType1 = Convert.ToDouble(_db.GOST_28759_3_90.Where(p => p.PN == pn && p.DN == dn).Select(p => p.n).First());
            return executionThicknessFlangenType1;
        }
    }
}
