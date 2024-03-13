using SCLab.Chk;
using SCLab.Enums;
using SCLab.Extensions;
using SCLab.SCPlays;

using System.Windows;
using System.Windows.Controls;

namespace MapReader
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		ChkFileInfo chkFileInfo;
		public MainWindow()
		{
			InitializeComponent();

			var reader = new ChkReader();
			chkFileInfo = reader.Read("Samples/RawStarcraftMap.chk");

			ChunkListBox.ItemsSource = chkFileInfo.Chunks;
		}

		void Info(string name, string description, string value)
		{
			var item = new ContentItem(name, description, value);
			InfoDataGrid.Items.Add(item);
		}

		private void ChunkListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (e.AddedItems.Count == 0)
			{
				return;
			}

			if (e.AddedItems[0] is not Chunk chunk)
			{
				return;
			}

			ChunkNameText.Text = chunk.Name;
			ChunkDescriptionText.Text = chunk.Description;

			InfoDataGrid.Items.Clear();
			switch (chunk.Name)
			{
				case "TYPE":
					Info("ScenarioType", "시나리오 타입", chkFileInfo.ScenarioType.ToString());
					break;

				case "VER ":
					Info("FileFormatVersion", "맵파일 포맷 버전", chkFileInfo.FileFormatVersion.ToString());
					break;

				case "IVER":
				case "IVE2":
					Info("MapVersion", "맵 버전", chkFileInfo.MapVersion.ToString());
					break;

				case "VCOD":
					for (int i = 0; i < chkFileInfo.Seed.Length; i++)
					{
						Info($"Seed[{i}]", $"시드 {i + 1}", chkFileInfo.Seed[i].ToString());
					}
					Info("OperationCode", "오퍼레이션 코드", chkFileInfo.OperationCode.ByteToString());
					break;

				case "IOWN":
					for (int i = 0; i < chkFileInfo.StarEditPlayerTypes.Length; i++)
					{
						Info($"StarEditPlayerTypes[{i}]", $"플레이어 {i + 1} 타입", chkFileInfo.StarEditPlayerTypes[i].ToString());
					}
					break;

				case "OWNR":
					for (int i = 0; i < chkFileInfo.StarCraftPlayerTypes.Length; i++)
					{
						Info($"StarCraftPlayerTypes[{i}]", $"플레이어 {i + 1} 타입", chkFileInfo.StarCraftPlayerTypes[i].ToString());
					}
					break;

				case "ERA ":
					Info("TileSet", "타일", chkFileInfo.TileSet.ToString());
					break;

				case "DIM ":
					Info("MapWidth", "맵 가로 크기", chkFileInfo.MapWidth.ToString());
					Info("MapHeight", "맵 세로 크기", chkFileInfo.MapHeight.ToString());
					break;

				case "SIDE":
					for (int i = 0; i < chkFileInfo.PlayerSpecies.Length; i++)
					{
						Info($"PlayerSpecies[{i}]", $"플레이어 {i + 1} 종족", chkFileInfo.PlayerSpecies[i].ToString());
					}
					break;

				case "MTXM":
					for (int i = 0; i < chkFileInfo.Tiles.Length; i++)
					{
						Info($"Tiles[{i}]", $"타일 {i + 1}", chkFileInfo.Tiles[i].ToString());
					}
					break;

				case "PUNI":
					for (int i = 0; i < chkFileInfo.UnitSet.Units.Length; i++)
					{
						var unit = chkFileInfo.UnitSet.Units[i];
						for (int j = 0; j < unit.PlayerAvailables.Length; j++)
						{
							Info($"PlayerAvailables[{i}][{j}]", $"플레이어 {j + 1} {SCUnit.IdString[i]} 생산가능", unit.PlayerAvailables[j].ToString());
						}
					}
					for (int i = 0; i < chkFileInfo.UnitSet.Units.Length; i++)
					{
						var unit = chkFileInfo.UnitSet.Units[i];
						Info($"GlobalAvailable[{i}]", $"일반적 {SCUnit.IdString[i]} 생산가능", unit.GlobalAvailable.ToString());
					}
					for (int i = 0; i < chkFileInfo.UnitSet.Units.Length; i++)
					{
						var unit = chkFileInfo.UnitSet.Units[i];
						for (int j = 0; j < unit.UseDefaults.Length; j++)
						{
							Info($"UseDefaults[{i}][{j}]", $"플레이어 {j + 1} {SCUnit.IdString[i]} 일반룰", unit.UseDefaults[j].ToString());
						}
					}
					break;

				case "UPGR":
					for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
					{
						var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
						for (int j = 0; j < upgrade.PlayerMaxLevels.Length; j++)
						{
							Info($"PlayerMaxLevels[{i}][{j}]", $"플레이어 {j + 1} {SCUpgrade.IdString[i]} 최대레벨", upgrade.PlayerMaxLevels[j].ToString());
						}
					}
					for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
					{
						var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
						for (int j = 0; j < upgrade.PlayerStartLevels.Length; j++)
						{
							Info($"PlayerStartLevels[{i}][{j}]", $"플레이어 {j + 1} {SCUpgrade.IdString[i]} 시작레벨", upgrade.PlayerStartLevels[j].ToString());
						}
					}
					for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
					{
						var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
						Info($"GlobalMaxLevel[{i}]", $"일반적 {SCUpgrade.IdString[i]} 최대레벨", upgrade.GlobalMaxLevel.ToString());
					}
					for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
					{
						var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
						Info($"GlobalStartLevel[{i}]", $"일반적 {SCUpgrade.IdString[i]} 시작레벨", upgrade.GlobalStartLevel.ToString());
					}
					for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
					{
						var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
						for (int j = 0; j < upgrade.UseDefaults.Length; j++)
						{
							Info($"UseDefaults[{i}][{j}]", $"플레이어 {j + 1} {SCUpgrade.IdString[i]} 일반룰", upgrade.UseDefaults[j].ToString());
						}
					}
					break;

				case "PTEC":
					for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
					{
						var tech = chkFileInfo.TechSet.Techs[i];
						for (int j = 0; j < tech.PlayerAvailables.Length; j++)
						{
							Info($"PlayerAvailables[{i}][{j}]", $"플레이어 {j + 1} {SCTech.IdString[i]} 개발가능", tech.PlayerAvailables[j].ToString());
						}
					}
					for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
					{
						var tech = chkFileInfo.TechSet.Techs[i];
						for (int j = 0; j < tech.PlayerResearched.Length; j++)
						{
							Info($"PlayerResearched[{i}][{j}]", $"플레이어 {j + 1} {SCTech.IdString[i]} 개발완료", tech.PlayerResearched[j].ToString());
						}
					}
					for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
					{
						var tech = chkFileInfo.TechSet.Techs[i];
						Info($"GlobalAvailable[{i}]", $"일반적 {SCTech.IdString[i]} 개발가능", tech.GlobalAvailable.ToString());
					}
					for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
					{
						var tech = chkFileInfo.TechSet.Techs[i];
						Info($"GlobalResearched[{i}]", $"일반적 {SCTech.IdString[i]} 개발완료", tech.GlobalResearched.ToString());
					}
					for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
					{
						var tech = chkFileInfo.TechSet.Techs[i];
						for (int j = 0; j < tech.UseDefaults.Length; j++)
						{
							Info($"UseDefaults[{i}][{j}]", $"플레이어 {j + 1} {SCTech.IdString[i]} 일반룰", tech.UseDefaults[j].ToString());
						}
					}
					break;

				case "ISOM":
					for (int i = 0; i < chkFileInfo.RectangleTiles.Length; i++)
					{
						Info($"RectangleTiles[{i}]", $"타일 {i + 1}", chkFileInfo.RectangleTiles[i].ToString());
					}
					break;

				case "TILE":
					for (int i = 0; i < chkFileInfo.MapTiles.Length; i++)
					{
						Info($"MapTiles[{i}]", $"타일 {i + 1}", chkFileInfo.MapTiles[i].ToString());
					}
					break;

				case "MASK":
					for (int i = 0; i < chkFileInfo.Fogs.Length; i++)
					{
						Info($"Fogs[{i}]", $"안개 {i + 1}", chkFileInfo.Fogs[i].ToString());
					}
					break;

				case "STR ":
					for (int i = 0; i < chkFileInfo.StringSet.Strings.Length; i++)
					{
						var _string = chkFileInfo.StringSet.Strings[i];
						Info($"Offset[{i}]", $"스트링 {i + 1} 오프셋", _string.Offset.ToString());
					}
					for (int i = 0; i < chkFileInfo.StringSet.Strings.Length; i++)
					{
						var _string = chkFileInfo.StringSet.Strings[i];
						Info($"Data[{i}]", $"스트링 {i + 1} 데이터", _string.Data.ToString());
					}
					break;

				case "UPRP":
					for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
					{
						var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
						Info($"SpecialProperties[{i}]", $"CUWP 슬롯 {i + 1} 특별속성", cuwp.SpecialProperties.ToString());
					}
					for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
					{
						var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
						Info($"ChangedProperties[{i}]", $"CUWP 슬롯 {i + 1} 변경속성", cuwp.ChangedProperties.ToString());
					}
					for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
					{
						var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
						Info($"Owner[{i}]", $"CUWP 슬롯 {i + 1} 소유 플레이어", cuwp.Owner.ToString());
					}
					for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
					{
						var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
						Info($"Hp[{i}]", $"CUWP 슬롯 {i + 1} HP", cuwp.Hp.ToString());
					}
					for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
					{
						var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
						Info($"Shield[{i}]", $"CUWP 슬롯 {i + 1} 쉴드", cuwp.Shield.ToString());
					}
					for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
					{
						var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
						Info($"Energy[{i}]", $"CUWP 슬롯 {i + 1} 에너지", cuwp.Energy.ToString());
					}
					for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
					{
						var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
						Info($"ResourceAmount[{i}]", $"CUWP 슬롯 {i + 1} 자원량", cuwp.ResourceAmount.ToString());
					}
					for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
					{
						var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
						Info($"Hangar[{i}]", $"CUWP 슬롯 {i + 1} 행거(스캐럽, 인터셉터)", cuwp.Hangar.ToString());
					}
					for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
					{
						var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
						Info($"Status[{i}]", $"CUWP 슬롯 {i + 1} 상태", cuwp.Status.ToString());
					}
					for (int i = 0; i < chkFileInfo.CUWPSet.CUWPs.Length; i++)
					{
						var cuwp = chkFileInfo.CUWPSet.CUWPs[i];
						Info($"UnknownUnused[{i}]", $"CUWP 슬롯 {i + 1} 몰?루", cuwp.UnknownUnused.ToString());
					}
					break;

				case "UPUS":
					for (int i = 0; i < chkFileInfo.CUWPSet.UsePropertySlots.Length; i++)
					{
						Info($"UsePropertySlots[{i}]", $"CUWP 슬롯 {i + 1} 사용", chkFileInfo.CUWPSet.UsePropertySlots[i].ToString());
					}
					break;

				case "MRGN":
					for (int i = 0; i < chkFileInfo.LocationSet.Locations.Length; i++)
					{
						var location = chkFileInfo.LocationSet.Locations[i];
						Info($"Left[{i}]", $"로케이션 {i + 1} (x1)", location.Left.ToString());
						Info($"Top[{i}]", $"로케이션 {i + 1} (y1)", location.Top.ToString());
						Info($"Right[{i}]", $"로케이션 {i + 1} (x2)", location.Right.ToString());
						Info($"Bottom[{i}]", $"로케이션 {i + 1} (y2)", location.Bottom.ToString());
						Info($"StringNumber[{i}]", $"로케이션 {i + 1} 이름 스트링#", location.StringNumber.ToString());
						Info($"Elevations[{i}]", $"로케이션 {i + 1} 적용범위", location.Elevations.ToString());
					}
					break;

				case "SPRP":
					Info("NameStringNumber", "시나리오 이름 스트링#", chkFileInfo.Scenario.NameStringNumber.ToString());
					Info("DescriptionStringNumber", "시나리오 설명 스트링#", chkFileInfo.Scenario.DescriptionStringNumber.ToString());
					break;

				case "FORC":
					for (int i = 0; i < chkFileInfo.ForceNumbers.Length; i++)
					{
						Info($"ForceNumbers[{i}]", $"플레이어 {i + 1} 포스#", chkFileInfo.ForceNumbers[i].ToString());
					}
					for (int i = 0; i < chkFileInfo.ForceSet.Forces.Length; i++)
					{
						Info($"NameStringNumbers[{i}]", $"포스 {i + 1} 이름 스트링#", chkFileInfo.ForceSet.Forces[i].NameStringNumbers.ToString());
					}
					for (int i = 0; i < chkFileInfo.ForceSet.Forces.Length; i++)
					{
						Info($"Properties[{i}]", $"포스 {i + 1} 속성", chkFileInfo.ForceSet.Forces[i].Properties.ToString());
					}
					break;

				case "WAV ":
					for (int i = 0; i < chkFileInfo.WavSet.Wavs.Length; i++)
					{
						var wav = chkFileInfo.WavSet.Wavs[i];
						Info($"MpqPath[{i}]", $"WAV {i + 1} 위치(MPQ)", wav.MpqPath.ToString());
					}
					break;

				case "UPGS":
					for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
					{
						var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
						Info($"SettingRule[{i}]", $"{SCUpgrade.IdString[i]} 일반룰", upgrade.SettingRule.ToString());
					}
					for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
					{
						var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
						Info($"Mineral[{i}]", $"{SCUpgrade.IdString[i]} 필요 미네랄", upgrade.Mineral.ToString());
					}
					for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
					{
						var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
						Info($"MineralBonus[{i}]", $"{SCUpgrade.IdString[i]} 필요 미네랄+", upgrade.MineralBonus.ToString());
					}
					for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
					{
						var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
						Info($"Gas[{i}]", $"{SCUpgrade.IdString[i]} 필요 가스", upgrade.Gas.ToString());
					}
					for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
					{
						var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
						Info($"GasBonus[{i}]", $"{SCUpgrade.IdString[i]} 필요 가스+", upgrade.GasBonus.ToString());
					}
					for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
					{
						var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
						Info($"Time[{i}]", $"{SCUpgrade.IdString[i]} 소요 시간", upgrade.Time.ToString());
					}
					for (int i = 0; i < chkFileInfo.UpgradeSet.Upgrades.Length; i++)
					{
						var upgrade = chkFileInfo.UpgradeSet.Upgrades[i];
						Info($"TimeBonus[{i}]", $"{SCUpgrade.IdString[i]} 소요 시간+", upgrade.TimeBonus.ToString());
					}
					break;

				case "TECS":
					for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
					{
						var tech = chkFileInfo.TechSet.Techs[i];
						Info($"SettingRule[{i}]", $"{SCTech.IdString[i]} 일반룰", tech.SettingRule.ToString());
					}
					for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
					{
						var tech = chkFileInfo.TechSet.Techs[i];
						Info($"Mineral[{i}]", $"{SCTech.IdString[i]} 필요 미네랄", tech.Mineral.ToString());
					}
					for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
					{
						var tech = chkFileInfo.TechSet.Techs[i];
						Info($"Gas[{i}]", $"{SCTech.IdString[i]} 필요 가스", tech.Gas.ToString());
					}
					for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
					{
						var tech = chkFileInfo.TechSet.Techs[i];
						Info($"Time[{i}]", $"{SCTech.IdString[i]} 소요 시간", tech.Time.ToString());
					}
					for (int i = 0; i < chkFileInfo.TechSet.Techs.Length; i++)
					{
						var tech = chkFileInfo.TechSet.Techs[i];
						Info($"Energy[{i}]", $"{SCTech.IdString[i]} 소모 에너지", tech.Energy.ToString());
					}
					break;

				case "SWNM":
					for (int i = 0; i < chkFileInfo.SwitchSet.Switches.Length; i++)
					{
						var _switch = chkFileInfo.SwitchSet.Switches[i];
						Info($"NameStringNumber[{i}]", $"스위치 {i + 1} 이름 스트링#", _switch.NameStringNumber.ToString());
					}
					break;

				default:
					break;
			}
		}
	}
}