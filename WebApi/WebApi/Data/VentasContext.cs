using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class VentasContext : DbContext
    {
        public VentasContext (DbContextOptions<VentasContext> options)
            : base(options)
        {
        }

        public DbSet<WebApi.Models.Facturas> Facturas { get; set; }

        public DbSet<WebApi.Models.Productos> Productos { get; set; }
    }
}
