using System.ComponentModel.DataAnnotations;

namespace xlearn.Models
{
    public class Profile : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}