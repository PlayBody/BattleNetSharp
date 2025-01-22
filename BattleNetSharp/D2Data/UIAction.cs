using System;

namespace D2Data
{
	// Token: 0x02000950 RID: 2384
	public enum UIAction : byte
	{
		// Token: 0x040075D1 RID: 30161
		RequestTrade,
		// Token: 0x040075D2 RID: 30162
		TradeRequest,
		// Token: 0x040075D3 RID: 30163
		TradeAccepted = 5,
		// Token: 0x040075D4 RID: 30164
		UnacceptAllTrades,
		// Token: 0x040075D5 RID: 30165
		NoRoomForTrade = 9,
		// Token: 0x040075D6 RID: 30166
		TraderHasNoRoom,
		// Token: 0x040075D7 RID: 30167
		RefuseTrade = 12,
		// Token: 0x040075D8 RID: 30168
		TradeCompleted,
		// Token: 0x040075D9 RID: 30169
		DisableAcceptTrade,
		// Token: 0x040075DA RID: 30170
		EnableAcceptTrade,
		// Token: 0x040075DB RID: 30171
		OpenStash,
		// Token: 0x040075DC RID: 30172
		HideStash,
		// Token: 0x040075DD RID: 30173
		OpenCubeD2R = 20,
		// Token: 0x040075DE RID: 30174
		OpenCube
	}
}
