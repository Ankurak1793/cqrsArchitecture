namespace Demo.Core.Models
{
    public class BlogDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public List<CommentDTO> Comments { get; set; } = new List<CommentDTO>();
    }
}
