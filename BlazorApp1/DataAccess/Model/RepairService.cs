using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.DataAccess.Model
{
    public class RepairService
    {
        [Key]
        
        public long Id { get; set; }


        [ForeignKey("RepairId")]
        public long RepairId { get; set; }
        public Repair? Repair { get; set; }

        [ForeignKey("ServiceId")]
        public long ServiceId { get; set; }
        public Service? Service { get; set; }
    }
}
