using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreTable.Models
{
    public class Team
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }

    public enum TeamType
    {
        Home,
        Host,
        None,
    }
}
