namespace ProductReview.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int Score { get; set; }
        public string Comment { get; set; } = string.Empty;
    }
}
