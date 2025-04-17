﻿using System.ComponentModel.DataAnnotations.Schema;

namespace PRN_BE.Data
{
    [Table("Booking_Status")]
    public class Booking_Status
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int booking_status_id { get; set; }
        public string booking_status_name { get; set; }
    }
}
