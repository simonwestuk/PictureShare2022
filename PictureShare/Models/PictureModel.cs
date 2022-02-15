using System.ComponentModel.DataAnnotations;

namespace PictureShare.Models
{
    public class PictureModel
    {
        [Key]
        public Guid Id { get; set; }

        [EmailAddress]
        public string UserEmail { get; set; }

        public string Caption { get; set; }

        [Required]
        public string ImagePath { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
