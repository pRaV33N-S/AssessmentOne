using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OneDayTeam team = new OneDayTeam();
                again:
                Console.WriteLine("The Available Functions to Perform\n\t1. Add Player\n\t2. Remove Player by Id\n\t3. Get Player By Id\n\t4. Get Player By Name\n\t5. Get All Players");
                Console.Write("Enter the Number : ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            Console.WriteLine("\nAdding Player to the Team....");
                            Player player = new Player();
                            Console.WriteLine("Enter Player Id");
                            player.PlayerId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Player Name");
                            player.PlayerName = Console.ReadLine();
                            Console.WriteLine("Enter Player Age");
                            player.PlayerAge = int.Parse(Console.ReadLine());
                            team.Add(player);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\nEnter Player Id to Remove");
                            int id = int.Parse(Console.ReadLine());
                            team.Remove(id);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\nEnter Player Id to Display");
                            int id = int.Parse(Console.ReadLine());
                            Player player = team.GetPlayerById(id);
                            Console.WriteLine("\nPlayer Id\tPlayer Name\t Player Age");
                            Console.WriteLine($"{player.PlayerId}\t\t{player.PlayerName}\t\t{player.PlayerAge}");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\nEnter Player Name to Display");
                            string name = Console.ReadLine();
                            Player player = team.GetPlayerByName(name);
                            Console.WriteLine("\nPlayer Id\tPlayer Name\t Player Age");
                            Console.WriteLine($"{player.PlayerId}\t\t{player.PlayerName}\t\t{player.PlayerAge}");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("\nList Of All Players....");
                            List<Player> allPlayers = team.GetAllPlayer();
                            Console.WriteLine("\nPlayer Id\tPlayer Name\t Player Age");
                            foreach (Player player in allPlayers)
                            {
                                Console.WriteLine($"{player.PlayerId}\t\t{player.PlayerName}\t\t{player.PlayerAge}");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nYou have Entered the Wrong Number!!!\n Choose the Right One\n");
                            goto again;
                        }
                }
                Console.WriteLine("\nPress 1 to Continue....And Others to Exit.");
                if (int.Parse(Console.ReadLine()) == 1)
                    goto again;
            }
            catch(Exception ec)
            {
                Console.WriteLine("\nNow The Error has Occured\n");
                Console.WriteLine(ec.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
