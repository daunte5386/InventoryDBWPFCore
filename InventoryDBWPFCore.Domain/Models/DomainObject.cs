using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDBWPFCore.Domain.Models
{
    public class DomainObject
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }
    }
}
