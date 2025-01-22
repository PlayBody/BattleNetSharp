using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AA5 RID: 2725
	public enum BattleNetPacket : byte
	{
		// Token: 0x0400901E RID: 36894
		KeepAlive,
		// Token: 0x0400901F RID: 36895
		StartAdvex = 8,
		// Token: 0x04009020 RID: 36896
		EnterChat = 10,
		// Token: 0x04009021 RID: 36897
		ChannelList,
		// Token: 0x04009022 RID: 36898
		JoinChannel,
		// Token: 0x04009023 RID: 36899
		ChatCommand = 14,
		// Token: 0x04009024 RID: 36900
		ChatEvent,
		// Token: 0x04009025 RID: 36901
		LeaveChat,
		// Token: 0x04009026 RID: 36902
		AdInfo = 21,
		// Token: 0x04009027 RID: 36903
		StartGame = 28,
		// Token: 0x04009028 RID: 36904
		LeaveGame = 31,
		// Token: 0x04009029 RID: 36905
		DisplayAd = 33,
		// Token: 0x0400902A RID: 36906
		NotifyJoin,
		// Token: 0x0400902B RID: 36907
		Ping = 37,
		// Token: 0x0400902C RID: 36908
		FileTimeInfo = 51,
		// Token: 0x0400902D RID: 36909
		Logon = 58,
		// Token: 0x0400902E RID: 36910
		Create2 = 61,
		// Token: 0x0400902F RID: 36911
		RealmLogon,
		// Token: 0x04009030 RID: 36912
		QueryRealms = 64,
		// Token: 0x04009031 RID: 36913
		NewsInfo = 70,
		// Token: 0x04009032 RID: 36914
		OptionalWork = 74,
		// Token: 0x04009033 RID: 36915
		ExtraWork,
		// Token: 0x04009034 RID: 36916
		RequiredWork,
		// Token: 0x04009035 RID: 36917
		AuthInfo = 80,
		// Token: 0x04009036 RID: 36918
		AuthCheck,
		// Token: 0x04009037 RID: 36919
		SetEmail = 89
	}
}
