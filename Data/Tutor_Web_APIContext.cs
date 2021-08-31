using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tutor_Web_API.Models;

namespace Tutor_Web_API.Data
{
    public class Tutor_Web_APIContext : DbContext
    {
        public Tutor_Web_APIContext (DbContextOptions<Tutor_Web_APIContext> options)
            : base(options)
        {
        }

        public DbSet<Tutor_Web_API.Models.Tutor> Tutor { get; set; }
    }
}
