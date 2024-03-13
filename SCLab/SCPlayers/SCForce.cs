using SCLab.Enums;

namespace SCLab.SCPlayers
{
	public class SCForce(ushort nameStringNumber, SCForceProperties properties)
	{
		public ushort NameStringNumbers { get; set; } = nameStringNumber;
		public SCForceProperties Properties { get; set; } = properties;
	}
}
