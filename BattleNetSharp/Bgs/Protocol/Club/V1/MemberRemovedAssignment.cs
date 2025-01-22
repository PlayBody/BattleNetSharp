using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200045F RID: 1119
	public sealed class MemberRemovedAssignment : IMessage<MemberRemovedAssignment>, IMessage, IEquatable<MemberRemovedAssignment>, IDeepCloneable<MemberRemovedAssignment>, IBufferMessage
	{
		// Token: 0x1700231D RID: 8989
		// (get) Token: 0x06006D88 RID: 28040 RVA: 0x001AAA40 File Offset: 0x001A8C40
		[DebuggerNonUserCode]
		public static MessageParser<MemberRemovedAssignment> Parser
		{
			get
			{
				return MemberRemovedAssignment._parser;
			}
		}

		// Token: 0x1700231E RID: 8990
		// (get) Token: 0x06006D89 RID: 28041 RVA: 0x001AAA58 File Offset: 0x001A8C58
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMemberReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x1700231F RID: 8991
		// (get) Token: 0x06006D8A RID: 28042 RVA: 0x001AAA7C File Offset: 0x001A8C7C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberRemovedAssignment.Descriptor;
			}
		}

		// Token: 0x06006D8B RID: 28043 RVA: 0x001AAA93 File Offset: 0x001A8C93
		[DebuggerNonUserCode]
		public MemberRemovedAssignment()
		{
		}

		// Token: 0x06006D8C RID: 28044 RVA: 0x001AAAA0 File Offset: 0x001A8CA0
		[DebuggerNonUserCode]
		public MemberRemovedAssignment(MemberRemovedAssignment other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = ((other.id_ != null) ? other.id_.Clone() : null);
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D8D RID: 28045 RVA: 0x001AAAFC File Offset: 0x001A8CFC
		[DebuggerNonUserCode]
		public MemberRemovedAssignment Clone()
		{
			return new MemberRemovedAssignment(this);
		}

		// Token: 0x17002320 RID: 8992
		// (get) Token: 0x06006D8E RID: 28046 RVA: 0x001AAB14 File Offset: 0x001A8D14
		// (set) Token: 0x06006D8F RID: 28047 RVA: 0x001AAB2C File Offset: 0x001A8D2C
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

		// Token: 0x17002321 RID: 8993
		// (get) Token: 0x06006D90 RID: 28048 RVA: 0x001AAB38 File Offset: 0x001A8D38
		// (set) Token: 0x06006D91 RID: 28049 RVA: 0x001AAB69 File Offset: 0x001A8D69
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
					reasonDefaultValue = MemberRemovedAssignment.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reason_ = value;
			}
		}

		// Token: 0x17002322 RID: 8994
		// (get) Token: 0x06006D92 RID: 28050 RVA: 0x001AAB84 File Offset: 0x001A8D84
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006D93 RID: 28051 RVA: 0x001AABA1 File Offset: 0x001A8DA1
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06006D94 RID: 28052 RVA: 0x001AABB4 File Offset: 0x001A8DB4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberRemovedAssignment);
		}

		// Token: 0x06006D95 RID: 28053 RVA: 0x001AABD4 File Offset: 0x001A8DD4
		[DebuggerNonUserCode]
		public bool Equals(MemberRemovedAssignment other)
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

		// Token: 0x06006D96 RID: 28054 RVA: 0x001AAC48 File Offset: 0x001A8E48
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

		// Token: 0x06006D97 RID: 28055 RVA: 0x001AACBC File Offset: 0x001A8EBC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006D98 RID: 28056 RVA: 0x001AACD4 File Offset: 0x001A8ED4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D99 RID: 28057 RVA: 0x001AACE0 File Offset: 0x001A8EE0
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

		// Token: 0x06006D9A RID: 28058 RVA: 0x001AAD54 File Offset: 0x001A8F54
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

		// Token: 0x06006D9B RID: 28059 RVA: 0x001AADC4 File Offset: 0x001A8FC4
		[DebuggerNonUserCode]
		public void MergeFrom(MemberRemovedAssignment other)
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

		// Token: 0x06006D9C RID: 28060 RVA: 0x001AAE49 File Offset: 0x001A9049
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D9D RID: 28061 RVA: 0x001AAE54 File Offset: 0x001A9054
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

		// Token: 0x04003266 RID: 12902
		private static readonly MessageParser<MemberRemovedAssignment> _parser = new MessageParser<MemberRemovedAssignment>(() => new MemberRemovedAssignment());

		// Token: 0x04003267 RID: 12903
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003268 RID: 12904
		private int _hasBits0;

		// Token: 0x04003269 RID: 12905
		public const int IdFieldNumber = 1;

		// Token: 0x0400326A RID: 12906
		private MemberId id_;

		// Token: 0x0400326B RID: 12907
		public const int ReasonFieldNumber = 2;

		// Token: 0x0400326C RID: 12908
		private static readonly ClubRemovedReason ReasonDefaultValue = ClubRemovedReason.None;

		// Token: 0x0400326D RID: 12909
		private ClubRemovedReason reason_;
	}
}
