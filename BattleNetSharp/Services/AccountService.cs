using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Collections;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000AF4 RID: 2804
	public class AccountService : AccountService.AccountServiceBase, IServiceListener
	{
		// Token: 0x0600BD7D RID: 48509 RVA: 0x0048673C File Offset: 0x0048493C
		public override Task<GetAccountStateResponse> GetAccountState(GetAccountStateRequest request, ServerCallContext context)
		{
			GetAccountStateResponse getAccountStateResponse = new GetAccountStateResponse();
			AccountState accountState = new AccountState();
			AccountLevelInfo accountLevelInfo = new AccountLevelInfo();
			RepeatedField<AccountLicense> licenses = accountLevelInfo.Licenses;
			RepeatedField<AccountLicense> repeatedField = new RepeatedField<AccountLicense>();
			repeatedField.Add(new AccountLicense
			{
				Id = 16332U
			});
			repeatedField.Add(new AccountLicense
			{
				Id = 454445U
			});
			licenses.Add(repeatedField);
			accountLevelInfo.DefaultCurrency = 5395778U;
			accountLevelInfo.Country = "USA";
			accountLevelInfo.PreferredRegion = 1U;
			accountLevelInfo.FullName = "d2r proxy";
			accountLevelInfo.BattleTag = "d2rproxy#1337";
			accountLevelInfo.Email = "D2R@PROXY.COM";
			accountLevelInfo.HeadlessAccount = false;
			accountLevelInfo.TestAccount = false;
			accountLevelInfo.Birthdate = "1985-08-07";
			OptIns optIns = new OptIns();
			RepeatedField<ulong> ids = optIns.Ids;
			RepeatedField<ulong> repeatedField2 = new RepeatedField<ulong>();
			repeatedField2.Add(1UL);
			repeatedField2.Add(2UL);
			repeatedField2.Add(26UL);
			ids.Add(repeatedField2);
			accountLevelInfo.OptIns = optIns;
			accountState.AccountLevelInfo = accountLevelInfo;
			getAccountStateResponse.State = accountState;
			getAccountStateResponse.Tags = new AccountFieldTags
			{
				PrivacyInfoTag = 3515344901U,
				AccountLevelInfoTag = 750475273U
			};
			GetAccountStateResponse getAccountStateResponse2 = getAccountStateResponse;
			return Task.FromResult<GetAccountStateResponse>(getAccountStateResponse2);
		}

		// Token: 0x0600BD7E RID: 48510 RVA: 0x00486870 File Offset: 0x00484A70
		public override Task<GetAuthorizedDataResponse> GetAuthorizedData(GetAuthorizedDataRequest request, ServerCallContext context)
		{
			return base.GetAuthorizedData(request, context);
		}

		// Token: 0x0600BD7F RID: 48511 RVA: 0x0048688C File Offset: 0x00484A8C
		public override Task<GetCAISInfoResponse> GetCAISInfo(GetCAISInfoRequest request, ServerCallContext context)
		{
			return base.GetCAISInfo(request, context);
		}

		// Token: 0x0600BD80 RID: 48512 RVA: 0x004868A8 File Offset: 0x00484AA8
		public override Task<GetGameAccountStateResponse> GetGameAccountState(GetGameAccountStateRequest request, ServerCallContext context)
		{
			return Task.FromResult<GetGameAccountStateResponse>(new GetGameAccountStateResponse
			{
				State = new GameAccountState
				{
					GameLevelInfo = new GameLevelInfo
					{
						Name = "OSI1",
						Program = 5198665U,
						RealmPermissions = 0U
					},
					GameStatus = new GameStatus
					{
						Program = 5198665U
					}
				},
				Tags = new GameAccountFieldTags
				{
					GameLevelInfoTag = 1320209120U,
					GameStatusTag = 1037635271U
				}
			});
		}

		// Token: 0x0600BD81 RID: 48513 RVA: 0x00486938 File Offset: 0x00484B38
		public override Task<GetGameSessionInfoResponse> GetGameSessionInfo(GetGameSessionInfoRequest request, ServerCallContext context)
		{
			return base.GetGameSessionInfo(request, context);
		}

		// Token: 0x0600BD82 RID: 48514 RVA: 0x00486954 File Offset: 0x00484B54
		public override Task<GetGameTimeRemainingInfoResponse> GetGameTimeRemainingInfo(GetGameTimeRemainingInfoRequest request, ServerCallContext context)
		{
			return base.GetGameTimeRemainingInfo(request, context);
		}

		// Token: 0x0600BD83 RID: 48515 RVA: 0x00486970 File Offset: 0x00484B70
		public override Task<GetLicensesResponse> GetLicenses(GetLicensesRequest request, ServerCallContext context)
		{
			return base.GetLicenses(request, context);
		}

		// Token: 0x0600BD84 RID: 48516 RVA: 0x0048698C File Offset: 0x00484B8C
		public override Task<GetSignedAccountStateResponse> GetSignedAccountState(GetSignedAccountStateRequest request, ServerCallContext context)
		{
			return base.GetSignedAccountState(request, context);
		}

		// Token: 0x0600BD85 RID: 48517 RVA: 0x004869A8 File Offset: 0x00484BA8
		public override Task<NoData> IsIgrAddress(IsIgrAddressRequest request, ServerCallContext context)
		{
			return base.IsIgrAddress(request, context);
		}

		// Token: 0x0600BD86 RID: 48518 RVA: 0x004869C4 File Offset: 0x00484BC4
		public override Task<ResolveAccountResponse> ResolveAccount(ResolveAccountRequest request, ServerCallContext context)
		{
			return base.ResolveAccount(request, context);
		}

		// Token: 0x0600BD87 RID: 48519 RVA: 0x004869E0 File Offset: 0x00484BE0
		public override Task<SubscriptionUpdateResponse> Subscribe(SubscriptionUpdateRequest request, ServerCallContext context)
		{
			return Task.FromResult<SubscriptionUpdateResponse>(new SubscriptionUpdateResponse());
		}

		// Token: 0x0600BD88 RID: 48520 RVA: 0x004869FC File Offset: 0x00484BFC
		public override Task<NoData> Unsubscribe(SubscriptionUpdateRequest request, ServerCallContext context)
		{
			return base.Unsubscribe(request, context);
		}
	}
}
