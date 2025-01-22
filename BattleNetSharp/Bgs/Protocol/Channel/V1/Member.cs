using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006EE RID: 1774
	public sealed class Member : IMessage<Member>, IMessage, IEquatable<Member>, IDeepCloneable<Member>, IBufferMessage
	{
		// Token: 0x170032AC RID: 12972
		// (get) Token: 0x0600A3A6 RID: 41894 RVA: 0x0027E378 File Offset: 0x0027C578
		[DebuggerNonUserCode]
		public static MessageParser<Member> Parser
		{
			get
			{
				return Member._parser;
			}
		}

		// Token: 0x170032AD RID: 12973
		// (get) Token: 0x0600A3A7 RID: 41895 RVA: 0x0027E390 File Offset: 0x0027C590
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x170032AE RID: 12974
		// (get) Token: 0x0600A3A8 RID: 41896 RVA: 0x0027E3B4 File Offset: 0x0027C5B4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Member.Descriptor;
			}
		}

		// Token: 0x0600A3A9 RID: 41897 RVA: 0x0027E3CB File Offset: 0x0027C5CB
		[DebuggerNonUserCode]
		public Member()
		{
		}

		// Token: 0x0600A3AA RID: 41898 RVA: 0x0027E3D8 File Offset: 0x0027C5D8
		[DebuggerNonUserCode]
		public Member(Member other)
			: this()
		{
			this.identity_ = ((other.identity_ != null) ? other.identity_.Clone() : null);
			this.state_ = ((other.state_ != null) ? other.state_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A3AB RID: 41899 RVA: 0x0027E438 File Offset: 0x0027C638
		[DebuggerNonUserCode]
		public Member Clone()
		{
			return new Member(this);
		}

		// Token: 0x170032AF RID: 12975
		// (get) Token: 0x0600A3AC RID: 41900 RVA: 0x0027E450 File Offset: 0x0027C650
		// (set) Token: 0x0600A3AD RID: 41901 RVA: 0x0027E468 File Offset: 0x0027C668
		[DebuggerNonUserCode]
		public Identity Identity
		{
			get
			{
				return this.identity_;
			}
			set
			{
				this.identity_ = value;
			}
		}

		// Token: 0x170032B0 RID: 12976
		// (get) Token: 0x0600A3AE RID: 41902 RVA: 0x0027E474 File Offset: 0x0027C674
		// (set) Token: 0x0600A3AF RID: 41903 RVA: 0x0027E48C File Offset: 0x0027C68C
		[DebuggerNonUserCode]
		public MemberState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x0600A3B0 RID: 41904 RVA: 0x0027E498 File Offset: 0x0027C698
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Member);
		}

		// Token: 0x0600A3B1 RID: 41905 RVA: 0x0027E4B8 File Offset: 0x0027C6B8
		[DebuggerNonUserCode]
		public bool Equals(Member other)
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
					bool flag4 = !object.Equals(this.Identity, other.Identity);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.State, other.State);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A3B2 RID: 41906 RVA: 0x0027E530 File Offset: 0x0027C730
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num ^= this.Identity.GetHashCode();
			}
			bool flag2 = this.state_ != null;
			if (flag2)
			{
				num ^= this.State.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A3B3 RID: 41907 RVA: 0x0027E59C File Offset: 0x0027C79C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A3B4 RID: 41908 RVA: 0x0027E5B4 File Offset: 0x0027C7B4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A3B5 RID: 41909 RVA: 0x0027E5C0 File Offset: 0x0027C7C0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.identity_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Identity);
			}
			bool flag2 = this.state_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.State);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A3B6 RID: 41910 RVA: 0x0027E634 File Offset: 0x0027C834
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Identity);
			}
			bool flag2 = this.state_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.State);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A3B7 RID: 41911 RVA: 0x0027E6A8 File Offset: 0x0027C8A8
		[DebuggerNonUserCode]
		public void MergeFrom(Member other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.identity_ != null;
				if (flag2)
				{
					bool flag3 = this.identity_ == null;
					if (flag3)
					{
						this.Identity = new Identity();
					}
					this.Identity.MergeFrom(other.Identity);
				}
				bool flag4 = other.state_ != null;
				if (flag4)
				{
					bool flag5 = this.state_ == null;
					if (flag5)
					{
						this.State = new MemberState();
					}
					this.State.MergeFrom(other.State);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A3B8 RID: 41912 RVA: 0x0027E755 File Offset: 0x0027C955
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A3B9 RID: 41913 RVA: 0x0027E760 File Offset: 0x0027C960
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
						bool flag = this.state_ == null;
						if (flag)
						{
							this.State = new MemberState();
						}
						input.ReadMessage(this.State);
					}
				}
				else
				{
					bool flag2 = this.identity_ == null;
					if (flag2)
					{
						this.Identity = new Identity();
					}
					input.ReadMessage(this.Identity);
				}
			}
		}

		// Token: 0x040049D0 RID: 18896
		private static readonly MessageParser<Member> _parser = new MessageParser<Member>(() => new Member());

		// Token: 0x040049D1 RID: 18897
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049D2 RID: 18898
		public const int IdentityFieldNumber = 1;

		// Token: 0x040049D3 RID: 18899
		private Identity identity_;

		// Token: 0x040049D4 RID: 18900
		public const int StateFieldNumber = 2;

		// Token: 0x040049D5 RID: 18901
		private MemberState state_;
	}
}
