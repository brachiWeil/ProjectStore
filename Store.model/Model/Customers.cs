﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Model
{
    [Table("Customers")]
    public class Customers
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(25)]
        public string FirstName { get; set; }
        [MaxLength(25)]
        public string LastName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        public string Email { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public bool ClubStatus { get; set; }
    }
}
