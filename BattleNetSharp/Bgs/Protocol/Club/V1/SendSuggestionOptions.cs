using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000457 RID: 1111
	public sealed class SendSuggestionOptions : IMessage<SendSuggestionOptions>, IMessage, IEquatable<SendSuggestionOptions>, IDeepCloneable<SendSuggestionOptions>, IBufferMessage
	{
		// Token: 0x170022C8 RID: 8904
		// (get) Token: 0x06006C97 RID: 27799 RVA: 0x001A640C File Offset: 0x001A460C
		[DebuggerNonUserCode]
		public static MessageParser<SendSuggestionOptions> Parser
		{
			get
			{
				return SendSuggestionOptions._parser;
			}
		}

		// Token: 0x170022C9 RID: 8905
		// (get) Token: 0x06006C98 RID: 27800 RVA: 0x001A6424 File Offset: 0x001A4624
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubInvitationReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170022CA RID: 8906
		// (get) Token: 0x06006C99 RID: 27801 RVA: 0x001A6448 File Offset: 0x001A4648
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendSuggestionOptions.Descriptor;
			}
		}

		// Token: 0x06006C9A RID: 27802 RVA: 0x001A645F File Offset: 0x001A465F
		[DebuggerNonUserCode]
		public SendSuggestionOptions()
		{
		}

		// Token: 0x06006C9B RID: 27803 RVA: 0x001A6474 File Offset: 0x001A4674
		[DebuggerNonUserCode]
		public SendSuggestionOptions(SendSuggestionOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this.slot_ = ((other.slot_ != null) ? other.slot_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this.joinClubSource_ = other.joinClubSource_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006C9C RID: 27804 RVA: 0x001A64FC File Offset: 0x001A46FC
		[DebuggerNonUserCode]
		public SendSuggestionOptions Clone()
		{
			return new SendSuggestionOptions(this);
		}

		// Token: 0x170022CB RID: 8907
		// (get) Token: 0x06006C9D RID: 27805 RVA: 0x001A6514 File Offset: 0x001A4714
		// (set) Token: 0x06006C9E RID: 27806 RVA: 0x001A652C File Offset: 0x001A472C
		[DebuggerNonUserCode]
		public MemberId TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x170022CC RID: 8908
		// (get) Token: 0x06006C9F RID: 27807 RVA: 0x001A6538 File Offset: 0x001A4738
		// (set) Token: 0x06006CA0 RID: 27808 RVA: 0x001A6550 File Offset: 0x001A4750
		[DebuggerNonUserCode]
		public ClubSlot Slot
		{
			get
			{
				return this.slot_;
			}
			set
			{
				this.slot_ = value;
			}
		}

		// Token: 0x170022CD RID: 8909
		// (get) Token: 0x06006CA1 RID: 27809 RVA: 0x001A655C File Offset: 0x001A475C
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x170022CE RID: 8910
		// (get) Token: 0x06006CA2 RID: 27810 RVA: 0x001A6574 File Offset: 0x001A4774
		// (set) Token: 0x06006CA3 RID: 27811 RVA: 0x001A65A5 File Offset: 0x001A47A5
		[DebuggerNonUserCode]
		public uint JoinClubSource
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint joinClubSourceDefaultValue;
				if (flag)
				{
					joinClubSourceDefaultValue = this.joinClubSource_;
				}
				else
				{
					joinClubSourceDefaultValue = SendSuggestionOptions.JoinClubSourceDefaultValue;
				}
				return joinClubSourceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.joinClubSource_ = value;
			}
		}

		// Token: 0x170022CF RID: 8911
		// (get) Token: 0x06006CA4 RID: 27812 RVA: 0x001A65C0 File Offset: 0x001A47C0
		[DebuggerNonUserCode]
		public bool HasJoinClubSource
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006CA5 RID: 27813 RVA: 0x001A65DD File Offset: 0x001A47DD
		[DebuggerNonUserCode]
		public void ClearJoinClubSource()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06006CA6 RID: 27814 RVA: 0x001A65F0 File Offset: 0x001A47F0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendSuggestionOptions);
		}

		// Token: 0x06006CA7 RID: 27815 RVA: 0x001A6610 File Offset: 0x001A4810
		[DebuggerNonUserCode]
		public bool Equals(SendSuggestionOptions other)
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
					bool flag4 = !object.Equals(this.TargetId, other.TargetId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Slot, other.Slot);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.attribute_.Equals(other.attribute_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.JoinClubSource != other.JoinClubSource;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006CA8 RID: 27816 RVA: 0x001A66C8 File Offset: 0x001A48C8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.targetId_ != null;
			if (flag)
			{
				num ^= this.TargetId.GetHashCode();
			}
			bool flag2 = this.slot_ != null;
			if (flag2)
			{
				num ^= this.Slot.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasJoinClubSource = this.HasJoinClubSource;
			if (hasJoinClubSource)
			{
				num ^= this.JoinClubSource.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006CA9 RID: 27817 RVA: 0x001A6760 File Offset: 0x001A4960
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006CAA RID: 27818 RVA: 0x001A6778 File Offset: 0x001A4978
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006CAB RID: 27819 RVA: 0x001A6784 File Offset: 0x001A4984
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.targetId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.TargetId);
			}
			bool flag2 = this.slot_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Slot);
			}
			this.attribute_.WriteTo(ref output, SendSuggestionOptions._repeated_attribute_codec);
			bool hasJoinClubSource = this.HasJoinClubSource;
			if (hasJoinClubSource)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.JoinClubSource);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006CAC RID: 27820 RVA: 0x001A682C File Offset: 0x001A4A2C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.targetId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			}
			bool flag2 = this.slot_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Slot);
			}
			num += this.attribute_.CalculateSize(SendSuggestionOptions._repeated_attribute_codec);
			bool hasJoinClubSource = this.HasJoinClubSource;
			if (hasJoinClubSource)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JoinClubSource);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006CAD RID: 27821 RVA: 0x001A68D0 File Offset: 0x001A4AD0
		[DebuggerNonUserCode]
		public void MergeFrom(SendSuggestionOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.targetId_ != null;
				if (flag2)
				{
					bool flag3 = this.targetId_ == null;
					if (flag3)
					{
						this.TargetId = new MemberId();
					}
					this.TargetId.MergeFrom(other.TargetId);
				}
				bool flag4 = other.slot_ != null;
				if (flag4)
				{
					bool flag5 = this.slot_ == null;
					if (flag5)
					{
						this.Slot = new ClubSlot();
					}
					this.Slot.MergeFrom(other.Slot);
				}
				this.attribute_.Add(other.attribute_);
				bool hasJoinClubSource = other.HasJoinClubSource;
				if (hasJoinClubSource)
				{
					this.JoinClubSource = other.JoinClubSource;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006CAE RID: 27822 RVA: 0x001A69AA File Offset: 0x001A4BAA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006CAF RID: 27823 RVA: 0x001A69B8 File Offset: 0x001A4BB8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_002F;
						}
						bool flag = this.slot_ == null;
						if (flag)
						{
							this.Slot = new ClubSlot();
						}
						input.ReadMessage(this.Slot);
					}
					else
					{
						bool flag2 = this.targetId_ == null;
						if (flag2)
						{
							this.TargetId = new MemberId();
						}
						input.ReadMessage(this.TargetId);
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						goto IL_002F;
					}
					this.JoinClubSource = input.ReadUInt32();
				}
				else
				{
					this.attribute_.AddEntriesFrom(ref input, SendSuggestionOptions._repeated_attribute_codec);
				}
				continue;
				IL_002F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040031E2 RID: 12770
		private static readonly MessageParser<SendSuggestionOptions> _parser = new MessageParser<SendSuggestionOptions>(() => new SendSuggestionOptions());

		// Token: 0x040031E3 RID: 12771
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031E4 RID: 12772
		private int _hasBits0;

		// Token: 0x040031E5 RID: 12773
		public const int TargetIdFieldNumber = 1;

		// Token: 0x040031E6 RID: 12774
		private MemberId targetId_;

		// Token: 0x040031E7 RID: 12775
		public const int SlotFieldNumber = 2;

		// Token: 0x040031E8 RID: 12776
		private ClubSlot slot_;

		// Token: 0x040031E9 RID: 12777
		public const int AttributeFieldNumber = 3;

		// Token: 0x040031EA RID: 12778
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(26U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040031EB RID: 12779
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x040031EC RID: 12780
		public const int JoinClubSourceFieldNumber = 4;

		// Token: 0x040031ED RID: 12781
		private static readonly uint JoinClubSourceDefaultValue = 0U;

		// Token: 0x040031EE RID: 12782
		private uint joinClubSource_;
	}
}
