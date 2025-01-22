using System;

namespace D4Packets.Game.Client
{
	// Token: 0x02000889 RID: 2185
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_CONNECTION_ESTABLISHED)]
	public class ConnectionEstablished : D4Packet
	{
		// Token: 0x04006447 RID: 25671
		public uint _043bb90f = 2385618990U;

		// Token: 0x04006448 RID: 25672
		public uint dwAnimSyncedSeed = 1251761028U;
	}
}
