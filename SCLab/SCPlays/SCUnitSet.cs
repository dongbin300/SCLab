﻿using SCLab.Enums;

namespace SCLab.SCPlays
{
	public class SCUnitSet
	{
		public SCUnit[] Units { get; set; }

		public SCUnitSet()
		{
			Units =
			[
				new SCUnit(SCUnitId.TerranMarine),
				new SCUnit(SCUnitId.TerranGhost),
				new SCUnit(SCUnitId.TerranVulture),
				new SCUnit(SCUnitId.TerranGoliath),
				new SCUnit(SCUnitId.GoliathTurret),
				new SCUnit(SCUnitId.TerranSiegeTankTankMode),
				new SCUnit(SCUnitId.TankTurretTankMode),
				new SCUnit(SCUnitId.TerranSCV),
				new SCUnit(SCUnitId.TerranWraith),
				new SCUnit(SCUnitId.TerranScienceVessel),
				new SCUnit(SCUnitId.GuiMontangFirebat),
				new SCUnit(SCUnitId.TerranDropship),
				new SCUnit(SCUnitId.TerranBattlecruiser),
				new SCUnit(SCUnitId.VultureSpiderMine),
				new SCUnit(SCUnitId.NuclearMissile),
				new SCUnit(SCUnitId.TerranCivilian),
				new SCUnit(SCUnitId.SarahKerriganGhost),
				new SCUnit(SCUnitId.AlanSchezarGoliath),
				new SCUnit(SCUnitId.AlanSchezarTurret),
				new SCUnit(SCUnitId.JimRaynorVulture),
				new SCUnit(SCUnitId.JimRaynorMarine),
				new SCUnit(SCUnitId.TomKazanskyWraith),
				new SCUnit(SCUnitId.MagellanScienceVessel),
				new SCUnit(SCUnitId.EdmundDukeSiegeTank),
				new SCUnit(SCUnitId.EdmundDukeTurret1),
				new SCUnit(SCUnitId.EdmundDukeSiegeMode),
				new SCUnit(SCUnitId.EdmundDukeTurret2),
				new SCUnit(SCUnitId.ArcturusMengskBattlecruiser),
				new SCUnit(SCUnitId.HyperionBattlecruiser),
				new SCUnit(SCUnitId.NoradIIBattlecruiser),
				new SCUnit(SCUnitId.TerranSiegeTankSiegeMode),
				new SCUnit(SCUnitId.TankTurretSiegeMode),
				new SCUnit(SCUnitId.Firebat),
				new SCUnit(SCUnitId.ScannerSweep),
				new SCUnit(SCUnitId.TerranMedic),
				new SCUnit(SCUnitId.ZergLarva),
				new SCUnit(SCUnitId.ZergEgg),
				new SCUnit(SCUnitId.ZergZergling),
				new SCUnit(SCUnitId.ZergHydralisk),
				new SCUnit(SCUnitId.ZergUltralisk),
				new SCUnit(SCUnitId.ZergBroodling),
				new SCUnit(SCUnitId.ZergDrone),
				new SCUnit(SCUnitId.ZergOverlord),
				new SCUnit(SCUnitId.ZergMutalisk),
				new SCUnit(SCUnitId.ZergGuardian),
				new SCUnit(SCUnitId.ZergQueen),
				new SCUnit(SCUnitId.ZergDefiler),
				new SCUnit(SCUnitId.ZergScourge),
				new SCUnit(SCUnitId.TorrarsqueUltralisk),
				new SCUnit(SCUnitId.MatriarchQueen),
				new SCUnit(SCUnitId.InfestedTerran),
				new SCUnit(SCUnitId.InfestedKerrigan),
				new SCUnit(SCUnitId.UncleanOneDefiler),
				new SCUnit(SCUnitId.HunterKillerHydralisk),
				new SCUnit(SCUnitId.DevouringOneZergling),
				new SCUnit(SCUnitId.KukulzaMutalisk),
				new SCUnit(SCUnitId.KukulzaGuardian),
				new SCUnit(SCUnitId.YggdrasillOverlord),
				new SCUnit(SCUnitId.TerranValkyrieFrigate),
				new SCUnit(SCUnitId.MutaliskGuardianCocoon),
				new SCUnit(SCUnitId.ProtossCorsair),
				new SCUnit(SCUnitId.ProtossDarkTemplarUnit),
				new SCUnit(SCUnitId.ZergDevourer),
				new SCUnit(SCUnitId.ProtossDarkArchon),
				new SCUnit(SCUnitId.ProtossProbe),
				new SCUnit(SCUnitId.ProtossZealot),
				new SCUnit(SCUnitId.ProtossDragoon),
				new SCUnit(SCUnitId.ProtossHighTemplar),
				new SCUnit(SCUnitId.ProtossArchon),
				new SCUnit(SCUnitId.ProtossShuttle),
				new SCUnit(SCUnitId.ProtossScout),
				new SCUnit(SCUnitId.ProtossArbiter),
				new SCUnit(SCUnitId.ProtossCarrier),
				new SCUnit(SCUnitId.ProtossInterceptor),
				new SCUnit(SCUnitId.DarkTemplarHero),
				new SCUnit(SCUnitId.ZeratulDarkTemplar),
				new SCUnit(SCUnitId.TassadarZeratulArchon),
				new SCUnit(SCUnitId.FenixZealot),
				new SCUnit(SCUnitId.FenixDragoon),
				new SCUnit(SCUnitId.TassadarTemplar),
				new SCUnit(SCUnitId.MojoScout),
				new SCUnit(SCUnitId.WarbringerReaver),
				new SCUnit(SCUnitId.GantrithorCarrier),
				new SCUnit(SCUnitId.ProtossReaver),
				new SCUnit(SCUnitId.ProtossObserver),
				new SCUnit(SCUnitId.ProtossScarab),
				new SCUnit(SCUnitId.DanimothArbiter),
				new SCUnit(SCUnitId.AldarisTemplar),
				new SCUnit(SCUnitId.ArtanisScout),
				new SCUnit(SCUnitId.RhynadonBadlandsCritter),
				new SCUnit(SCUnitId.BengalaasJungleCritter),
				new SCUnit(SCUnitId.UnusedWasCargoShip),
				new SCUnit(SCUnitId.UnusedWasMercenaryGunship),
				new SCUnit(SCUnitId.ScantidDesertCritter),
				new SCUnit(SCUnitId.KakaruTwilightCritter),
				new SCUnit(SCUnitId.RagnasaurAshworldCritter),
				new SCUnit(SCUnitId.UrsadonIceWorldCritter),
				new SCUnit(SCUnitId.LurkerEgg),
				new SCUnit(SCUnitId.Raszagal),
				new SCUnit(SCUnitId.SamirDuranGhost),
				new SCUnit(SCUnitId.AlexeiStukovGhost),
				new SCUnit(SCUnitId.MapRevealer),
				new SCUnit(SCUnitId.GerardDuGalle),
				new SCUnit(SCUnitId.ZergLurker),
				new SCUnit(SCUnitId.InfestedDuran),
				new SCUnit(SCUnitId.DisruptionWeb),
				new SCUnit(SCUnitId.TerranCommandCenter),
				new SCUnit(SCUnitId.TerranComsatStation),
				new SCUnit(SCUnitId.TerranNuclearSilo),
				new SCUnit(SCUnitId.TerranSupplyDepot),
				new SCUnit(SCUnitId.TerranRefinery),
				new SCUnit(SCUnitId.TerranBarracks),
				new SCUnit(SCUnitId.TerranAcademy),
				new SCUnit(SCUnitId.TerranFactory),
				new SCUnit(SCUnitId.TerranStarport),
				new SCUnit(SCUnitId.TerranControlTower),
				new SCUnit(SCUnitId.TerranScienceFacility),
				new SCUnit(SCUnitId.TerranCovertOps),
				new SCUnit(SCUnitId.TerranPhysicsLab),
				new SCUnit(SCUnitId.UnusedWasStarbase),
				new SCUnit(SCUnitId.TerranMachineShop),
				new SCUnit(SCUnitId.UnusedWasRepairBay),
				new SCUnit(SCUnitId.TerranEngineeringBay),
				new SCUnit(SCUnitId.TerranArmory),
				new SCUnit(SCUnitId.TerranMissileTurret),
				new SCUnit(SCUnitId.TerranBunker),
				new SCUnit(SCUnitId.NoradII),
				new SCUnit(SCUnitId.IonCannon),
				new SCUnit(SCUnitId.UrajCrystal),
				new SCUnit(SCUnitId.KhalisCrystal),
				new SCUnit(SCUnitId.InfestedCommandCenter),
				new SCUnit(SCUnitId.ZergHatchery),
				new SCUnit(SCUnitId.ZergLair),
				new SCUnit(SCUnitId.ZergHive),
				new SCUnit(SCUnitId.ZergNydusCanal),
				new SCUnit(SCUnitId.ZergHydraliskDen),
				new SCUnit(SCUnitId.ZergDefilerMound),
				new SCUnit(SCUnitId.ZergGreaterSpire),
				new SCUnit(SCUnitId.ZergQueensNest),
				new SCUnit(SCUnitId.ZergEvolutionChamber),
				new SCUnit(SCUnitId.ZergUltraliskCavern),
				new SCUnit(SCUnitId.ZergSpire),
				new SCUnit(SCUnitId.ZergSpawningPool),
				new SCUnit(SCUnitId.ZergCreepColony),
				new SCUnit(SCUnitId.ZergSporeColony),
				new SCUnit(SCUnitId.UnusedZergBuilding),
				new SCUnit(SCUnitId.ZergSunkenColony),
				new SCUnit(SCUnitId.ZergOvermindWithShell),
				new SCUnit(SCUnitId.ZergOvermind),
				new SCUnit(SCUnitId.ZergExtractor),
				new SCUnit(SCUnitId.MatureChrysalis),
				new SCUnit(SCUnitId.ZergCerebrate),
				new SCUnit(SCUnitId.ZergCerebrateDaggoth),
				new SCUnit(SCUnitId.UnusedZergBuilding5),
				new SCUnit(SCUnitId.ProtossNexus),
				new SCUnit(SCUnitId.ProtossRoboticsFacility),
				new SCUnit(SCUnitId.ProtossPylon),
				new SCUnit(SCUnitId.ProtossAssimilator),
				new SCUnit(SCUnitId.UnusedProtossBuilding1),
				new SCUnit(SCUnitId.ProtossObservatory),
				new SCUnit(SCUnitId.ProtossGateway),
				new SCUnit(SCUnitId.UnusedProtossBuilding2),
				new SCUnit(SCUnitId.ProtossPhotonCannon),
				new SCUnit(SCUnitId.ProtossCitadelofAdun),
				new SCUnit(SCUnitId.ProtossCyberneticsCore),
				new SCUnit(SCUnitId.ProtossTemplarArchives),
				new SCUnit(SCUnitId.ProtossForge),
				new SCUnit(SCUnitId.ProtossStargate),
				new SCUnit(SCUnitId.StasisCellPrison),
				new SCUnit(SCUnitId.ProtossFleetBeacon),
				new SCUnit(SCUnitId.ProtossArbiterTribunal),
				new SCUnit(SCUnitId.ProtossRoboticsSupportBay),
				new SCUnit(SCUnitId.ProtossShieldBattery),
				new SCUnit(SCUnitId.KhaydarinCrystalFormation),
				new SCUnit(SCUnitId.ProtossTemple),
				new SCUnit(SCUnitId.XelNagaTemple),
				new SCUnit(SCUnitId.MineralFieldType1),
				new SCUnit(SCUnitId.MineralFieldType2),
				new SCUnit(SCUnitId.MineralFieldType3),
				new SCUnit(SCUnitId.Cave),
				new SCUnit(SCUnitId.CaveIn),
				new SCUnit(SCUnitId.Cantina),
				new SCUnit(SCUnitId.MiningPlatform),
				new SCUnit(SCUnitId.IndependantCommandCenter),
				new SCUnit(SCUnitId.IndependantStarport),
				new SCUnit(SCUnitId.IndependantJumpGate),
				new SCUnit(SCUnitId.Ruins),
				new SCUnit(SCUnitId.KyadarinCrystalFormation),
				new SCUnit(SCUnitId.VespeneGeyser),
				new SCUnit(SCUnitId.WarpGate),
				new SCUnit(SCUnitId.PSIDisruptor),
				new SCUnit(SCUnitId.ZergMarker),
				new SCUnit(SCUnitId.TerranMarker),
				new SCUnit(SCUnitId.ProtossMarker),
				new SCUnit(SCUnitId.ZergBeacon),
				new SCUnit(SCUnitId.TerranBeacon),
				new SCUnit(SCUnitId.ProtossBeacon),
				new SCUnit(SCUnitId.ZergFlagBeacon),
				new SCUnit(SCUnitId.TerranFlagBeacon),
				new SCUnit(SCUnitId.ProtossFlagBeacon),
				new SCUnit(SCUnitId.PowerGenerator),
				new SCUnit(SCUnitId.OvermindCocoon),
				new SCUnit(SCUnitId.DarkSwarm),
				new SCUnit(SCUnitId.FloorMissileTrap),
				new SCUnit(SCUnitId.FloorHatch),
				new SCUnit(SCUnitId.LeftUpperLevelDoor),
				new SCUnit(SCUnitId.RightUpperLevelDoor),
				new SCUnit(SCUnitId.LeftPitDoor),
				new SCUnit(SCUnitId.RightPitDoor),
				new SCUnit(SCUnitId.FloorGunTrap),
				new SCUnit(SCUnitId.LeftWallMissileTrap),
				new SCUnit(SCUnitId.LeftWallFlameTrap),
				new SCUnit(SCUnitId.RightWallMissileTrap),
				new SCUnit(SCUnitId.RightWallFlameTrap),
				new SCUnit(SCUnitId.StartLocation),
				new SCUnit(SCUnitId.Flag),
				new SCUnit(SCUnitId.YoungChrysalis),
				new SCUnit(SCUnitId.PsiEmitter),
				new SCUnit(SCUnitId.DataDisc),
				new SCUnit(SCUnitId.KhaydarinCrystal),
				new SCUnit(SCUnitId.MineralClusterType1),
				new SCUnit(SCUnitId.MineralClusterType2),
				new SCUnit(SCUnitId.ProtossVespeneGasOrbType1),
				new SCUnit(SCUnitId.ProtossVespeneGasOrbType2),
				new SCUnit(SCUnitId.ZergVespeneGasSacType1),
				new SCUnit(SCUnitId.ZergVespeneGasSacType2),
				new SCUnit(SCUnitId.TerranVespeneGasTankType1),
				new SCUnit(SCUnitId.TerranVespeneGasTankType2),
			];
		}
	}
}
