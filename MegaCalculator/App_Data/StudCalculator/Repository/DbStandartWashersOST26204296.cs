using System;
using System.Linq;
using MegaCalculator.App_Data.StudCalculator.Data;

namespace MegaCalculator.App_Data.StudCalculator.Repository
{
    public class DbStandartWashersOST26204296
    {
        private readonly ApplicationContext _db;

        public double StandartWashers(string tread)
        {
            var executeStandartWashers = Convert.ToDouble(_db.OST26_2042_96.Where(p => p.Thread == tread).Select(p => p.S).First());
            return executeStandartWashers;
        }
    }
}