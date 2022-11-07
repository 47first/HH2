using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bebra
{
    public class GamesModelContext : DbContext
    {
        public DbSet<Game> Games { get; set; } = null!;
        public DbSet<Company> Companies { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<Launcher> Launchers { get; set; } = null!;
        public DbSet<Showground> Showgrounds { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Привязка контекста к существующей бд
            optionsBuilder.UseMySql("Server=MYSQL8001.site4now.net;Database=db_a8ee9f_games;Uid=a8ee9f_games;Pwd=dsafsf243",
            new MySqlServerVersion(new Version(5, 0)));
        }
    }
}
