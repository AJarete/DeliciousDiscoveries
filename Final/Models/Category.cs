using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
