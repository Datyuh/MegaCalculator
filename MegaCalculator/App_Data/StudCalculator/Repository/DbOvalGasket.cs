using System;
using System.Linq;
using MegaCalculator.App_Data.StudCalculator.Data;

namespace MegaCalculator.App_Data.StudCalculator.Repository
{
    public class DbOvalGasket
    {
        private readonly ApplicationContext _db;

        public double ExecutedOvalGasket(string pn, string dn)
        {
            var executedOvalGasket =
                Convert.ToDouble(_db.Oval_Gasket.Where(p => p.PN == pn && p.DN == dn).Select(p => p.c).First());
            return executedOvalGasket;
        }
    }
}