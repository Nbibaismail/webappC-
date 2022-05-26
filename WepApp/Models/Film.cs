using System.ComponentModel.DataAnnotations;

namespace WepApp.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }

        public String Score { get; set; }

        public String Image { get; set; }
        
        public int catId { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
