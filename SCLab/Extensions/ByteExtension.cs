using System.Text;

namespace SCLab.Extensions
{
	public static class ByteExtension
	{
		public static ushort ToUShort(this byte[] bytes, int startIndex = 0)
		{
			return BitConverter.ToUInt16(bytes, startIndex);
		}

		public static uint ToUInt(this byte[] bytes, int startIndex = 0)
		{
			return BitConverter.ToUInt32(bytes, startIndex);
		}

		public static byte[] Substring(this byte[] bytes, int startIndex = 0)
		{
			var result = new byte[bytes.Length - startIndex];
			Buffer.BlockCopy(bytes, startIndex, result, 0, result.Length);
			return result;
		}

		public static string GetString(this byte[] bytes, int startIndex)
		{
			int length = 0;
			while (startIndex + length < bytes.Length && bytes[startIndex + length] != 0)
			{
				length++;
			}
			return Encoding.ASCII.GetString(bytes, startIndex, length);
		}

		public static string ByteToString(this byte[] bytes)
		{
			string result = string.Empty;
			foreach (var b in bytes)
			{
				result += b.ToString();
			}
			return result;
		}
	}
}
