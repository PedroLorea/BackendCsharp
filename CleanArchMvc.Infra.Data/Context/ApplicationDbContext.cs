using CleanArchMvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchMvc.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder) //Configura modelo usando fluentApi
        {
            base.OnModelCreating(builder); 
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            //O ApplyConfigurationsFromAssembly, procura as classes no EntitiesConfiguration que herdam IEntityTypeConfiguration 
        }
    }
}
