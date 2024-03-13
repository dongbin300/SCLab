#pragma warning disable CA1069 // 열거형 값은 중복되어서는 안 됨
namespace SCLab.Enums
{
	public enum SCFileFormatVersion : ushort
	{
		Unknown = 0,

		/// <summary>
		/// StarCraft Map (.scm)
		/// </summary>
		StarCraft100 = 59,

		StarCraft104 = 63,
		Revelations = 63,
		Hybrid = 63,

		BroodWar = 205,

		Remastered = 206
	}
}
#pragma warning restore CA1069 // 열거형 값은 중복되어서는 안 됨