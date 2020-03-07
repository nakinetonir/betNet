using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using betController.Models;
using betController.Services;
using Microsoft.AspNetCore.Mvc;

namespace betController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IBetService _betService;

        public ValuesController(IBetService betService)
        {
            _betService = betService;
        }
        // GET api/values
        [HttpGet("getBets")]
        public ActionResult<IEnumerable<Bet>> GetBets()
        {
            return this._betService.getBets();
        }
        [HttpGet]
        public ActionResult<String> Get()
        {
            return "Hola Mundo";
        }
        [HttpGet("getById/{id}")]
        public ActionResult<Bet> GetById(int id)
        {

            return this._betService.getBet(id);
            
        }
        // GET api/values/5
        

        // POST api/values
        [HttpPost("postSeveral")]
        public ActionResult<Boolean> PostSeveral([FromBody] List<Bet> bets)
        {
            foreach(var bet in bets)
            {
                _betService.AddBet(bet);
            }
            return true;
        }

        [HttpPost("post")]
        public ActionResult<Bet> Post([FromBody] Bet bet)
        {
            return _betService.AddBet(bet);
        }

        // PUT api/values/5
        [HttpPut("put")]
        public Bet Put([FromBody] Bet bet)
        {
            return this._betService.updateBet(bet);
        }

        // DELETE api/values/5
        [HttpDelete("delById/{id}")]
        public List<Bet> Delete(int id)
        {
            //this._betService.deleteBet(id);
            return this._betService.getBets();
        }

        
    }
}
