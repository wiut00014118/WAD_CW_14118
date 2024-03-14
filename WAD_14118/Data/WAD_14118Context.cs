using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WAD_14118.Models;

namespace WAD_14118.Data
{
    public class WAD_14118Context : DbContext
    {
        public WAD_14118Context (DbContextOptions<WAD_14118Context> options)
            : base(options)
        {
        }

        public DbSet<WAD_14118.Models.Movies> Movies { get; set; } = default!;
    }
}
