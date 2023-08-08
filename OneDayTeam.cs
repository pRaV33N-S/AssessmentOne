using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();
        public OneDayTeam() 
        {
            if (oneDayTeam.Count <= 11)
            {
                oneDayTeam = new List<Player>();
            }
            else
            {
                Console.WriteLine("The team can only have 11 Members");
            }
        }
        public void Add(Player player)
        {
            oneDayTeam.Add(player);
            Console.WriteLine("Player Added Successfully");
        }
        public void Remove(int id)
        {
            Player playerRemoval = oneDayTeam.Find(oneDayTeam => oneDayTeam.PlayerId == id);
            if (playerRemoval != null)
            {
                oneDayTeam.Remove(playerRemoval);
                Console.WriteLine("Player Removed Successfully");
            }
            else
                Console.WriteLine("There is no such member in the Team");
        }
        public Player GetPlayerById(int id)
        {
            Player playerById = oneDayTeam.Find(oneDayTeam => oneDayTeam.PlayerId == id);
            return playerById;
        }
        public Player GetPlayerByName(string name)
        {
            Player playerByName = oneDayTeam.Find(oneDayTeam => oneDayTeam.PlayerName.Equals(name));
            return playerByName;
        }
        public List<Player> GetAllPlayer()
        {
            return oneDayTeam;
        }   
    }
}
