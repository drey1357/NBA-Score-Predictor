using System;
using System.Collections.Generic;
using NBA_Simulator.Teams;


namespace NBA_Simulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            // writing to the console and taking user input
            Console.WriteLine("Welcome to the NBA Simulator!");
            Console.WriteLine("");

            Console.WriteLine("All data used in this program is from the 2021-2022 NBA regular season.");
            Console.WriteLine("\"Per game\" statistics refer to the statistic per 48 minutes, the standard length of a regulation game.");
            Console.WriteLine("You may enter the city and/or team name. Enter \"random\" to select a random team.");
            Console.WriteLine("");

            Team_Selector selector = new Team_Selector();

            Console.WriteLine("Please select the first team.");
            Team teamOne = selector.GetTeam();
            Console.WriteLine("Please select the second team.");
            Team teamTwo = selector.GetTeam();

            Console.Clear();
            
            Console.WriteLine($"You have chosen a matchup between the {teamOne.Name} and the {teamTwo.Name}.");



            teamOne.CompareTeams(teamTwo);
        }
    }
}