using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.DataAccess.Model
{
    public class UsedPart
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("RepairId")]
        public long RepairId { get; set; }
        public Repair? Repair { get; set; }
        [ForeignKey("PartId")]
        public long PartId { get; set; }
        public Part? Part { get; set; }

        public int Quantity { get; set; }
    }
}
