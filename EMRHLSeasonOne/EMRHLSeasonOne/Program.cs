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
		static List<SeasonInformation> seasons = new List<SeasonInformation>();
		static Dictionary<string, int> goalPool = new Dictionary<string, int>();
		static string c = "Canadiens";
		static string b = "Bruins";
		static string w = "Whalers";
		static string s = "Sabres";
		

		static void Main(string[] args)
		{
			Initialize();

			//foreach (var item in players)
			//{
			//	item.PrintInformation();
			//}

			//foreach (var item in seasons)
			//{
			//	item.PrintInformation();
			//	item.PrintGoalTotals();
			//	item.PrintRegularSeasonGoalTotals();
			//}

			OrderPlayersByFewestSeasons();

			Console.ReadLine();
		}

		static void Initialize()
		{
			CreatePlayers();
			CreateSeasons();
			InitializeGoalPool();
		}

		static void CreatePlayers()
		{
			PlayerInformation p1 = new PlayerInformation("Jay Mello", 71, 46);
			p1.AddTeam(1, b);
			p1.AddTeam(2, b);
			p1.AddTeam(3, b);
			p1.AddTeam(4, s);
			PlayerInformation p2 = new PlayerInformation("Shawn Mello", 74, 41);
			p2.AddTeam(1, b);
			p2.AddTeam(2, w);
			p2.AddTeam(3, s);
			p2.AddTeam(4, w);
			PlayerInformation p3 = new PlayerInformation("Derek Jones", 64, 36);
			p3.AddTeam(1, c);
			p3.AddTeam(2, c);
			p3.AddTeam(3, b);
			p3.AddTeam(4, b);
			PlayerInformation p4 = new PlayerInformation("Eric Higgins", 51, 34);
			p4.AddTeam(1, s);
			p4.AddTeam(2, s);
			p4.AddTeam(3, w);
			p4.AddTeam(4, c);
			PlayerInformation p5 = new PlayerInformation("Jack Copley", 57, 17);
			p5.AddTeam(2, w);
			p5.AddTeam(3, c);
			p5.AddTeam(4, b);
			PlayerInformation p6 = new PlayerInformation("Dave Gardner", 40, 34);
			p6.AddTeam(2, s);
			p6.AddTeam(3, c);
			p6.AddTeam(4, b);
			PlayerInformation p7 = new PlayerInformation("Bill St. Pierre", 34, 32);
			p7.AddTeam(1, c);
			p7.AddTeam(2, w);
			p7.AddTeam(3, s);
			p7.AddTeam(4, s);
			PlayerInformation p8 = new PlayerInformation("Zac Macaro", 40, 22);
			p8.AddTeam(1, b);
			p8.AddTeam(2, s);
			p8.AddTeam(3, b);
			p8.AddTeam(4, c);
			PlayerInformation p9 = new PlayerInformation("Dan Leveillee", 30, 27);
			p9.AddTeam(1, c);
			p9.AddTeam(2, w);
			p9.AddTeam(3, s);
			p9.AddTeam(4, w);
			PlayerInformation p10 = new PlayerInformation("Gary Bamford", 28, 24);
			p10.AddTeam(1, s);
			p10.AddTeam(2, s);
			p10.AddTeam(3, c);
			p10.AddTeam(4, s);
			PlayerInformation p11 = new PlayerInformation("Darryl MacEachern", 20, 22);
			p11.AddTeam(2, b);
			p11.AddTeam(3, w);
			p11.AddTeam(4, w);
			PlayerInformation p12 = new PlayerInformation("Dave Belisle", 18, 20);
			p12.AddTeam(1, w);
			p12.AddTeam(2, c);
			p12.AddTeam(3, w);
			p12.AddTeam(4, b);
			PlayerInformation p13 = new PlayerInformation("Derek Sauchuk", 17, 19);
			p13.AddTeam(1, s);
			PlayerInformation p14 = new PlayerInformation("James Carter", 23, 13);
			p14.AddTeam(1, b);
			p14.AddTeam(2, b);
			p14.AddTeam(3, w);
			p14.AddTeam(4, w);
			PlayerInformation p15 = new PlayerInformation("George Dixon", 20, 8);
			p15.AddTeam(1, w);
			PlayerInformation p16 = new PlayerInformation("John Morrison", 12, 16);
			p16.AddTeam(1, s);
			p16.AddTeam(3, c);
			p16.AddTeam(4, b);
			PlayerInformation p17 = new PlayerInformation("Jay Fraser", 7, 21);
			p17.AddTeam(1, s);
			p17.AddTeam(2, b);
			p17.AddTeam(3, b);
			p17.AddTeam(4, c);
			PlayerInformation p18 = new PlayerInformation("Tom Beaulieu", 13, 14);
			p18.AddTeam(1, w);
			p18.AddTeam(2, c);
			p18.AddTeam(3, b);
			p18.AddTeam(4, s);
			PlayerInformation p19 = new PlayerInformation("Scott Liporto", 10, 16);
			p19.AddTeam(1, c);
			p19.AddTeam(2, c);
			p19.AddTeam(3, s);
			p19.AddTeam(4, w);
			PlayerInformation p20 = new PlayerInformation("Tim Lewis", 14, 8);
			p20.AddTeam(1, w);
			p20.AddTeam(2, b);
			PlayerInformation p21 = new PlayerInformation("Luis Carmona", 5, 14);
			p21.AddTeam(1, c);
			p21.AddTeam(2, c);
			p21.AddTeam(3, s);
			p21.AddTeam(4, c);
			PlayerInformation p22 = new PlayerInformation("John White", 5, 11);
			p22.AddTeam(1, s);
			p22.AddTeam(2, s);
			p22.AddTeam(3, s);
			p22.AddTeam(4, s);
			PlayerInformation p23 = new PlayerInformation("Brian Davis", 6, 9);
			p23.AddTeam(1, c);
			p23.AddTeam(2, c);
			PlayerInformation p24 = new PlayerInformation("Steve Burdick", 3, 11);
			p24.AddTeam(2, w);
			p24.AddTeam(3, c);
			PlayerInformation p25 = new PlayerInformation("John Glidden", 8, 6);
			p25.AddTeam(3, b);
			p25.AddTeam(4, c);
			PlayerInformation p26 = new PlayerInformation("Ed LaPlante", 8, 4);
			p26.AddTeam(1, b);
			p26.AddTeam(3, w);
			p26.AddTeam(4, c);
			PlayerInformation p27 = new PlayerInformation("Terry Andress", 1, 10);
			p27.AddTeam(1, w);
			p27.AddTeam(2, w);
			p27.AddTeam(3, c);
			p27.AddTeam(4, b);
			PlayerInformation p28 = new PlayerInformation("Mike Noone", 2, 7);
			p28.AddTeam(1, b);
			p28.AddTeam(2, b);
			p28.AddTeam(3, w);
			p28.AddTeam(4, s);
			PlayerInformation p29 = new PlayerInformation("Kurt Need", 0, 1);
			p29.AddTeam(1, w);
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

		static void CreateSeasons()
		{
			SeasonInformation s1 = new SeasonInformation();
			s1.SeasonNumber = 1;
			s1.AddGameResult("5/5/1999", w, 14, b, 6);
			s1.AddGameResult("5/5/1999", c, 8, s, 7);
			s1.AddGameResult("5/12/1999", s, 5, w, 11);
			s1.AddGameResult("5/12/1999", b, 9, c, 5);
			s1.AddGameResult("5/19/1999", b, 7, s, 6);
			s1.AddGameResult("5/19/1999", c, 7, w, 6);
			s1.AddGameResult("5/26/1999", s, 11, c, 7);
			s1.AddGameResult("5/26/1999", w, 9, b, 5);
			s1.AddGameResult("6/2/1999", b, 7, c, 3);
			s1.AddGameResult("6/2/1999", s, 8, w, 2);
			s1.AddGameResult("6/9/1999", w, 8, c, 4, true);
			s1.AddGameResult("6/9/1999", b, 6, s, 3, true);
			s1.AddGameResult("6/9/1999", w, 6, b, 4, true);

			SeasonInformation s2 = new SeasonInformation();
			s2.SeasonNumber = 2;
			s2.AddGameResult("6/16/1999", w, 10, b, 3);
			s2.AddGameResult("6/16/1999", c, 6, s, 5);
			s2.AddGameResult("6/23/1999", s, 9, w, 8);
			s2.AddGameResult("6/23/1999", c, 4, b, 3);
			s2.AddGameResult("6/30/1999", s, 12, b, 7);
			s2.AddGameResult("6/30/1999", w, 13, c, 9);
			s2.AddGameResult("7/7/1999", c, 8, s, 5);
			s2.AddGameResult("7/7/1999", w, 11, b, 6);
			s2.AddGameResult("7/14/1999", c, 10, b, 9);
			s2.AddGameResult("7/14/1999", w, 8, s, 2);
			s2.AddGameResult("7/21/1999", w, 12, c, 4);
			s2.AddGameResult("7/21/1999", s, 5, b, 3);
			s2.AddGameResult("7/28/1999", b, 6, w, 3, true);
			s2.AddGameResult("7/29/1999", s, 2, c, 1, true);
			s2.AddGameResult("7/29/1999", s, 4, b, 1, true);

			SeasonInformation s3 = new SeasonInformation();
			s3.SeasonNumber = 3;
			s3.AddGameResult("8/4/1999", c, 10, w, 1);
			s3.AddGameResult("8/4/1999", s, 11, b, 6);
			s3.AddGameResult("8/11/1999", w, 8, s, 7);
			s3.AddGameResult("8/11/1999", b, 14, c, 7);
			s3.AddGameResult("8/18/1999", s, 7, c, 6);
			s3.AddGameResult("8/18/1999", b, 9, w, 8);
			s3.AddGameResult("8/25/1999", b, 16, s, 12);
			s3.AddGameResult("8/25/1999", c, 12, w, 8);
			s3.AddGameResult("9/1/1999", b, 10, c, 4);
			s3.AddGameResult("9/1/1999", w, 5, s, 4);
			s3.AddGameResult("9/8/1999", w, 9, b, 8);
			s3.AddGameResult("9/8/1999", c, 10, s, 4);
			s3.AddGameResult("9/23/1999", b, 6, s, 4, true);
			s3.AddGameResult("9/23/1999", c, 4, w, 3, true);
			s3.AddGameResult("9/23/1999", b, 6, c, 4, true);

			SeasonInformation s4 = new SeasonInformation();
			s4.SeasonNumber = 4;
			s4.AddGameResult("9/29/1999", b, 9, w, 8);
			s4.AddGameResult("9/29/1999", c, 9, s, 7);
			s4.AddGameResult("10/6/1999", w, 13, s, 9);
			s4.AddGameResult("10/6/1999", b, 7, c, 7);
			s4.AddGameResult("10/13/1999", b, 10, s, 7);
			s4.AddGameResult("10/13/1999", c, 11, w, 7);
			s4.AddGameResult("10/16/1999", c, 8, s, 8);
			s4.AddGameResult("10/16/1999", b, 8, w, 6);
			s4.AddGameResult("10/20/1999", c, 9, b, 8);
			s4.AddGameResult("10/20/1999", w, 16, s, 14);
			s4.AddGameResult("10/27/1999", c, 13, s, 2, true);
			s4.AddGameResult("10/27/1999", b, 8, w, 6, true);
			s4.AddGameResult("10/27/1999", b, 5, c, 4, true);

			seasons.Add(s1);
			seasons.Add(s2);
			seasons.Add(s3);
			seasons.Add(s4);
		}

		static void InitializeGoalPool()
		{
			foreach (var item in players)
			{
				goalPool.Add(item.PlayerName, item.Goals);
			}
		}

		static void OrderPlayersByFewestSeasons()
		{
			IEnumerable<PlayerInformation> fewest = players.OrderBy(p => p.NumberOfSeasons);
			foreach (var item in fewest)
			{
				item.PrintInformation();
			}
		}
	}
}
