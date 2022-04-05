using FGOSummonSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGOSummonSimulator.Utility.Interfaces.Repositories {
    public interface ICraftEssenceRepository {
        List<CraftEssence> GetCEByRarityAndLimitedYN(int rarity, char limitedYN);
    }
}
