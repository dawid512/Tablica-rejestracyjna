using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using tablica_rejestracyjna.Data;

namespace tablica_rejestracyjna.Data
{
    public class tablicaContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<tablice> Tablice { get; set; }
        public DbSet<Komentarze> Komentarze { get; set; }
        public DbSet<wojewodztwa>  Wojewodztwa { get; set; }
        public DbSet<powiat> Powiaty { get; set; }

        public tablicaContext(DbContextOptions<tablicaContext> options)
            : base(options)
        {

        }
        public tablicaContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<tablice>()
                .HasMany(x => x.Komentarze)
                .WithOne(x => x.Tablice)
                .HasForeignKey(x => x.tablicaID);
        }
    }
}
