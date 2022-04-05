using FGOSummonSimulator.Entities;
using FGOSummonSimulator.Utility.Interfaces.Repositories;
using FGOSummonSimulator.Utility.Interfaces.Services;
using FGOSummonSimulator.Utility.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGOSummonSimulator.Utility.Services {
    public class GetRollService : IGetRollService {
        private readonly IServantRepository _servantRepo;
        private readonly ICraftEssenceRepository _craftEssenceRepo;
        private Random rng = new Random();

        public GetRollService() {
            _servantRepo = new ServantRepository();
            _craftEssenceRepo = new CraftEssenceRepository();
        }
        //private readonly IServantRepository _servantRepo;
        //private readonly ICraftEssenceRepository _craftEssenceRepo;

        //public GetRollService() {
        //    _servantRepo = new ServantRepository();
        //    _craftEssenceRepo = new CraftEssenceRepository();
        //}
        public CraftEssence GetNonLimitedCE(int rarity) {
            List<CraftEssence> list = new List<CraftEssence>();
            
            list = _craftEssenceRepo.GetCEByRarityAndLimitedYN(rarity, 'N');
            int i = rng.Next(0, list.Count - 1);

            var ce = list[i];

            return ce;
        }

        public Servant GetNonLimitedServant(int rarity) {
            List<Servant> list = new List<Servant>();

            list = _servantRepo.GetServantsByRarityAndLimitedYN(rarity, 'N');
            int i = rng.Next(0, list.Count - 1);

            var servant = list[i];

            return servant;
        }
    }
}
