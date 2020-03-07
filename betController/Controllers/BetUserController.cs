using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using betController.Models;
using betController.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace betController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetUserController : ControllerBase
    {
        private readonly IBetUserService _betUserService;

        public BetUserController(IBetUserService betUserService)
        {
            _betUserService = betUserService;
        }
        // GET api/values
        [HttpGet("getBetsUser")]
        public ActionResult<IEnumerable<BetUser>> getBetsUser()
        {
            return this._betUserService.getBetsUser();
        }
        [HttpGet]
        public ActionResult<String> Get()
        {
            return "Hola Mundo";
        }
        [HttpGet("getById/{id}")]
        public ActionResult<BetUser> GetById(int id)
        {

            return this._betUserService.getBetUser(id);

        }
        // GET api/values/5


        // POST api/values
        [HttpPost("postSeveral")]
        public ActionResult<Boolean> PostSeveral([FromBody] List<BetUser> betsUser)
        {
            foreach (var betUser in betsUser)
            {
                _betUserService.AddBetUser(betUser);
            }
            return true;
        }

        [HttpPost("post")]
        public ActionResult<BetUser> Post([FromBody] BetUser betsUser)
        {
            return _betUserService.AddBetUser(betsUser);
        }

        // PUT api/values/5
        [HttpPut("put")]
        public BetUser Put([FromBody] BetUser betsUser)
        {
            return this._betUserService.updateBetUser(betsUser);
        }

        // DELETE api/values/5
        [HttpDelete("delById/{id}")]
        public List<BetUser> Delete(int id)
        {
            //this._betService.deleteBet(id);
            return this._betUserService.getBetsUser();
        }

    }
}