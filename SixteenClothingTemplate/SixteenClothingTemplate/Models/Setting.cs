using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SixteenClothingTemplate.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string AboutTitle { get; set; }
        [Column(TypeName ="ntext")]
        public string AboutContext { get; set; }
        [MaxLength(255)]
        public string AboutImage { get; set; }
        [MaxLength(255)]
        public string AboutLink { get; set; }
        [MaxLength(50)]

        public string OurBgTitle { get; set; }
        [Column(TypeName = "ntext")]
        public string OurBgContext { get; set; }
        [MaxLength(255)]
        public string OurBgImage { get; set; }

    }
}
