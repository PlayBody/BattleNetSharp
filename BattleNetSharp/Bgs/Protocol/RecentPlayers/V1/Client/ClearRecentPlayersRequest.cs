using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x02000639 RID: 1593
	public sealed class ClearRecentPlayersRequest : IMessage<ClearRecentPlayersRequest>, IMessage, IEquatable<ClearRecentPlayersRequest>, IDeepCloneable<ClearRecentPlayersRequest>, IBufferMessage
	{
		// Token: 0x17002E4A RID: 11850
		// (get) Token: 0x06009464 RID: 37988 RVA: 0x0023E76C File Offset: 0x0023C96C
		[DebuggerNonUserCode]
		public static MessageParser<ClearRecentPlayersRequest> Parser
		{
			get
			{
				return ClearRecentPlayersRequest._parser;
			}
		}

		// Token: 0x17002E4B RID: 11851
		// (get) Token: 0x06009465 RID: 37989 RVA: 0x0023E784 File Offset: 0x0023C984
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RecentPlayersServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17002E4C RID: 11852
		// (get) Token: 0x06009466 RID: 37990 RVA: 0x0023E7A8 File Offset: 0x0023C9A8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClearRecentPlayersRequest.Descriptor;
			}
		}

		// Token: 0x06009467 RID: 37991 RVA: 0x0023E7BF File Offset: 0x0023C9BF
		[DebuggerNonUserCode]
		public ClearRecentPlayersRequest()
		{
		}

		// Token: 0x06009468 RID: 37992 RVA: 0x0023E7C9 File Offset: 0x0023C9C9
		[DebuggerNonUserCode]
		public ClearRecentPlayersRequest(ClearRecentPlayersRequest other)
			: this()
		{
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009469 RID: 37993 RVA: 0x0023E800 File Offset: 0x0023CA00
		[DebuggerNonUserCode]
		public ClearRecentPlayersRequest Clone()
		{
			return new ClearRecentPlayersRequest(this);
		}

		// Token: 0x17002E4D RID: 11853
		// (get) Token: 0x0600946A RID: 37994 RVA: 0x0023E818 File Offset: 0x0023CA18
		// (set) Token: 0x0600946B RID: 37995 RVA: 0x0023E830 File Offset: 0x0023CA30
		[DebuggerNonUserCode]
		public ClearRecentPlayersOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x0600946C RID: 37996 RVA: 0x0023E83C File Offset: 0x0023CA3C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClearRecentPlayersRequest);
		}

		// Token: 0x0600946D RID: 37997 RVA: 0x0023E85C File Offset: 0x0023CA5C
		[DebuggerNonUserCode]
		public bool Equals(ClearRecentPlayersRequest other)
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
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = !object.Equals(this.Options, other.Options);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600946E RID: 37998 RVA: 0x0023E8B8 File Offset: 0x0023CAB8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.options_ != null;
			if (flag)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600946F RID: 37999 RVA: 0x0023E908 File Offset: 0x0023CB08
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009470 RID: 38000 RVA: 0x0023E920 File Offset: 0x0023CB20
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009471 RID: 38001 RVA: 0x0023E92C File Offset: 0x0023CB2C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.options_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Options);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009472 RID: 38002 RVA: 0x0023E97C File Offset: 0x0023CB7C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.options_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009473 RID: 38003 RVA: 0x0023E9D0 File Offset: 0x0023CBD0
		[DebuggerNonUserCode]
		public void MergeFrom(ClearRecentPlayersRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.options_ != null;
				if (flag2)
				{
					bool flag3 = this.options_ == null;
					if (flag3)
					{
						this.Options = new ClearRecentPlayersOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009474 RID: 38004 RVA: 0x0023EA3C File Offset: 0x0023CC3C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009475 RID: 38005 RVA: 0x0023EA48 File Offset: 0x0023CC48
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.options_ == null;
					if (flag)
					{
						this.Options = new ClearRecentPlayersOptions();
					}
					input.ReadMessage(this.Options);
				}
			}
		}

		// Token: 0x040042D8 RID: 17112
		private static readonly MessageParser<ClearRecentPlayersRequest> _parser = new MessageParser<ClearRecentPlayersRequest>(() => new ClearRecentPlayersRequest());

		// Token: 0x040042D9 RID: 17113
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042DA RID: 17114
		public const int OptionsFieldNumber = 2;

		// Token: 0x040042DB RID: 17115
		private ClearRecentPlayersOptions options_;
	}
}
