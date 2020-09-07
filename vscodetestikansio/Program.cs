using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace vscodetestikansio
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            for (int i = 0; i < 10000; i++)
            {
                new Player() { Id = Guid.NewGuid() };

                List<Guid> players = new List<Guid>();
                var playerID = Guid.NewGuid();
                players.Add(playerID);
                foreach (var ID in players)
                {
                    Console.WriteLine("Player " + i + ": " + ID);
                }

                // checks if duplicate values on list
                if (players.Count != players.Distinct().Count())
                {
                    Console.WriteLine("DUPLICATES FOUND");
                }
            }
        }
    }

    public static class GuidExtensions
    {
        public static Guid[] GetHighestLevelItem(this Guid guid)
        {
            return new Guid[] { guid, guid };
        }
    }
}
