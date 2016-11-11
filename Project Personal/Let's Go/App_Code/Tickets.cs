namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tickets
    {
        public int TicketsID { get; set; }

        public int DiscountID { get; set; }

        public int BookingID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Class { get; set; }

        public virtual Booking Booking { get; set; }

        public virtual Discount Discount { get; set; }
    }
}
