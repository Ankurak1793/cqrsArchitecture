using System.ComponentModel.DataAnnotations;

namespace Demo.ViewModels
{
    public class BlogViewModel
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;
    }
}