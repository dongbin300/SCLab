namespace SCLab.SCScripts
{
	public class SCStringSet
	{
		public ushort StringCount { get; set; }
		public SCString[] Strings { get; set; }

		public SCStringSet(ushort stringCount)
		{
			StringCount = stringCount;
			Strings = new SCString[stringCount];
			for (int i = 0; i < stringCount; i++)
			{
				Strings[i] = new SCString();
			}
		}

		public string GetString(int index)
		{
			return Strings[index].Data;
		}
	}
}
