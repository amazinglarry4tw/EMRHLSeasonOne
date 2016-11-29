using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRHLSeasonOne
{
	public class GameResult
	{
		public string Date;
		public string TeamOne;
		public string TeamTwo;
		public int TeamOneScore;
		public int TeamTwoScore;
		public string Result;
		protected string WinningTeam;
		protected string LosingTeam;
		protected int WinningScore;
		protected int LosingScore;
		public bool PlayoffGame;

		public GameResult()
		{
			this.Date = string.Empty;
			this.TeamOne = string.Empty;
			this.TeamTwo = string.Empty;
			this.TeamOneScore = 0;
			this.TeamTwoScore = 0;
			this.Result = string.Empty;
			this.PlayoffGame = false;
		}

		public GameResult(string date, string team1, int team1score, string team2, int team2score)
		{
			this.Date = date;
			this.TeamOne = team1;
			this.TeamOneScore = team1score;
			this.TeamTwo = team2;
			this.TeamTwoScore = team2score;
			this.PlayoffGame = false;
			DetermineResult();
		}

		public GameResult(string date, string team1, int team1score, string team2, int team2score, bool playoff)
		{
			this.Date = date;
			this.TeamOne = team1;
			this.TeamOneScore = team1score;
			this.TeamTwo = team2;
			this.TeamTwoScore = team2score;
			this.PlayoffGame = playoff;
			DetermineResult();
		}

		public void DetermineResult()
		{
			if (!Tie())
			{
				GetWinningTeam();
				GetLosingTeam();
				this.Result = string.Format("{0}: The {1} defeated the {2} by a score of {3} - {4}", Date, WinningTeam, LosingTeam, WinningScore, LosingScore);
			}
			else
				this.Result = string.Format("{0}: The {1} and {2} tied each other with a score of {3} - {4}", Date, TeamOne, TeamTwo, TeamOneScore, TeamTwoScore);
		}

		public void GetWinningTeam()
		{
			if (TeamOneScore > TeamTwoScore)
			{
				this.WinningTeam = TeamOne;
				this.WinningScore = TeamOneScore;
			}
			else if (TeamOneScore < TeamTwoScore)
			{
				this.WinningTeam = TeamTwo;
				this.WinningScore = TeamTwoScore;
			}
		}

		public void GetLosingTeam()
		{
			if (TeamOneScore < TeamTwoScore)
			{
				this.LosingTeam = TeamOne;
				this.LosingScore = TeamOneScore;
			}
			else if (TeamOneScore > TeamTwoScore)
			{
				this.LosingTeam = TeamTwo;
				this.LosingScore = TeamTwoScore;
			}
		}

		public bool Tie()
		{
			if (TeamOneScore == TeamTwoScore)
				return true;
			return false;
		}
	}
}
