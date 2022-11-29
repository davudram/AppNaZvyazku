namespace TestZvyazok.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonalArea")]
    public partial class PersonalArea
    {
        public int PersonalAreaID { get; set; }

        [StringLength(20)]
        public string FullName { get; set; }

        [Column(TypeName = "image")]
        public byte[] Avatar { get; set; }

        public DateTime? DateReg { get; set; }
    }
}
