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
    public class ServantRepository : IServantRepository {
        public List<Servant> GetServantsByName(string name) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FGOSSDB"))) {
                var output = connection.Query<Servant>($"SELECT * FROM dbo.servant WHERE name LIKE '%{name}%'").ToList();
                return output;
            }
        }

        public List<Servant> GetServantsByRarity(int rarity) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FGOSSDB"))) {
                return connection.Query<Servant>("dbo.uspGetServantsByRarity @Rarity", new { rarity = rarity }).ToList();
            }
        }

        public List<Servant> GetServantsByRarityAndLimitedYN(int rarity, char limitedYN) {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FGOSSDB"))) {
                return connection.Query<Servant>("dbo.uspGetServantsByRarityAndLimitedYN @Rarity, @LimitedYN", new { rarity = rarity, limitedYN = limitedYN }).ToList();
            }
        }
    }
}
