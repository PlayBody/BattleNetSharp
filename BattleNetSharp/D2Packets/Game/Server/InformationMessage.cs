using System;
using System.IO;
using System.Linq;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009BE RID: 2494
	public class InformationMessage : Packet
	{
		// Token: 0x0600BACD RID: 47821 RVA: 0x0046D850 File Offset: 0x0046BA50
		public override byte[] ToArray()
		{
			return this.orig;
		}

		// Token: 0x0600BACE RID: 47822 RVA: 0x0046D868 File Offset: 0x0046BA68
		public override void FromBytes(byte[] data)
		{
			int num;
			GameServerPacketSizes.GetPacketSize(data.ToList<byte>(), out num, base.PacketVersion == GameVersion.D2R);
			this.orig = data.Take(num).ToArray<byte>();
			this.memoryStream = new MemoryStream(data);
			this.reader = new BinaryReader(this.memoryStream);
			this.reader.ReadBytes(data.Length);
			this.SlayerType = UnitType.NotApplicable;
			this.CharClass = CharacterClass.NotApplicable;
			this.SlayerObject = GameObjectID.NotApplicable;
			this.SlayerMonster = NPCCode.NotApplicable;
			this.InformationType = PlayerInformationActionType.None;
			this.RelationType = PlayerRelationActionType.NotApplicable;
			this.Amount = -1;
		}

		// Token: 0x04008A41 RID: 35393
		public GameServerPacket PacketId;

		// Token: 0x04008A42 RID: 35394
		public InformationMessage.InformationMessageType Type;

		// Token: 0x04008A43 RID: 35395
		public byte Action;

		// Token: 0x04008A44 RID: 35396
		public PlayerInformationActionType InformationType;

		// Token: 0x04008A45 RID: 35397
		public PlayerRelationActionType RelationType;

		// Token: 0x04008A46 RID: 35398
		public uint PlayerId;

		// Token: 0x04008A47 RID: 35399
		public UnitType SlayerType;

		// Token: 0x04008A48 RID: 35400
		public CharacterClass CharClass;

		// Token: 0x04008A49 RID: 35401
		public GameObjectID SlayerObject;

		// Token: 0x04008A4A RID: 35402
		public NPCCode SlayerMonster;

		// Token: 0x04008A4B RID: 35403
		public int Amount;

		// Token: 0x04008A4C RID: 35404
		public byte[] orig;

		// Token: 0x0200134E RID: 4942
		public class unk : Packet
		{
			// Token: 0x04009E2F RID: 40495
			public byte unk1;
		}

		// Token: 0x0200134F RID: 4943
		public enum InformationMessageType : byte
		{
			// Token: 0x04009E31 RID: 40497
			DroppedFromGame,
			// Token: 0x04009E32 RID: 40498
			JoinedGame = 2,
			// Token: 0x04009E33 RID: 40499
			LeftGame,
			// Token: 0x04009E34 RID: 40500
			NotInGame,
			// Token: 0x04009E35 RID: 40501
			PlayerRelation = 7,
			// Token: 0x04009E36 RID: 40502
			PlayerSlain = 6,
			// Token: 0x04009E37 RID: 40503
			SoJsSoldToMerchants = 17,
			// Token: 0x04009E38 RID: 40504
			DiabloWalksTheEarth
		}
	}
}
