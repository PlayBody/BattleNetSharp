using System;
using System.Linq;
using System.Security.Cryptography;

namespace WoW.Packets
{
	// Token: 0x02000815 RID: 2069
	public class AuthContinuedSession : ClientPacket
	{
		// Token: 0x0600B545 RID: 46405 RVA: 0x002C342C File Offset: 0x002C162C
		public AuthContinuedSession(byte[] key, byte[] sessionKey, byte[] clientChallenge, byte[] serverChallenge)
		{
			this.Key = key;
			this.ClientChallenge = clientChallenge.ToArray<byte>();
			HMACSHA256 hmacsha = new HMACSHA256(sessionKey);
			hmacsha.Initialize();
			hmacsha.TransformBlock(key, 0, key.Length, null, 0);
			hmacsha.TransformBlock(clientChallenge, 0, clientChallenge.Length, null, 0);
			hmacsha.TransformBlock(serverChallenge, 0, serverChallenge.Length, null, 0);
			hmacsha.TransformFinalBlock(AuthContinuedSession.ContinuedSessionSeed, 0, AuthContinuedSession.ContinuedSessionSeed.Length);
			this.Digest = hmacsha.Hash.Take(24).ToArray<byte>();
		}

		// Token: 0x04005AC0 RID: 23232
		private static readonly byte[] ContinuedSessionSeed = new byte[]
		{
			22, 173, 12, 212, 70, 249, 79, 178, 239, 125,
			234, 42, 23, 102, 77, 47
		};

		// Token: 0x04005AC1 RID: 23233
		public byte[] DosResponse = new byte[8];

		// Token: 0x04005AC2 RID: 23234
		public byte[] Key;

		// Token: 0x04005AC3 RID: 23235
		public byte[] ClientChallenge = new byte[16];

		// Token: 0x04005AC4 RID: 23236
		public byte[] Digest = new byte[24];
	}
}
