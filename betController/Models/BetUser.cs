using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace betController.Models
{
    public class BetUser
    {
        public int id { get; set; }
        public int active { get; set; }
        public double bet_user_money { get; set; }
        public string winner { get; set; }
        public string evento { get; set; }

    }
  
}
