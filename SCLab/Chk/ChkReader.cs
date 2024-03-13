using SCLab.Enums;
using SCLab.Extensions;
using SCLab.SCPlays;
using SCLab.SCRegions;
using SCLab.SCScripts;

using System.Text;

namespace SCLab.Chk
{
	public class ChkReader
	{
		public static Encoding BaseEncoding = Encoding.ASCII;

		public ChkFileInfo Read(string chkFileName)
		{
			var chkFileInfo = new ChkFileInfo();
			var data = File.ReadAllBytes(chkFileName);

			int offset = 0;
			while (offset < data.Length)
			{
				string chunkName = BaseEncoding.GetString(data, offset, 4);
				offset += 4;

				int chunkLength = BitConverter.ToInt32(data, offset);
				offset += 4;

				byte[] chunkData = new byte[chunkLength];
				Buffer.BlockCopy(data, offset, chunkData, 0, chunkLength);
				offset += chunkLength;

				chkFileInfo.Chunks.Add(new Chunk(chunkName, chunkLength, chunkData));
			}

			foreach (var chunk in chkFileInfo.Chunks)
			{
				var chunkData = chunk.Data;
				switch (chunk.Name)
				{
					case "TYPE":
						chkFileInfo.ScenarioType = chunkData.ToUInt() switch
						{
							0x53574152 => SCScenarioType.StarCraft104Hybrid,
							0x42574152 => SCScenarioType.BroodWar,
							_ => SCScenarioType.Unknown
						};
						break;

					case "VER ":
						chkFileInfo.FileFormatVersion = chunkData.ToUShort() switch
						{
							59 => SCFileFormatVersion.StarCraft100,
							63 => SCFileFormatVersion.Hybrid,
							205 => SCFileFormatVersion.BroodWar,
							206 => SCFileFormatVersion.Remastered,
							_ => SCFileFormatVersion.Unknown
						};
						chkFileInfo.UpgradeSet = new SCUpgradeSet(chkFileInfo.FileFormatVersion);
						chkFileInfo.TechSet = new SCTechSet(chkFileInfo.FileFormatVersion);
						chkFileInfo.LocationSet = new SCLocationSet(chkFileInfo.FileFormatVersion);
						break;

					case "IVER":
					case "IVE2":
						chkFileInfo.MapVersion = chunkData.ToUShort() switch
						{
							9 => SCMapVersion.Beta,
							10 => SCMapVersion.StarCraft100,
							11 => SCMapVersion.StarCraft104Above,
							_ => SCMapVersion.Unknown
						};
						break;

					case "VCOD":
						for (int i = 0; i < chkFileInfo.Seed.Length; i++)
						{
							chkFileInfo.Seed[i] = chunkData.ToUInt(i * 4);
						}
						chkFileInfo.OperationCode = chunkData.Substring(4 * 256);
						break;

					case "IOWN":
						for (int i = 0; i < chkFileInfo.StarEditPlayerTypes.Length; i++)
						{
							chkFileInfo.StarEditPlayerTypes[i] = chunkData[i] switch
							{
								0 => SCPlayerType.Inactive,
								1 => SCPlayerType.ComputerGame,
								2 => SCPlayerType.OccupiedByHumanPlayer,
								3 => SCPlayerType.RescuePassive,
								4 => SCPlayerType.Unused,
								5 => SCPlayerType.Computer,
								6 => SCPlayerType.Human,
								7 => SCPlayerType.Neutral,
								8 => SCPlayerType.ClosedSlot,
								_ => SCPlayerType.Unknown
							};
						}
						break;

					case "OWNR":
						for (int i = 0; i < chkFileInfo.StarCraftPlayerTypes.Length; i++)
						{
							chkFileInfo.StarCraftPlayerTypes[i] = chunkData[i] switch
							{
								0 => SCPlayerType.Inactive,
								1 => SCPlayerType.ComputerGame,
								2 => SCPlayerType.OccupiedByHumanPlayer,
								3 => SCPlayerType.RescuePassive,
								4 => SCPlayerType.Unused,
								5 => SCPlayerType.Computer,
								6 => SCPlayerType.Human,
								7 => SCPlayerType.Neutral,
								8 => SCPlayerType.ClosedSlot,
								_ => SCPlayerType.Unknown
							};
						}
						break;

					case "ERA ":
						chkFileInfo.TileSet = chunkData.ToUShort() switch
						{
							0 => SCMapTileSet.Badlands,
							1 => SCMapTileSet.SpacePlatform,
							2 => SCMapTileSet.Installation,
							3 => SCMapTileSet.Ashworld,
							4 => SCMapTileSet.Jungle,
							5 => SCMapTileSet.Desert,
							6 => SCMapTileSet.Arctic,
							7 => SCMapTileSet.Twilight,
							_ => SCMapTileSet.Unknown,
						};
						break;

					case "DIM ":
						chkFileInfo.MapWidth = chunkData.ToUShort();
						chkFileInfo.MapHeight = chunkData.ToUShort(2);
						break;

					case "SIDE":
						for (int i = 0; i < chkFileInfo.PlayerSpecies.Length; i++)
						{
							chkFileInfo.PlayerSpecies[i] = chunk.Data[i] switch
							{
								0 => SCPlayerSpecies.Zerg,
								1 => SCPlayerSpecies.Terran,
								2 => SCPlayerSpecies.Protoss,
								3 => SCPlayerSpecies.Independent,
								4 => SCPlayerSpecies.Neutral,
								5 => SCPlayerSpecies.UserSelectable,
								6 => SCPlayerSpecies.Random,
								7 => SCPlayerSpecies.Inactive,
								_ => SCPlayerSpecies.Unknown,
							};
						}
						break;

					case "MTXM":
						chkFileInfo.Tiles = new ushort[chkFileInfo.MapWidth * chkFileInfo.MapHeight];
						for (int i = 0; i < chkFileInfo.Tiles.Length; i++)
						{
							chkFileInfo.Tiles[i] = chunkData.ToUShort(i * 2);
						}
						break;

					case "PUNI":
						int puniOffset = 0;
						for (int i = 0; i < chkFileInfo.UnitSet.Units.Length; i++)
						{
							var unit = chkFileInfo.UnitSet.Units[i];
							for (int j = 0; j < unit.PlayerAvailables.Length; j++)
							{
								unit.PlayerAvailables[j] = chunkData[puniOffset++];
							}
						}
						for (int i = 0; i < chkFileInfo.UnitSet.Units.Length; i++)
						{
							var unit = chkFileInfo.UnitSet.Units[i];
							unit.GlobalAvailable = chunkData[puniOffset++];
						}
						for (int i = 0; i < chkFileInfo.UnitSet.Units.Length; i++)
						{
							var unit = chkFileInfo.UnitSet.Units[i];
							for (int j = 0; j < unit.UseDefaults.Length; j++)
							{
								unit.UseDefaults[j] = chunkData[puniOffset++];
							}
						}
						break;

					case "UPGR":
						int upgrOffset = 0;
						for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
						{
							var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
							for (int j = 0; j < upgrade.PlayerMaxLevels.Length; j++)
							{
								upgrade.PlayerMaxLevels[j] = chunkData[upgrOffset++];
							}
						}
						for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
						{
							var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
							for (int j = 0; j < upgrade.PlayerStartLevels.Length; j++)
							{
								upgrade.PlayerStartLevels[j] = chunkData[upgrOffset++];
							}
						}
						for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
						{
							var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
							upgrade.GlobalMaxLevel = chunkData[upgrOffset++];
						}
						for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
						{
							var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
							upgrade.GlobalStartLevel = chunkData[upgrOffset++];
						}
						for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
						{
							var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
							for (int j = 0; j < upgrade.UseDefaults.Length; j++)
							{
								upgrade.UseDefaults[j] = chunkData[upgrOffset++];
							}
						}
						break;

					case "PTEC":
						var ptecOffset = 0;
						for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
						{
							var tech = chkFileInfo.TechSet.Techs[i];
							for (int j = 0; j < tech.PlayerAvailables.Length; j++)
							{
								tech.PlayerAvailables[j] = chunkData[ptecOffset++];
							}
						}
						for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
						{
							var tech = chkFileInfo.TechSet.Techs[i];
							for (int j = 0; j < tech.PlayerResearched.Length; j++)
							{
								tech.PlayerResearched[j] = chunkData[ptecOffset++];
							}
						}
						for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
						{
							var tech = chkFileInfo.TechSet.Techs[i];
							tech.GlobalAvailable = chunkData[ptecOffset++];
						}
						for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
						{
							var tech = chkFileInfo.TechSet.Techs[i];
							tech.GlobalResearched = chunkData[ptecOffset++];
						}
						for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
						{
							var tech = chkFileInfo.TechSet.Techs[i];
							for (int j = 0; j < tech.UseDefaults.Length; j++)
							{
								tech.UseDefaults[j] = chunkData[ptecOffset++];
							}
						}
						break;

					case "UNIT":
						break;

					case "ISOM":
						chkFileInfo.RectangleTiles = new ushort[(chkFileInfo.MapWidth / 2 + 1) * (chkFileInfo.MapHeight + 1) * 4];
						for (int i = 0; i < chkFileInfo.RectangleTiles.Length; i++)
						{
							chkFileInfo.RectangleTiles[i] = chunkData.ToUShort(i * 2);
						}
						break;

					case "TILE":
						chkFileInfo.MapTiles = new ushort[chkFileInfo.MapWidth * chkFileInfo.MapHeight];
						for (int i = 0; i < chkFileInfo.MapTiles.Length; i++)
						{
							chkFileInfo.MapTiles[i] = chunkData.ToUShort(i * 2);
						}
						break;

					case "DD2 ":
						break;

					case "THG2":
						break;

					case "MASK":
						chkFileInfo.Fogs = new SCFogs[chkFileInfo.MapWidth * chkFileInfo.MapHeight];
						for (int i = 0; i < chkFileInfo.Fogs.Length; i++)
						{
							chkFileInfo.Fogs[i] = (SCFogs)chunkData[i];
						}
						break;

					case "STR ":
						var strOffset = 0;
						chkFileInfo.StringSet = new SCStringSet(chunkData.ToUShort(strOffset));
						strOffset += 2;
						for (int i = 0; i < chkFileInfo.StringSet.Strings.Length; i++)
						{
							var _string = chkFileInfo.StringSet.Strings[i];
							_string.Offset = chunkData.ToUShort(strOffset);
							strOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.StringSet.Strings.Length; i++)
						{
							var _string = chkFileInfo.StringSet.Strings[i];
							_string.Data = chunkData.GetString((int)_string.Offset);
						}
						break;

					case "UPRP":
						var uprpOffset = 0;
						for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
						{
							var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
							cuwp.SpecialProperties = (SCUnitSpecialProperties)chunkData.ToUShort(uprpOffset);
							uprpOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
						{
							var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
							cuwp.ChangedProperties = (SCUnitChangedProperties)chunkData.ToUShort(uprpOffset);
							uprpOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
						{
							var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
							cuwp.Owner = chunkData[uprpOffset++];
						}
						for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
						{
							var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
							cuwp.Hp = chunkData[uprpOffset++];
						}
						for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
						{
							var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
							cuwp.Shield = chunkData[uprpOffset++];
						}
						for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
						{
							var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
							cuwp.Energy = chunkData[uprpOffset++];
						}
						for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
						{
							var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
							cuwp.ResourceAmount = chunkData.ToUInt(uprpOffset);
							uprpOffset += 4;
						}
						for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
						{
							var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
							cuwp.Hangar = chunkData.ToUShort(uprpOffset);
							uprpOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
						{
							var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
							cuwp.Status = (SCUnitStatus)chunkData.ToUShort(uprpOffset);
							uprpOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
						{
							var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
							cuwp.UnknownUnused = chunkData.ToUInt(uprpOffset);
							uprpOffset += 4;
						}
						break;

					case "UPUS":
						for (int i = 0; i < chkFileInfo.CUWPSet.UsePropertySlots.Length; i++)
						{
							chkFileInfo.CUWPSet.UsePropertySlots[i] = chunkData[i];
						}
						break;

					case "MRGN":
						int mrgnOffset = 0;
						for (int i = 0; i < chkFileInfo.LocationSet.Locations.Length; i++)
						{
							var location = chkFileInfo.LocationSet.Locations[i];
							location.Left = chunkData.ToUInt(mrgnOffset);
							mrgnOffset += 4;
							location.Top = chunkData.ToUInt(mrgnOffset);
							mrgnOffset += 4;
							location.Right = chunkData.ToUInt(mrgnOffset);
							mrgnOffset += 4;
							location.Bottom = chunkData.ToUInt(mrgnOffset);
							mrgnOffset += 4;
							location.StringNumber = chunkData.ToUShort(mrgnOffset);
							mrgnOffset += 2;
							location.Elevations = (SCElevations)chunkData.ToUShort(mrgnOffset);
							mrgnOffset += 2;
						}
						break;

					case "TRIG":
						break;

					case "MBRF":
						break;

					case "SPRP":
						chkFileInfo.Scenario.NameStringNumber = chunkData.ToUShort();
						chkFileInfo.Scenario.DescriptionStringNumber = chunkData.ToUShort(2);
						break;

					case "FORC":
						var forcOffset = 0;
						for (int i = 0; i < chkFileInfo.ForceNumbers.Length; i++)
						{
							chkFileInfo.ForceNumbers[i] = chunkData[forcOffset++];
						}
						for (int i = 0; i < chkFileInfo.ForceSet.Forces.Length; i++)
						{
							chkFileInfo.ForceSet.Forces[i].NameStringNumbers = chunkData.ToUShort(forcOffset);
							forcOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.ForceSet.Forces.Length; i++)
						{
							chkFileInfo.ForceSet.Forces[i].Properties = (SCForceProperties)chunkData[forcOffset++];
						}
						break;

					case "WAV ":
						var wavOffset = 0;
						for (int i = 0; i < chkFileInfo.WavSet.Wavs.Length; i++)
						{
							var wav = chkFileInfo.WavSet.Wavs[i];
							wav.MpqPath = chunkData.ToUInt(wavOffset);
							wavOffset += 4;
						}
						break;

					case "UNIS": // 왜 4048 바이트인지 확인필요
						break;
						int unisOffset = 0;
						for (int i = 0; i < chkFileInfo.UnitSet.Units.Length; i++)
						{
							var unit = chkFileInfo.UnitSet.Units[i];
							unit.SettingRule = chunkData[unisOffset++] switch
							{
								0 => SCRuleSetting.Custom,
								1 => SCRuleSetting.Default,
								_ => SCRuleSetting.Unknown
							};
						}
						for (int i = 0; i < chkFileInfo.UnitSet.Units.Length; i++)
						{
							var unit = chkFileInfo.UnitSet.Units[i];
							// 표시된 값은 이 값 / 256이며, 낮은 바이트는 분수 HP 값입니다.
							unit.Hp = chunkData.ToUInt(unisOffset);
							unisOffset += 4;
						}
						for (int i = 0; i < chkFileInfo.UnitSet.Units.Length; i++)
						{
							var unit = chkFileInfo.UnitSet.Units[i];
							unit.Shield = chunkData.ToUShort(unisOffset);
							unisOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.UnitSet.Units.Length; i++)
						{
							var unit = chkFileInfo.UnitSet.Units[i];
							unit.Armor = chunkData[unisOffset++];
						}
						for (int i = 0; i < chkFileInfo.UnitSet.Units.Length; i++)
						{
							var unit = chkFileInfo.UnitSet.Units[i];
							// 1/60초
							unit.BuildTime = chunkData.ToUShort(unisOffset);
							unisOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.UnitSet.Units.Length; i++)
						{
							var unit = chkFileInfo.UnitSet.Units[i];
							unit.Mineral = chunkData.ToUShort(unisOffset);
							unisOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.UnitSet.Units.Length; i++)
						{
							var unit = chkFileInfo.UnitSet.Units[i];
							unit.Gas = chunkData.ToUShort(unisOffset);
							unisOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.UnitSet.Units.Length; i++)
						{
							var unit = chkFileInfo.UnitSet.Units[i];
							unit.StringNumber = chunkData.ToUShort(unisOffset);
							unisOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.UnitSet.Units.Length; i++)
						{
							var unit = chkFileInfo.UnitSet.Units[i];
							unit.BaseWeaponDamage = chunkData.ToUShort(unisOffset);
							unisOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.UnitSet.Units.Length; i++)
						{
							var unit = chkFileInfo.UnitSet.Units[i];
							unit.BonusWeaponDamage = chunkData.ToUShort(unisOffset);
							unisOffset += 2;
						}
						break;

					case "UPGS":
						int upgsOffset = 0;
						for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
						{
							var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
							upgrade.SettingRule = chunkData[upgsOffset++] switch
							{
								0 => SCRuleSetting.Custom,
								1 => SCRuleSetting.Default,
								_ => SCRuleSetting.Unknown
							};
						}
						for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
						{
							var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
							upgrade.Mineral = chunkData.ToUShort(upgsOffset);
							upgsOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
						{
							var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
							upgrade.MineralBonus = chunkData.ToUShort(upgsOffset);
							upgsOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
						{
							var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
							upgrade.Gas = chunkData.ToUShort(upgsOffset);
							upgsOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
						{
							var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
							upgrade.GasBonus = chunkData.ToUShort(upgsOffset);
							upgsOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
						{
							var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
							upgrade.Time = chunkData.ToUShort(upgsOffset);
							upgsOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
						{
							var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
							upgrade.TimeBonus = chunkData.ToUShort(upgsOffset);
							upgsOffset += 2;
						}
						break;

					case "TECS":
						var tecsOffset = 0;
						for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
						{
							var tech = chkFileInfo.TechSet.Techs[i];
							tech.SettingRule = chunkData[tecsOffset++] switch
							{
								0 => SCRuleSetting.Custom,
								1 => SCRuleSetting.Default,
								_ => SCRuleSetting.Unknown
							};
						}
						for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
						{
							var tech = chkFileInfo.TechSet.Techs[i];
							tech.Mineral = chunkData.ToUShort(tecsOffset);
							tecsOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
						{
							var tech = chkFileInfo.TechSet.Techs[i];
							tech.Gas = chunkData.ToUShort(tecsOffset);
							tecsOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
						{
							var tech = chkFileInfo.TechSet.Techs[i];
							tech.Time = chunkData.ToUShort(tecsOffset);
							tecsOffset += 2;
						}
						for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
						{
							var tech = chkFileInfo.TechSet.Techs[i];
							tech.Energy = chunkData.ToUShort(tecsOffset);
							tecsOffset += 2;
						}
						break;

					case "SWNM":
						for (int i = 0; i < chkFileInfo.SwitchSet.Switches.Length; i++)
						{
							var _switch = chkFileInfo.SwitchSet.Switches[i];
							_switch.NameStringNumber = chunkData.ToUInt(i * 4);
						}
						break;

					default:
						break;
				}
			}

			return chkFileInfo;
		}
	}
}
