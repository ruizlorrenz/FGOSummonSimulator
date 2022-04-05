using Dapper;
using FGOSummonSimulator.Entities;
using FGOSummonSimulator.Utility.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGOSummonSimulator.Utility.Repositories {
    public class CraftEssenceRepository : ICraftEssenceRepository {
        public List<CraftEssence> GetCEByRarityAndLimitedYN(int rarity, char limitedYN) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FGOSSDB"))) {
                return connection.Query<CraftEssence>("dbo.uspGetCraftEssencesByRarityAndLimitedYN @Rarity, @LimitedYN", new { rarity = rarity, limitedYN = limitedYN }).ToList();
            }
        }
    }
}
