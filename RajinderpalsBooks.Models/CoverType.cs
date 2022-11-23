using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;// added this using system

namespace RajinderpalsBooks.Models
{
    public class CoverType
    {
        [Key]   // added all below lines
        public int Id { get; set; }
        [Display(Name = "Category Name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
