using Microsoft.EntityFrameworkCore;
using SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.DAL
{
    public class SampleDBContext: DbContext
    {
        public SampleDBContext(DbContextOptions<SampleDBContext> options) : base(options)
        {
        }
        public virtual DbSet<ItemModel> Items { get; set; }
        public virtual DbSet<StateModel> State { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemModel>().ToTable("ITEM_DATA");
            modelBuilder.Entity<StateModel>().ToTable("STATE_DATA");

        }
    }
}
