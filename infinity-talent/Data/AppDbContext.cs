﻿using infinity_talent.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace infinity_talent.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Candidate> Candidate { get; set; }
    }
}
