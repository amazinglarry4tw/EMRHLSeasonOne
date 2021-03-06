﻿using System;
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
		public int NumberOfSeasons;
		public int NumberOfTeams;

		public PlayerInformation()
		{
			this.PlayerName = string.Empty;
			this.Goals = 0;
			this.Assists = 0;
			this.Points = 0;
			this.Teams = new Dictionary<int, string>();
			this.NumberOfSeasons = 0;
			this.NumberOfTeams = 0;
		}

		public PlayerInformation(string name, int goals, int assists)
		{
			this.PlayerName = name;
			this.Goals = goals;
			this.Assists = assists;
			this.Points = this.Goals + this.Assists;
			this.Teams = new Dictionary<int, string>();
			this.NumberOfSeasons = 0;
			this.NumberOfTeams = 0;
		}

		public void AddTeam(int season, string team)
		{
			this.Teams.Add(season, team);
			CalculateSeasonsAndTeams();
		}

		protected void CalculateSeasonsAndTeams()
		{
			CalculateTotalSeasons();
			CalculateTotalTeams();
		}

		protected void CalculateTotalSeasons()
		{
			this.NumberOfSeasons = this.Teams.Count;
		}

		protected void CalculateTotalTeams()
		{
			int counter = 0;
			if (this.Teams.Count > 0)
			{
				bool bruins = false;
				bool whalers = false;
				bool canadiens = false;
				bool sabres = false;

				foreach (var item in Teams)
				{
					switch (item.Value)
					{
						case "Bruins":
							bruins = true;
							break;
						case "Canadiens":
							canadiens = true;
							break;
						case "Whalers":
							whalers = true;
							break;
						case "Sabres":
							sabres = true;
							break;
					}
				}

				if (bruins)
					counter++;
				if (canadiens)
					counter++;
				if (whalers)
					counter++;
				if (sabres)
					counter++;
			}
			this.NumberOfTeams = counter;
		}

		public void PrintInformation()
		{
			Console.WriteLine(string.Format("Player:  {0}", this.PlayerName));
			Console.WriteLine(string.Format("Goals:  {0}   Assists:  {1}   Points:  {2}", this.Goals, this.Assists, this.Points));

			if (Teams.Count > 0)
			{
				Console.WriteLine(string.Format("Played {0} Combined Seasons for {1} Team(s).", this.NumberOfSeasons, this.NumberOfTeams));
				foreach (var item in Teams)
				{
					Console.WriteLine(string.Format("Played for the {0} during Season {1}.", item.Value, item.Key));
				}
			}
			Console.WriteLine();
		}
	}
}
