using System;
using System.ComponentModel.DataAnnotations;

namespace xlearn.Models
{
    public class User : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}