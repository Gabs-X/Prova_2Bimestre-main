using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using Revisao.Data.EntityFramework.Configurations;
using Revisao.Data.Repositories;
using Revisao.Domain.Entities;

namespace Revisao.Data.EntityFramework
{
    public class Contexto : DbContext
    {

        private readonly DatabaseSettings _databaseSettings;

        public Contexto(DbContextOptions<Contexto> options, IOptions<DatabaseSettings> databaseSettings)
            : base(options)
        {
            _databaseSettings = databaseSettings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_databaseSettings.ConnectionString);
        }

       

        public DbSet<RegistroJogo> RegistroJogo { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RegistroJogoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
