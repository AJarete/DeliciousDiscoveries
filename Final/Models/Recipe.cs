using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Ingredients { get; set; }
        [Required]
        public string Instructions { get; set; }
        public string Category { get; set; }
        [ValidateNever]
        public ICollection<Comment> Comments { get; set; }
    }
}
