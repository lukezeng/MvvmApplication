namespace MvvmApplication.Models
{
    public class Relation
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long BrandId { get; set; }
        public long VisitCount { get; set; }
        public string Reason { get; set; } 
    }
}