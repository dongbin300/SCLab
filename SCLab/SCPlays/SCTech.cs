using SCLab.Enums;

namespace SCLab.SCPlays
{
	public class SCTech
	{
		public static string[] IdString = {
			"StimPacks",
			"Lockdown",
			"EMPShockwave",
			"SpiderMines",
			"ScannerSweep",
			"SiegeMode",
			"DefensiveMatrix",
			"Irradiate",
			"YamatoGun",
			"CloakingField",
			"PersonnelCloaking",
			"Burrowing",
			"Infestation",
			"SpawnBroodling",
			"DarkSwarm",
			"Plague",
			"Consume",
			"Ensnare",
			"Parasite",
			"PsionicStorm",
			"Hallucination",
			"Recall",
			"StasisField",
			"ArchonWarp",
			"Restoration",
			"DisruptionWeb",
			"Unused26",
			"MindControl",
			"DarkArchonMeld",
			"Feedback",
			"OpticalFlare",
			"Maelstorm",
			"LurkerAspect",
			"Unused33",
			"Healing",
			"Unused35",
			"Unused36",
			"Unused37",
			"Unused38",
			"Unused39",
			"Unused40",
			"Unused41",
			"Unused42",
			"Unused43"
		};

		public SCTechId Id { get; set; }
		public SCRuleSetting SettingRule { get; set; }
		public ushort Mineral { get; set; }
		public ushort Gas { get; set; }
		public ushort Time { get; set; }
		public ushort Energy { get; set; }

		public byte[] PlayerAvailables { get; set; } = new byte[12];
		public byte[] PlayerResearched { get; set; } = new byte[12];
		public byte GlobalAvailable { get; set; }
		public byte GlobalResearched { get; set; }
		public byte[] UseDefaults { get; set; } = new byte[12];

		public SCTech(SCTechId id)
		{
			Id = id;

			switch (id)
			{
				case SCTechId.StimPacks:
					Init(100, 100, 1200, 0);
					break;
				case SCTechId.Lockdown:
					Init(200, 200, 1500, 100);
					break;
				case SCTechId.EMPShockwave:
					Init(200, 200, 1800, 100);
					break;
				case SCTechId.SpiderMines:
					Init(100, 100, 1200, 0);
					break;
				case SCTechId.ScannerSweep:
					Init(0, 0, 0, 50);
					break;
				case SCTechId.SiegeMode:
					Init(150, 150, 1200, 0);
					break;
				case SCTechId.DefensiveMatrix:
					Init(150, 150, 1500, 100);
					break;
				case SCTechId.Irradiate:
					Init(200, 200, 1200, 75);
					break;
				case SCTechId.YamatoGun:
					Init(100, 100, 1800, 150);
					break;
				case SCTechId.CloakingField:
					Init(150, 150, 1500, 25);
					break;
				case SCTechId.PersonnelCloaking:
					Init(100, 100, 1200, 25);
					break;
				case SCTechId.Burrowing:
					Init(100, 100, 1200, 0);
					break;
				case SCTechId.Infestation:
					Init(100, 100, 1200, 0);
					break;
				case SCTechId.SpawnBroodling:
					Init(100, 100, 1200, 150);
					break;
				case SCTechId.DarkSwarm:
					Init(100, 100, 1200, 100);
					break;
				case SCTechId.Plague:
					Init(200, 200, 1500, 150);
					break;
				case SCTechId.Consume:
					Init(100, 100, 1500, 0);
					break;
				case SCTechId.Ensnare:
					Init(100, 100, 1200, 75);
					break;
				case SCTechId.Parasite:
					Init(100, 100, 1200, 75);
					break;
				case SCTechId.PsionicStorm:
					Init(200, 200, 1800, 75);
					break;
				case SCTechId.Hallucination:
					Init(150, 150, 1200, 100);
					break;
				case SCTechId.Recall:
					Init(150, 150, 1800, 150);
					break;
				case SCTechId.StasisField:
					Init(150, 150, 1500, 100);
					break;
				case SCTechId.ArchonWarp:
					Init(150, 150, 1500, 0);
					break;
				case SCTechId.Restoration:
					Init(100, 100, 1200, 50);
					break;
				case SCTechId.DisruptionWeb:
					Init(200, 200, 1200, 125);
					break;
				case SCTechId.Unused26:
					Init(150, 150, 1800, 50);
					break;
				case SCTechId.MindControl:
					Init(200, 200, 1800, 150);
					break;
				case SCTechId.DarkArchonMeld:
					Init(200, 200, 1800, 100);
					break;
				case SCTechId.Feedback:
					Init(100, 100, 1800, 50);
					break;
				case SCTechId.OpticalFlare:
					Init(100, 100, 1800, 75);
					break;
				case SCTechId.Maelstorm:
					Init(100, 100, 1500, 100);
					break;
				case SCTechId.LurkerAspect:
					Init(200, 200, 1800, 100);
					break;
				case SCTechId.Unused33:
					Init(0, 0, 0, 0);
					break;
				case SCTechId.Healing:
					Init(0, 0, 0, 1);
					break;
				case SCTechId.Unused35:
					Init(200, 200, 1800, 100);
					break;
				case SCTechId.Unused36:
					Init(200, 200, 1800, 100);
					break;
				case SCTechId.Unused37:
					Init(200, 200, 1800, 100);
					break;
				case SCTechId.Unused38:
					Init(200, 200, 1800, 100);
					break;
				case SCTechId.Unused39:
					Init(200, 200, 1800, 100);
					break;
				case SCTechId.Unused40:
					Init(200, 200, 1800, 100);
					break;
				case SCTechId.Unused41:
					Init(200, 200, 1800, 100);
					break;
				case SCTechId.Unused42:
					Init(200, 200, 1800, 100);
					break;
				case SCTechId.Unused43:
					Init(200, 200, 1800, 100);
					break;

			}
		}

		public void Init(ushort mineral, ushort gas, ushort time, ushort energy)
		{
			SettingRule = SCRuleSetting.Default;

			Mineral = mineral;
			Gas = gas;
			Time = time;
			Energy = energy;

			Array.Fill<byte>(PlayerAvailables, 1);
			Array.Fill<byte>(PlayerResearched, 0);
			GlobalAvailable = 1;
			Array.Fill<byte>(UseDefaults, 1);

			GlobalResearched = Id switch
			{
				SCTechId.ScannerSweep or SCTechId.DefensiveMatrix or SCTechId.Infestation or SCTechId.DarkSwarm or
				SCTechId.Parasite or SCTechId.ArchonWarp or SCTechId.DarkArchonMeld or SCTechId.Feedback or
				SCTechId.Unused33 or SCTechId.Healing => 1,
				_ => 0,
			};
		}
	}
}
