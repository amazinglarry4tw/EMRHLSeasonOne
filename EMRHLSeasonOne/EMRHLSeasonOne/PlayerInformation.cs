using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRHLSeasonOne
{
	public class PlayerInformation
	{
		public string PlayerName;
		public int Goals;
		public int Points;
		public int Assists;
		public Dictionary<int, string> Teams;

		public PlayerInformation()
		{
			this.PlayerName = string.Empty;
			this.Goals = 0;
			this.Assists = 0;
			this.Points = 0;
			this.Teams = new Dictionary<int, string>();
		}

		public PlayerInformation(string name, int goals, int assists)
		{
			this.PlayerName = name;
			this.Goals = goals;
			this.Assists = assists;
			this.Points = this.Goals + this.Assists;
			this.Teams = new Dictionary<int, string>();
		}

		public void AddTeam(int season, string team)
		{
			this.Teams.Add(season, team);
		}

		public void PrintInformation()
		{
			Console.WriteLine(string.Format("Player:  {0}", this.PlayerName));
			Console.WriteLine(string.Format("Goals:  {0}   Assists:  {1}   Points:  {2}", this.Goals, this.Assists, this.Points));
			foreach (var item in Teams)
			{
				Console.WriteLine(string.Format("Played for the {0} during Season {1}.", item.Value, item.Key));
			}
			Console.WriteLine();
		}
	}
}
