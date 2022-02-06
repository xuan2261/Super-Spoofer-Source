using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace SUPER
{
	internal sealed class EmulatorProvider
	{
		private static readonly object dashboard;

		private static readonly int dashboard;

		private static readonly int green;

		private static readonly MemoryStream dashboard;

		private static readonly MemoryStream green;

		private static readonly byte dashboard;

		static EmulatorProvider()
		{
			System.Runtime.CompilerServices.Unsafe.As<byte, MemoryStream>(ref EmulatorProvider.dashboard) = StreamType.dashboard;
			green = StreamType.dashboard;
			System.Runtime.CompilerServices.Unsafe.As<byte, int>(ref EmulatorProvider.dashboard) = int.MaxValue;
			System.Runtime.CompilerServices.Unsafe.As<MemoryStream, int>(ref EmulatorProvider.green) = int.MinValue;
			System.Runtime.CompilerServices.Unsafe.As<byte, MemoryStream>(ref EmulatorProvider.dashboard) = new MemoryStream(0);
			green = new MemoryStream(0);
			System.Runtime.CompilerServices.Unsafe.As<byte, object>(ref EmulatorProvider.dashboard) = new object();
		}

		private static string MainLoad(Assembly assembly_0)
		{
			string text = assembly_0.FullName;
			int num = text.IndexOf(',');
			if (num >= 0)
				text = text.Substring(0, num);
			return text;
		}

		private static byte[] MainLoad(Assembly assembly_0)
		{
			try
			{
				string fullName = assembly_0.FullName;
				int num = fullName.IndexOf("PublicKeyToken=");
				if (num < 0)
					num = fullName.IndexOf("publickeytoken=");
				if (num < 0)
					return VectorEventArgs.dashboard;
				num += 15;
				if (fullName[num] != 'n' && fullName[num] != 'N')
				{
					byte[] bytes = BitConverter.GetBytes(long.Parse(fullName.Substring(num, 16), NumberStyles.HexNumber));
					Array.Reverse(bytes);
					return bytes;
				}
				return VectorEventArgs.dashboard;
			}
			catch
			{
			}
			return null;
		}

		internal static byte[] MainLoad(Stream stream_0)
		{
			lock (System.Runtime.CompilerServices.Unsafe.As<byte, object>(ref EmulatorProvider.dashboard))
			{
				return MainLoad(97L, (object)stream_0);
			}
		}

		internal static byte[] MainLoad(long long_0, Stream stream_0)
		{
			try
			{
				return MainLoad(stream_0);
			}
			catch
			{
				return MainLoad(97L, (object)stream_0);
			}
		}

		internal static byte[] MainLoad(long long_0, object object_0)
		{
			Stream stream = object_0 as Stream;
			Stream stream2 = stream;
			MemoryStream memoryStream = StreamType.dashboard;
			for (int i = 1; i < 4; i++)
			{
				stream.ReadByte();
			}
			ushort num = (ushort)(~(ushort)stream.ReadByte());
			if ((num & 2u) != 0)
			{
				DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
				byte[] array = new byte[8];
				stream.Read(array, 0, 8);
				dESCryptoServiceProvider.IV = array;
				byte[] array2 = new byte[8];
				stream.Read(array2, 0, 8);
				bool flag = true;
				byte[] array3 = array2;
				for (int j = 0; j < array3.Length; j++)
				{
					if (array3[j] != 0)
					{
						flag = false;
						break;
					}
				}
				if (flag)
					array2 = EmulatorProvider.MainLoad(Assembly.GetExecutingAssembly());
				dESCryptoServiceProvider.Key = array2;
				if (System.Runtime.CompilerServices.Unsafe.As<byte, MemoryStream>(ref EmulatorProvider.dashboard) == null)
				{
					if (System.Runtime.CompilerServices.Unsafe.As<byte, int>(ref EmulatorProvider.dashboard) == int.MaxValue)
						System.Runtime.CompilerServices.Unsafe.As<byte, MemoryStream>(ref EmulatorProvider.dashboard).Capacity = (int)stream.Length;
					else
						System.Runtime.CompilerServices.Unsafe.As<byte, MemoryStream>(ref EmulatorProvider.dashboard).Capacity = System.Runtime.CompilerServices.Unsafe.As<byte, int>(ref EmulatorProvider.dashboard);
				}
				System.Runtime.CompilerServices.Unsafe.As<byte, Stream>(ref EmulatorProvider.dashboard).Position = 0L;
				ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
				int inputBlockSize = cryptoTransform.InputBlockSize;
				_ = cryptoTransform.OutputBlockSize;
				byte[] array4 = new byte[cryptoTransform.OutputBlockSize];
				byte[] array5 = new byte[cryptoTransform.InputBlockSize];
				int k;
				for (k = (int)stream.Position; k + inputBlockSize < stream.Length; k += inputBlockSize)
				{
					stream.Read(array5, 0, inputBlockSize);
					int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
					System.Runtime.CompilerServices.Unsafe.As<byte, Stream>(ref EmulatorProvider.dashboard).Write(array4, 0, count);
				}
				stream.Read(array5, 0, (int)(stream.Length - k));
				byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(stream.Length - k));
				System.Runtime.CompilerServices.Unsafe.As<byte, Stream>(ref EmulatorProvider.dashboard).Write(array6, 0, array6.Length);
				stream2 = System.Runtime.CompilerServices.Unsafe.As<byte, Stream>(ref EmulatorProvider.dashboard);
				stream2.Position = 0L;
				memoryStream = System.Runtime.CompilerServices.Unsafe.As<byte, MemoryStream>(ref EmulatorProvider.dashboard);
			}
			if ((num & 8u) != 0)
			{
				if (green == null)
				{
					if (System.Runtime.CompilerServices.Unsafe.As<MemoryStream, int>(ref EmulatorProvider.green) == int.MinValue)
						green.Capacity = (int)stream2.Length * 2;
					else
						green.Capacity = System.Runtime.CompilerServices.Unsafe.As<MemoryStream, int>(ref EmulatorProvider.green);
				}
				green.Position = 0L;
				DeflateStream deflateStream = new DeflateStream(stream2, CompressionMode.Decompress);
				int num2 = 1000;
				byte[] buffer = new byte[1000];
				int num3;
				do
				{
					num3 = deflateStream.Read(buffer, 0, num2);
					if (num3 > 0)
						green.Write(buffer, 0, num3);
				}
				while (num3 >= num2);
				memoryStream = green;
			}
			if (memoryStream != null)
				return memoryStream.ToArray();
			byte[] array7 = new byte[stream.Length - stream.Position];
			stream.Read(array7, 0, array7.Length);
			return array7;
		}
	}
}
