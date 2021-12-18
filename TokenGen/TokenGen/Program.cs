using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TokenGen
{
	// Token: 0x02000002 RID: 2
	internal class Program
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static string GetUniqueUSG(int maxSize)
		{
			char[] array = new char[62];
			array = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
			byte[] array2 = new byte[1];
			RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider();
			rngcryptoServiceProvider.GetNonZeroBytes(array2);
			array2 = new byte[maxSize];
			rngcryptoServiceProvider.GetNonZeroBytes(array2);
			StringBuilder stringBuilder = new StringBuilder(maxSize);
			foreach (byte b in array2)
			{
				stringBuilder.Append(array[(int)b % array.Length]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020D8 File Offset: 0x000002D8
		public static string GetUniqueUSG2(int maxSize)
		{
			char[] array = new char[62];
			array = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-_".ToCharArray();
			byte[] array2 = new byte[1];
			RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider();
			rngcryptoServiceProvider.GetNonZeroBytes(array2);
			array2 = new byte[maxSize];
			rngcryptoServiceProvider.GetNonZeroBytes(array2);
			StringBuilder stringBuilder = new StringBuilder(maxSize);
			foreach (byte b in array2)
			{
				stringBuilder.Append(array[(int)b % array.Length]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002160 File Offset: 0x00000360
		private static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("  ______                              __              \r\n    /            /                  /    )            \r\n---/-------__---/-__----__----__---/---------__----__-\r\n  /      /   ) /(     /___) /   ) /  --,   /___) /   )\r\n_/______(___/_/___\\__(___ _/___/_(____/___(___ _/___/_");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Tokens are being saved in Saved.txt");
			Console.WriteLine("Made by JustMyLife");
			TextWriter @out = Console.Out;
			FileStream fileStream;
			StreamWriter streamWriter;
			try
			{
				fileStream = new FileStream("./Saved.txt", FileMode.OpenOrCreate, FileAccess.Write);
				streamWriter = new StreamWriter(fileStream);
			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Cannot open Saved.txt for writing");
				Console.WriteLine(ex.Message);
				return;
			}
			Console.SetOut(streamWriter);
			for (int i = 0; i < 2147483647; i++)
			{
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write(string.Concat(new string[]
				{
					"NDc0N",
					Program.GetUniqueUSG(19),
					".D",
					Program.GetUniqueUSG2(5),
					".",
					Program.GetUniqueUSG2(27),
					"\n"
				}), ConsoleColor.Blue, 14);
				Console.Title = "Generated tokens: " + i.ToString();
			}
			Console.ReadKey();
			Console.SetOut(@out);
			streamWriter.Close();
			fileStream.Close();
			Console.WriteLine("Done");
			Console.ReadLine();
		}
	}
}
