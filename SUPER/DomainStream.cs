using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SUPER
{
	public static class DomainStream
	{
		public static string MainLoad(byte[] byte_0)
		{
			StringBuilder stringBuilder = new StringBuilder(byte_0.Length * 2);
			for (int i = 0; i < byte_0.Length; i++)
			{
				stringBuilder.AppendFormat("{0:x2}", byte_0[i]);
			}
			return stringBuilder.ToString();
		}

		public static byte[] bsClick(string string_0)
		{
			int length = string_0.Length;
			byte[] array = new byte[length / 2];
			for (int i = 0; i < length; i += 2)
			{
				array[i / 2] = Convert.ToByte(string_0.Substring(i, 2), 16);
			}
			return array;
		}

		public static string MainLoad(string string_0, byte[] byte_0, byte[] byte_1)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Key = byte_0;
			aes.IV = byte_1;
			using (MemoryStream memoryStream = new MemoryStream())
				using (ICryptoTransform transform = aes.CreateEncryptor())
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
					{
						byte[] bytes = Encoding.Default.GetBytes(string_0);
						cryptoStream.Write(bytes, 0, bytes.Length);
						cryptoStream.FlushFinalBlock();
						return MainLoad(memoryStream.ToArray());
					}
		}

		public static string bsClick(string string_0, byte[] byte_0, byte[] byte_1)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Key = byte_0;
			aes.IV = byte_1;
			using (MemoryStream memoryStream = new MemoryStream())
				using (ICryptoTransform transform = aes.CreateDecryptor())
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
					{
						byte[] array = bsClick(string_0);
						cryptoStream.Write(array, 0, array.Length);
						cryptoStream.FlushFinalBlock();
						byte[] array2 = memoryStream.ToArray();
						return Encoding.Default.GetString(array2, 0, array2.Length);
					}
		}

		public static string MainLoad()
		{
			return Guid.NewGuid().ToString().Substring(0, Guid.NewGuid().ToString().IndexOf("-", StringComparison.Ordinal));
		}

		public static string stoppClick(string string_0)
		{
			return MainLoad(new SHA256Managed().ComputeHash(Encoding.Default.GetBytes(string_0)));
		}

		public static string windowsClick(string string_0, string string_1, string string_2)
		{
			return MainLoad(string_0, Encoding.Default.GetBytes(stoppClick(string_1).Substring(0, 32)), Encoding.Default.GetBytes(stoppClick(string_2).Substring(0, 16)));
		}

		public static string gpuClick(string string_0, string string_1, string string_2)
		{
			return bsClick(string_0, Encoding.Default.GetBytes(stoppClick(string_1).Substring(0, 32)), Encoding.Default.GetBytes(stoppClick(string_2).Substring(0, 16)));
		}
	}
}
