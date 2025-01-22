using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200046C RID: 1132
	public sealed class ClubMembershipFilter : IMessage<ClubMembershipFilter>, IMessage, IEquatable<ClubMembershipFilter>, IDeepCloneable<ClubMembershipFilter>, IBufferMessage
	{
		// Token: 0x1700237C RID: 9084
		// (get) Token: 0x06006EC4 RID: 28356 RVA: 0x001AF2B4 File Offset: 0x001AD4B4
		[DebuggerNonUserCode]
		public static MessageParser<ClubMembershipFilter> Parser
		{
			get
			{
				return ClubMembershipFilter._parser;
			}
		}

		// Token: 0x1700237D RID: 9085
		// (get) Token: 0x06006EC5 RID: 28357 RVA: 0x001AF2CC File Offset: 0x001AD4CC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700237E RID: 9086
		// (get) Token: 0x06006EC6 RID: 28358 RVA: 0x001AF2F0 File Offset: 0x001AD4F0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubMembershipFilter.Descriptor;
			}
		}

		// Token: 0x06006EC7 RID: 28359 RVA: 0x001AF307 File Offset: 0x001AD507
		[DebuggerNonUserCode]
		public ClubMembershipFilter()
		{
		}

		// Token: 0x06006EC8 RID: 28360 RVA: 0x001AF314 File Offset: 0x001AD514
		[DebuggerNonUserCode]
		public ClubMembershipFilter(ClubMembershipFilter other)
			: this()
		{
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.type_ = ((other.type_ != null) ? other.type_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006EC9 RID: 28361 RVA: 0x001AF374 File Offset: 0x001AD574
		[DebuggerNonUserCode]
		public ClubMembershipFilter Clone()
		{
			return new ClubMembershipFilter(this);
		}

		// Token: 0x1700237F RID: 9087
		// (get) Token: 0x06006ECA RID: 28362 RVA: 0x001AF38C File Offset: 0x001AD58C
		// (set) Token: 0x06006ECB RID: 28363 RVA: 0x001AF3A4 File Offset: 0x001AD5A4
		[DebuggerNonUserCode]
		public MemberId MemberId
		{
			get
			{
				return this.memberId_;
			}
			set
			{
				this.memberId_ = value;
			}
		}

		// Token: 0x17002380 RID: 9088
		// (get) Token: 0x06006ECC RID: 28364 RVA: 0x001AF3B0 File Offset: 0x001AD5B0
		// (set) Token: 0x06006ECD RID: 28365 RVA: 0x001AF3C8 File Offset: 0x001AD5C8
		[DebuggerNonUserCode]
		public UniqueClubType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x06006ECE RID: 28366 RVA: 0x001AF3D4 File Offset: 0x001AD5D4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubMembershipFilter);
		}

		// Token: 0x06006ECF RID: 28367 RVA: 0x001AF3F4 File Offset: 0x001AD5F4
		[DebuggerNonUserCode]
		public bool Equals(ClubMembershipFilter other)
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
					bool flag4 = !object.Equals(this.MemberId, other.MemberId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Type, other.Type);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006ED0 RID: 28368 RVA: 0x001AF46C File Offset: 0x001AD66C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num ^= this.MemberId.GetHashCode();
			}
			bool flag2 = this.type_ != null;
			if (flag2)
			{
				num ^= this.Type.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006ED1 RID: 28369 RVA: 0x001AF4D8 File Offset: 0x001AD6D8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006ED2 RID: 28370 RVA: 0x001AF4F0 File Offset: 0x001AD6F0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006ED3 RID: 28371 RVA: 0x001AF4FC File Offset: 0x001AD6FC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.memberId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MemberId);
			}
			bool flag2 = this.type_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Type);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006ED4 RID: 28372 RVA: 0x001AF570 File Offset: 0x001AD770
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			bool flag2 = this.type_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Type);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006ED5 RID: 28373 RVA: 0x001AF5E4 File Offset: 0x001AD7E4
		[DebuggerNonUserCode]
		public void MergeFrom(ClubMembershipFilter other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.memberId_ != null;
				if (flag2)
				{
					bool flag3 = this.memberId_ == null;
					if (flag3)
					{
						this.MemberId = new MemberId();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				bool flag4 = other.type_ != null;
				if (flag4)
				{
					bool flag5 = this.type_ == null;
					if (flag5)
					{
						this.Type = new UniqueClubType();
					}
					this.Type.MergeFrom(other.Type);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006ED6 RID: 28374 RVA: 0x001AF691 File Offset: 0x001AD891
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006ED7 RID: 28375 RVA: 0x001AF69C File Offset: 0x001AD89C
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.type_ == null;
						if (flag)
						{
							this.Type = new UniqueClubType();
						}
						input.ReadMessage(this.Type);
					}
				}
				else
				{
					bool flag2 = this.memberId_ == null;
					if (flag2)
					{
						this.MemberId = new MemberId();
					}
					input.ReadMessage(this.MemberId);
				}
			}
		}

		// Token: 0x040032EB RID: 13035
		private static readonly MessageParser<ClubMembershipFilter> _parser = new MessageParser<ClubMembershipFilter>(() => new ClubMembershipFilter());

		// Token: 0x040032EC RID: 13036
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032ED RID: 13037
		public const int MemberIdFieldNumber = 1;

		// Token: 0x040032EE RID: 13038
		private MemberId memberId_;

		// Token: 0x040032EF RID: 13039
		public const int TypeFieldNumber = 2;

		// Token: 0x040032F0 RID: 13040
		private UniqueClubType type_;
	}
}
