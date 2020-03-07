using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace betController.Models
{
    public class Bet
    {
        public int id { get; set; }
        public int active { get; set; }
        public double bet_money { get; set; }
        public DateTime creation_date { get; set; }
        public string emision { get; set; }
        public int estado { get; set; }
        public string evento { get; set; }
        public string event_date { get; set; }
        public string hour { get; set; }
        public string player_one { get; set; }
        public string player_two { get; set; }
        public string resultado { get; set; }
        public string sport { get; set; }
    }
}
