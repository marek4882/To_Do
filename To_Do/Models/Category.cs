﻿using System.ComponentModel.DataAnnotations;

namespace To_Do.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
