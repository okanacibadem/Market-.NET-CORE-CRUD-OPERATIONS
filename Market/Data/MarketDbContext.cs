using Market.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Data
{
    public class MarketDbContext:DbContext
    {
        public MarketDbContext(DbContextOptions<MarketDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Personel> Personels { get; set; }
        public virtual DbSet<Reyonlar> Reyonlars { get; set; }
        public virtual DbSet<Urunler> Urunlers { get; set; }

    }
}
