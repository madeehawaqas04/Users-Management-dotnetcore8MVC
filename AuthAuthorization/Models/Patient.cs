using System.ComponentModel.DataAnnotations;

namespace AuthAuthorization.Models
{
    public class Patient
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        public string? Address { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
