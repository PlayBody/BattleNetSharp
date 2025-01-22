using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace WoW.Packets
{
	// Token: 0x02000810 RID: 2064
	public class AuthSession : ClientPacket
	{
		// Token: 0x0600B53B RID: 46395 RVA: 0x002C2FC8 File Offset: 0x002C11C8
		public AuthSession(byte[] clientSecret, byte[] joinSecret, byte[] clientChallenge, byte[] serverChallenge)
		{
			this.ClientChallenge = clientChallenge.ToArray<byte>();
			SHA256 sha = SHA256.Create();
			sha.Initialize();
			sha.TransformBlock(clientSecret, 0, clientSecret.Length, null, 0);
			sha.TransformBlock(joinSecret, 0, joinSecret.Length, null, 0);
			sha.TransformFinalBlock(AuthSession.PlatformKeySeed, 0, AuthSession.PlatformKeySeed.Length);
			HMACSHA256 hmacsha = new HMACSHA256(sha.Hash);
			hmacsha.Initialize();
			hmacsha.TransformBlock(clientChallenge, 0, clientChallenge.Length, null, 0);
			hmacsha.TransformBlock(serverChallenge, 0, serverChallenge.Length, null, 0);
			hmacsha.TransformFinalBlock(AuthSession.AuthCheckSeed, 0, AuthSession.AuthCheckSeed.Length);
			this.Digest = hmacsha.Hash.Take(24).ToArray<byte>();
		}

		// Token: 0x0600B53C RID: 46396 RVA: 0x002C3084 File Offset: 0x002C1284
		public static byte[] GetAesKey(byte[] clientSecret, byte[] joinSecret, byte[] localChallenge, byte[] serverChallenge, out List<byte> sessionKey)
		{
			SHA256 sha = SHA256.Create();
			sha.Initialize();
			sha.TransformBlock(clientSecret, 0, clientSecret.Length, null, 0);
			sha.TransformFinalBlock(joinSecret, 0, joinSecret.Length);
			HMACSHA256 hmacsha = new HMACSHA256(sha.Hash);
			hmacsha.TransformBlock(serverChallenge, 0, serverChallenge.Length, null, 0);
			hmacsha.TransformBlock(localChallenge, 0, localChallenge.Length, null, 0);
			hmacsha.TransformFinalBlock(AuthSession.SessionKeySeed, 0, AuthSession.SessionKeySeed.Length);
			byte[] array = new byte[hmacsha.Hash.Length];
			sha.Initialize();
			sha.TransformFinalBlock(hmacsha.Hash, 0, hmacsha.Hash.Length / 2);
			byte[] hash = sha.Hash;
			sha.Initialize();
			sha.TransformFinalBlock(hmacsha.Hash, hmacsha.Hash.Length / 2, hmacsha.Hash.Length / 2);
			byte[] hash2 = sha.Hash;
			sessionKey = new List<byte>();
			while (sessionKey.Count < 40)
			{
				sha.Initialize();
				sha.TransformBlock(hash, 0, hash.Length, null, 0);
				sha.TransformBlock(array, 0, array.Length, null, 0);
				sha.TransformFinalBlock(hash2, 0, hash2.Length);
				array = sha.Hash;
				sessionKey.AddRange(array);
				sessionKey = sessionKey.Take(40).ToList<byte>();
			}
			hmacsha = new HMACSHA256(sessionKey.ToArray());
			hmacsha.TransformBlock(localChallenge, 0, localChallenge.Length, null, 0);
			hmacsha.TransformBlock(serverChallenge, 0, serverChallenge.Length, null, 0);
			hmacsha.TransformFinalBlock(AuthSession.EncryptionKeySeed, 0, AuthSession.EncryptionKeySeed.Length);
			return hmacsha.Hash.Take(16).ToArray<byte>();
		}

		// Token: 0x0600B53D RID: 46397 RVA: 0x002C3224 File Offset: 0x002C1424
		public static byte[] GetAesKey(byte[] session, byte[] localChallenge, byte[] serverChallenge)
		{
			HMACSHA256 hmacsha = new HMACSHA256(session.ToArray<byte>());
			hmacsha.TransformBlock(localChallenge, 0, localChallenge.Length, null, 0);
			hmacsha.TransformBlock(serverChallenge, 0, serverChallenge.Length, null, 0);
			hmacsha.TransformFinalBlock(AuthSession.EncryptionKeySeed, 0, AuthSession.EncryptionKeySeed.Length);
			return hmacsha.Hash.Take(16).ToArray<byte>();
		}

		// Token: 0x04005AA8 RID: 23208
		private static readonly byte[] PlatformKeySeed = Convert.FromHexString("55 8c df 95 8f a0 82 e9 58 49 77 9c 7c 69 45 e5".Replace(" ", ""));

		// Token: 0x04005AA9 RID: 23209
		private static readonly byte[] AuthCheckSeed = new byte[]
		{
			197, 198, 152, 149, 118, 63, 29, 205, 182, 161,
			55, 40, 179, 18, byte.MaxValue, 138
		};

		// Token: 0x04005AAA RID: 23210
		private static readonly byte[] SessionKeySeed = new byte[]
		{
			88, 203, 207, 64, 254, 46, 206, 166, 90, 144,
			184, 1, 104, 108, 40, 11
		};

		// Token: 0x04005AAB RID: 23211
		private static readonly byte[] EncryptionKeySeed = new byte[]
		{
			233, 117, 60, 80, 144, 147, 97, 218, 59, 7,
			238, 250, byte.MaxValue, 157, 65, 184
		};

		// Token: 0x04005AAC RID: 23212
		public byte[] DosResponse;

		// Token: 0x04005AAD RID: 23213
		public uint RegionID;

		// Token: 0x04005AAE RID: 23214
		public uint BattlegroupID;

		// Token: 0x04005AAF RID: 23215
		public uint RealmID;

		// Token: 0x04005AB0 RID: 23216
		public byte[] ClientChallenge;

		// Token: 0x04005AB1 RID: 23217
		public byte[] Digest;

		// Token: 0x04005AB2 RID: 23218
		public byte UseIPv6;

		// Token: 0x04005AB3 RID: 23219
		public uint RealmJoinTicketLen;

		// Token: 0x04005AB4 RID: 23220
		public List<byte> RealmJoinTicket;
	}
}
