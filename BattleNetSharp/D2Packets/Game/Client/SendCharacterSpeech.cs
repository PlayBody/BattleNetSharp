using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A5E RID: 2654
	public class SendCharacterSpeech : Packet
	{
		// Token: 0x04008E7F RID: 36479
		public GameClientPacket PacketId;

		// Token: 0x04008E80 RID: 36480
		public GameSound Speech;
	}
}
