using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CompService.Supporting
{
    public class ConnectionСryptography
    {
		readonly static ushort cryptoKey = 0x0322;

		public static string Encrypt(string data)
		{
			byte[] decrypted = Encoding.UTF8.GetBytes(data);
			byte[] encrypted = new byte[decrypted.Length];

			for (int i = 0; i < decrypted.Length; i++)
			{
				encrypted[i] = (byte)(decrypted[i] ^ cryptoKey);
			}

			string cryptedByteString = Convert.ToBase64String(encrypted);
			return cryptedByteString;
		}

		public static string Decrypt(string data)
		{
			var decrypted = Convert.FromBase64String(data);
			byte[] encrypted = new byte[decrypted.Length];

			for (int i = 0; i < decrypted.Length; i++)
			{
				encrypted[i] = (byte)(decrypted[i] ^ cryptoKey);
			}

			string decryptedByteString = Encoding.UTF8.GetString(encrypted);
			return decryptedByteString;
		}
	}
}
