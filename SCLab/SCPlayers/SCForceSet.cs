using SCLab.Enums;

namespace SCLab.SCPlayers
{
	public class SCForceSet
	{
		public SCForce[] Forces { get; set; }

		public SCForceSet()
		{
			Forces = new SCForce[4];

			for (int i = 0; i < Forces.Length; i++)
			{
				Forces[i] = new SCForce(0, SCForceProperties.None);
			}
		}
	}
}
