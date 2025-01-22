using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Utilities.Security;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AA1 RID: 2721
	public class AuthCheckC2S : Packet
	{
		// Token: 0x0600BBE5 RID: 48101 RVA: 0x00473AEB File Offset: 0x00471CEB
		public AuthCheckC2S()
		{
		}

		// Token: 0x0600BBE6 RID: 48102 RVA: 0x00473B2C File Offset: 0x00471D2C
		public AuthCheckC2S(AuthInfoS2C authInfo, string classicKey, string lodKey, uint token = 0U)
		{
			FileInfo fileInfo = new FileInfo("Game.exe");
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(fileInfo.FullName);
			bool flag = authInfo.FormulaString.StartsWith("A=");
			if (flag)
			{
				string text = string.Concat(new string[]
				{
					fileInfo.Name,
					" ",
					fileInfo.LastWriteTimeUtc.ToString("MM/dd/yy HH:mm:ss"),
					" ",
					fileInfo.Length.ToString()
				});
				int num = RevisionCheckerOld.CheckRevision(authInfo.FormulaString, new string[] { fileInfo.FullName }, int.Parse(authInfo.MpqFileName.Substring(authInfo.MpqFileName.Length - 5, 1)));
				this.ExeHash = (uint)num;
				this.ExeInfo = text;
			}
			else
			{
				Tuple<uint, string> tuple = CheckRevision.Hash(authInfo.FormulaString, versionInfo.FileVersion);
				this.ExeHash = tuple.Item1;
				this.ExeInfo = tuple.Item2;
			}
			CdKey cdKey = new CdKey(classicKey);
			CdKey cdKey2 = new CdKey(lodKey);
			bool flag2 = !cdKey.IsValid || !cdKey2.IsValid;
			if (flag2)
			{
				throw new Exception("INVALID CD KEY, DON'T GET BANNED");
			}
			bool flag3 = token == 0U;
			if (flag3)
			{
				token = (uint)Environment.TickCount;
			}
			this.ClientToken = token;
			this.Major = (byte)versionInfo.ProductMajorPart;
			this.Minor = (byte)versionInfo.ProductMinorPart;
			this.Build = (byte)versionInfo.ProductBuildPart;
			AuthCheckC2S.CdKeyPacket cdKeyPacket = new AuthCheckC2S.CdKeyPacket(cdKey, this.ClientToken, authInfo.ServerToken);
			AuthCheckC2S.CdKeyPacket cdKeyPacket2 = new AuthCheckC2S.CdKeyPacket(cdKey2, this.ClientToken, authInfo.ServerToken);
			this.CdKeys.Add(cdKeyPacket);
			this.CdKeys.Add(cdKeyPacket2);
		}

		// Token: 0x04008FF3 RID: 36851
		public byte FF = byte.MaxValue;

		// Token: 0x04008FF4 RID: 36852
		public BattleNetPacket PacketId;

		// Token: 0x04008FF5 RID: 36853
		public ushort Length;

		// Token: 0x04008FF6 RID: 36854
		public uint ClientToken;

		// Token: 0x04008FF7 RID: 36855
		public byte Tick = 0;

		// Token: 0x04008FF8 RID: 36856
		public byte Build;

		// Token: 0x04008FF9 RID: 36857
		public byte Minor;

		// Token: 0x04008FFA RID: 36858
		public byte Major;

		// Token: 0x04008FFB RID: 36859
		public uint ExeHash;

		// Token: 0x04008FFC RID: 36860
		public uint NumCdKeys = 2U;

		// Token: 0x04008FFD RID: 36861
		public uint SpawnCdKey = 0U;

		// Token: 0x04008FFE RID: 36862
		public List<AuthCheckC2S.CdKeyPacket> CdKeys = new List<AuthCheckC2S.CdKeyPacket>();

		// Token: 0x04008FFF RID: 36863
		public string ExeInfo;

		// Token: 0x04009000 RID: 36864
		public string Owner = "d2haker";

		// Token: 0x02001389 RID: 5001
		public class CdKeyPacket : Packet
		{
			// Token: 0x0600DFFA RID: 57338 RVA: 0x004C536E File Offset: 0x004C356E
			public CdKeyPacket()
			{
			}

			// Token: 0x0600DFFB RID: 57339 RVA: 0x004C538C File Offset: 0x004C358C
			public CdKeyPacket(CdKey key, uint client, uint server)
			{
				this.KeyLen = (uint)key.Key.Length;
				this.Product = (uint)key.Product;
				this.Public = (uint)key.Public;
				this.HashedKey = key.GetHash(client, server).ToList<byte>();
			}

			// Token: 0x04009F2F RID: 40751
			public uint KeyLen;

			// Token: 0x04009F30 RID: 40752
			public uint Product;

			// Token: 0x04009F31 RID: 40753
			public uint Public;

			// Token: 0x04009F32 RID: 40754
			public uint Zero = 0U;

			// Token: 0x04009F33 RID: 40755
			public List<byte> HashedKey = new List<byte>(20);
		}
	}
}
