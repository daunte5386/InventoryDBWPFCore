using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDBWPFCore.Domain.Models
{
    [Table("Users")]
    public class UserDB : DomainObject
    {
        //[Key]
        //[Column(Order = 0)]
        //public int UserId { get; set; }

        [Column(Order = 1)]
        public string Email { get; set; }

        [Column(Order = 2)]
        public string Username { get; set; }

        [Column(Order = 3)]
        public string Password { get; set; }
    }
}
