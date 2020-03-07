using betController.EntityConfig;
using betController.Interfaces;
using betController.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace betController.Contest
{
    public class contexto : DbContext, IContexto
    {
        public contexto(DbContextOptions<contexto> options) : base(options)
        { 
            
        }
        
        public DbSet<Models.Bet> Bet { set; get; }

        public DbSet<Models.BetUser> BetUser { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            BetEntityConfig.SetBetEntityConfig(modelBuilder.Entity<Bet>().ToTable("bet_bet"));

            BetUserEntityConfig.SetBetEntityConfig(modelBuilder.Entity<BetUser>().ToTable("bet_bet_user"));
            //modelBuilder.Entity<Models.Bet>().ToTable("bet_bet");
        }

    }
}
