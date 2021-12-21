using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SixteenClothingTemplate.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
        public string About { get; set; }
        [ForeignKey("Speciality")]
        public int SpecialityId { get; set; }
        public Speciality Speciality { get; set; }

    }
}
