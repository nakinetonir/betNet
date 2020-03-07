using betController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace betController.EntityConfig
{
    public class BetEntityConfig
    {
        public static void SetBetEntityConfig(EntityTypeBuilder<Bet> entityBuilder)
        {
            entityBuilder.HasKey(x => x.id);
            //entityBuilder.Property(x => x.player_one).IsRequired();
            //entityBuilder.Property(x => x.bet_money).ValueGeneratedNever(> 100);
        }
    }
}
