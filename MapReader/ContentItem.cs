namespace MapReader
{
	public class ContentItem(string name, string description, string value)
	{
		public string Name { get; set; } = name;
		public string Description { get; set; } = description;
		public string Value { get; set; } = value;
	}
}
