using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000ADB RID: 2779
	public class ConnectionContext : ServerCallContext
	{
		// Token: 0x1700392C RID: 14636
		// (get) Token: 0x0600BCC2 RID: 48322 RVA: 0x00483677 File Offset: 0x00481877
		protected override string MethodCore
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700392D RID: 14637
		// (get) Token: 0x0600BCC3 RID: 48323 RVA: 0x0048367E File Offset: 0x0048187E
		protected override string HostCore
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700392E RID: 14638
		// (get) Token: 0x0600BCC4 RID: 48324 RVA: 0x00483685 File Offset: 0x00481885
		protected override string PeerCore
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700392F RID: 14639
		// (get) Token: 0x0600BCC5 RID: 48325 RVA: 0x0048368C File Offset: 0x0048188C
		protected override DateTime DeadlineCore
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17003930 RID: 14640
		// (get) Token: 0x0600BCC6 RID: 48326 RVA: 0x0048369E File Offset: 0x0048189E
		protected override Metadata RequestHeadersCore
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17003931 RID: 14641
		// (get) Token: 0x0600BCC7 RID: 48327 RVA: 0x004836A8 File Offset: 0x004818A8
		protected override CancellationToken CancellationTokenCore
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17003932 RID: 14642
		// (get) Token: 0x0600BCC8 RID: 48328 RVA: 0x004836BA File Offset: 0x004818BA
		protected override Metadata ResponseTrailersCore
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17003933 RID: 14643
		// (get) Token: 0x0600BCC9 RID: 48329 RVA: 0x004836C4 File Offset: 0x004818C4
		// (set) Token: 0x0600BCCA RID: 48330 RVA: 0x004836D6 File Offset: 0x004818D6
		protected override Status StatusCore
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17003934 RID: 14644
		// (get) Token: 0x0600BCCB RID: 48331 RVA: 0x004836DD File Offset: 0x004818DD
		// (set) Token: 0x0600BCCC RID: 48332 RVA: 0x004836E4 File Offset: 0x004818E4
		protected override WriteOptions WriteOptionsCore
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17003935 RID: 14645
		// (get) Token: 0x0600BCCD RID: 48333 RVA: 0x004836EB File Offset: 0x004818EB
		protected override AuthContext AuthContextCore
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x0600BCCE RID: 48334 RVA: 0x004836F2 File Offset: 0x004818F2
		protected override ContextPropagationToken CreatePropagationTokenCore(ContextPropagationOptions options)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600BCCF RID: 48335 RVA: 0x004836FA File Offset: 0x004818FA
		protected override Task WriteResponseHeadersAsyncCore(Metadata responseHeaders)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04009157 RID: 37207
		public Guid Caller;
	}
}
