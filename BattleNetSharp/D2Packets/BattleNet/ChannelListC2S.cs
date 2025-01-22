using System;
using System.Linq;
using System.Text;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AA6 RID: 2726
	public class ChannelListC2S : Packet
	{
		// Token: 0x04009038 RID: 36920
		public byte FF = byte.MaxValue;

		// Token: 0x04009039 RID: 36921
		public BattleNetPacket PacketId;

		// Token: 0x0400903A RID: 36922
		public ushort Length;

		// Token: 0x0400903B RID: 36923
		public uint Product = BitConverter.ToUInt32(Encoding.ASCII.GetBytes("D2XP").Reverse<byte>().ToArray<byte>(), 0);
	}
}
