using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blog.DataAccess.Entities
{
    [Table("Tag")]
    public class TagClass
    {
        [Key]
        public int Id { get; set; }

        public string Tag { get; set; }

    }
}
