using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.DataAccess.Model
{
    public class Part
    {
        [Key]
        
        public long Id { get; set; }
        public string PartName { get; set; }
        public decimal Price { get; set; }

        public ICollection<UsedPart>? UsedParts { get; set; }
    }
}
