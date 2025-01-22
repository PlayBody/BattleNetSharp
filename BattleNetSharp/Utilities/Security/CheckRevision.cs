using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Utilities.Security
{
	// Token: 0x020007B6 RID: 1974
	public static class CheckRevision
	{
		// Token: 0x0600B4DA RID: 46298 RVA: 0x002C0DA4 File Offset: 0x002BEFA4
		public static Tuple<uint, string> Hash(string val, string version)
		{
			List<byte> list = Convert.FromBase64String(val).Take(4).ToList<byte>();
			list.AddRange(Encoding.UTF8.GetBytes(":" + version + ":"));
			list.Add(1);
			Tuple<uint, string> tuple;
			using (SHA1 sha = SHA1.Create())
			{
				byte[] array = sha.ComputeHash(list.ToArray());
				string text = Convert.ToBase64String(array);
				tuple = new Tuple<uint, string>(BitConverter.ToUInt32(Encoding.ASCII.GetBytes(text.Substring(0, 4)), 0), text.Substring(4));
			}
			return tuple;
		}
	}
}
