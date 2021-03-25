using System.ComponentModel.DataAnnotations;

namespace MegaCalculator.App_Data.StudCalculator.Data
{
    public partial class Oval_Gasket
    {
        public int id { get; set; }

        [StringLength(255)]
        public string DN { get; set; }

        [StringLength(255)]
        public string PN { get; set; }

        public double? c { get; set; }
    }
}
