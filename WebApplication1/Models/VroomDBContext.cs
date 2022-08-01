using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class VroomDBContext : DbContext
    {
        public VroomDBContext(DbContextOptions<VroomDBContext> options):base(options)
        {
                
        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
    }
}
