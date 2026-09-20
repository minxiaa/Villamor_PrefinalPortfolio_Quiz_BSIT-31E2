namespace Villamor_Portfolio_Quiz.Models
{
    public class Comment
    {
        public string ProjectName { get; set; } = string.Empty; 
        public string Name { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public DateTime DatePosted { get; set; }
    }
}
