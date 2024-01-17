namespace Demo.Core.Models
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public BlogDTO Blogs { get; set; }
        public string Comment { get; set; } = string.Empty;
    }
}
