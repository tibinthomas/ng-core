using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vega.Models
{
    [Table("Models")]
    public class Model
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Make Make { get; set; } // (navigation property)
        public int MakeId { get; set; } // (foregin key -> nameof parent class(Make) + its propery(Id) = MakeId) code first migration makes only one field for Make and MakeId 
    }
}