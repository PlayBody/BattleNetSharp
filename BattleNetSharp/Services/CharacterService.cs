using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Classic.Protocol.External.V1.Character;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000AFD RID: 2813
	public class CharacterService : Character.CharacterBase, IServiceListener
	{
		// Token: 0x0600BDC9 RID: 48585 RVA: 0x00487668 File Offset: 0x00485868
		public override Task<CharacterResponse> ConvertCharacter(CharacterRequest request, ServerCallContext context)
		{
			return base.ConvertCharacter(request, context);
		}

		// Token: 0x0600BDCA RID: 48586 RVA: 0x00487684 File Offset: 0x00485884
		public override Task<CharacterResponse> CreateCharacter(CreateCharacterRequest request, ServerCallContext context)
		{
			return Task.FromResult<CharacterResponse>(new CharacterResponse
			{
				Id = 1U
			});
		}

		// Token: 0x0600BDCB RID: 48587 RVA: 0x004876A8 File Offset: 0x004858A8
		public override Task<CharacterResponse> DeleteCharacter(DeleteCharacterRequest request, ServerCallContext context)
		{
			return Task.FromResult<CharacterResponse>(new CharacterResponse
			{
				Id = request.Id
			});
		}

		// Token: 0x0600BDCC RID: 48588 RVA: 0x004876D4 File Offset: 0x004858D4
		public override Task<ReadCharacterResponse> ReadCharacter(NoData request, ServerCallContext context)
		{
			ReadCharacterResponse readCharacterResponse = new ReadCharacterResponse
			{
				MaxNum = 20U
			};
			return Task.FromResult<ReadCharacterResponse>(readCharacterResponse);
		}

		// Token: 0x0600BDCD RID: 48589 RVA: 0x004876FC File Offset: 0x004858FC
		public override Task<CharacterResponse> UseCharacter(CharacterRequest request, ServerCallContext context)
		{
			return base.UseCharacter(request, context);
		}
	}
}
