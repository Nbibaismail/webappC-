using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WepApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [DisplayName("category number")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
