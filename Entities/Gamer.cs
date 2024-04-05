using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelling.Entities
{
    public class Gamer
    {
        public int GamerId { get; set; }
        public string GamerName { get; set; }
        public string GamerLastName { get; set; }
        public long GamerTcNumber { get; set; }
        public int GamerDateOfBirth { get; set; }
    }
}
