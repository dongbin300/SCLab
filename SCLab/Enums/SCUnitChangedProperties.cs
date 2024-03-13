namespace SCLab.Enums
{
	[Flags]
	public enum SCUnitChangedProperties
	{
		None = 0,
		Owner = 1,
		HP = 2,
		Shield = 4,
		Energy = 8,
		Resource = 16,
		Hangar = 32
	}
}
