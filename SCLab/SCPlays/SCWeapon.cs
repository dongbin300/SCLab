using SCLab.Enums;

namespace SCLab.SCPlays
{
	public class SCWeapon
	{
		public static readonly string[] IdString =
		{
			"GaussRifleNormal",
			"GaussRifleJimRaynorMarine",
			"C10ConcussionRifleNormal",
			"C10ConcussionRifleSarahKerrigan",
			"FragmentationGrenadeNormal",
			"FragmentationGrenadeJimRaynorVulture",
			"SpiderMines",
			"TwinAutocannonsNormal",
			"HellfireMissilePackNormal",
			"TwinAutocannonsAlanSchezar",
			"HellfireMissilePackAlanSchezar",
			"ArcliteCannonNormal",
			"ArcliteCannonEdmundDuke",
			"FusionCutter",
			"FusionCutterHarvest",
			"GeminiMissilesNormal",
			"BurstLasersNormal",
			"GeminiMissilesTomKazansky",
			"BurstLasersTomKazansky",
			"ATSLaserBatteryNormal",
			"ATALaserBatteryNormal",
			"ATSLaserBatteryNoradIIMengskDuGalle",
			"ATALaserBatteryNoradIIMengskDuGalle",
			"ATSLaserBatteryHyperion",
			"ATALaserBatteryHyperion",
			"FlameThrowerNormal",
			"FlameThrowerGuiMontag",
			"ArcliteShockCannonNormal",
			"ArcliteShockCannonEdmundDuke",
			"LongboltMissiles",
			"YamatoGun",
			"NuclearMissile",
			"Lockdown",
			"EMPShockwave",
			"Irradiate",
			"ClawsNormal",
			"ClawsDevouringOne",
			"ClawsInfestedKerrigan",
			"NeedleSpinesNormal",
			"NeedleSpinesHunterKiller",
			"KaiserBladesNormal",
			"KaiserBladesTorrasque",
			"ToxicSporesBroodling",
			"Spines",
			"SpinesHarvest",
			"AcidSprayUnused",
			"AcidSporeNormal",
			"AcidSporeKukulzaGuardian",
			"GlaveWurmNormal",
			"GlaveWurmKukulzaMutalisk",
			"VenomUnusedDefiler",
			"VenomUnusedDefilerHero",
			"SeekerSpores",
			"SubterraneanTentacle",
			"SuicideInfestedTerran",
			"SuicideScourge",
			"Parasite",
			"SpawnBroodlings",
			"Ensnare",
			"DarkSwarm",
			"Plague",
			"Consume",
			"ParticleBeam",
			"ParticleBeamHarvest",
			"PsiBladesNormal",
			"PsiBladesFenixZealot",
			"PhaseDisruptorNormal",
			"PhaseDisruptorFenixDragoon",
			"PsiAssaultNormalUnused",
			"PsiAssaultTassadarAldaris",
			"PsionicShockwaveNormal",
			"PsionicShockwaveTassadarZeratulArchon",
			"Unknown72",
			"DualPhotonBlastersNormal",
			"AntimatterMissilesNormal",
			"DualPhotonBlastersMojo",
			"AnitmatterMissilesMojo",
			"PhaseDisruptorCannonNormal",
			"PhaseDisruptorCannonDanimoth",
			"PulseCannon",
			"STSPhotonCannon",
			"STAPhotonCannon",
			"Scarab",
			"StasisField",
			"PsiStorm",
			"WarpBladesZeratul",
			"WarpBladesDarkTemplarHero",
			"MissilesUnused",
			"LaserBattery1Unused",
			"TormentorMissilesUnused",
			"BombsUnused",
			"RaiderGunUnused",
			"LaserBattery2Unused",
			"LaserBattery3Unused",
			"DualPhotonBlastersUnused",
			"FlechetteGrenadeUnused",
			"TwinAutocannonsFloorTrap",
			"HellfireMissilePackWallTrap",
			"FlameThrowerWallTrap",
			"HellfireMissilePackFloorTrap",
			"NeutronFlare",
			"DisruptionWeb",
			"Restoration",
			"HaloRockets",
			"CorrosiveAcid",
			"MindControl",
			"Feedback",
			"OpticalFlare",
			"Maelstrom",
			"SubterraneanSpines",
			"GaussRifle0Unused",
			"WarpBladesNormal",
			"C10ConcussionRifleSamirDuran",
			"C10ConcussionRifleInfestedDuran",
			"DualPhotonBlastersArtanis",
			"AntimatterMissilesArtanis",
			"C10ConcussionRifleAlexeiStukov",
			"GaussRifle1Unused",
			"GaussRifle2Unused",
			"GaussRifle3Unused",
			"GaussRifle4Unused",
			"GaussRifle5Unused",
			"GaussRifle6Unused",
			"GaussRifle7Unused",
			"GaussRifle8Unused",
			"GaussRifle9Unused",
			"GaussRifle10Unused",
			"GaussRifle11Unused",
			"GaussRifle12Unused",
			"GaussRifle13Unused",
			"None"
		};

		public SCWeaponId Id;
		public ushort Power;
		public ushort PowerBonus;

		public SCWeapon(SCWeaponId id)
		{
			Id = id;

			switch (id)
			{
				case SCWeaponId.GaussRifleNormal:
					Init(6, 1);
					break;
				case SCWeaponId.GaussRifleJimRaynorMarine:
					Init(18, 1);
					break;
				case SCWeaponId.C10ConcussionRifleNormal:
					Init(10, 1);
					break;
				case SCWeaponId.C10ConcussionRifleSarahKerrigan:
					Init(30, 1);
					break;
				case SCWeaponId.FragmentationGrenadeNormal:
					Init(20, 2);
					break;
				case SCWeaponId.FragmentationGrenadeJimRaynorVulture:
					Init(30, 2);
					break;
				case SCWeaponId.SpiderMines:
					Init(125, 0);
					break;
				case SCWeaponId.TwinAutocannonsNormal:
					Init(12, 1);
					break;
				case SCWeaponId.HellfireMissilePackNormal:
					Init(10, 2);
					break;
				case SCWeaponId.TwinAutocannonsAlanSchezar:
					Init(24, 1);
					break;
				case SCWeaponId.HellfireMissilePackAlanSchezar:
					Init(20, 1);
					break;
				case SCWeaponId.ArcliteCannonNormal:
					Init(30, 3);
					break;
				case SCWeaponId.ArcliteCannonEdmundDuke:
					Init(70, 3);
					break;
				case SCWeaponId.FusionCutter:
					Init(5, 1);
					break;
				case SCWeaponId.FusionCutterHarvest:
					Init(0, 0);
					break;
				case SCWeaponId.GeminiMissilesNormal:
					Init(20, 2);
					break;
				case SCWeaponId.BurstLasersNormal:
					Init(8, 1);
					break;
				case SCWeaponId.GeminiMissilesTomKazansky:
					Init(40, 2);
					break;
				case SCWeaponId.BurstLasersTomKazansky:
					Init(16, 1);
					break;
				case SCWeaponId.ATSLaserBatteryNormal:
					Init(25, 3);
					break;
				case SCWeaponId.ATALaserBatteryNormal:
					Init(25, 3);
					break;
				case SCWeaponId.ATSLaserBatteryNoradIIMengskDuGalle:
					Init(50, 3);
					break;
				case SCWeaponId.ATALaserBatteryNoradIIMengskDuGalle:
					Init(50, 3);
					break;
				case SCWeaponId.ATSLaserBatteryHyperion:
					Init(30, 3);
					break;
				case SCWeaponId.ATALaserBatteryHyperion:
					Init(30, 3);
					break;
				case SCWeaponId.FlameThrowerNormal:
					Init(8, 1);
					break;
				case SCWeaponId.FlameThrowerGuiMontag:
					Init(16, 1);
					break;
				case SCWeaponId.ArcliteShockCannonNormal:
					Init(70, 5);
					break;
				case SCWeaponId.ArcliteShockCannonEdmundDuke:
					Init(150, 5);
					break;
				case SCWeaponId.LongboltMissiles:
					Init(20, 0);
					break;
				case SCWeaponId.YamatoGun:
					Init(0, 0);
					break;
				case SCWeaponId.NuclearMissile:
					Init(0, 0);
					break;
				case SCWeaponId.Lockdown:
					Init(0, 0);
					break;
				case SCWeaponId.EMPShockwave:
					Init(0, 0);
					break;
				case SCWeaponId.Irradiate:
					Init(0, 0);
					break;
				case SCWeaponId.ClawsNormal:
					Init(5, 1);
					break;
				case SCWeaponId.ClawsDevouringOne:
					Init(10, 1);
					break;
				case SCWeaponId.ClawsInfestedKerrigan:
					Init(50, 1);
					break;
				case SCWeaponId.NeedleSpinesNormal:
					Init(10, 1);
					break;
				case SCWeaponId.NeedleSpinesHunterKiller:
					Init(20, 1);
					break;
				case SCWeaponId.KaiserBladesNormal:
					Init(20, 3);
					break;
				case SCWeaponId.KaiserBladesTorrasque:
					Init(50, 3);
					break;
				case SCWeaponId.ToxicSporesBroodling:
					Init(4, 1);
					break;
				case SCWeaponId.Spines:
					Init(5, 0);
					break;
				case SCWeaponId.SpinesHarvest:
					Init(0, 0);
					break;
				case SCWeaponId.AcidSprayUnused:
					Init(0, 0);
					break;
				case SCWeaponId.AcidSporeNormal:
					Init(20, 2);
					break;
				case SCWeaponId.AcidSporeKukulzaGuardian:
					Init(40, 2);
					break;
				case SCWeaponId.GlaveWurmNormal:
					Init(9, 1);
					break;
				case SCWeaponId.GlaveWurmKukulzaMutalisk:
					Init(18, 1);
					break;
				case SCWeaponId.VenomUnusedDefiler:
					Init(0, 0);
					break;
				case SCWeaponId.VenomUnusedDefilerHero:
					Init(0, 0);
					break;
				case SCWeaponId.SeekerSpores:
					Init(15, 0);
					break;
				case SCWeaponId.SubterraneanTentacle:
					Init(40, 0);
					break;
				case SCWeaponId.SuicideInfestedTerran:
					Init(500, 0);
					break;
				case SCWeaponId.SuicideScourge:
					Init(110, 0);
					break;
				case SCWeaponId.Parasite:
					Init(0, 0);
					break;
				case SCWeaponId.SpawnBroodlings:
					Init(0, 0);
					break;
				case SCWeaponId.Ensnare:
					Init(0, 0);
					break;
				case SCWeaponId.DarkSwarm:
					Init(0, 0);
					break;
				case SCWeaponId.Plague:
					Init(0, 0);
					break;
				case SCWeaponId.Consume:
					Init(0, 0);
					break;
				case SCWeaponId.ParticleBeam:
					Init(5, 0);
					break;
				case SCWeaponId.ParticleBeamHarvest:
					Init(0, 0);
					break;
				case SCWeaponId.PsiBladesNormal:
					Init(8, 1);
					break;
				case SCWeaponId.PsiBladesFenixZealot:
					Init(20, 1);
					break;
				case SCWeaponId.PhaseDisruptorNormal:
					Init(20, 2);
					break;
				case SCWeaponId.PhaseDisruptorFenixDragoon:
					Init(45, 2);
					break;
				case SCWeaponId.PsiAssaultNormalUnused:
					Init(0, 0);
					break;
				case SCWeaponId.PsiAssaultTassadarAldaris:
					Init(20, 1);
					break;
				case SCWeaponId.PsionicShockwaveNormal:
					Init(30, 3);
					break;
				case SCWeaponId.PsionicShockwaveTassadarZeratulArchon:
					Init(60, 3);
					break;
				case SCWeaponId.Unknown72:
					Init(0, 0);
					break;
				case SCWeaponId.DualPhotonBlastersNormal:
					Init(8, 1);
					break;
				case SCWeaponId.AntimatterMissilesNormal:
					Init(14, 1);
					break;
				case SCWeaponId.DualPhotonBlastersMojo:
					Init(20, 1);
					break;
				case SCWeaponId.AnitmatterMissilesMojo:
					Init(28, 1);
					break;
				case SCWeaponId.PhaseDisruptorCannonNormal:
					Init(10, 1);
					break;
				case SCWeaponId.PhaseDisruptorCannonDanimoth:
					Init(20, 1);
					break;
				case SCWeaponId.PulseCannon:
					Init(46, 1);
					break;
				case SCWeaponId.STSPhotonCannon:
					Init(20, 0);
					break;
				case SCWeaponId.STAPhotonCannon:
					Init(20, 0);
					break;
				case SCWeaponId.Scarab:
					Init(100, 25);
					break;
				case SCWeaponId.StasisField:
					Init(0, 0);
					break;
				case SCWeaponId.PsiStorm:
					Init(0, 0);
					break;
				case SCWeaponId.WarpBladesZeratul:
					Init(100, 1);
					break;
				case SCWeaponId.WarpBladesDarkTemplarHero:
					Init(45, 1);
					break;
				case SCWeaponId.MissilesUnused:
					Init(0, 0);
					break;
				case SCWeaponId.LaserBattery1Unused:
					Init(0, 0);
					break;
				case SCWeaponId.TormentorMissilesUnused:
					Init(0, 0);
					break;
				case SCWeaponId.BombsUnused:
					Init(0, 0);
					break;
				case SCWeaponId.RaiderGunUnused:
					Init(0, 0);
					break;
				case SCWeaponId.LaserBattery2Unused:
					Init(7, 1);
					break;
				case SCWeaponId.LaserBattery3Unused:
					Init(7, 1);
					break;
				case SCWeaponId.DualPhotonBlastersUnused:
					Init(0, 0);
					break;
				case SCWeaponId.FlechetteGrenadeUnused:
					Init(0, 0);
					break;
				case SCWeaponId.TwinAutocannonsFloorTrap:
					Init(10, 1);
					break;
				case SCWeaponId.HellfireMissilePackWallTrap:
					Init(10, 1);
					break;
				case SCWeaponId.FlameThrowerWallTrap:
					Init(8, 1);
					break;
				case SCWeaponId.HellfireMissilePackFloorTrap:
					Init(10, 1);
					break;
				case SCWeaponId.NeutronFlare:
					Init(5, 1);
					break;
				case SCWeaponId.DisruptionWeb:
					Init(0, 0);
					break;
				case SCWeaponId.Restoration:
					Init(0, 0);
					break;
				case SCWeaponId.HaloRockets:
					Init(6, 1);
					break;
				case SCWeaponId.CorrosiveAcid:
					Init(25, 2);
					break;
				case SCWeaponId.MindControl:
					Init(0, 0);
					break;
				case SCWeaponId.Feedback:
					Init(0, 0);
					break;
				case SCWeaponId.OpticalFlare:
					Init(0, 0);
					break;
				case SCWeaponId.Maelstrom:
					Init(0, 0);
					break;
				case SCWeaponId.SubterraneanSpines:
					Init(20, 2);
					break;
				case SCWeaponId.GaussRifle0Unused:
					Init(0, 0);
					break;
				case SCWeaponId.WarpBladesNormal:
					Init(40, 3);
					break;
				case SCWeaponId.C10ConcussionRifleSamirDuran:
					Init(25, 1);
					break;
				case SCWeaponId.C10ConcussionRifleInfestedDuran:
					Init(25, 1);
					break;
				case SCWeaponId.DualPhotonBlastersArtanis:
					Init(20, 1);
					break;
				case SCWeaponId.AntimatterMissilesArtanis:
					Init(28, 1);
					break;
				case SCWeaponId.C10ConcussionRifleAlexeiStukov:
					Init(30, 1);
					break;
				case SCWeaponId.GaussRifle1Unused:
					Init(0, 0);
					break;
				case SCWeaponId.GaussRifle2Unused:
					Init(0, 0);
					break;
				case SCWeaponId.GaussRifle3Unused:
					Init(0, 0);
					break;
				case SCWeaponId.GaussRifle4Unused:
					Init(0, 0);
					break;
				case SCWeaponId.GaussRifle5Unused:
					Init(0, 0);
					break;
				case SCWeaponId.GaussRifle6Unused:
					Init(0, 0);
					break;
				case SCWeaponId.GaussRifle7Unused:
					Init(0, 0);
					break;
				case SCWeaponId.GaussRifle8Unused:
					Init(0, 0);
					break;
				case SCWeaponId.GaussRifle9Unused:
					Init(0, 0);
					break;
				case SCWeaponId.GaussRifle10Unused:
					Init(0, 0);
					break;
				case SCWeaponId.GaussRifle11Unused:
					Init(0, 0);
					break;
				case SCWeaponId.GaussRifle12Unused:
					Init(0, 0);
					break;
				case SCWeaponId.GaussRifle13Unused:
					Init(0, 0);
					break;
				case SCWeaponId.None:
					Init(0, 0);
					break;
			}
		}

		public void Init(ushort power, ushort powerBonus)
		{
			Power = power;
			PowerBonus = powerBonus;
		}
	}
}
