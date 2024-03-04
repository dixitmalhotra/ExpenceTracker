using System.ComponentModel.DataAnnotations;

namespace ExpenceTracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
    }
}
