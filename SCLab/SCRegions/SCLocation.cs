using SCLab.Enums;

namespace SCLab.SCRegions
{
	public class SCLocation(uint left, uint top, uint right, uint bottom, ushort stringNumber, SCElevations elevations)
	{
		public uint Left { get; set; } = left;
		public uint Top { get; set; } = top;
		public uint Right { get; set; } = right;
		public uint Bottom { get; set; } = bottom;

		/// <summary>
		/// String Number는 1부터 시작
		/// </summary>
		public ushort StringNumber { get; set; } = stringNumber;

		public SCElevations Elevations { get; set; } = elevations;
	}
}
