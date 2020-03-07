using betController.Interfaces;
using betController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace betController.Services
{
    public class BetService : IBetService
    {
        private readonly IContexto _contextoDB;

        public BetService(IContexto contextoDB)
        {
            _contextoDB = contextoDB;
        }

        public Bet AddBet(Bet bet)
        {
            var betPost =_contextoDB.Bet.Add(bet).Entity;

            _contextoDB.SaveChanges();

            return betPost;
        }

        public void deleteBet(int id)
        {
            var betRemove = this.getBet(id);
            this.deleteBet(betRemove);
        }


        public void deleteBet(Bet bet)
        {
            this._contextoDB.Bet.Remove(bet);
            this._contextoDB.SaveChanges();
        }

        public List<Bet> getBets()
        {
            return this._contextoDB.Bet.Select(x => x).ToList();
        }

        public Bet getBet(int id)
        {
            return this._contextoDB.Bet.Where(x => x.id == id).FirstOrDefault();
        }

        public Bet updateBet(Bet bet)
        {
           var updateBet = this._contextoDB.Bet.Update(bet).Entity;
            this._contextoDB.SaveChanges();
            return updateBet;
        }
    }
}
