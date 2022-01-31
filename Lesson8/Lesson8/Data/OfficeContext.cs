#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lesson8.Models;

namespace Lesson8.Data
{
    public class OfficeContext : DbContext
    {
        public OfficeContext (DbContextOptions<OfficeContext> options)
            : base(options)
        {
        }

        public DbSet<Lesson8.Models.Office> Office { get; set; }
    }
}
