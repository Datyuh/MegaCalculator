using System.Linq;
using MegaCalculator.App_Data.StudCalculator.Data;

namespace MegaCalculator.App_Data.StudCalculator.Repository
{
    public class DbExecutionGost33259
    {
        private readonly ApplicationContext _db;

        public double? ExecutionGost33259CE(string pn, string dn)
        {
            var executionGost33259CE =
                _db.Execution_All.Where(p => p.PN == pn && p.DN == dn).Select(p => p.h1).First();
            return executionGost33259CE;
        }

        public double? ExecutionGost33259DF(string pn, string dn)
        {
            var executionGost33259DF =
                _db.Execution_All.Where(p => p.PN == pn && p.DN == dn).Select(p => p.h2).First();
            return executionGost33259DF;
        }

        public double? ExecutionGost33259L(string pn, string dn)
        {
            var executionGost33259L =
                _db.Execution_All.Where(p => p.PN == pn && p.DN == dn).Select(p => p.h4).First();
            return executionGost33259L;
        }

        public double? ExecutionGost33259M(string pn, string dn)
        {
            var executionGost33259M =
                _db.Execution_All.Where(p => p.PN == pn && p.DN == dn).Select(p => p.h5).First();
            return executionGost33259M;
        }
    }
}