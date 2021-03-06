﻿using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace Czechitas.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext (DbContextOptions<PeopleContext> options)
            : base(options)
        {
        }

        public DbSet<People> People { get; set; }
    }
}
