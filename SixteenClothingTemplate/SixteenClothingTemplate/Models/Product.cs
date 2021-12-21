using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SixteenClothingTemplate.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Title { get; set; }
        public int Price { get; set; }
        [MaxLength(50)]
        public string About { get; set; }
    }
}
