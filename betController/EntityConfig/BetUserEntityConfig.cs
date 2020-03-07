using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace betController.EntityConfig
{
    public class BetUserEntityConfig
    {
        public static void SetBetEntityConfig(EntityTypeBuilder<Models.BetUser> entityBuilder)
        {
            entityBuilder.HasKey(x => x.id);
            //entityBuilder.Property(x => x.player_one).IsRequired();
            //entityBuilder.Property(x => x.bet_money).ValueGeneratedNever(> 100);
        }
    }
}
