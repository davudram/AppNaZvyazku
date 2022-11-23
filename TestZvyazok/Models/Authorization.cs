namespace TestZvyazok
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Authorization")]
    public partial class Authorization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Authorization()
        {
            USERs = new HashSet<USER>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorizationID { get; set; }
        [Required]
        [StringLength(20)]
        public string FullName { get; set; }
        [Required]
        [StringLength(30)]
        public string Email { get; set; }
        [Required]
        [StringLength(15)]
        public string Login { get; set; }
        [Required]
        [StringLength(10)]
        public string Password { get; set; }
        [Required]
        public int? CreditCardID { get; set; }
        [Required]
        public int? PhoneNumberID { get; set; }

        public virtual CreditCard CreditCard { get; set; }

        public virtual PhoneNumber PhoneNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER> USERs { get; set; }
    }
}
