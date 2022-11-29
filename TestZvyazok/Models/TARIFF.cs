namespace TestZvyazok.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TARIFF")]
    public partial class TARIFF
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TARIFF()
        {
            USERs = new HashSet<USER>();
        }

        public int TariffID { get; set; }

        [StringLength(15)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Device { get; set; }

        public int? Gigabyte { get; set; }

        public int? CallsInner { get; set; }

        public int? CallsOuter { get; set; }

        [StringLength(75)]
        public string Notes { get; set; }

        public double? Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER> USERs { get; set; }
    }
}
