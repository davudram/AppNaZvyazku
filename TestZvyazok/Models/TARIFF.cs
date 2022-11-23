namespace TestZvyazok
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TARIFF")]
    public partial class TARIFF
    {
        public int ID { get; set; }
        [Required]
        public int? TariffID { get; set; }
        [Required]
        [StringLength(15)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string Device { get; set; }
        [Required]
        public int? Stock { get; set; }
        [Required]
        public int? Gigabyte { get; set; }
        [Required]
        public int? Calls { get; set; }
        [Required]
        [StringLength(75)]
        public string Notes { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public int? Price { get; set; }
    }
}
