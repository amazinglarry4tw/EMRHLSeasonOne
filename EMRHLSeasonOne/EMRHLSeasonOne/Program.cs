using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRHLSeasonOne
{
	class Program
	{
		static List<PlayerInformation> players = new List<PlayerInformation>();
		static Dictionary<string, string> teams = new Dictionary<string, string>();

		static void Main(string[] args)
		{
			Initialize();

			foreach (var item in players)
			{
				item.PrintInformation();
			}

			Console.ReadLine();
		}

		static void Initialize()
		{
			teams.Add("B", "Bruins");
			teams.Add("C", "Canadiens");
			teams.Add("W", "Whalers");
			teams.Add("S", "Sabres");

			CreatePlayers();
		}

		static void CreatePlayers()
		{
			PlayerInformation p1 = new PlayerInformation("Jay Mello", 71, 46);
			p1.AddTeam(1, teams["B"]);
			p1.AddTeam(2, teams["B"]);
			p1.AddTeam(3, teams["B"]);
			p1.AddTeam(4, teams["S"]);
			PlayerInformation p2 = new PlayerInformation("Shawn Mello", 74, 41);
			p2.AddTeam(1, teams["B"]);
			p2.AddTeam(2, teams["W"]);
			p2.AddTeam(3, teams["S"]);
			p2.AddTeam(4, teams["W"]);
			PlayerInformation p3 = new PlayerInformation("Derek Jones", 64, 36);
			p3.AddTeam(1, teams["C"]);
			p3.AddTeam(2, teams["C"]);
			p3.AddTeam(3, teams["B"]);
			p3.AddTeam(4, teams["B"]);
			PlayerInformation p4 = new PlayerInformation("Eric Higgins", 51, 34);
			p4.AddTeam(1, teams["S"]);
			p4.AddTeam(2, teams["S"]);
			p4.AddTeam(3, teams["W"]);
			p4.AddTeam(4, teams["C"]);
			PlayerInformation p5 = new PlayerInformation("Jack Copley", 57, 17);
			p5.AddTeam(2, teams["W"]);
			p5.AddTeam(3, teams["C"]);
			p5.AddTeam(4, teams["B"]);
			PlayerInformation p6 = new PlayerInformation("Dave Gardner", 40, 34);
			p6.AddTeam(2, teams["S"]);
			p6.AddTeam(3, teams["C"]);
			p6.AddTeam(4, teams["B"]);
			PlayerInformation p7 = new PlayerInformation("Bill St. Pierre", 34, 32);
			p7.AddTeam(1, teams["C"]);
			p7.AddTeam(2, teams["W"]);
			p7.AddTeam(3, teams["S"]);
			p7.AddTeam(4, teams["S"]);
			PlayerInformation p8 = new PlayerInformation("Zac Macaro", 40, 22);
			PlayerInformation p9 = new PlayerInformation("Dan Leveillee", 30, 27);
			PlayerInformation p10 = new PlayerInformation("Gary Bamford", 28, 24);
			PlayerInformation p11 = new PlayerInformation("Darryl MacEachern", 20, 22);
			PlayerInformation p12 = new PlayerInformation("Dave Belisle", 18, 20);
			PlayerInformation p13 = new PlayerInformation("Derek Sauchuk", 17, 19);
			PlayerInformation p14 = new PlayerInformation("James Carter", 23, 13);
			PlayerInformation p15 = new PlayerInformation("George Dixon", 20, 8);
			PlayerInformation p16 = new PlayerInformation("John Morrison", 12, 16);
			PlayerInformation p17 = new PlayerInformation("Jay Fraser", 7, 21);
			PlayerInformation p18 = new PlayerInformation("Tom Beaulieu", 13, 14);
			PlayerInformation p19 = new PlayerInformation("Scott Liporto", 10, 16);
			PlayerInformation p20 = new PlayerInformation("Tim Lewis", 14, 8);
			PlayerInformation p21 = new PlayerInformation("Luis Carmona", 5, 14);
			PlayerInformation p22 = new PlayerInformation("John White", 5, 11);
			PlayerInformation p23 = new PlayerInformation("Brian Davis", 6, 9);
			PlayerInformation p24 = new PlayerInformation("Steve Burdick", 3, 11);
			PlayerInformation p25 = new PlayerInformation("John Glidden", 8, 6);
			PlayerInformation p26 = new PlayerInformation("Ed LaPlante", 8, 4);
			PlayerInformation p27 = new PlayerInformation("Terry Andress", 1, 10);
			PlayerInformation p28 = new PlayerInformation("Mike Noone", 2, 7);
			PlayerInformation p29 = new PlayerInformation("Kurt Need", 0, 1);
			PlayerInformation p30 = new PlayerInformation("Mike Gastonguay", 1, 0);

			players.Add(p1);
			players.Add(p2);
			players.Add(p3);
			players.Add(p4);
			players.Add(p5);
			players.Add(p6);
			players.Add(p7);
			players.Add(p8);
			players.Add(p9);
			players.Add(p10);
			players.Add(p11);
			players.Add(p12);
			players.Add(p13);
			players.Add(p14);
			players.Add(p15);
			players.Add(p16);
			players.Add(p17);
			players.Add(p18);
			players.Add(p19);
			players.Add(p20);
			players.Add(p21);
			players.Add(p22);
			players.Add(p23);
			players.Add(p24);
			players.Add(p25);
			players.Add(p26);
			players.Add(p27);
			players.Add(p28);
			players.Add(p29);
			players.Add(p30);
		}
	}
}
