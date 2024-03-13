namespace SCLab.SCScripts
{
	public class SCSwitchSet
	{
		public SCSwitch[] Switches { get; set; }

		public SCSwitchSet()
		{
			Switches = new SCSwitch[256];
			for (int i = 0; i < Switches.Length; i++)
			{
				Switches[i] = new SCSwitch(0);
			}
		}
	}
}
