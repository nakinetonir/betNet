using betController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace betController.Services
{
    public interface IBetService
    {
        Bet AddBet(Bet bet);

        void deleteBet(int id);

        void deleteBet(Bet bet);

        List<Bet> getBets();

        Bet getBet(int id);

        Bet updateBet(Bet bet);
    }
}
