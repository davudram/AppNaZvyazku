namespace TestZvyazok.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subscription")]
    public partial class Subscription
    {
        public int SubscriptionID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Gigabyte { get; set; }

        public int? Calls { get; set; }

        [StringLength(250)]
        public string Notes { get; set; }

        public int? Price { get; set; }
    }
}
