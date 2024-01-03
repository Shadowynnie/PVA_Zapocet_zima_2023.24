using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Zapocet.Models
{
    public class Credit
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public int Value { get; set; }

        [Required]
        public bool Success { get; set; }
    }
}
