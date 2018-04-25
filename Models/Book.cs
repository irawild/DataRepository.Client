﻿using System.ComponentModel.DataAnnotations;

namespace DataRepository.Client.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
