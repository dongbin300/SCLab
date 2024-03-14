using SCLab.Enums;

namespace SCLab.SCPlays
{
	public class SCUnit
	{
		public static readonly string[] IdString = {
			"TerranMarine",
			"TerranGhost",
			"TerranVulture",
			"TerranGoliath",
			"GoliathTurret",
			"TerranSiegeTankTankMode",
			"TankTurretTankMode",
			"TerranSCV",
			"TerranWraith",
			"TerranScienceVessel",
			"GuiMontangFirebat",
			"TerranDropship",
			"TerranBattlecruiser",
			"VultureSpiderMine",
			"NuclearMissile",
			"TerranCivilian",
			"SarahKerriganGhost",
			"AlanSchezarGoliath",
			"AlanSchezarTurret",
			"JimRaynorVulture",
			"JimRaynorMarine",
			"TomKazanskyWraith",
			"MagellanScienceVessel",
			"EdmundDukeSiegeTank",
			"EdmundDukeTurret1",
			"EdmundDukeSiegeMode",
			"EdmundDukeTurret2",
			"ArcturusMengskBattlecruiser",
			"HyperionBattlecruiser",
			"NoradIIBattlecruiser",
			"TerranSiegeTankSiegeMode",
			"TankTurretSiegeMode",
			"Firebat",
			"ScannerSweep",
			"TerranMedic",
			"ZergLarva",
			"ZergEgg",
			"ZergZergling",
			"ZergHydralisk",
			"ZergUltralisk",
			"ZergBroodling",
			"ZergDrone",
			"ZergOverlord",
			"ZergMutalisk",
			"ZergGuardian",
			"ZergQueen",
			"ZergDefiler",
			"ZergScourge",
			"TorrarsqueUltralisk",
			"MatriarchQueen",
			"InfestedTerran",
			"InfestedKerrigan",
			"UncleanOneDefiler",
			"HunterKillerHydralisk",
			"DevouringOneZergling",
			"KukulzaMutalisk",
			"KukulzaGuardian",
			"YggdrasillOverlord",
			"TerranValkyrieFrigate",
			"MutaliskGuardianCocoon",
			"ProtossCorsair",
			"ProtossDarkTemplarUnit",
			"ZergDevourer",
			"ProtossDarkArchon",
			"ProtossProbe",
			"ProtossZealot",
			"ProtossDragoon",
			"ProtossHighTemplar",
			"ProtossArchon",
			"ProtossShuttle",
			"ProtossScout",
			"ProtossArbiter",
			"ProtossCarrier",
			"ProtossInterceptor",
			"DarkTemplarHero",
			"ZeratulDarkTemplar",
			"TassadarZeratulArchon",
			"FenixZealot",
			"FenixDragoon",
			"TassadarTemplar",
			"MojoScout",
			"WarbringerReaver",
			"GantrithorCarrier",
			"ProtossReaver",
			"ProtossObserver",
			"ProtossScarab",
			"DanimothArbiter",
			"AldarisTemplar",
			"ArtanisScout",
			"RhynadonBadlandsCritter",
			"BengalaasJungleCritter",
			"UnusedWasCargoShip",
			"UnusedWasMercenaryGunship",
			"ScantidDesertCritter",
			"KakaruTwilightCritter",
			"RagnasaurAshworldCritter",
			"UrsadonIceWorldCritter",
			"LurkerEgg",
			"Raszagal",
			"SamirDuranGhost",
			"AlexeiStukovGhost",
			"MapRevealer",
			"GerardDuGalle",
			"ZergLurker",
			"InfestedDuran",
			"DisruptionWeb",
			"TerranCommandCenter",
			"TerranComsatStation",
			"TerranNuclearSilo",
			"TerranSupplyDepot",
			"TerranRefinery",
			"TerranBarracks",
			"TerranAcademy",
			"TerranFactory",
			"TerranStarport",
			"TerranControlTower",
			"TerranScienceFacility",
			"TerranCovertOps",
			"TerranPhysicsLab",
			"UnusedWasStarbase",
			"TerranMachineShop",
			"UnusedWasRepairBay",
			"TerranEngineeringBay",
			"TerranArmory",
			"TerranMissileTurret",
			"TerranBunker",
			"NoradII",
			"IonCannon",
			"UrajCrystal",
			"KhalisCrystal",
			"InfestedCommandCenter",
			"ZergHatchery",
			"ZergLair",
			"ZergHive",
			"ZergNydusCanal",
			"ZergHydraliskDen",
			"ZergDefilerMound",
			"ZergGreaterSpire",
			"ZergQueensNest",
			"ZergEvolutionChamber",
			"ZergUltraliskCavern",
			"ZergSpire",
			"ZergSpawningPool",
			"ZergCreepColony",
			"ZergSporeColony",
			"UnusedZergBuilding",
			"ZergSunkenColony",
			"ZergOvermindWithShell",
			"ZergOvermind",
			"ZergExtractor",
			"MatureChrysalis",
			"ZergCerebrate",
			"ZergCerebrateDaggoth",
			"UnusedZergBuilding5",
			"ProtossNexus",
			"ProtossRoboticsFacility",
			"ProtossPylon",
			"ProtossAssimilator",
			"UnusedProtossBuilding1",
			"ProtossObservatory",
			"ProtossGateway",
			"UnusedProtossBuilding2",
			"ProtossPhotonCannon",
			"ProtossCitadelofAdun",
			"ProtossCyberneticsCore",
			"ProtossTemplarArchives",
			"ProtossForge",
			"ProtossStargate",
			"StasisCellPrison",
			"ProtossFleetBeacon",
			"ProtossArbiterTribunal",
			"ProtossRoboticsSupportBay",
			"ProtossShieldBattery",
			"KhaydarinCrystalFormation",
			"ProtossTemple",
			"XelNagaTemple",
			"MineralFieldType1",
			"MineralFieldType2",
			"MineralFieldType3",
			"Cave",
			"CaveIn",
			"Cantina",
			"MiningPlatform",
			"IndependantCommandCenter",
			"IndependantStarport",
			"IndependantJumpGate",
			"Ruins",
			"KyadarinCrystalFormation",
			"VespeneGeyser",
			"WarpGate",
			"PSIDisruptor",
			"ZergMarker",
			"TerranMarker",
			"ProtossMarker",
			"ZergBeacon",
			"TerranBeacon",
			"ProtossBeacon",
			"ZergFlagBeacon",
			"TerranFlagBeacon",
			"ProtossFlagBeacon",
			"PowerGenerator",
			"OvermindCocoon",
			"DarkSwarm",
			"FloorMissileTrap",
			"FloorHatch",
			"LeftUpperLevelDoor",
			"RightUpperLevelDoor",
			"LeftPitDoor",
			"RightPitDoor",
			"FloorGunTrap",
			"LeftWallMissileTrap",
			"LeftWallFlameTrap",
			"RightWallMissileTrap",
			"RightWallFlameTrap",
			"StartLocation",
			"Flag",
			"YoungChrysalis",
			"PsiEmitter",
			"DataDisc",
			"KhaydarinCrystal",
			"MineralClusterType1",
			"MineralClusterType2",
			"ProtossVespeneGasOrbType1",
			"ProtossVespeneGasOrbType2",
			"ZergVespeneGasSacType1",
			"ZergVespeneGasSacType2",
			"TerranVespeneGasTankType1",
			"TerranVespeneGasTankType2"
		};

		public SCUnitId Id { get; set; }
		public SCRuleSetting SettingRule { get; set; }
		public uint Hp { get; set; }
		public ushort Shield { get; set; }
		public byte Armor { get; set; }
		public ushort BuildTime { get; set; }
		public ushort Mineral { get; set; }
		public ushort Gas { get; set; }
		public ushort StringNumber { get; set; }
		public SCWeaponId[]? WeaponId { get; set; }

		/// <summary>
		/// 플레이어별 생산 제한
		/// 이 항목이 적용되려면 생산 제한 규칙이 Override여야함.
		/// 크기: [12]
		/// 경우:
		/// Enable(01): 해당 플레이어는 해당 유닛을 생산할 수 있음
		/// Disable(00): 해당 플레이어는 해당 유닛을 생산할 수 없음
		/// </summary>
		public byte[] PlayerAvailables { get; set; } = new byte[12];

		/// <summary>
		/// 글로벌 생산 제한
		/// Default규칙을 사용하는 플레이어 및 유닛에게 적용됨.
		/// 경우: 
		/// Enable(01): 생산할 수 있음 규칙
		/// Disable(00): 생산할 수 없음 규칙
		/// </summary>
		public byte GlobalAvailable { get; set; }

		/// <summary>
		/// 플레이어별 생산 제한 규칙
		/// 크기: [12]
		/// 경우:
		/// Default(01): 글로벌 규칙을 따라간다.
		/// Override(00): 글로벌 규칙을 무시하고 플레이어별 규칙을 따라간다.
		/// </summary>
		public byte[] UseDefaults { get; set; } = new byte[12];

		public SCUnit(SCUnitId id)
		{
			Id = id;

			switch (id)
			{
				case SCUnitId.TerranMarine:
					Init(40, 100, 0, 360, 50, 0, 0, [SCWeaponId.GaussRifleNormal]);
					break;
				case SCUnitId.TerranGhost:
					Init(45, 100, 0, 750, 25, 75, 0, [SCWeaponId.C10ConcussionRifleNormal]);
					break;
				case SCUnitId.TerranVulture:
					Init(80, 100, 0, 450, 75, 0, 0, [SCWeaponId.FragmentationGrenadeNormal]);
					break;
				case SCUnitId.TerranGoliath:
					Init(125, 100, 1, 600, 100, 50, 0, [SCWeaponId.TwinAutocannonsNormal]);
					break;
				case SCUnitId.GoliathTurret:
					Init(0, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.TerranSiegeTankTankMode:
					Init(150, 100, 1, 750, 150, 100, 0);
					break;
				case SCUnitId.TankTurretTankMode:
					Init(0, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.TerranSCV:
					Init(60, 100, 0, 300, 50, 0, 0);
					break;
				case SCUnitId.TerranWraith:
					Init(120, 100, 0, 900, 150, 100, 0);
					break;
				case SCUnitId.TerranScienceVessel:
					Init(200, 100, 1, 1200, 100, 225, 0);
					break;
				case SCUnitId.GuiMontangFirebat:
					Init(160, 100, 3, 720, 100, 50, 0);
					break;
				case SCUnitId.TerranDropship:
					Init(150, 100, 1, 750, 100, 100, 0);
					break;
				case SCUnitId.TerranBattlecruiser:
					Init(500, 100, 3, 2000, 400, 300, 0);
					break;
				case SCUnitId.VultureSpiderMine:
					Init(20, 100, 0, 1, 1, 0, 0);
					break;
				case SCUnitId.NuclearMissile:
					Init(100, 100, 0, 1500, 200, 200, 0);
					break;
				case SCUnitId.TerranCivilian:
					Init(40, 100, 0, 1, 0, 0, 0);
					break;
				case SCUnitId.SarahKerriganGhost:
					Init(250, 100, 3, 1500, 50, 150, 0);
					break;
				case SCUnitId.AlanSchezarGoliath:
					Init(300, 100, 3, 1200, 200, 100, 0);
					break;
				case SCUnitId.AlanSchezarTurret:
					Init(0, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.JimRaynorVulture:
					Init(300, 100, 3, 900, 150, 0, 0);
					break;
				case SCUnitId.JimRaynorMarine:
					Init(200, 100, 3, 1, 50, 0, 0);
					break;
				case SCUnitId.TomKazanskyWraith:
					Init(500, 100, 4, 1800, 400, 200, 0);
					break;
				case SCUnitId.MagellanScienceVessel:
					Init(800, 100, 4, 2400, 50, 600, 0);
					break;
				case SCUnitId.EdmundDukeSiegeTank:
					Init(400, 100, 3, 1500, 300, 200, 0);
					break;
				case SCUnitId.EdmundDukeTurret1:
					Init(0, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.EdmundDukeSiegeMode:
					Init(400, 100, 3, 1500, 300, 200, 0);
					break;
				case SCUnitId.EdmundDukeTurret2:
					Init(0, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.ArcturusMengskBattlecruiser:
					Init(1000, 100, 4, 4800, 800, 600, 0);
					break;
				case SCUnitId.HyperionBattlecruiser:
					Init(850, 100, 4, 2400, 800, 600, 0);
					break;
				case SCUnitId.NoradIIBattlecruiser:
					Init(700, 100, 4, 4800, 800, 600, 0);
					break;
				case SCUnitId.TerranSiegeTankSiegeMode:
					Init(150, 100, 1, 750, 150, 100, 0);
					break;
				case SCUnitId.TankTurretSiegeMode:
					Init(0, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.Firebat:
					Init(50, 100, 1, 360, 50, 25, 0);
					break;
				case SCUnitId.ScannerSweep:
					Init(0, 0, 0, 1, 0, 0, 0);
					break;
				case SCUnitId.TerranMedic:
					Init(60, 100, 1, 450, 50, 25, 0);
					break;
				case SCUnitId.ZergLarva:
					Init(25, 0, 10, 1, 1, 1, 0);
					break;
				case SCUnitId.ZergEgg:
					Init(200, 0, 10, 1, 1, 1, 0);
					break;
				case SCUnitId.ZergZergling:
					Init(35, 100, 0, 420, 50, 0, 0);
					break;
				case SCUnitId.ZergHydralisk:
					Init(80, 100, 0, 420, 75, 25, 0);
					break;
				case SCUnitId.ZergUltralisk:
					Init(400, 100, 1, 900, 200, 200, 0);
					break;
				case SCUnitId.ZergBroodling:
					Init(30, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.ZergDrone:
					Init(40, 100, 0, 300, 50, 0, 0);
					break;
				case SCUnitId.ZergOverlord:
					Init(200, 100, 0, 600, 100, 0, 0);
					break;
				case SCUnitId.ZergMutalisk:
					Init(120, 100, 0, 600, 100, 100, 0);
					break;
				case SCUnitId.ZergGuardian:
					Init(150, 100, 2, 600, 50, 100, 0);
					break;
				case SCUnitId.ZergQueen:
					Init(120, 100, 0, 750, 100, 100, 0);
					break;
				case SCUnitId.ZergDefiler:
					Init(80, 100, 1, 750, 50, 150, 0);
					break;
				case SCUnitId.ZergScourge:
					Init(25, 100, 0, 450, 25, 75, 0);
					break;
				case SCUnitId.TorrarsqueUltralisk:
					Init(800, 100, 4, 1800, 400, 400, 0);
					break;
				case SCUnitId.MatriarchQueen:
					Init(300, 100, 3, 1500, 200, 300, 0);
					break;
				case SCUnitId.InfestedTerran:
					Init(60, 100, 0, 600, 100, 50, 0);
					break;
				case SCUnitId.InfestedKerrigan:
					Init(400, 100, 2, 1500, 200, 300, 0);
					break;
				case SCUnitId.UncleanOneDefiler:
					Init(250, 100, 3, 1500, 50, 200, 0);
					break;
				case SCUnitId.HunterKillerHydralisk:
					Init(160, 100, 2, 780, 150, 50, 0);
					break;
				case SCUnitId.DevouringOneZergling:
					Init(120, 100, 3, 840, 100, 0, 0);
					break;
				case SCUnitId.KukulzaMutalisk:
					Init(300, 100, 3, 1200, 200, 200, 0);
					break;
				case SCUnitId.KukulzaGuardian:
					Init(400, 100, 4, 1200, 100, 200, 0);
					break;
				case SCUnitId.YggdrasillOverlord:
					Init(1000, 100, 4, 1200, 200, 0, 0);
					break;
				case SCUnitId.TerranValkyrieFrigate:
					Init(200, 100, 2, 750, 250, 125, 0);
					break;
				case SCUnitId.MutaliskGuardianCocoon:
					Init(200, 0, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.ProtossCorsair:
					Init(100, 80, 1, 600, 150, 100, 0);
					break;
				case SCUnitId.ProtossDarkTemplarUnit:
					Init(80, 40, 1, 750, 125, 100, 0);
					break;
				case SCUnitId.ZergDevourer:
					Init(250, 100, 2, 600, 150, 50, 0);
					break;
				case SCUnitId.ProtossDarkArchon:
					Init(25, 200, 1, 300, 0, 0, 0);
					break;
				case SCUnitId.ProtossProbe:
					Init(20, 20, 0, 300, 50, 0, 0);
					break;
				case SCUnitId.ProtossZealot:
					Init(100, 60, 1, 600, 100, 0, 0);
					break;
				case SCUnitId.ProtossDragoon:
					Init(100, 80, 1, 750, 125, 50, 0);
					break;
				case SCUnitId.ProtossHighTemplar:
					Init(40, 40, 0, 750, 50, 150, 0);
					break;
				case SCUnitId.ProtossArchon:
					Init(10, 350, 0, 300, 0, 0, 0);
					break;
				case SCUnitId.ProtossShuttle:
					Init(80, 60, 1, 900, 200, 0, 0);
					break;
				case SCUnitId.ProtossScout:
					Init(150, 100, 0, 1200, 275, 125, 0);
					break;
				case SCUnitId.ProtossArbiter:
					Init(200, 150, 1, 2400, 100, 350, 0);
					break;
				case SCUnitId.ProtossCarrier:
					Init(300, 150, 4, 2100, 350, 250, 0);
					break;
				case SCUnitId.ProtossInterceptor:
					Init(40, 40, 0, 300, 25, 0, 0);
					break;
				case SCUnitId.DarkTemplarHero:
					Init(40, 80, 0, 750, 150, 150, 0);
					break;
				case SCUnitId.ZeratulDarkTemplar:
					Init(60, 400, 0, 1500, 100, 300, 0);
					break;
				case SCUnitId.TassadarZeratulArchon:
					Init(100, 800, 3, 600, 0, 0, 0);
					break;
				case SCUnitId.FenixZealot:
					Init(240, 240, 2, 1200, 200, 0, 0);
					break;
				case SCUnitId.FenixDragoon:
					Init(240, 240, 3, 1500, 300, 100, 0);
					break;
				case SCUnitId.TassadarTemplar:
					Init(80, 300, 2, 1500, 100, 300, 0);
					break;
				case SCUnitId.MojoScout:
					Init(400, 400, 3, 2400, 600, 300, 0);
					break;
				case SCUnitId.WarbringerReaver:
					Init(200, 400, 3, 1800, 400, 200, 0);
					break;
				case SCUnitId.GantrithorCarrier:
					Init(800, 500, 4, 4200, 700, 600, 0);
					break;
				case SCUnitId.ProtossReaver:
					Init(100, 80, 0, 1050, 200, 100, 0);
					break;
				case SCUnitId.ProtossObserver:
					Init(40, 20, 0, 600, 25, 75, 0);
					break;
				case SCUnitId.ProtossScarab:
					Init(20, 10, 0, 105, 15, 0, 0);
					break;
				case SCUnitId.DanimothArbiter:
					Init(600, 500, 3, 4800, 50, 1000, 0);
					break;
				case SCUnitId.AldarisTemplar:
					Init(80, 300, 2, 1500, 100, 300, 0);
					break;
				case SCUnitId.ArtanisScout:
					Init(250, 250, 3, 2400, 600, 300, 0);
					break;
				case SCUnitId.RhynadonBadlandsCritter:
					Init(60, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.BengalaasJungleCritter:
					Init(60, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.UnusedWasCargoShip:
					Init(125, 100, 1, 600, 100, 100, 0);
					break;
				case SCUnitId.UnusedWasMercenaryGunship:
					Init(125, 100, 1, 600, 100, 100, 0);
					break;
				case SCUnitId.ScantidDesertCritter:
					Init(60, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.KakaruTwilightCritter:
					Init(60, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.RagnasaurAshworldCritter:
					Init(60, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.UrsadonIceWorldCritter:
					Init(60, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.LurkerEgg:
					Init(200, 0, 10, 1, 1, 1, 0);
					break;
				case SCUnitId.Raszagal:
					Init(100, 60, 0, 750, 150, 100, 0);
					break;
				case SCUnitId.SamirDuranGhost:
					Init(200, 100, 2, 1500, 200, 75, 0);
					break;
				case SCUnitId.AlexeiStukovGhost:
					Init(250, 100, 3, 1500, 200, 75, 0);
					break;
				case SCUnitId.MapRevealer:
					Init(1, 1, 0, 1, 0, 0, 0);
					break;
				case SCUnitId.GerardDuGalle:
					Init(700, 100, 4, 4800, 800, 600, 0);
					break;
				case SCUnitId.ZergLurker:
					Init(125, 100, 1, 600, 50, 100, 0);
					break;
				case SCUnitId.InfestedDuran:
					Init(300, 100, 3, 1500, 200, 75, 0);
					break;
				case SCUnitId.DisruptionWeb:
					Init(800, 100, 0, 2400, 250, 250, 0);
					break;
				case SCUnitId.TerranCommandCenter:
					Init(1500, 100, 1, 1800, 400, 0, 0);
					break;
				case SCUnitId.TerranComsatStation:
					Init(500, 100, 1, 600, 50, 50, 0);
					break;
				case SCUnitId.TerranNuclearSilo:
					Init(600, 100, 1, 1200, 100, 100, 0);
					break;
				case SCUnitId.TerranSupplyDepot:
					Init(500, 100, 1, 600, 100, 0, 0);
					break;
				case SCUnitId.TerranRefinery:
					Init(750, 100, 1, 600, 100, 0, 0);
					break;
				case SCUnitId.TerranBarracks:
					Init(1000, 100, 1, 1200, 150, 0, 0);
					break;
				case SCUnitId.TerranAcademy:
					Init(600, 100, 1, 1200, 150, 0, 0);
					break;
				case SCUnitId.TerranFactory:
					Init(1250, 100, 1, 1200, 200, 100, 0);
					break;
				case SCUnitId.TerranStarport:
					Init(1300, 100, 1, 1050, 150, 100, 0);
					break;
				case SCUnitId.TerranControlTower:
					Init(500, 100, 1, 600, 50, 50, 0);
					break;
				case SCUnitId.TerranScienceFacility:
					Init(850, 100, 1, 900, 100, 150, 0);
					break;
				case SCUnitId.TerranCovertOps:
					Init(750, 100, 1, 600, 50, 50, 0);
					break;
				case SCUnitId.TerranPhysicsLab:
					Init(600, 100, 1, 600, 50, 50, 0);
					break;
				case SCUnitId.UnusedWasStarbase:
					Init(0, 100, 1, 1, 1, 1, 0);
					break;
				case SCUnitId.TerranMachineShop:
					Init(750, 100, 1, 600, 50, 50, 0);
					break;
				case SCUnitId.UnusedWasRepairBay:
					Init(0, 100, 1, 1, 1, 1, 0);
					break;
				case SCUnitId.TerranEngineeringBay:
					Init(850, 100, 1, 900, 125, 0, 0);
					break;
				case SCUnitId.TerranArmory:
					Init(750, 100, 1, 1200, 100, 50, 0);
					break;
				case SCUnitId.TerranMissileTurret:
					Init(200, 100, 0, 450, 75, 0, 0);
					break;
				case SCUnitId.TerranBunker:
					Init(350, 100, 1, 450, 100, 0, 0);
					break;
				case SCUnitId.NoradII:
					Init(700, 100, 1, 4800, 800, 600, 0);
					break;
				case SCUnitId.IonCannon:
					Init(2000, 100, 1, 900, 200, 0, 0);
					break;
				case SCUnitId.UrajCrystal:
					Init(10000, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.KhalisCrystal:
					Init(10000, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.InfestedCommandCenter:
					Init(1500, 100, 1, 1800, 1, 1, 0);
					break;
				case SCUnitId.ZergHatchery:
					Init(1250, 100, 1, 1800, 300, 0, 0);
					break;
				case SCUnitId.ZergLair:
					Init(1800, 100, 1, 1500, 150, 100, 0);
					break;
				case SCUnitId.ZergHive:
					Init(2500, 100, 1, 1800, 200, 150, 0);
					break;
				case SCUnitId.ZergNydusCanal:
					Init(250, 100, 1, 600, 150, 0, 0);
					break;
				case SCUnitId.ZergHydraliskDen:
					Init(850, 100, 1, 600, 100, 50, 0);
					break;
				case SCUnitId.ZergDefilerMound:
					Init(850, 100, 1, 900, 100, 100, 0);
					break;
				case SCUnitId.ZergGreaterSpire:
					Init(1000, 100, 1, 1800, 100, 150, 0);
					break;
				case SCUnitId.ZergQueensNest:
					Init(850, 100, 1, 900, 150, 100, 0);
					break;
				case SCUnitId.ZergEvolutionChamber:
					Init(750, 100, 1, 600, 75, 0, 0);
					break;
				case SCUnitId.ZergUltraliskCavern:
					Init(600, 100, 1, 1200, 150, 200, 0);
					break;
				case SCUnitId.ZergSpire:
					Init(600, 100, 1, 1800, 200, 150, 0);
					break;
				case SCUnitId.ZergSpawningPool:
					Init(750, 100, 1, 1200, 200, 0, 0);
					break;
				case SCUnitId.ZergCreepColony:
					Init(400, 100, 0, 300, 75, 0, 0);
					break;
				case SCUnitId.ZergSporeColony:
					Init(400, 100, 0, 300, 50, 0, 0);
					break;
				case SCUnitId.UnusedZergBuilding:
					Init(0, 100, 1, 1, 1, 1, 0);
					break;
				case SCUnitId.ZergSunkenColony:
					Init(300, 100, 2, 300, 50, 0, 0);
					break;
				case SCUnitId.ZergOvermindWithShell:
					Init(5000, 100, 1, 1, 1, 1, 0);
					break;
				case SCUnitId.ZergOvermind:
					Init(2500, 100, 1, 1, 1, 1, 0);
					break;
				case SCUnitId.ZergExtractor:
					Init(750, 100, 1, 600, 50, 0, 0);
					break;
				case SCUnitId.MatureChrysalis:
					Init(250, 100, 1, 0, 0, 0, 0);
					break;
				case SCUnitId.ZergCerebrate:
					Init(1500, 100, 1, 0, 0, 0, 0);
					break;
				case SCUnitId.ZergCerebrateDaggoth:
					Init(1500, 100, 1, 0, 0, 0, 0);
					break;
				case SCUnitId.UnusedZergBuilding5:
					Init(0, 100, 1, 1, 1, 1, 0);
					break;
				case SCUnitId.ProtossNexus:
					Init(750, 750, 1, 1800, 400, 0, 0);
					break;
				case SCUnitId.ProtossRoboticsFacility:
					Init(500, 500, 1, 1200, 200, 200, 0);
					break;
				case SCUnitId.ProtossPylon:
					Init(300, 300, 0, 450, 100, 0, 0);
					break;
				case SCUnitId.ProtossAssimilator:
					Init(450, 450, 1, 600, 100, 0, 0);
					break;
				case SCUnitId.UnusedProtossBuilding1:
					Init(300, 300, 1, 1, 1, 1, 0);
					break;
				case SCUnitId.ProtossObservatory:
					Init(250, 250, 1, 450, 50, 100, 0);
					break;
				case SCUnitId.ProtossGateway:
					Init(500, 500, 1, 900, 150, 0, 0);
					break;
				case SCUnitId.UnusedProtossBuilding2:
					Init(0, 1, 1, 1, 1, 1, 0);
					break;
				case SCUnitId.ProtossPhotonCannon:
					Init(100, 100, 0, 750, 150, 0, 0);
					break;
				case SCUnitId.ProtossCitadelofAdun:
					Init(450, 450, 1, 900, 150, 100, 0);
					break;
				case SCUnitId.ProtossCyberneticsCore:
					Init(500, 500, 1, 900, 200, 0, 0);
					break;
				case SCUnitId.ProtossTemplarArchives:
					Init(500, 500, 1, 900, 150, 200, 0);
					break;
				case SCUnitId.ProtossForge:
					Init(550, 550, 1, 600, 150, 0, 0);
					break;
				case SCUnitId.ProtossStargate:
					Init(600, 600, 1, 1050, 150, 150, 0);
					break;
				case SCUnitId.StasisCellPrison:
					Init(2000, 100, 1, 1, 150, 0, 0);
					break;
				case SCUnitId.ProtossFleetBeacon:
					Init(500, 500, 1, 900, 300, 200, 0);
					break;
				case SCUnitId.ProtossArbiterTribunal:
					Init(500, 500, 1, 900, 200, 150, 0);
					break;
				case SCUnitId.ProtossRoboticsSupportBay:
					Init(450, 450, 1, 450, 150, 100, 0);
					break;
				case SCUnitId.ProtossShieldBattery:
					Init(200, 200, 1, 450, 100, 0, 0);
					break;
				case SCUnitId.KhaydarinCrystalFormation:
					Init(100000, 100, 1, 1, 250, 0, 0);
					break;
				case SCUnitId.ProtossTemple:
					Init(1500, 100, 1, 1, 250, 0, 0);
					break;
				case SCUnitId.XelNagaTemple:
					Init(5000, 100, 1, 4800, 1500, 500, 0);
					break;
				case SCUnitId.MineralFieldType1:
					Init(100000, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.MineralFieldType2:
					Init(100000, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.MineralFieldType3:
					Init(100000, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.Cave:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.CaveIn:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.Cantina:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.MiningPlatform:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.IndependantCommandCenter:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.IndependantStarport:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.IndependantJumpGate:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.Ruins:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.KyadarinCrystalFormation:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.VespeneGeyser:
					Init(100000, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.WarpGate:
					Init(700, 100, 1, 2400, 600, 200, 0);
					break;
				case SCUnitId.PSIDisruptor:
					Init(2000, 100, 1, 4800, 1000, 400, 0);
					break;
				case SCUnitId.ZergMarker:
					Init(100000, 100, 0, 1, 250, 0, 0);
					break;
				case SCUnitId.TerranMarker:
					Init(100000, 100, 0, 1, 50, 50, 0);
					break;
				case SCUnitId.ProtossMarker:
					Init(100000, 100, 0, 1, 100, 100, 0);
					break;
				case SCUnitId.ZergBeacon:
					Init(100000, 100, 0, 1, 250, 0, 0);
					break;
				case SCUnitId.TerranBeacon:
					Init(100000, 100, 0, 1, 50, 50, 0);
					break;
				case SCUnitId.ProtossBeacon:
					Init(100000, 100, 0, 1, 100, 100, 0);
					break;
				case SCUnitId.ZergFlagBeacon:
					Init(100000, 100, 0, 1, 250, 0, 0);
					break;
				case SCUnitId.TerranFlagBeacon:
					Init(100000, 100, 0, 1, 50, 50, 0);
					break;
				case SCUnitId.ProtossFlagBeacon:
					Init(100000, 100, 0, 1, 100, 100, 0);
					break;
				case SCUnitId.PowerGenerator:
					Init(800, 100, 1, 2400, 200, 50, 0);
					break;
				case SCUnitId.OvermindCocoon:
					Init(2500, 100, 1, 2400, 1000, 500, 0);
					break;
				case SCUnitId.DarkSwarm:
					Init(800, 100, 0, 2400, 250, 200, 0);
					break;
				case SCUnitId.FloorMissileTrap:
					Init(50, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.FloorHatch:
					Init(100000, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.LeftUpperLevelDoor:
					Init(100000, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.RightUpperLevelDoor:
					Init(100000, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.LeftPitDoor:
					Init(100000, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.RightPitDoor:
					Init(100000, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.FloorGunTrap:
					Init(50, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.LeftWallMissileTrap:
					Init(50, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.LeftWallFlameTrap:
					Init(50, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.RightWallMissileTrap:
					Init(50, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.RightWallFlameTrap:
					Init(50, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.StartLocation:
					Init(800, 100, 0, 0, 0, 0, 0);
					break;
				case SCUnitId.Flag:
					Init(100000, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.YoungChrysalis:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.PsiEmitter:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.DataDisc:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.KhaydarinCrystal:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.MineralClusterType1:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.MineralClusterType2:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.ProtossVespeneGasOrbType1:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.ProtossVespeneGasOrbType2:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.ZergVespeneGasSacType1:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.ZergVespeneGasSacType2:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.TerranVespeneGasTankType1:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
				case SCUnitId.TerranVespeneGasTankType2:
					Init(800, 100, 0, 1, 1, 1, 0);
					break;
			}
		}

		public void Init(uint hp, ushort shield, byte armor, ushort buildTime, ushort mineral, ushort gas, ushort stringNumber, SCWeaponId[]? weaponID = null)
		{
			SettingRule = SCRuleSetting.Default;

			Hp = hp;
			Shield = shield;
			Armor = armor;
			BuildTime = buildTime;
			Mineral = mineral;
			Gas = gas;
			StringNumber = stringNumber;

			WeaponId = weaponID;

			Array.Fill<byte>(PlayerAvailables, 1);
			GlobalAvailable = 1;
			Array.Fill<byte>(UseDefaults, 1);
		}
	}
}
