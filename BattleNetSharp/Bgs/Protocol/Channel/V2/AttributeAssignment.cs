using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000688 RID: 1672
	public sealed class AttributeAssignment : IMessage<AttributeAssignment>, IMessage, IEquatable<AttributeAssignment>, IDeepCloneable<AttributeAssignment>, IBufferMessage
	{
		// Token: 0x17003034 RID: 12340
		// (get) Token: 0x06009B0B RID: 39691 RVA: 0x0025ACC8 File Offset: 0x00258EC8
		[DebuggerNonUserCode]
		public static MessageParser<AttributeAssignment> Parser
		{
			get
			{
				return AttributeAssignment._parser;
			}
		}

		// Token: 0x17003035 RID: 12341
		// (get) Token: 0x06009B0C RID: 39692 RVA: 0x0025ACE0 File Offset: 0x00258EE0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17003036 RID: 12342
		// (get) Token: 0x06009B0D RID: 39693 RVA: 0x0025AD04 File Offset: 0x00258F04
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeAssignment.Descriptor;
			}
		}

		// Token: 0x06009B0E RID: 39694 RVA: 0x0025AD1B File Offset: 0x00258F1B
		[DebuggerNonUserCode]
		public AttributeAssignment()
		{
		}

		// Token: 0x06009B0F RID: 39695 RVA: 0x0025AD30 File Offset: 0x00258F30
		[DebuggerNonUserCode]
		public AttributeAssignment(AttributeAssignment other)
			: this()
		{
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B10 RID: 39696 RVA: 0x0025AD84 File Offset: 0x00258F84
		[DebuggerNonUserCode]
		public AttributeAssignment Clone()
		{
			return new AttributeAssignment(this);
		}

		// Token: 0x17003037 RID: 12343
		// (get) Token: 0x06009B11 RID: 39697 RVA: 0x0025AD9C File Offset: 0x00258F9C
		// (set) Token: 0x06009B12 RID: 39698 RVA: 0x0025ADB4 File Offset: 0x00258FB4
		[DebuggerNonUserCode]
		public GameAccountHandle MemberId
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

		// Token: 0x17003038 RID: 12344
		// (get) Token: 0x06009B13 RID: 39699 RVA: 0x0025ADC0 File Offset: 0x00258FC0
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x06009B14 RID: 39700 RVA: 0x0025ADD8 File Offset: 0x00258FD8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeAssignment);
		}

		// Token: 0x06009B15 RID: 39701 RVA: 0x0025ADF8 File Offset: 0x00258FF8
		[DebuggerNonUserCode]
		public bool Equals(AttributeAssignment other)
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
						bool flag5 = !this.attribute_.Equals(other.attribute_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009B16 RID: 39702 RVA: 0x0025AE70 File Offset: 0x00259070
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num ^= this.MemberId.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009B17 RID: 39703 RVA: 0x0025AECC File Offset: 0x002590CC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009B18 RID: 39704 RVA: 0x0025AEE4 File Offset: 0x002590E4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B19 RID: 39705 RVA: 0x0025AEF0 File Offset: 0x002590F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.memberId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MemberId);
			}
			this.attribute_.WriteTo(ref output, AttributeAssignment._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B1A RID: 39706 RVA: 0x0025AF54 File Offset: 0x00259154
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			num += this.attribute_.CalculateSize(AttributeAssignment._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B1B RID: 39707 RVA: 0x0025AFB8 File Offset: 0x002591B8
		[DebuggerNonUserCode]
		public void MergeFrom(AttributeAssignment other)
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
						this.MemberId = new GameAccountHandle();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009B1C RID: 39708 RVA: 0x0025B036 File Offset: 0x00259236
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B1D RID: 39709 RVA: 0x0025B044 File Offset: 0x00259244
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
						this.attribute_.AddEntriesFrom(ref input, AttributeAssignment._repeated_attribute_codec);
					}
				}
				else
				{
					bool flag = this.memberId_ == null;
					if (flag)
					{
						this.MemberId = new GameAccountHandle();
					}
					input.ReadMessage(this.MemberId);
				}
			}
		}

		// Token: 0x040045F2 RID: 17906
		private static readonly MessageParser<AttributeAssignment> _parser = new MessageParser<AttributeAssignment>(() => new AttributeAssignment());

		// Token: 0x040045F3 RID: 17907
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045F4 RID: 17908
		public const int MemberIdFieldNumber = 1;

		// Token: 0x040045F5 RID: 17909
		private GameAccountHandle memberId_;

		// Token: 0x040045F6 RID: 17910
		public const int AttributeFieldNumber = 2;

		// Token: 0x040045F7 RID: 17911
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040045F8 RID: 17912
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();
	}
}
