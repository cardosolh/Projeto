using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Model
{
    public class DataBaseContext : DbContext
    {

        public DataBaseContext()
        {
        }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
        {

        }

        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<Recurso> Recurso { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //o correto é colocar isso no arquivo de configuração
                optionsBuilder.UseMySql("server=localhost;database=seunome;user=root;password=");
            }
        }

    }
}
