using System;
using Microsoft.EntityFrameworkCore;

namespace SpamAPI.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions options) : base(options) { }
        public DbSet<Key> Keys {get; set;}
        public DbSet<Spam> Spam {get; set;}
    }

}