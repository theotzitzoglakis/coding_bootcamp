namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            Booking = new HashSet<Booking>();
        }

        [Key]
        public int UserID { get; set; }

        [Column("First Name")]
        [Required]
        [StringLength(50)]
        public string First_Name { get; set; }

        [Column("Last Name")]
        [Required]
        [StringLength(50)]
        public string Last_Name { get; set; }

        [Column("Birth Date", TypeName = "date")]
        public DateTime Birth_Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Column("e-mail")]
        [Required]
        [StringLength(50)]
        public string e_mail { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Booking { get; set; }
    }
}
