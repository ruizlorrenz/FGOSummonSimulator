using FGOSummonSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGOSummonSimulator.Utility.Interfaces.Repositories {
    public interface IServantRepository {
        List<Servant> GetServantsByName(string name);
        List<Servant> GetServantsByRarity(int rarity);
        List<Servant> GetServantsByRarityAndLimitedYN(int rarity, char limitedYN);
    }
}
