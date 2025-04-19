﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRN_BE.Data
{
    [Table("Feature")]
    public class Feature
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int feature_id { get; set; }
        public string feature_name { get; set; }
    }
}
