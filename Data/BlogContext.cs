using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelMe.Models;

namespace TravelMe.Data
{
    public class BlogContext: DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options): base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<PlaceCategory> PlaceCategories { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
