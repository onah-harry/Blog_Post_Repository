using System.ComponentModel.DataAnnotations;

namespace BlogApp.BackService.Models
{
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string? Title { get; set; }
        [StringLength(1000)]
        public string? PostContent { get; set; }
    }
}
