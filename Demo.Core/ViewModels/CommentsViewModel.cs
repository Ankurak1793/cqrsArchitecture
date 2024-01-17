using System.ComponentModel.DataAnnotations;

namespace Demo.Core.ViewModels
{
    public class CommentsViewModel
    {
        [Required]
        public int BlogId { get; set; }

        [Required]
        public string Comment { get; set; } = string.Empty;
    }
}
