using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Challenge.V1;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000AD8 RID: 2776
	public class ChallengeListener : ChallengeListener.ChallengeListenerBase, IServiceListener
	{
		// Token: 0x0600BCAE RID: 48302 RVA: 0x0048348C File Offset: 0x0048168C
		public override Task<NO_RESPONSE> OnExternalChallenge(ChallengeExternalRequest request, ServerCallContext context)
		{
			return Task.FromResult<NO_RESPONSE>(new NO_RESPONSE());
		}

		// Token: 0x0600BCAF RID: 48303 RVA: 0x004834A8 File Offset: 0x004816A8
		public override Task<NO_RESPONSE> OnExternalChallengeResult(ChallengeExternalResult request, ServerCallContext context)
		{
			return null;
		}

		// Token: 0x04009156 RID: 37206
		public ChallengeExternalRequest ChallengeExternalRequest;
	}
}
