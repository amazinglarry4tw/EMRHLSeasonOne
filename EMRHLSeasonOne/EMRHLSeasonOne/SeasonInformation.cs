using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRHLSeasonOne
{
	public class SeasonInformation
	{
		public int SeasonNumber;
		public List<GameResult> Games;
		public int BruinGoals;
		public int SabreGoals;
		public int WhalerGoals;
		public int CanadienGoals;
		public int TotalGoals;
		public int RegularSeasonGoals;

		public List<string> BruinsPlayers;
		public List<string> CanadiensPlayers;
		public List<string> SabresPlayers;
		public List<string> WhalersPlayers;

		public List<string> SeasonGoalPool;

		public SeasonInformation()
		{
			this.SeasonNumber = 0;
			this.Games = new List<GameResult>();
			this.BruinGoals = 0;
			this.SabreGoals = 0;
			this.WhalerGoals = 0;
			this.CanadienGoals = 0;
			this.TotalGoals = 0;
			this.RegularSeasonGoals = 0;

			this.BruinsPlayers = new List<string>();
			this.CanadiensPlayers = new List<string>();
			this.SabresPlayers = new List<string>();
			this.WhalersPlayers = new List<string>();

			this.SeasonGoalPool = new List<string>();
		}

		public void AddTeamPlayer(string team, string player)
		{
			switch (team)
			{
				case "Bruins":
					this.BruinsPlayers.Add(player);
					break;
				case "Canadiens":
					this.CanadiensPlayers.Add(player);
					break;
				case "Sabres":
					this.SabresPlayers.Add(player);
					break;
				case "Whalers":
					this.WhalersPlayers.Add(player);
					break;
			}
		}

		public void AddPlayerToGoalPool(string player)
		{
			this.SeasonGoalPool.Add(player);
		}

		public void PrintTeamPlayers()
		{
			PrintPlayers("Bruins");
			PrintPlayers("Canadiens");
			PrintPlayers("Sabres");
			PrintPlayers("Whalers");
		}

		protected void PrintPlayers(string team)
		{
			switch (team)
			{
				case "Bruins":
					Console.WriteLine("Bruins Roster:");
					foreach (var item in BruinsPlayers)
					{
						Console.WriteLine(string.Format("{0}", item));
					}
					break;
				case "Canadiens":
					Console.WriteLine("Canadiens Roster:");
					foreach (var item in CanadiensPlayers)
					{
						Console.WriteLine(string.Format("{0}", item));
					}
					break;
				case "Sabres":
					Console.WriteLine("Sabres Roster:");
					foreach (var item in SabresPlayers)
					{
						Console.WriteLine(string.Format("{0}", item));
					}
					break;
				case "Whalers":
					Console.WriteLine("Whalers Roster:");
					foreach (var item in WhalersPlayers)
					{
						Console.WriteLine(string.Format("{0}", item));
					}
					break;
			}
			Console.WriteLine();
		}

		public void AddGameResult(string date, string team1, int team1score, string team2, int team2score)
		{
			GameResult temp = new GameResult(date, team1, team1score, team2, team2score);
			Games.Add(temp);
		}

		public void AddGameResult(string date, string team1, int team1score, string team2, int team2score, bool playoff)
		{
			GameResult temp = new GameResult(date, team1, team1score, team2, team2score, playoff);
			Games.Add(temp);
		}

		public void PrintInformation()
		{
			foreach (var item in Games)
			{
				Console.WriteLine(item.Result);
			}
		}

		public void PrintRegularSeasonInformation()
		{
			foreach (var item in Games)
			{
				if (!item.PlayoffGame)
				{
					Console.WriteLine(item.Result);
				}
			}
		}

		protected void CalculateGoalTotal()
		{
			this.BruinGoals = this.CanadienGoals = this.SabreGoals = this.WhalerGoals = 0;

			foreach (var item in Games)
			{
				switch (item.TeamOne)
				{
					case "Bruins":
						this.BruinGoals += item.TeamOneScore;
						break;
					case "Sabres":
						this.SabreGoals += item.TeamOneScore;
						break;
					case "Canadiens":
						this.CanadienGoals += item.TeamOneScore;
						break;
					case "Whalers":
						this.WhalerGoals += item.TeamOneScore;
						break;
				}

				switch (item.TeamTwo)
				{
					case "Bruins":
						this.BruinGoals += item.TeamTwoScore;
						break;
					case "Sabres":
						this.SabreGoals += item.TeamTwoScore;
						break;
					case "Canadiens":
						this.CanadienGoals += item.TeamTwoScore;
						break;
					case "Whalers":
						this.WhalerGoals += item.TeamTwoScore;
						break;
				}

				this.TotalGoals = this.BruinGoals + this.CanadienGoals + this.SabreGoals + this.WhalerGoals;
			}
		}

		protected void CalculateRegularSeasonTeamGoalTotal()
		{
			this.BruinGoals = this.CanadienGoals = this.SabreGoals = this.WhalerGoals = 0;

			foreach (var item in Games)
			{
				if (!item.PlayoffGame)
				{
					switch (item.TeamOne)
					{
						case "Bruins":
							this.BruinGoals += item.TeamOneScore;
							break;
						case "Sabres":
							this.SabreGoals += item.TeamOneScore;
							break;
						case "Canadiens":
							this.CanadienGoals += item.TeamOneScore;
							break;
						case "Whalers":
							this.WhalerGoals += item.TeamOneScore;
							break;
					}

					switch (item.TeamTwo)
					{
						case "Bruins":
							this.BruinGoals += item.TeamTwoScore;
							break;
						case "Sabres":
							this.SabreGoals += item.TeamTwoScore;
							break;
						case "Canadiens":
							this.CanadienGoals += item.TeamTwoScore;
							break;
						case "Whalers":
							this.WhalerGoals += item.TeamTwoScore;
							break;
					}
				}
				this.TotalGoals = this.BruinGoals + this.CanadienGoals + this.SabreGoals + this.WhalerGoals;
			}
		}

		protected void CalculateRegularSeasonGoalTotal()
		{
			this.BruinGoals = this.CanadienGoals = this.SabreGoals = this.WhalerGoals = 0;

			foreach (var item in Games)
			{
				if (!item.PlayoffGame)
				{
					switch (item.TeamOne)
					{
						case "Bruins":
							this.BruinGoals += item.TeamOneScore;
							break;
						case "Sabres":
							this.SabreGoals += item.TeamOneScore;
							break;
						case "Canadiens":
							this.CanadienGoals += item.TeamOneScore;
							break;
						case "Whalers":
							this.WhalerGoals += item.TeamOneScore;
							break;
					}

					switch (item.TeamTwo)
					{
						case "Bruins":
							this.BruinGoals += item.TeamTwoScore;
							break;
						case "Sabres":
							this.SabreGoals += item.TeamTwoScore;
							break;
						case "Canadiens":
							this.CanadienGoals += item.TeamTwoScore;
							break;
						case "Whalers":
							this.WhalerGoals += item.TeamTwoScore;
							break;
					}
				}

				this.RegularSeasonGoals = this.BruinGoals + this.CanadienGoals + this.SabreGoals + this.WhalerGoals;
			}
		}

		public void PrintGoalTotals()
		{
			CalculateGoalTotal();
			PrintTeamGoal("Bruins", this.BruinGoals);
			PrintTeamGoal("Canadiens", this.CanadienGoals);
			PrintTeamGoal("Sabres", this.SabreGoals);
			PrintTeamGoal("Whalers", this.WhalerGoals);
			Console.WriteLine("There were a total of {0} goals scored.", this.TotalGoals);
		}

		public void PrintRegularSeasonGoalTotals()
		{
			CalculateRegularSeasonGoalTotal();
			CalculateRegularSeasonTeamGoalTotal();

			PrintTeamGoal("Bruins", this.BruinGoals);
			PrintTeamGoal("Canadiens", this.CanadienGoals);
			PrintTeamGoal("Sabres", this.SabreGoals);
			PrintTeamGoal("Whalers", this.WhalerGoals);

			Console.WriteLine("There were a total of {0} Regular Season goals scored.", this.RegularSeasonGoals);
		}

		protected void PrintTeamGoal(string team, int goals)
		{
			Console.WriteLine(string.Format("The {0} scored a total of {1} goals.", team, goals));
		}
	}
}
