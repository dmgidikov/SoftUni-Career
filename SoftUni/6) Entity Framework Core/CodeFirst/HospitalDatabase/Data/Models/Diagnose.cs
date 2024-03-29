﻿using System.ComponentModel.DataAnnotations;

namespace HospitalDatabase.Data.Models
{
    public class Diagnose
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Comments { get; set; }

        public int PatientId { get; set; }

        public Patient Patient { get; set; }
    }
}
