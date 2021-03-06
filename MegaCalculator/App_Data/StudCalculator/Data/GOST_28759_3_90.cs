using System.ComponentModel.DataAnnotations;

namespace MegaCalculator.App_Data.StudCalculator.Data
{
    public partial class GOST_28759_3_90
    {
        public int id { get; set; }

        [StringLength(255)]
        public string DN { get; set; }

        [StringLength(255)]
        public string PN { get; set; }

        public double? b { get; set; }

        [StringLength(255)]
        public string Thread { get; set; }

        public double? n { get; set; }
    }
}
