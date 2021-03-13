using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class SampleDatabaseContext:DbContext
    {
        //OnConfiguring metodu virtual şeklinde tanımlandığı için burada onu override ile yeniden kodlayabiliyoruz.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=C:\USERS\USER\SOURCE\REPOS\RECAPPROJECT\SAMPLEDATABASE\CARRENTALDATABASE.MDF;Trusted_Connection=true");
        }
        //SampleDatabaseContext entityler ile db'deki tabloları birleştirmeye yarar.
        public DbSet<Car> Cars { get; set; }       
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
