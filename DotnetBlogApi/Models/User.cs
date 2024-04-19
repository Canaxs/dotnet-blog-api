using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DotnetBlogApi.Attribute;

namespace DotnetBlogApi.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Username is required")]
        [Unique(nameof(Id))]
        public string Username { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Username is required")]
        public string Password { get; set; }
    }
}
