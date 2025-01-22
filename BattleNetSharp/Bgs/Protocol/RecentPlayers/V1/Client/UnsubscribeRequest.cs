using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x02000635 RID: 1589
	public sealed class UnsubscribeRequest : IMessage<UnsubscribeRequest>, IMessage, IEquatable<UnsubscribeRequest>, IDeepCloneable<UnsubscribeRequest>, IBufferMessage
	{
		// Token: 0x17002E3C RID: 11836
		// (get) Token: 0x0600941C RID: 37916 RVA: 0x0023DC24 File Offset: 0x0023BE24
		[DebuggerNonUserCode]
		public static MessageParser<UnsubscribeRequest> Parser
		{
			get
			{
				return UnsubscribeRequest._parser;
			}
		}

		// Token: 0x17002E3D RID: 11837
		// (get) Token: 0x0600941D RID: 37917 RVA: 0x0023DC3C File Offset: 0x0023BE3C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RecentPlayersServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002E3E RID: 11838
		// (get) Token: 0x0600941E RID: 37918 RVA: 0x0023DC60 File Offset: 0x0023BE60
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnsubscribeRequest.Descriptor;
			}
		}

		// Token: 0x0600941F RID: 37919 RVA: 0x0023DC77 File Offset: 0x0023BE77
		[DebuggerNonUserCode]
		public UnsubscribeRequest()
		{
		}

		// Token: 0x06009420 RID: 37920 RVA: 0x0023DC81 File Offset: 0x0023BE81
		[DebuggerNonUserCode]
		public UnsubscribeRequest(UnsubscribeRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009421 RID: 37921 RVA: 0x0023DC9C File Offset: 0x0023BE9C
		[DebuggerNonUserCode]
		public UnsubscribeRequest Clone()
		{
			return new UnsubscribeRequest(this);
		}

		// Token: 0x06009422 RID: 37922 RVA: 0x0023DCB4 File Offset: 0x0023BEB4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnsubscribeRequest);
		}

		// Token: 0x06009423 RID: 37923 RVA: 0x0023DCD4 File Offset: 0x0023BED4
		[DebuggerNonUserCode]
		public bool Equals(UnsubscribeRequest other)
		{
			bool flag = other == null;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = other == this;
				flag2 = flag3 || object.Equals(this._unknownFields, other._unknownFields);
			}
			return flag2;
		}

		// Token: 0x06009424 RID: 37924 RVA: 0x0023DD14 File Offset: 0x0023BF14
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009425 RID: 37925 RVA: 0x0023DD48 File Offset: 0x0023BF48
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009426 RID: 37926 RVA: 0x0023DD60 File Offset: 0x0023BF60
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009427 RID: 37927 RVA: 0x0023DD6C File Offset: 0x0023BF6C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009428 RID: 37928 RVA: 0x0023DD98 File Offset: 0x0023BF98
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009429 RID: 37929 RVA: 0x0023DDCC File Offset: 0x0023BFCC
		[DebuggerNonUserCode]
		public void MergeFrom(UnsubscribeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600942A RID: 37930 RVA: 0x0023DDFC File Offset: 0x0023BFFC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600942B RID: 37931 RVA: 0x0023DE08 File Offset: 0x0023C008
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040042CC RID: 17100
		private static readonly MessageParser<UnsubscribeRequest> _parser = new MessageParser<UnsubscribeRequest>(() => new UnsubscribeRequest());

		// Token: 0x040042CD RID: 17101
		private UnknownFieldSet _unknownFields;
	}
}
