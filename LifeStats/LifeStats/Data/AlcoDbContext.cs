﻿using LifeStats.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace LifeStats.Data
{
    public class AlcoDbContext : DbContext
    {
        public AlcoDbContext(DbContextOptions dbContextOptions ): base( dbContextOptions )
        {
             
        }

        public DbSet<Alcohol> Alcohol { get; set; }
         
    }
}
