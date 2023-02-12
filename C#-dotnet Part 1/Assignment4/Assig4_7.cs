using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class TeamClass2 : IEnumerable
    {
        public List<Player> TeamPlayer { get; set; }

        public TeamClass2()
        {
            TeamPlayer = new List<Player>();
        }
        public void AddPlayer(Player p)
        {
            TeamPlayer.Add(p);
        }
        public IEnumerator<Player> GetEnumerator()
        {
            foreach (Player p in TeamPlayer)
            {
                if (p == null)
                {
                    break;
                }
                yield return p;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)TeamPlayer).GetEnumerator();
        }

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
        public IEnumerable<Player> Iterators()
        {
            foreach (Player p in TeamPlayer)
            {
                yield return p;
            }
        }
    }
    
    class Assig4_7
    {
        public static void IndiaTeamMethod2() {
            Player p1 = new Player() { Name = "Name1", Run = 100 };
            Player p2 = new Player() { Name = "Name2", Run = 50 };
            Player p3 = new Player() { Name = "Name3", Run = 80 };
            TeamClass2 IndiaTeam=new TeamClass2() { TeamPlayer=new List<Player> { p1,p2,p3} };
            Player p4 = new Player() { Name = "Name4", Run = 70 };
            IndiaTeam.TeamPlayer.Add(p4);

            Console.WriteLine("Players in Team India using itorator .....");
        IEnumerable<Player> Iterators = IndiaTeam.Iterators();
            foreach (Player p in Iterators)
            {
                Console.WriteLine("Name:"+p.Name+"\t Run:"+p.Run);
            }

        }

    }
}

