﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.DataAccess.Model
{
    public class Master
    {
        [Key]
        
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Specialization { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<Repair>? Repairs { get; set; }
    }
}
