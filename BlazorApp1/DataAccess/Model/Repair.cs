using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.DataAccess.Model
{
    public class Repair
    {
        [Key]
        
        public long Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal TotalCost { get; set; }


        [ForeignKey("EquipmentId")]
        public long EquipmentId { get; set; }
        public Equipment? Equipment { get; set; }

        [ForeignKey("MasterId")]
        public long MasterId { get; set; }
        public Master? Master { get; set; }

        [ForeignKey("ReceptionistId")]
        public long ReceptionistId { get; set; }
        public Receptionist? Receptionist { get; set; }


        public ICollection<RepairService>? RepairServices { get; set; }
        public ICollection<UsedPart>? UsedParts { get; set; }
    }
}
