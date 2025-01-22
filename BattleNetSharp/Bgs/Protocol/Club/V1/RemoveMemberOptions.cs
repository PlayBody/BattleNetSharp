using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200045E RID: 1118
	public sealed class RemoveMemberOptions : IMessage<RemoveMemberOptions>, IMessage, IEquatable<RemoveMemberOptions>, IDeepCloneable<RemoveMemberOptions>, IBufferMessage
	{
		// Token: 0x17002317 RID: 8983
		// (get) Token: 0x06006D71 RID: 28017 RVA: 0x001AA584 File Offset: 0x001A8784
		[DebuggerNonUserCode]
		public static MessageParser<RemoveMemberOptions> Parser
		{
			get
			{
				return RemoveMemberOptions._parser;
			}
		}

		// Token: 0x17002318 RID: 8984
		// (get) Token: 0x06006D72 RID: 28018 RVA: 0x001AA59C File Offset: 0x001A879C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMemberReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002319 RID: 8985
		// (get) Token: 0x06006D73 RID: 28019 RVA: 0x001AA5C0 File Offset: 0x001A87C0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveMemberOptions.Descriptor;
			}
		}

		// Token: 0x06006D74 RID: 28020 RVA: 0x001AA5D7 File Offset: 0x001A87D7
		[DebuggerNonUserCode]
		public RemoveMemberOptions()
		{
		}

		// Token: 0x06006D75 RID: 28021 RVA: 0x001AA5E4 File Offset: 0x001A87E4
		[DebuggerNonUserCode]
		public RemoveMemberOptions(RemoveMemberOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = ((other.id_ != null) ? other.id_.Clone() : null);
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D76 RID: 28022 RVA: 0x001AA640 File Offset: 0x001A8840
		[DebuggerNonUserCode]
		public RemoveMemberOptions Clone()
		{
			return new RemoveMemberOptions(this);
		}

		// Token: 0x1700231A RID: 8986
		// (get) Token: 0x06006D77 RID: 28023 RVA: 0x001AA658 File Offset: 0x001A8858
		// (set) Token: 0x06006D78 RID: 28024 RVA: 0x001AA670 File Offset: 0x001A8870
		[DebuggerNonUserCode]
		public MemberId Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700231B RID: 8987
		// (get) Token: 0x06006D79 RID: 28025 RVA: 0x001AA67C File Offset: 0x001A887C
		// (set) Token: 0x06006D7A RID: 28026 RVA: 0x001AA6AD File Offset: 0x001A88AD
		[DebuggerNonUserCode]
		public ClubRemovedReason Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ClubRemovedReason reasonDefaultValue;
				if (flag)
				{
					reasonDefaultValue = this.reason_;
				}
				else
				{
					reasonDefaultValue = RemoveMemberOptions.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reason_ = value;
			}
		}

		// Token: 0x1700231C RID: 8988
		// (get) Token: 0x06006D7B RID: 28027 RVA: 0x001AA6C8 File Offset: 0x001A88C8
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006D7C RID: 28028 RVA: 0x001AA6E5 File Offset: 0x001A88E5
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06006D7D RID: 28029 RVA: 0x001AA6F8 File Offset: 0x001A88F8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveMemberOptions);
		}

		// Token: 0x06006D7E RID: 28030 RVA: 0x001AA718 File Offset: 0x001A8918
		[DebuggerNonUserCode]
		public bool Equals(RemoveMemberOptions other)
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
					bool flag4 = !object.Equals(this.Id, other.Id);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Reason != other.Reason;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006D7F RID: 28031 RVA: 0x001AA78C File Offset: 0x001A898C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.id_ != null;
			if (flag)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006D80 RID: 28032 RVA: 0x001AA800 File Offset: 0x001A8A00
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006D81 RID: 28033 RVA: 0x001AA818 File Offset: 0x001A8A18
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D82 RID: 28034 RVA: 0x001AA824 File Offset: 0x001A8A24
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.id_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Id);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Reason);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006D83 RID: 28035 RVA: 0x001AA898 File Offset: 0x001A8A98
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.id_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Id);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006D84 RID: 28036 RVA: 0x001AA908 File Offset: 0x001A8B08
		[DebuggerNonUserCode]
		public void MergeFrom(RemoveMemberOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.id_ != null;
				if (flag2)
				{
					bool flag3 = this.id_ == null;
					if (flag3)
					{
						this.Id = new MemberId();
					}
					this.Id.MergeFrom(other.Id);
				}
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006D85 RID: 28037 RVA: 0x001AA98D File Offset: 0x001A8B8D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D86 RID: 28038 RVA: 0x001AA998 File Offset: 0x001A8B98
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Reason = (ClubRemovedReason)input.ReadEnum();
					}
				}
				else
				{
					bool flag = this.id_ == null;
					if (flag)
					{
						this.Id = new MemberId();
					}
					input.ReadMessage(this.Id);
				}
			}
		}

		// Token: 0x0400325E RID: 12894
		private static readonly MessageParser<RemoveMemberOptions> _parser = new MessageParser<RemoveMemberOptions>(() => new RemoveMemberOptions());

		// Token: 0x0400325F RID: 12895
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003260 RID: 12896
		private int _hasBits0;

		// Token: 0x04003261 RID: 12897
		public const int IdFieldNumber = 1;

		// Token: 0x04003262 RID: 12898
		private MemberId id_;

		// Token: 0x04003263 RID: 12899
		public const int ReasonFieldNumber = 2;

		// Token: 0x04003264 RID: 12900
		private static readonly ClubRemovedReason ReasonDefaultValue = ClubRemovedReason.None;

		// Token: 0x04003265 RID: 12901
		private ClubRemovedReason reason_;
	}
}
