using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LMS_Lexicon.Core.Models.Entities
{
    public class Course
    {
        public int Id { get; set; }
        [MaxLength(25)]
        [MinLength(3)]
        [Required]
        [Display(Name = "Kursnamn")]
        public string CourseName { get; set; }
        [MaxLength(45)]
        [MinLength(3)]
        [Display(Name = "Beskrivning")]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Startdatum")]
        public DateTime StartDate { get; set; }

        //Nav prop
        public ICollection<ApplicationUser> ApplicationUsers { get; set; }
        public ICollection<Module> Modules { get; set; }
        public ICollection<Document> Documents { get; set; }


    }
}
