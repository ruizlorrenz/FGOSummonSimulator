using FGOSummonSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGOSummonSimulator.Utility.Interfaces.Services {
    public interface IGetRollService {
        Servant GetNonLimitedServant(int rarity);
        CraftEssence GetNonLimitedCE(int rarity);
    }
}
