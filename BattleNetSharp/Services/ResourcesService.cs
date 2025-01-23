using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Resources.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000B0C RID: 2828
	public class ResourcesService : Bgs.Protocol.Resources.V1.ResourcesService.ResourcesServiceBase, IServiceListener
	{
		// Token: 0x0600BE14 RID: 48660 RVA: 0x00487F64 File Offset: 0x00486164
		public override Task<ContentHandle> GetContentHandle(ContentHandleRequest request, ServerCallContext context)
		{
			Console.WriteLine(string.Concat(new string[]
			{
				Encoding.UTF8.GetString(BitConverter.GetBytes(request.Program)),
				" : ",
				Encoding.UTF8.GetString(BitConverter.GetBytes(request.Stream)),
				" : ",
				Encoding.UTF8.GetString(BitConverter.GetBytes(request.Version))
			}));
			return Task.FromResult<ContentHandle>(new ContentHandle
			{
				Region = 21843U,
				Usage = 1885762681U,
				Hash = ByteString.FromBase64("zq1KuVQvcfa30mJFIziPr0RNkic0TwvypaGsP1qSs5I="),
				ProtoUrl = "https://prod.depot.battle.net/${hash}.${usage}"
			});
		}

		// Token: 0x0600BE15 RID: 48661 RVA: 0x00488020 File Offset: 0x00486220
		public override Task<GetTitleIconsResponse> GetTitleIcons(GetTitleIconsRequest request, ServerCallContext context)
		{
			Dictionary<uint, string> dictionary = new Dictionary<uint, string>
			{
				{ 4613486U, "xE84BLDRpHWMNog9V0jCsoj9VcrXL8PCLWNpXIk7qNw=" },
				{ 17459U, "P89nFplK0Eq8y77Ix2JuxmaS0csJAlDmCDkx2+42JSk=" },
				{ 21298U, "Ado95PK6PJokcHBAnPK2IzfRwjjHKkqmfnqDjJjfGVs=" },
				{ 5730135U, "fWv88kNg8alaZNbQ4VviYUV51M8WmhC+B5TX/dymD1o=" },
				{ 16974U, "EPmexS4wPI55F1CL+qVEv0gJl5KLFcLLyJMWf9KUziQ=" },
				{ 4288624U, "EPmexS4wPI55F1CL+qVEv0gJl5KLFcLLyJMWf9KUziQ=" },
				{ 1112752496U, "EPmexS4wPI55F1CL+qVEv0gJl5KLFcLLyJMWf9KUziQ=" },
				{ 1465140039U, "8XDnj7OKC4/vFIlIdd7iMLvlByMdUO3aq+cfuLJPiOQ=" },
				{ 1214607983U, "AjPbS3+N8gdiMA62HHXQvZOUAGoKsmA2zXLq3WJ4Hz8=" },
				{ 5272175U, "k+awv8mxQQsgrKznBfB37dBXnpwjYSzPzv62RpMMtqA=" }
			};
			GetTitleIconsResponse getTitleIconsResponse = new GetTitleIconsResponse();
			RepeatedField<TitleIconContentHandle> titleIconContentHandles = getTitleIconsResponse.TitleIconContentHandles;
			RepeatedField<TitleIconContentHandle> repeatedField = new RepeatedField<TitleIconContentHandle>();
			repeatedField.Add(new TitleIconContentHandle
			{
				ContentHandle = new ContentHandle
				{
					Region = 21843U,
					Usage = request.Usage,
					Hash = ByteString.FromBase64(dictionary[request.TitleIds[0]]),
					ProtoUrl = "https://prod.depot.battle.net/${hash}.${usage}"
				},
				TitleId = request.TitleIds[0]
			});
			titleIconContentHandles.Add(repeatedField);
			return Task.FromResult<GetTitleIconsResponse>(getTitleIconsResponse);
		}
	}
}
