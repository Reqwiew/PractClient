using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.DataAccess.Model
{
    public class Client
    {
        [Key]
        public long Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }


        public ICollection<Equipment>? Equipments { get; set; }
    }
}
