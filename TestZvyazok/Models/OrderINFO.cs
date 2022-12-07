namespace TestZvyazok.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderINFO")]
    public partial class OrderINFO
    {
        public int OrderINFOId { get; set; }

        public int? UserID { get; set; }

        public int? SubscriptionID { get; set; }

        public int? TariffID { get; set; }

        [StringLength(20)]
        public string STATUS { get; set; }

        public virtual Subscription Subscription { get; set; }

        public virtual TARIFF TARIFF { get; set; }
    }
}
