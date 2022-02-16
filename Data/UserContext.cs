#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lesson9.Models.Entities;

namespace Lesson9.Data
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext (DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public DbSet<Lesson9.Models.Entities.User> User { get; set; }
    }
}
