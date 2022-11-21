﻿using System.ComponentModel.DataAnnotations;

namespace BookListRazor.wwwroot.Model
{
    public class Book
    {
        [Key]
        public int ID { get; set;  }
        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
