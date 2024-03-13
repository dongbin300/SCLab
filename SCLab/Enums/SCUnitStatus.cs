namespace SCLab.Enums
{
	[Flags]
	public enum SCUnitStatus
	{
		None = 0,
		Cloaked = 1,
		Burrowed = 2,
		InTransit = 4,
		Hallucinated = 8,
		Invincible = 16
	}
}
