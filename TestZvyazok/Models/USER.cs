namespace TestZvyazok.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER")]
    public partial class USER
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleID { get; set; }

        public int? AuthorizationID { get; set; }

        public int? TariffID { get; set; }

        public int? CreditCardID { get; set; }

        public virtual Authorization Authorization { get; set; }

        public virtual CreditCard CreditCard { get; set; }

        public virtual Role Role { get; set; }

        public virtual TARIFF TARIFF { get; set; }
    }
}
