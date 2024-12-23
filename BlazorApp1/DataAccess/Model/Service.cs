using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.DataAccess.Model
{
    public class Service
    {
        [Key]

        public long Id { get; set; }
        public string ServiceName { get; set; }
        public decimal Price { get; set; }

        public ICollection<RepairService>? RepairServices { get; set; }
    }
}
