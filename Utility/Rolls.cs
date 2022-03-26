using FGOSummonSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGOSummonSimulator.Utility {
    public class Rolls {
        private Random rng = new Random();
        public CraftEssence Get3StarCE() {
            List<CraftEssence> list = new List<CraftEssence>();
            DataAccess db = new DataAccess();

            list = db.GetCEByRarityAndLimitedYN(3, 'N');
            int i = rng.Next(0, list.Count - 1);

            var ce = list[i];

            return ce;
        }

        public Servant Get3StarServant() {
            List<Servant> list = new List<Servant>();
            DataAccess db = new DataAccess();

            list = db.GetServantsByRarityAndLimitedYN(3, 'N');
            int i = rng.Next(0, list.Count - 1);

            var servant = list[i];

            return servant;
        }

        public CraftEssence GetNonLimitedCE(int rarity) {
            List<CraftEssence> list = new List<CraftEssence>();
            DataAccess db = new DataAccess();

            list = db.GetCEByRarityAndLimitedYN(rarity, 'N');
            int i = rng.Next(0, list.Count);

            var ce = list[i];

            return ce;
        }

        public Servant GetNonLimitedServant(int rarity) {
            List<Servant> list = new List<Servant>();
            DataAccess db = new DataAccess();

            list = db.GetServantsByRarityAndLimitedYN(rarity, 'N');
            int i = rng.Next(0, list.Count - 1);

            var servant = list[i];

            return servant;
        }
    }
}
