using SCLab.Enums;

namespace SCLab.SCScripts
{
	/// <summary>
	/// Create Unit With Properties
	/// </summary>
	/// <param name="specialProperties"></param>
	/// <param name="changedProperties"></param>
	/// <param name="owner"></param>
	/// <param name="hp"></param>
	/// <param name="shield"></param>
	/// <param name="energy"></param>
	/// <param name="resourceAmount"></param>
	/// <param name="hangar"></param>
	/// <param name="status"></param>
	public class SCCUWP(SCUnitSpecialProperties specialProperties, SCUnitChangedProperties changedProperties, byte owner, byte hp, byte shield, byte energy, uint resourceAmount, ushort hangar, SCUnitStatus status)
	{
		public SCUnitSpecialProperties SpecialProperties { get; set; } = specialProperties;
		public SCUnitChangedProperties ChangedProperties { get; set; } = changedProperties;
		public byte Owner { get; set; } = owner;
		public byte Hp { get; set; } = hp;
		public byte Shield { get; set; } = shield;
		public byte Energy { get; set; } = energy;
		/// <summary>
		/// Resource only
		/// </summary>
		public uint ResourceAmount { get; set; } = resourceAmount;
		public ushort Hangar { get; set; } = hangar;
		public SCUnitStatus Status { get; set; } = status;
		public uint UnknownUnused { get; set; }
	}
}
