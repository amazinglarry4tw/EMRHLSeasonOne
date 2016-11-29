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

		public SeasonInformation()
		{
			this.SeasonNumber = 0;
			this.Games = new List<GameResult>();
			this.BruinGoals = 0;
			this.SabreGoals = 0;
			this.WhalerGoals = 0;
			this.CanadienGoals = 0;
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

		protected void CalculateSeasonGoalTotal()
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

		public void PrintSeasonGoalTotals()
		{
			CalculateSeasonGoalTotal();
			PrintTeamGoal("Bruins", this.BruinGoals);
			PrintTeamGoal("Canadiens", this.CanadienGoals);
			PrintTeamGoal("Sabres", this.SabreGoals);
			PrintTeamGoal("Whalers", this.WhalerGoals);
			Console.WriteLine("There were a total of {0} goals scored.", this.TotalGoals);
		}

		protected void PrintTeamGoal(string team, int goals)
		{
			Console.WriteLine(string.Format("The {0} scored a total of {1} goals.", team, goals));
		}
	}
}
