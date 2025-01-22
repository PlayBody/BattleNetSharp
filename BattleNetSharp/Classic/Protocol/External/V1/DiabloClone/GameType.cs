using System;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.DiabloClone
{
	// Token: 0x0200079E RID: 1950
	public enum GameType
	{
		// Token: 0x040050F9 RID: 20729
		[OriginalName("Classic")]
		Classic,
		// Token: 0x040050FA RID: 20730
		[OriginalName("ClassicHardcore")]
		ClassicHardcore,
		// Token: 0x040050FB RID: 20731
		[OriginalName("ClassicLadder")]
		ClassicLadder,
		// Token: 0x040050FC RID: 20732
		[OriginalName("ClassicLadderHardcore")]
		ClassicLadderHardcore,
		// Token: 0x040050FD RID: 20733
		[OriginalName("ExpansionNonLadder")]
		ExpansionNonLadder,
		// Token: 0x040050FE RID: 20734
		[OriginalName("ExpansionNonLadderHardcore")]
		ExpansionNonLadderHardcore,
		// Token: 0x040050FF RID: 20735
		[OriginalName("ExpansionLadder")]
		ExpansionLadder,
		// Token: 0x04005100 RID: 20736
		[OriginalName("ExpansionLadderHardcore")]
		ExpansionLadderHardcore
	}
}
