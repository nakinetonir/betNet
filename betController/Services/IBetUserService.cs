using betController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace betController.Services
{
    public interface IBetUserService
    {
        BetUser AddBetUser(BetUser betUser);

        void deleteBetUser(int id);

        void deleteBetUser(BetUser betUser);

        List<BetUser> getBetsUser();

        BetUser getBetUser(int id);

        BetUser updateBetUser(BetUser betUser);
    }
}
