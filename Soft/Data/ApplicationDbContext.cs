﻿using Loppprojekt.Infra.Cars.CarsDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Loppprojekt.Soft.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            initializeTables(builder);
        }

        internal void initializeTables(ModelBuilder builder)
        {
            CarsDbContext.InitializeTables(builder);
        }
    }
}
