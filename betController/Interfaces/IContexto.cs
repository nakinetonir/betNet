using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace betController.Interfaces
{
    public interface IContexto
    {
        DbSet<Models.Bet> Bet { get; set; }
        DbSet<Models.BetUser> BetUser { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
    }
}
