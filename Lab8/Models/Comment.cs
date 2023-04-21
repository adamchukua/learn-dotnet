namespace Lab6.Models
{
    public class Comment
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long PostId { get; set; }
        public string Text { get; set; }
    }
}
