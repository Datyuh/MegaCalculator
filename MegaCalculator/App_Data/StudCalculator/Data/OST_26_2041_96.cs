using System.ComponentModel.DataAnnotations;

namespace MegaCalculator.App_Data.StudCalculator.Data
{
    public partial class OST_26_2041_96
    {
        public int id { get; set; }

        [StringLength(255)]
        public string Thread { get; set; }

        public double? Р_Large { get; set; }

        public double? P_Small { get; set; }

        public double? H { get; set; }
    }
}
