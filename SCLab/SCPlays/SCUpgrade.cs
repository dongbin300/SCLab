using SCLab.Enums;

namespace SCLab.SCPlays
{
	public class SCUpgrade
	{
		public static string[] IdString =
		{
			"TerranInfantryArmor",
			"TerranVehiclePlating",
			"TerranShipPlating",
			"ZergCarapace",
			"ZergFlyerCaparace",
			"ProtossArmor",
			"ProtossPlating",
			"TerranInfantryWeapons",
			"TerranVehicleWeapons",
			"TerranShipWeapons",
			"ZergMeleeAttacks",
			"ZergMissileAttacks",
			"ZergFlyerAttacks",
			"ProtossGroundWeapons",
			"ProtossAirWeapons",
			"ProtossPlasmaShields",
			"U238Shells",
			"IonThrusters",
			"BurstLasers",
			"TitanReactor",
			"OcularImplants",
			"MoebiusReactor",
			"ApolloReactor",
			"ColossusReactor",
			"VentralSacs",
			"Antennae",
			"PneumatizedCarapace",
			"MetabolicBoost",
			"AdrenalGlands",
			"MuscularAugments",
			"GroovedSpines",
			"GameteMeiosis",
			"MetasynapticNode",
			"SingularityCharge",
			"LegEnhancements",
			"ScarabDamage",
			"ReaverCapacity",
			"GraviticDrive",
			"SensorArray",
			"GraviticBoosters",
			"KhaydarinAmulet",
			"ApialSensors",
			"GraviticThrusters",
			"CarrierCapacity",
			"KhaydarinCore",
			"UnknownUpgrade45",
			"UnknownUpgrade46",
			"ArgusJewel",
			"UnknownUpgrade48",
			"ArgusTalisman",
			"UnknownUpgrade50",
			"CaduceusReactor",
			"ChitinousPlating",
			"AnabolicSynthesis",
			"CharonBooster",
			"UnknownUpgrade55",
			"UnknownUpgrade56",
			"UnknownUpgrade57",
			"UnknownUpgrade58",
			"UnknownUpgrade59",
			"UnknownUpgrade60"
		};

		public SCUpgradeId Id { get; set; }
		public SCRuleSetting SettingRule { get; set; }
		public ushort Mineral { get; set; }
		public ushort MineralBonus { get; set; }
		public ushort Gas { get; set; }
		public ushort GasBonus { get; set; }
		public ushort Time { get; set; }
		public ushort TimeBonus { get; set; }

		/// <summary>
		/// 플레이어별 업글 최고레벨
		/// Default규칙을 사용하지 않는 플레이어에게 적용됨.
		/// 크기: [12]
		/// </summary>
		public byte[] PlayerMaxLevels { get; set; } = new byte[12];

		/// <summary>
		/// 플레이어별 업글 시작레벨
		/// Default규칙을 사용하지 않는 플레이어에게 적용됨.
		/// 크기: [12]
		/// </summary>
		public byte[] PlayerStartLevels { get; set; } = new byte[12];

		/// <summary>
		/// 글로벌 최고레벨
		/// Default규칙을 사용하는 플레이어에게 적용됨.
		/// </summary>
		public byte GlobalMaxLevel { get; set; }

		/// <summary>
		/// 글로벌 시작레벨
		/// Default규칙을 사용하는 플레이어에게 적용됨.
		/// </summary>
		public byte GlobalStartLevel { get; set; }

		/// <summary>
		/// 플레이어별 업글 규칙
		/// 크기: [12]
		/// 경우:
		/// Default(01): 글로벌 규칙을 따라간다.
		/// Override(00): 글로벌 규칙을 무시하고 플레이어별 규칙을 따라간다.
		/// </summary>
		public byte[] UseDefaults { get; set; } = new byte[12];

		public SCUpgrade(SCUpgradeId id)
		{
			Id = id;

			switch (id)
			{
				case SCUpgradeId.TerranInfantryArmor:
					Init(3, 100, 75, 100, 75, 3990, 480);
					break;
				case SCUpgradeId.TerranVehiclePlating:
					Init(3, 100, 75, 100, 75, 3990, 480);
					break;
				case SCUpgradeId.TerranShipPlating:
					Init(3, 150, 75, 150, 75, 3990, 480);
					break;
				case SCUpgradeId.ZergCarapace:
					Init(3, 150, 75, 150, 75, 3990, 480);
					break;
				case SCUpgradeId.ZergFlyerCaparace:
					Init(3, 150, 75, 150, 75, 3990, 480);
					break;
				case SCUpgradeId.ProtossArmor:
					Init(3, 100, 75, 100, 75, 3990, 480);
					break;
				case SCUpgradeId.ProtossPlating:
					Init(3, 150, 75, 150, 75, 3990, 480);
					break;
				case SCUpgradeId.TerranInfantryWeapons:
					Init(3, 100, 75, 100, 75, 3990, 480);
					break;
				case SCUpgradeId.TerranVehicleWeapons:
					Init(3, 100, 75, 100, 75, 3990, 480);
					break;
				case SCUpgradeId.TerranShipWeapons:
					Init(3, 100, 50, 100, 50, 3990, 480);
					break;
				case SCUpgradeId.ZergMeleeAttacks:
					Init(3, 100, 50, 100, 50, 3990, 480);
					break;
				case SCUpgradeId.ZergMissileAttacks:
					Init(3, 100, 50, 100, 50, 3990, 480);
					break;
				case SCUpgradeId.ZergFlyerAttacks:
					Init(3, 100, 75, 100, 75, 3990, 480);
					break;
				case SCUpgradeId.ProtossGroundWeapons:
					Init(3, 100, 50, 100, 50, 3990, 480);
					break;
				case SCUpgradeId.ProtossAirWeapons:
					Init(3, 100, 75, 100, 75, 3990, 480);
					break;
				case SCUpgradeId.ProtossPlasmaShields:
					Init(3, 200, 100, 200, 100, 3990, 480);
					break;
				case SCUpgradeId.U238Shells:
					Init(1, 150, 0, 150, 0, 1500, 0);
					break;
				case SCUpgradeId.IonThrusters:
					Init(1, 100, 0, 100, 0, 1500, 0);
					break;
				case SCUpgradeId.BurstLasers:
					Init(0, 200, 0, 200, 0, 2490, 0);
					break;
				case SCUpgradeId.TitanReactor:
					Init(1, 150, 0, 150, 0, 2490, 0);
					break;
				case SCUpgradeId.OcularImplants:
					Init(1, 100, 0, 100, 0, 2490, 0);
					break;
				case SCUpgradeId.MoebiusReactor:
					Init(1, 150, 0, 150, 0, 2490, 0);
					break;
				case SCUpgradeId.ApolloReactor:
					Init(1, 200, 0, 200, 0, 2490, 0);
					break;
				case SCUpgradeId.ColossusReactor:
					Init(1, 150, 0, 150, 0, 2490, 0);
					break;
				case SCUpgradeId.VentralSacs:
					Init(1, 200, 0, 200, 0, 2400, 0);
					break;
				case SCUpgradeId.Antennae:
					Init(1, 150, 0, 150, 0, 1995, 0);
					break;
				case SCUpgradeId.PneumatizedCarapace:
					Init(1, 150, 0, 150, 0, 1995, 0);
					break;
				case SCUpgradeId.MetabolicBoost:
					Init(1, 100, 0, 100, 0, 1500, 0);
					break;
				case SCUpgradeId.AdrenalGlands:
					Init(1, 200, 0, 200, 0, 1500, 0);
					break;
				case SCUpgradeId.MuscularAugments:
					Init(1, 150, 0, 150, 0, 1500, 0);
					break;
				case SCUpgradeId.GroovedSpines:
					Init(1, 150, 0, 150, 0, 1500, 0);
					break;
				case SCUpgradeId.GameteMeiosis:
					Init(1, 150, 0, 150, 0, 2490, 0);
					break;
				case SCUpgradeId.MetasynapticNode:
					Init(1, 150, 0, 150, 0, 2490, 0);
					break;
				case SCUpgradeId.SingularityCharge:
					Init(1, 150, 0, 150, 0, 2490, 0);
					break;
				case SCUpgradeId.LegEnhancements:
					Init(1, 150, 0, 150, 0, 1995, 0);
					break;
				case SCUpgradeId.ScarabDamage:
					Init(1, 200, 0, 200, 0, 2490, 0);
					break;
				case SCUpgradeId.ReaverCapacity:
					Init(1, 200, 0, 200, 0, 2490, 0);
					break;
				case SCUpgradeId.GraviticDrive:
					Init(1, 200, 0, 200, 0, 2490, 0);
					break;
				case SCUpgradeId.SensorArray:
					Init(1, 150, 0, 150, 0, 1995, 0);
					break;
				case SCUpgradeId.GraviticBoosters:
					Init(1, 150, 0, 150, 0, 1995, 0);
					break;
				case SCUpgradeId.KhaydarinAmulet:
					Init(1, 150, 0, 150, 0, 2490, 0);
					break;
				case SCUpgradeId.ApialSensors:
					Init(1, 100, 0, 100, 0, 2490, 0);
					break;
				case SCUpgradeId.GraviticThrusters:
					Init(1, 200, 0, 200, 0, 2490, 0);
					break;
				case SCUpgradeId.CarrierCapacity:
					Init(1, 100, 0, 100, 0, 1500, 0);
					break;
				case SCUpgradeId.KhaydarinCore:
					Init(1, 150, 0, 150, 0, 2490, 0);
					break;
				case SCUpgradeId.UnknownUpgrade45:
					Init(0, 0, 0, 0, 0, 0, 0);
					break;
				case SCUpgradeId.UnknownUpgrade46:
					Init(0, 0, 0, 0, 0, 0, 0);
					break;
				case SCUpgradeId.ArgusJewel:
					Init(1, 100, 0, 100, 0, 2490, 0);
					break;
				case SCUpgradeId.UnknownUpgrade48:
					Init(0, 100, 0, 100, 0, 2490, 0);
					break;
				case SCUpgradeId.ArgusTalisman:
					Init(1, 150, 0, 150, 0, 2490, 0);
					break;
				case SCUpgradeId.UnknownUpgrade50:
					Init(0, 150, 0, 150, 0, 2490, 0);
					break;
				case SCUpgradeId.CaduceusReactor:
					Init(1, 150, 0, 150, 0, 2490, 0);
					break;
				case SCUpgradeId.ChitinousPlating:
					Init(1, 150, 0, 150, 0, 1995, 0);
					break;
				case SCUpgradeId.AnabolicSynthesis:
					Init(1, 200, 0, 200, 0, 1995, 0);
					break;
				case SCUpgradeId.CharonBooster:
					Init(1, 100, 0, 100, 0, 1995, 0);
					break;
				case SCUpgradeId.UnknownUpgrade55:
					Init(0, 0, 0, 0, 0, 0, 0);
					break;
				case SCUpgradeId.UnknownUpgrade56:
					Init(0, 0, 0, 0, 0, 0, 0);
					break;
				case SCUpgradeId.UnknownUpgrade57:
					Init(0, 0, 0, 0, 0, 0, 0);
					break;
				case SCUpgradeId.UnknownUpgrade58:
					Init(0, 0, 0, 0, 0, 0, 0);
					break;
				case SCUpgradeId.UnknownUpgrade59:
					Init(0, 0, 0, 0, 0, 0, 0);
					break;
				case SCUpgradeId.UnknownUpgrade60:
					Init(0, 0, 0, 0, 0, 0, 0);
					break;
			}
		}

		public void Init(byte maxLevel, ushort mineral, ushort mineralBonus, ushort gas, ushort gasBonus, ushort time, ushort timeBonus)
		{
			SettingRule = SCRuleSetting.Default;

			Mineral = mineral;
			MineralBonus = mineralBonus;
			Gas = gas;
			GasBonus = gasBonus;
			Time = time;
			TimeBonus = timeBonus;

			Array.Fill(PlayerMaxLevels, maxLevel);
			Array.Fill<byte>(PlayerStartLevels, 0);
			GlobalMaxLevel = maxLevel;
			GlobalStartLevel = 0;
			Array.Fill<byte>(UseDefaults, 1);
		}
	}
}
