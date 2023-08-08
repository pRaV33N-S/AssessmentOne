using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    public interface ITeam
    {
        void Add(Player player);
        void Remove(int id);  
        Player GetPlayerById(int id);
        Player GetPlayerByName(string name);
        List<Player> GetAllPlayer();

    }
}
