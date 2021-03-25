using System.ComponentModel.DataAnnotations;

namespace MegaCalculator.App_Data.StudCalculator.Data
{
    public partial class ATK_24_200_02_90
    {
        public int id { get; set; }

        [StringLength(255)]
        public string DN { get; set; }

        public double? b { get; set; }

        [StringLength(255)]
        public string PN { get; set; }

        [StringLength(255)]
        public string Style { get; set; }
    }
}
