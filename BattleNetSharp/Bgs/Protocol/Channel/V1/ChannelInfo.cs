using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006EA RID: 1770
	public sealed class ChannelInfo : IMessage<ChannelInfo>, IMessage, IEquatable<ChannelInfo>, IDeepCloneable<ChannelInfo>, IBufferMessage
	{
		// Token: 0x17003284 RID: 12932
		// (get) Token: 0x0600A329 RID: 41769 RVA: 0x0027C658 File Offset: 0x0027A858
		[DebuggerNonUserCode]
		public static MessageParser<ChannelInfo> Parser
		{
			get
			{
				return ChannelInfo._parser;
			}
		}

		// Token: 0x17003285 RID: 12933
		// (get) Token: 0x0600A32A RID: 41770 RVA: 0x0027C670 File Offset: 0x0027A870
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17003286 RID: 12934
		// (get) Token: 0x0600A32B RID: 41771 RVA: 0x0027C694 File Offset: 0x0027A894
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelInfo.Descriptor;
			}
		}

		// Token: 0x0600A32C RID: 41772 RVA: 0x0027C6AB File Offset: 0x0027A8AB
		[DebuggerNonUserCode]
		public ChannelInfo()
		{
		}

		// Token: 0x0600A32D RID: 41773 RVA: 0x0027C6C0 File Offset: 0x0027A8C0
		[DebuggerNonUserCode]
		public ChannelInfo(ChannelInfo other)
			: this()
		{
			this.description_ = ((other.description_ != null) ? other.description_.Clone() : null);
			this.member_ = other.member_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A32E RID: 41774 RVA: 0x0027C714 File Offset: 0x0027A914
		[DebuggerNonUserCode]
		public ChannelInfo Clone()
		{
			return new ChannelInfo(this);
		}

		// Token: 0x17003287 RID: 12935
		// (get) Token: 0x0600A32F RID: 41775 RVA: 0x0027C72C File Offset: 0x0027A92C
		// (set) Token: 0x0600A330 RID: 41776 RVA: 0x0027C744 File Offset: 0x0027A944
		[DebuggerNonUserCode]
		public ChannelDescription Description
		{
			get
			{
				return this.description_;
			}
			set
			{
				this.description_ = value;
			}
		}

		// Token: 0x17003288 RID: 12936
		// (get) Token: 0x0600A331 RID: 41777 RVA: 0x0027C750 File Offset: 0x0027A950
		[DebuggerNonUserCode]
		public RepeatedField<Member> Member
		{
			get
			{
				return this.member_;
			}
		}

		// Token: 0x0600A332 RID: 41778 RVA: 0x0027C768 File Offset: 0x0027A968
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelInfo);
		}

		// Token: 0x0600A333 RID: 41779 RVA: 0x0027C788 File Offset: 0x0027A988
		[DebuggerNonUserCode]
		public bool Equals(ChannelInfo other)
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
					bool flag4 = !object.Equals(this.Description, other.Description);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.member_.Equals(other.member_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A334 RID: 41780 RVA: 0x0027C800 File Offset: 0x0027AA00
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.description_ != null;
			if (flag)
			{
				num ^= this.Description.GetHashCode();
			}
			num ^= this.member_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A335 RID: 41781 RVA: 0x0027C85C File Offset: 0x0027AA5C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A336 RID: 41782 RVA: 0x0027C874 File Offset: 0x0027AA74
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A337 RID: 41783 RVA: 0x0027C880 File Offset: 0x0027AA80
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.description_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Description);
			}
			this.member_.WriteTo(ref output, ChannelInfo._repeated_member_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A338 RID: 41784 RVA: 0x0027C8E4 File Offset: 0x0027AAE4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.description_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Description);
			}
			num += this.member_.CalculateSize(ChannelInfo._repeated_member_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A339 RID: 41785 RVA: 0x0027C948 File Offset: 0x0027AB48
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.description_ != null;
				if (flag2)
				{
					bool flag3 = this.description_ == null;
					if (flag3)
					{
						this.Description = new ChannelDescription();
					}
					this.Description.MergeFrom(other.Description);
				}
				this.member_.Add(other.member_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A33A RID: 41786 RVA: 0x0027C9C6 File Offset: 0x0027ABC6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A33B RID: 41787 RVA: 0x0027C9D4 File Offset: 0x0027ABD4
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
						this.member_.AddEntriesFrom(ref input, ChannelInfo._repeated_member_codec);
					}
				}
				else
				{
					bool flag = this.description_ == null;
					if (flag)
					{
						this.Description = new ChannelDescription();
					}
					input.ReadMessage(this.Description);
				}
			}
		}

		// Token: 0x04004994 RID: 18836
		private static readonly MessageParser<ChannelInfo> _parser = new MessageParser<ChannelInfo>(() => new ChannelInfo());

		// Token: 0x04004995 RID: 18837
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004996 RID: 18838
		public const int DescriptionFieldNumber = 1;

		// Token: 0x04004997 RID: 18839
		private ChannelDescription description_;

		// Token: 0x04004998 RID: 18840
		public const int MemberFieldNumber = 2;

		// Token: 0x04004999 RID: 18841
		private static readonly FieldCodec<Member> _repeated_member_codec = FieldCodec.ForMessage<Member>(18U, Bgs.Protocol.Channel.V1.Member.Parser);

		// Token: 0x0400499A RID: 18842
		private readonly RepeatedField<Member> member_ = new RepeatedField<Member>();
	}
}
