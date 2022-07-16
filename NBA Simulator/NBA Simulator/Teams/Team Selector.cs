using System;
using System.Collections.Generic;
using System.Text;

namespace NBA_Simulator.Teams
{
    class Team_Selector
    {

        //methods
        public Team GetTeam()
        {
            Team team = null;

            while (team == null)
            {
                Console.WriteLine("Select team (city and/or team name): ");
                string teamSelection = Console.ReadLine();

                List<string> teamsList = new List<string> { "hawks", "celtics", "nets", "hornets", "bulls", "cavaliers", "mavericks", "nuggets", "pistons", "warriors", "rockets", "pacers", "clippers", "lakers", "grizzlies", "heat", "bucks", "timberwolves", "pelicans", "knicks", "thunder", "magic", "76ers", "suns", "trail blazers", "kings", "spurs", "raptors", "jazz", "wizards" };

                if (teamSelection.ToLower() == "random" || teamSelection.ToLower() == "random team")
                {
                    Random rdm = new Random();
                    int randomTeamIndex = rdm.Next(0, teamsList.Count-1);
                    teamSelection = teamsList[randomTeamIndex];
                }
                

                if (teamSelection.ToLower() == "atlanta" || teamSelection.ToLower() == "hawks" || teamSelection.ToLower() == "atlanta hawks")
                {
                    team = new Team("Atlanta Hawks", 43, 39, 113.8, 112.2);
                }
                else if (teamSelection.ToLower() == "boston" || teamSelection.ToLower() == "celtics" || teamSelection.ToLower() == "boston celtics")
                {
                    team = new Team("Boston Celtics", 51, 31, 110.5, 103.3);
                }
                else if (teamSelection.ToLower() == "brooklyn" || teamSelection.ToLower() == "nets" || teamSelection.ToLower() == "brooklyn nets")
                {
                    team = new Team("Brooklyn Nets", 44, 38, 112.5, 111.7);
                }
                else if (teamSelection.ToLower() == "charlotte" || teamSelection.ToLower() == "hornets" || teamSelection.ToLower() == "charlotte hornets")
                {
                    team = new Team("Charlotte Hornets", 43, 39, 114.2, 113.7);
                }
                else if (teamSelection.ToLower() == "chicago" || teamSelection.ToLower() == "bulls" || teamSelection.ToLower() == "chicago bulls")
                {
                    team = new Team("Chicago Bulls", 46, 36, 111.3, 111.7);
                }
                else if (teamSelection.ToLower() == "cleveland" || teamSelection.ToLower() == "cavaliers" || teamSelection.ToLower() == "cleveland cavaliers" || teamSelection.ToLower() == "cavs" || teamSelection.ToLower() == "cleveland cavs")
                {
                    team = new Team("Cleveland Cavaliers", 44, 38, 107.5, 105.4);
                }
                else if (teamSelection.ToLower() == "dallas" || teamSelection.ToLower() == "mavericks" || teamSelection.ToLower() == "dallas mavericks" || teamSelection.ToLower() == "mavs" || teamSelection.ToLower() == "dallas mavs")
                {
                    team = new Team("Dallas Mavericks", 52, 30, 107.6, 104.3);
                }
                else if (teamSelection.ToLower() == "denver" || teamSelection.ToLower() == "nuggets" || teamSelection.ToLower() == "denver nuggets")
                {
                    team = new Team("Denver Nuggets", 48, 34, 112.0, 109.7);
                }
                else if (teamSelection.ToLower() == "detroit" || teamSelection.ToLower() == "pistons" || teamSelection.ToLower() == "detroit pistons")
                {
                    team = new Team("Detroit Pistons", 23, 59, 104.3, 112.0);
                }
                else if (teamSelection.ToLower() == "golden state" || teamSelection.ToLower() == "warriors" || teamSelection.ToLower() == "golden state warriors")
                {
                    team = new Team("Golden State Warriors", 53, 29, 110.7, 105.2);
                }
                else if (teamSelection.ToLower() == "houston" || teamSelection.ToLower() == "rockets" || teamSelection.ToLower() == "houston rockets")
                {
                    team = new Team("Houston Rockets", 20, 62, 109.3, 117.7);
                }
                else if (teamSelection.ToLower() == "indiana" || teamSelection.ToLower() == "pacers" || teamSelection.ToLower() == "indiana pacers")
                {
                    team = new Team("Indiana Pacers", 25, 57, 110.3, 113.8);
                }
                else if (teamSelection.ToLower() == "la" || teamSelection.ToLower() == "los angeles")
                {
                    Console.WriteLine("Did you mean to select the Los Angeles Lakers or the Los Angeles Clippers?");
                    string whichLA = Console.ReadLine();

                    if (whichLA.ToLower() == "lakers" || whichLA.ToLower() == "la lakers" || whichLA.ToLower() == "los angeles lakers")
                    {
                        team = new Team("Los Angeles Lakers", 33, 49, 110.4, 113.4);
                    }
                    if (whichLA.ToLower() == "clippers" || whichLA.ToLower() == "la clippers" || whichLA.ToLower() == "los angeles clippers")
                    {
                        team = new Team("Los Angeles Clippers", 42, 40, 107.9, 107.8);
                    }
                }
                else if (teamSelection.ToLower() == "lakers" || teamSelection.ToLower() == "la lakers" || teamSelection.ToLower() == "los angeles lakers")
                {
                    team = new Team("Los Angeles Lakers", 33, 49, 110.4, 113.4);
                }
                else if (teamSelection.ToLower() == "clippers" || teamSelection.ToLower() == "la clippers" || teamSelection.ToLower() == "los angeles clippers")
                {
                    team = new Team("Los Angeles Clippers", 42, 40, 107.9, 107.8);
                }
                else if (teamSelection.ToLower() == "memphis" || teamSelection.ToLower() == "grizzlies" || teamSelection.ToLower() == "memphis grizzlies")
                {
                    team = new Team("Memphis Grizzlies", 56, 26, 115.0, 109.4);
                }
                else if (teamSelection.ToLower() == "miami" || teamSelection.ToLower() == "heat" || teamSelection.ToLower() == "miami heat")
                {
                    team = new Team("Miami Heat", 53, 29, 109.1, 104.6);
                }
                else if (teamSelection.ToLower() == "milwaukee" || teamSelection.ToLower() == "bucks" || teamSelection.ToLower() == "milwaukee bucks")
                {
                    team = new Team("Milwaukee Bucks", 51, 31, 115.0, 111.7);
                }
                else if (teamSelection.ToLower() == "minnesota" || teamSelection.ToLower() == "timberwolves" || teamSelection.ToLower() == "minnesota timberwolves")
                {
                    team = new Team("Minnesota Timberwolves", 46, 36, 115.4, 112.7);
                }
                else if (teamSelection.ToLower() == "new orleans" || teamSelection.ToLower() == "pelicans" || teamSelection.ToLower() == "new orleans pelicans")
                {
                    team = new Team("New Orleans Pelicans", 36, 46, 108.9, 109.9);
                }
                else if (teamSelection.ToLower() == "new york" || teamSelection.ToLower() == "knicks" || teamSelection.ToLower() == "new york knicks" || teamSelection.ToLower() == "ny knicks" || teamSelection.ToLower() == "ny")
                {
                    team = new Team("New York Knicks", 37, 45, 105.9, 106.1);
                }
                else if (teamSelection.ToLower() == "oklahoma city" || teamSelection.ToLower() == "thunder" || teamSelection.ToLower() == "oklahoma city thunder" || teamSelection.ToLower() == "okc" || teamSelection.ToLower() == "okc thunder")
                {
                    team = new Team("Oklahoma City Thunder", 24, 58, 103.1, 111.1);
                }
                else if (teamSelection.ToLower() == "orlando" || teamSelection.ToLower() == "magic" || teamSelection.ToLower() == "orlando magic")
                {
                    team = new Team("Orlando Magic", 22, 60, 103.7, 111.7);
                }
                else if (teamSelection.ToLower() == "philadelphia" || teamSelection.ToLower() == "76ers" || teamSelection.ToLower() == "philadelphia 76ers" || teamSelection.ToLower() == "phila" || teamSelection.ToLower() == "76'ers" || teamSelection.ToLower() == "philadelphia 76'ers")
                {
                    team = new Team("Philadelphia 76ers", 51, 31, 109.2, 106.7);
                }
                else if (teamSelection.ToLower() == "phoenix" || teamSelection.ToLower() == "suns" || teamSelection.ToLower() == "phoenix suns")
                {
                    team = new Team("Phoenix Suns", 64, 18, 114.5, 107.1);
                }
                else if (teamSelection.ToLower() == "portland" || teamSelection.ToLower() == "trail blazers" || teamSelection.ToLower() == "portland trail blazers" || teamSelection.ToLower() == "trailblazers" || teamSelection.ToLower() == "portland trailblazers" || teamSelection.ToLower() == "blazers" || teamSelection.ToLower() == "portland blazers")
                {
                    team = new Team("Portland Trail Blazers", 27, 55, 106.0, 114.8);
                }
                else if (teamSelection.ToLower() == "sacramento" || teamSelection.ToLower() == "kings" || teamSelection.ToLower() == "sacramento kings")
                {
                    team = new Team("Sacramento Kings", 30, 52, 109.6, 115.0);
                }
                else if (teamSelection.ToLower() == "san antonio" || teamSelection.ToLower() == "spurs" || teamSelection.ToLower() == "san antonio spurs")
                {
                    team = new Team("San Antonio Spurs", 34, 48, 112.4, 112.3);
                }
                else if (teamSelection.ToLower() == "toronto" || teamSelection.ToLower() == "raptors" || teamSelection.ToLower() == "toronto raptors")
                {
                    team = new Team("Toronto Raptors", 48, 34, 108.4, 106.2);
                }
                else if (teamSelection.ToLower() == "utah" || teamSelection.ToLower() == "jazz" || teamSelection.ToLower() == "utah jazz")
                {
                    team = new Team("Utah Jazz", 49, 33, 113.3, 107.3);
                }
                else if (teamSelection.ToLower() == "washington" || teamSelection.ToLower() == "wizards" || teamSelection.ToLower() == "washington wizards")
                {
                    team = new Team("Washington Wizards", 35, 47, 107.8, 111.2);
                }
                else
                {
                    Console.WriteLine("Your team selection was an invalid entry.");
                }
            }
            return team;
        }
    }
}
