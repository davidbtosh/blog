using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blog.DataAccess.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string Bio { get; set; }

        public string Image { get; set; }

        public bool Following { get; set; }
    }
}
