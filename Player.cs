using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int PlayerAge { get; set; }
        public Player() { }
        public Player(int id,string name,int age)
        {
            PlayerId = id;
            PlayerName = name;
            PlayerAge = age;
        }
    }
}
