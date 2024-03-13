using SCLab.Enums;

namespace SCLab.SCRegions
{
	public class SCLocationSet
	{
		public SCLocation[] Locations { get; set; }

		public SCLocationSet(SCFileFormatVersion version)
		{
			Locations = version switch
			{
				SCFileFormatVersion.StarCraft100 => new SCLocation[64],
				_ => new SCLocation[255],
			};

			for (int i = 0; i < Locations.Length; i++)
			{
				Locations[i] = new SCLocation(0, 0, 0, 0, 0, 0);
			}
		}
	}
}
