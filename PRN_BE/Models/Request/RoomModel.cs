﻿using System.ComponentModel.DataAnnotations;

namespace PRN_BE.Models.Request
{
    public class RoomModel
    {
        public int room_id { get; set; }
        [Required] public string room_number { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be greater than or equal to 0.")]
        public double price_per_night { get; set; }
        [Required] public string description { get; set; }
        [Required] public int room_status_id { get; set; }
        [Required] public string location { get; set; }
        public int num_beds { get; set; }

        public int num_bathrooms { get; set; }
        public String? user_id { get; set; }
        public string? thumbnail { get; set; }
    }
}

