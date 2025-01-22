using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009B8 RID: 2488
	public class GameMessage : Packet
	{
		// Token: 0x0400899F RID: 35231
		public GameServerPacket PacketId;

		// Token: 0x040089A0 RID: 35232
		public GameMessageType MessageType = GameMessageType.GameMessage;

		// Token: 0x040089A1 RID: 35233
		public byte LanguageCode;

		// Token: 0x040089A2 RID: 35234
		public UnitType Type;

		// Token: 0x040089A3 RID: 35235
		public uint Id;

		// Token: 0x040089A4 RID: 35236
		public byte chatColor;

		// Token: 0x040089A5 RID: 35237
		public byte subType;

		// Token: 0x040089A6 RID: 35238
		public string Player;

		// Token: 0x040089A7 RID: 35239
		public string Message;
	}
}
