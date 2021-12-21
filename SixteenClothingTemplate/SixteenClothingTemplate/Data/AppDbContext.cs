using Microsoft.EntityFrameworkCore;
using SixteenClothingTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SixteenClothingTemplate.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options): base(options)
        { }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
