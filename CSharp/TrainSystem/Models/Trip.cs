﻿using System.ComponentModel.DataAnnotations;

namespace TrainSystem.Models
{
    public class Trip
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        public string Origin { get; set; }

        [Required]
        [MinLength(1)]
        public string Destination { get; set; }

        [Required]
        public int Business { get; set; }

        [Required]
        public int Economy { get; set; }
    }
}