﻿using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.DataAccess.Model
{
    public class Equipment
    {
        [Key]
        public long Id { get; set; }
        public string EquipmentType { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }


        public long ClientId { get; set; }
        public Client? Client { get; set; }


        public ICollection<Repair>? Repairs { get; set; }
    }
}
