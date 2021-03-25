using System;
using System.Collections.Generic;
using System.Linq;
using MegaCalculator.App_Data.StudCalculator.Data;
using NaturalSort.Extension;

namespace MegaCalculator.App_Data.StudCalculator.Repository
{
    class DbAtk26_18_13_96
    {
        private readonly ApplicationContext _db;

        public List<string> ExecutePnCollection()
        {
            var executePnCollection = new List<string>(_db.ATK_26_18_13_96.Select(p => p.PN).Distinct());
            var executeSortPnCollection = new List<string>(executePnCollection.OrderBy(p => p, StringComparison.OrdinalIgnoreCase.WithNaturalSort()));
            return executeSortPnCollection;
        }

        public List<string> ExecuteExecutionsCollectionForPlug()
        {
            var executeExecutionsCollection = new List<string>(_db.ATK_26_18_13_96.Select(p => p.Execution_Caps).Where(p => p != null).Distinct());
            var executeSortExecutionsCollection = new List<string>(executeExecutionsCollection.OrderBy(p => p, StringComparison.OrdinalIgnoreCase.WithNaturalSort()));
            return executeSortExecutionsCollection;
        }

        public List<string> ExecuteExecutionsCollection()
        {
            var executeExecutionsCollection = new List<string>(_db.GOSTs.Select(p => p.Exec_ATK_26_18_13_96).Where(p => p != null));
            var executeSortExecutionsCollection = new List<string>(executeExecutionsCollection.OrderBy(p => p, StringComparison.OrdinalIgnoreCase.WithNaturalSort()));
            return executeSortExecutionsCollection;
        }

        public List<string> ExecuteDnCollection()
        {
            var executeDnCollection = new List<string>(_db.ATK_26_18_13_96.Select(p => p.DN)).Distinct();
            var executeSortDnCollection = new List<string>(executeDnCollection.OrderBy(p => p, StringComparison.OrdinalIgnoreCase.WithNaturalSort()));
            return executeSortDnCollection;
        }

        public double ExecutionThicknessFlangeB(string pn, string dn)
        {
            var executionThicknessFlangeB = Convert.ToDouble(_db.ATK_26_18_13_96.Where(p => p.PN == pn && p.DN == dn).Select(p => p.b).First());
            return executionThicknessFlangeB;
        }

        public double ExecutionGost26181396H1(string pn, string dn)
        {
            var executionThicknessFlangeB = Convert.ToDouble(_db.ATK_26_18_13_96.Where(p => p.PN == pn && p.DN == dn).Select(p => p.h1).First());
            return executionThicknessFlangeB;
        }

        public double ExecutionGost26181396H2(string pn, string dn)
        {
            var executionThicknessFlangeB = Convert.ToDouble(_db.ATK_26_18_13_96.Where(p => p.PN == pn && p.DN == dn).Select(p => p.h2).First());
            return executionThicknessFlangeB;
        }

        public double ExecutionThicknessFlangeN(string pn, string dn)
        {
            var executionThicknessFlangeB = Convert.ToDouble(_db.ATK_26_18_13_96.Where(p => p.PN == pn && p.DN == dn).Select(p => p.n).First());
            return executionThicknessFlangeB;
        }

        public string ExecutionThicknessFlangeTheard(string pn, string dn)
        {
            var executionThicknessFlangeB = _db.ATK_26_18_13_96.Where(p => p.PN == pn && p.DN == dn).Select(p => p.Thread).First();
            return executionThicknessFlangeB;
        }
    }
}
