using System;
using System.Collections.Generic;
using System.Linq;
using MegaCalculator.App_Data.StudCalculator.Data;
using NaturalSort.Extension;

namespace MegaCalculator.App_Data.StudCalculator.Repository
{
    public class DbStudExtract
    {
        private readonly ApplicationContext _db;

        public List<string> ExtractMaterialStud()
        {
            var extractMaterialStud = new List<string>(_db.GOSTs.Select(p => p.Material_Stud).Where(p => p != null).Distinct());
            var extractSortMaterialStud = new List<string>(extractMaterialStud.OrderBy(p => p, StringComparison.OrdinalIgnoreCase.WithNaturalSort()));
            return extractSortMaterialStud;
        }

        public List<string> ExecutionStud()
        {
            var executionStud = new List<string>(_db.GOSTs.Select(p => p.Style_Stud).Where(p => p != null));
            var executionSortStud = new List<string>(executionStud.OrderBy(p => p, StringComparison.OrdinalIgnoreCase.WithNaturalSort()));
            return executionSortStud;
        }
    }
}