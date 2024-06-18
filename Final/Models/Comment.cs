using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        [Required]
        public string CommentTitle { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }
        public int RecipeID { get; set; }
        [ValidateNever]
        public Recipe Recipe { get; set; }
    }
}
