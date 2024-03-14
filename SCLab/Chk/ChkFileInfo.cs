using SCLab.Enums;
using SCLab.SCPlayers;
using SCLab.SCPlays;
using SCLab.SCRegions;
using SCLab.SCScripts;

namespace SCLab.Chk
{
	public class ChkFileInfo
	{
		public List<Chunk> Chunks { get; set; } = [];
		public SCScenarioType ScenarioType { get; set; }
		public SCFileFormatVersion FileFormatVersion { get; set; }
		public SCMapVersion MapVersion { get; set; }
		public uint[] Seed { get; set; } = new uint[256];
		public byte[] OperationCode { get; set; } = new byte[16];
		public SCPlayerType[] StarEditPlayerTypes { get; set; } = new SCPlayerType[12];
		public SCPlayerType[] StarCraftPlayerTypes { get; set; } = new SCPlayerType[12];
		public SCMapTileSet TileSet { get; set; }
		public ushort MapWidth { get; set; }
		public ushort MapHeight { get; set; }
		public SCPlayerSpecies[] PlayerSpecies { get; set; } = new SCPlayerSpecies[12];
		/// <summary>
		/// Force Number는 0부터 시작
		/// </summary>
		public byte[] ForceNumbers { get; set; } = new byte[8];
		public ushort[] Tiles { get; set; } = [];
		public ushort[] RectangleTiles { get; set; } = [];
		public ushort[] MapTiles { get; set; } = [];
		public SCUnitSet UnitSet { get; set; } = new SCUnitSet();
		public SCWeaponSet WeaponSet { get; set; } = default!;
		public SCUpgradeSet UpgradeSet { get; set; } = default!;
		public SCLocationSet LocationSet { get; set; } = default!;
		public SCFogs[] Fogs { get; set; } = default!;
		public SCStringSet StringSet { get; set; } = default!;
		public SCScenario Scenario { get; set; } = new SCScenario();
		public SCForceSet ForceSet { get; set; } = new SCForceSet();
		public SCWavSet WavSet { get; set; } = new SCWavSet();
		public SCTechSet TechSet { get; set; } = default!;
		public SCCUWPSet CUWPSet { get; set; } = new SCCUWPSet();
		public SCSwitchSet SwitchSet { get; set; } = new SCSwitchSet();
	}
}
