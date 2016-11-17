using System;
using System.Collections.Generic;
using System.Linq;

namespace P06FootballTeamGenerator
{
    public class FootballTeam
    {
        private string name;

        public FootballTeam(string name)
        {
            this.Name = name;
            this.NumberOfPlayers = 0;
            this.Rating = 0;
            this.Players = new Dictionary<string, FootbalPlayer>();

        }

        private Dictionary<string, FootbalPlayer> Players { get; }
        private int NumberOfPlayers { get; set; }
        public double Rating { get; private set; }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(value, "A name should not be empty.");
                }

                this.name = value;
            }
        }


        public void AddPlayer(FootbalPlayer player)
        {
            this.Players[player.Name] = player;
            this.NumberOfPlayers++;
        }

        public void RemovePlayer(string playerName)
        {

            if (!this.Players.ContainsKey(playerName))
            {
                throw new InvalidOperationException($"Player {playerName} is not in {this.Name} team.");
            }
            else
            {
                this.Players.Remove(playerName);
                this.NumberOfPlayers--;
            }
        }

        public double CalculateRating()
        {
            foreach (var footbalPlayer in this.Players)
            {
                this.Rating += footbalPlayer.Value.OverallSkills;
            }

            if (this.NumberOfPlayers == 0)
            {
                return 0;
            }

            this.Rating = this.Rating / this.NumberOfPlayers;

            return this.Rating;
        }
    }

    public class FootbalPlayer
    {
        private string name;
        private double endurance;
        private double sprint;
        private double dribble;
        private double passing;
        private double shooting;

        public FootbalPlayer(string name, double endurance, double sprint, double dribble, double passing, double shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public double Shooting
        {
            get { return this.shooting; }
            private set
            {
                if (0 > value || value > 100)
                {
                    throw new ArgumentException($"{nameof(this.Shooting)} should be between 0 and 100.");
                }

                this.shooting = value;
            }
        }

        public double Passing
        {
            get { return this.passing; }
            private set
            {
                if (0 > value || value > 100)
                {
                    throw new ArgumentException($"{nameof(this.Passing)} should be between 0 and 100.");
                }

                this.passing = value;
            }
        }

        public double Dribble
        {
            get { return this.dribble; }
            private set
            {
                if (0 > value || value > 100)
                {
                    throw new ArgumentException($"{nameof(this.Dribble)} should be between 0 and 100.");
                }

                this.dribble = value;
            }
        }

        public double Sprint
        {
            get { return this.sprint; }
            private set
            {
                if (0 > value || value > 100)
                {
                    throw new ArgumentException($"{nameof(this.Sprint)} should be between 0 and 100.");
                }

                this.sprint = value;
            }
        }

        public double Endurance
        {
            get { return this.endurance; }
            private set
            {
                if (0 > value || value > 100)
                {
                    throw new ArgumentException($"{nameof(this.Endurance)} should be between 0 and 100.");
                }

                this.endurance = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(value, "A name should not be empty.");
                }

                this.name = value;
            }
        }

        public double OverallSkills => (this.Dribble + this.Endurance + this.Passing + this.Shooting + this.Sprint) / 5.0;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, FootballTeam> footballTeams = new Dictionary<string, FootballTeam>();

            while (input != "END")
            {
                string[] footballDetails = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                try
                {
                    switch (footballDetails[0])
                    {
                        case "Team":
                            AddTeam(footballDetails, footballTeams);
                            break;
                        case "Add":
                            AddPlayer(footballTeams, footballDetails);
                            break;
                        case "Remove":
                            RemovePlayer(footballTeams, footballDetails);
                            break;
                        case "Rating":
                            PrintRating(footballDetails, footballTeams);
                            break;
                    }
                }
                catch (InvalidOperationException ioex)
                {
                    Console.WriteLine(ioex.Message);
                }
                catch (ArgumentNullException aex)
                {
                    Console.WriteLine(aex.Message);
                }
                catch (ArgumentException aorex)
                {
                    Console.WriteLine(aorex.Message);
                }

                input = Console.ReadLine();
            }
        }

        private static void PrintRating(string[] footballDetails, Dictionary<string, FootballTeam> footballTeams)
        {
            if (!footballTeams.ContainsKey(footballDetails[1]))
            {
                throw new InvalidOperationException($"Team {footballDetails[1]} does not exist.");
            }

            Console.WriteLine($"{footballDetails[1]} - {footballTeams[footballDetails[1]].CalculateRating():F0}");
        }

        private static void AddTeam(string[] footballDetails, Dictionary<string, FootballTeam> footballTeams)
        {
            FootballTeam footballTeam = new FootballTeam(footballDetails[1]);
            footballTeams.Add(footballDetails[1], footballTeam);
        }

        private static void RemovePlayer(Dictionary<string, FootballTeam> footballTeams, string[] footballDetails)
        {
            if (!footballTeams.ContainsKey(footballDetails[1]))
            {
                throw new InvalidOperationException($"Team {footballDetails[1]} does not exist.");
            }
            else
            {
                footballTeams[footballDetails[1]].RemovePlayer(footballDetails[2]);
            }
        }

        private static void AddPlayer(Dictionary<string, FootballTeam> footballTeams, string[] footballDetails)
        {
            if (!footballTeams.ContainsKey(footballDetails[1]))
            {
                throw new InvalidOperationException($"Team {footballDetails[1]} does not exist.");
            }
            else
            {
                FootbalPlayer player = new FootbalPlayer(footballDetails[2], double.Parse(footballDetails[3]),
                    double.Parse(footballDetails[4]), double.Parse(footballDetails[5]),
                    double.Parse(footballDetails[6]), double.Parse(footballDetails[7]));

                footballTeams[footballDetails[1]].AddPlayer(player);
            }
        }
    }
}
