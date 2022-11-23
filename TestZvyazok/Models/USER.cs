namespace TestZvyazok
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(20)]
        public string FullName { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [Range(1990, 2023)]
        public DateTime? DateReg { get; set; }
        [Required]
        public int? RoleID { get; set; }
        [Required]
        public int? AuthorizationID { get; set; }

        public virtual Authorization Authorization { get; set; }

        public virtual PersonalArea PersonalArea { get; set; }

        public virtual Role Role { get; set; }
    }
}
