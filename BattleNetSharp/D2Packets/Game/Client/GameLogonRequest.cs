using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using D2Data;
using Utilities;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A3C RID: 2620
	public class GameLogonRequest : Packet
	{
		// Token: 0x17003922 RID: 14626
		// (get) Token: 0x0600BB72 RID: 47986 RVA: 0x00472B34 File Offset: 0x00470D34
		// (set) Token: 0x0600BB73 RID: 47987 RVA: 0x00472B6A File Offset: 0x00470D6A
		public List<byte> Secret
		{
			get
			{
				List<byte> list = BitConverter.GetBytes(this.Secret1).ToList<byte>();
				list.AddRange(BitConverter.GetBytes(this.Secret2));
				return list;
			}
			set
			{
				this.Secret1 = BitConverter.ToUInt64(value.ToArray(), 0);
				this.Secret2 = BitConverter.ToUInt64(value.ToArray(), 8);
			}
		}

		// Token: 0x17003923 RID: 14627
		// (get) Token: 0x0600BB74 RID: 47988 RVA: 0x00472B94 File Offset: 0x00470D94
		// (set) Token: 0x0600BB75 RID: 47989 RVA: 0x00472BE4 File Offset: 0x00470DE4
		public string Name
		{
			get
			{
				List<byte> list = BitConverter.GetBytes(this.Name1).ToList<byte>();
				list.AddRange(BitConverter.GetBytes(this.Name2).ToList<byte>());
				return Encoding.ASCII.GetString(list.ToArray()).TrimString('\0');
			}
			set
			{
				List<byte> list = Encoding.ASCII.GetBytes(value).ToList<byte>();
				int num = 16 - list.Count;
				for (int i = 0; i < num; i++)
				{
					list.Add(0);
				}
				this.Name1 = BitConverter.ToUInt64(list.ToArray(), 0);
				this.Name2 = BitConverter.ToUInt64(list.ToArray(), 8);
			}
		}

		// Token: 0x0600BB76 RID: 47990 RVA: 0x00472C4C File Offset: 0x00470E4C
		public GameLogonRequest(uint hash, ushort id, CharacterClass classType, string name)
		{
			this.Hash = hash;
			this.Id = id;
			this.Class = classType;
			this.Name = name;
		}

		// Token: 0x0600BB77 RID: 47991 RVA: 0x00472CAC File Offset: 0x00470EAC
		public GameLogonRequest(List<byte> secret, ushort id, CharacterClass classType, string name, ulong charId)
		{
			this.Secret = secret;
			this.Id = id;
			this.Class = classType;
			this.Name = name;
			this.CharacterId = charId;
		}

		// Token: 0x0600BB78 RID: 47992 RVA: 0x00472D15 File Offset: 0x00470F15
		public GameLogonRequest(List<byte> secret)
		{
			this.Secret = secret;
		}

		// Token: 0x0600BB79 RID: 47993 RVA: 0x00472D54 File Offset: 0x00470F54
		public GameLogonRequest()
		{
		}

		// Token: 0x04008DB7 RID: 36279
		public GameClientPacket PacketId;

		// Token: 0x04008DB8 RID: 36280
		[MaxVersion(GameVersion.D2RBeta)]
		public uint Hash;

		// Token: 0x04008DB9 RID: 36281
		[MinVersion(GameVersion.D2R)]
		public ulong Secret1;

		// Token: 0x04008DBA RID: 36282
		[MinVersion(GameVersion.D2R)]
		public ulong Secret2;

		// Token: 0x04008DBB RID: 36283
		[MaxVersion(GameVersion.D2RBeta)]
		public ushort Id;

		// Token: 0x04008DBC RID: 36284
		[MaxVersion(GameVersion.D2RBeta)]
		public CharacterClass Class;

		// Token: 0x04008DBD RID: 36285
		[MaxVersion(GameVersion.D2RBeta)]
		public uint Version = 14U;

		// Token: 0x04008DBE RID: 36286
		[MaxVersion(GameVersion.D2RBeta)]
		public uint Unk1 = 3982347344U;

		// Token: 0x04008DBF RID: 36287
		[MaxVersion(GameVersion.D2RBeta)]
		public uint Unk2 = 2443516342U;

		// Token: 0x04008DC0 RID: 36288
		[MaxVersion(GameVersion.D2RBeta)]
		public byte LocaleId = 0;

		// Token: 0x04008DC1 RID: 36289
		[MaxVersion(GameVersion.D2RBeta)]
		[MinVersion(GameVersion.D2RBeta)]
		public ulong CharacterId = 0UL;

		// Token: 0x04008DC2 RID: 36290
		[MaxVersion(GameVersion.D2RBeta)]
		public ulong Name1;

		// Token: 0x04008DC3 RID: 36291
		[MaxVersion(GameVersion.D2RBeta)]
		public ulong Name2;
	}
}
