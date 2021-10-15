using System;
using System.ComponentModel.DataAnnotations;

namespace CoasterManagment.Models
{
    public class Coaster
    {
        public string Id { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]

        [Display(Name = "Size(in Inch)")]
        public int Size { get; set; }

        [Required]
        public int Rating { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Modified Date")]
        public DateTime? ModifiedDate { get; set; }
    }
}