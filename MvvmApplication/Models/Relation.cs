using MvvmApplication.Services;

namespace MvvmApplication.Models
{
    public class Relation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BrandId { get; set; }
        public int ClickCount { get; set; }

        public Relation()
        {
            
        }
    }
}