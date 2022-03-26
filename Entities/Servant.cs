using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGOSummonSimulator.Entities {
    public class Servant {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public char LimitedYN { get; set; }
        public char StoryLockedYN { get; set; }
        public int Rarity { get; set; }

        public string Info {
            get {
                return $"{Name} | {Rarity} Star";
            }
        }
    }
}
