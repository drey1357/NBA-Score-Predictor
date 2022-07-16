using System;
using System.Collections.Generic;
using System.Text;

namespace NBA_Simulator.Teams
{
    public class Team
    {
        public string Name { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public double PointsForced { get; set; }
        public double PointsAllowed { get; set; }


        //constructors
        public Team(string name, int wins, int losses, double pointsForced, double pointsAllowed)
        {
            Name = name;
            Wins = wins;
            Losses = losses;
            PointsForced = pointsForced;
            PointsAllowed = pointsAllowed;
        }

        //methods
        public void CompareTeams(Team otherTeam)
        {

            double leageAveragePoints = 110.0;  //the average number of points each team scored per 48 minutes in an NBA game during the 2021-22 season

            // calculating which team has a better record
            if (this.Wins > otherTeam.Wins)
            {
                Console.WriteLine($"The {this.Name} ({this.Wins}-{this.Losses}) have the stronger record compared to the {otherTeam.Name} ({otherTeam.Wins}-{otherTeam.Losses}).");
            }
            else if (this.Wins < otherTeam.Wins)
            {
                Console.WriteLine($"The {otherTeam.Name} ({otherTeam.Wins}-{otherTeam.Losses}) have the stronger record compared to the {this.Name} ({this.Wins}-{this.Losses}).");
            }
            else if (this.Wins == otherTeam.Wins)
            {
                Console.WriteLine($"The {this.Name} ({this.Wins}-{this.Losses}) and {otherTeam.Name} ({otherTeam.Wins}-{otherTeam.Losses}) have the same record.");
            }

            // calculating which team is better on offense
            if (this.PointsForced > otherTeam.PointsForced)
            {
                Console.WriteLine($"The {this.Name} have a statistically better offense, scoring an average of {this.PointsForced} points per game.");
            }
            else if (this.PointsForced < otherTeam.PointsForced)
            {
                Console.WriteLine($"The {otherTeam.Name} have a statistically better offense, scoring an average of {otherTeam.PointsForced} points per game.");
            }
            else if (this.PointsForced == otherTeam.PointsForced)
            {
                Console.WriteLine($"Both teams have identical offensive production, scoring an average of {this.PointsForced} points per game.");
            }

            // calculating which team is better on defense
            if (this.PointsAllowed < otherTeam.PointsAllowed)
            {
                Console.WriteLine($"The {this.Name} are stronger on defense, giving up an average of {this.PointsAllowed} points per game.");
            }
            else if (this.PointsAllowed > otherTeam.PointsAllowed)
            {
                Console.WriteLine($"The {otherTeam.Name} are stronger on defense, giving up an average of {otherTeam.PointsAllowed} points per game.");
            }
            else if (this.PointsAllowed == otherTeam.PointsAllowed)
            {
                Console.WriteLine($"Both teams have identical defensive statistics, giving up an average of {this.PointsAllowed} points per game.");
            }


            // calculating the projected score based on each team's stats relative to the league scoring average
            if (Math.Round((this.PointsForced - leageAveragePoints) + (otherTeam.PointsAllowed - leageAveragePoints) + leageAveragePoints) > Math.Round((otherTeam.PointsForced - leageAveragePoints) + (this.PointsAllowed - leageAveragePoints) + leageAveragePoints))
            {
                Console.WriteLine($"Based on these statistics, the {this.Name} are favored to beat the {otherTeam.Name} by a score of {Math.Round((this.PointsForced - leageAveragePoints) + (otherTeam.PointsAllowed - leageAveragePoints) + leageAveragePoints)}-{Math.Round((otherTeam.PointsForced - leageAveragePoints) + (this.PointsAllowed - leageAveragePoints) + leageAveragePoints)}.");
            }
            else if (Math.Round((this.PointsForced - leageAveragePoints) + (otherTeam.PointsAllowed - leageAveragePoints) + leageAveragePoints) < Math.Round((otherTeam.PointsForced - leageAveragePoints) + (this.PointsAllowed - leageAveragePoints) + leageAveragePoints))
            {
                Console.WriteLine($"Based on these statistics, the {otherTeam.Name} are favored to beat the {this.Name} by a score of {Math.Round((otherTeam.PointsForced - leageAveragePoints) + (this.PointsAllowed - leageAveragePoints) + leageAveragePoints)}-{Math.Round((this.PointsForced - leageAveragePoints) + (otherTeam.PointsAllowed - leageAveragePoints) + leageAveragePoints)}.");
            }
            else if (Math.Round((this.PointsForced - leageAveragePoints) + (otherTeam.PointsAllowed - leageAveragePoints) + leageAveragePoints) == Math.Round((otherTeam.PointsForced - leageAveragePoints) + (this.PointsAllowed - leageAveragePoints) + leageAveragePoints))
            {
                Console.WriteLine($"Based on these statistics, each team is projected to score {Math.Round((otherTeam.PointsForced - leageAveragePoints) + (this.PointsAllowed - leageAveragePoints) + leageAveragePoints)} points and the game will go into overtime. Anything could happen in overtime.");
            }
        }
    }
}