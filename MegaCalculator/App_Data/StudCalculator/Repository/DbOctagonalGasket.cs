using System;
using System.Linq;
using MegaCalculator.App_Data.StudCalculator.Data;

namespace MegaCalculator.App_Data.StudCalculator.Repository
{
    public class DbOctagonalGasket
    {
        private readonly ApplicationContext _db;

        public double ExecutedOctogonalGasket(string pn, string dn)
        {
            var executedOctogonalGasket =
                Convert.ToDouble(_db.Octagonal_Gasket.Where(p => p.PN == pn && p.DN == dn).Select(p => p.c).First());
            return executedOctogonalGasket;
        }
    }
}