namespace SCLab.Enums
{
	[Flags]
	public enum SCElevations
	{
		None = 0,
		LowElevation = 1,
		MediumElevation = 2,
		HighElevation = 4,
		LowAir = 8,
		MediumAir = 16,
		HighAir = 32
	}
}
