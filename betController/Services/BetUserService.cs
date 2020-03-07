using betController.Interfaces;
using betController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace betController.Services
{
    public class BetUserService : IBetUserService
    {
        private readonly IContexto _contextoDB;

        public BetUserService(IContexto contextoDB)
        {
            _contextoDB = contextoDB;
        }
        public BetUser AddBetUser(BetUser betUser)
        {
            var betPost = _contextoDB.BetUser.Add(betUser).Entity;

            _contextoDB.SaveChanges();

            return betPost;
        }

        public  void deleteBetUser(int id)
        {

            var betRemove = this.getBetUser(id);
            this.deleteBetUser(betRemove);
        }

        public void deleteBetUser(BetUser betUser)
        {
            this._contextoDB.BetUser.Remove(betUser);
            this._contextoDB.SaveChanges();
        }

        public List<BetUser> getBetsUser()
        {
            return this._contextoDB.BetUser.Select(x => x).ToList();
        }

        public BetUser getBetUser(int id)
        {
            return this._contextoDB.BetUser.Where(x => x.id == id).FirstOrDefault();
        }

        public BetUser updateBetUser(BetUser betUser)
        {
            var updateBet = this._contextoDB.BetUser.Update(betUser).Entity;
            this._contextoDB.SaveChanges();
            return updateBet;
        }
    }
}
