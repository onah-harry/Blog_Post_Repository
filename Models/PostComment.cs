using System.ComponentModel.DataAnnotations;

namespace BlogApp.BackService.Models
{
    public class PostComment
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        public string? Comment { get; set; }
        public int BlogPostId { get; set; }

        public virtual BlogPost BlogPost { get; set; }
    }
}
