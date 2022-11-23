namespace TestZvyazok
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subscription")]
    public partial class Subscription
    {
        public int ID { get; set; }
        [Required]
        public int? SubscriptionID { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [Required]
        public int? Gigabyte { get; set; }
        [Required]
        public int? Calls { get; set; }
        [Required]
        public int? Discount { get; set; }
        [Required]
        [StringLength(70)]
        public string Notes { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public int? Price { get; set; }
    }
}
