using SCLab.Enums;

namespace SCLab.SCScripts
{
	public class SCCUWPSet
	{
		public SCCUWP[] CUWPs { get; set; }
		public byte[] UsePropertySlots { get; set; } = new byte[64];

		public SCCUWPSet()
		{
			CUWPs = new SCCUWP[64];
			for (int i = 0; i < CUWPs.Length; i++)
			{
				CUWPs[i] = new SCCUWP(SCUnitSpecialProperties.None, SCUnitChangedProperties.Owner | SCUnitChangedProperties.HP | SCUnitChangedProperties.Shield | SCUnitChangedProperties.Energy | SCUnitChangedProperties.Resource | SCUnitChangedProperties.Hangar, 0, 100, 100, 100, 0, 0, SCUnitStatus.None);
			}

			Array.Fill<byte>(UsePropertySlots, 0);
		}
	}
}
