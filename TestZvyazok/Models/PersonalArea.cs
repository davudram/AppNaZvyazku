namespace TestZvyazok
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonalArea")]
    public partial class PersonalArea
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(20)]
        public string FullName { get; set; }

        [Column(TypeName = "image")]
        public byte[] Avatar { get; set; }
        [Required]
        public int? TariffID { get; set; }
        [Required]
        public int? SubscriptionID { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public int? Cash { get; set; }
        [Required]
        public int? Gigabyte { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [Range(1990, 2023)]
        public DateTime? DateReg { get; set; }

        public virtual USER USER { get; set; }
    }
}
