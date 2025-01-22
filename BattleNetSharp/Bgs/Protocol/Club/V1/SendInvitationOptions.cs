using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000455 RID: 1109
	public sealed class SendInvitationOptions : IMessage<SendInvitationOptions>, IMessage, IEquatable<SendInvitationOptions>, IDeepCloneable<SendInvitationOptions>, IBufferMessage
	{
		// Token: 0x170022B3 RID: 8883
		// (get) Token: 0x06006C59 RID: 27737 RVA: 0x001A5180 File Offset: 0x001A3380
		[DebuggerNonUserCode]
		public static MessageParser<SendInvitationOptions> Parser
		{
			get
			{
				return SendInvitationOptions._parser;
			}
		}

		// Token: 0x170022B4 RID: 8884
		// (get) Token: 0x06006C5A RID: 27738 RVA: 0x001A5198 File Offset: 0x001A3398
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubInvitationReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170022B5 RID: 8885
		// (get) Token: 0x06006C5B RID: 27739 RVA: 0x001A51BC File Offset: 0x001A33BC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendInvitationOptions.Descriptor;
			}
		}

		// Token: 0x06006C5C RID: 27740 RVA: 0x001A51D3 File Offset: 0x001A33D3
		[DebuggerNonUserCode]
		public SendInvitationOptions()
		{
		}

		// Token: 0x06006C5D RID: 27741 RVA: 0x001A51E8 File Offset: 0x001A33E8
		[DebuggerNonUserCode]
		public SendInvitationOptions(SendInvitationOptions other)
			: this()
		{
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this.slot_ = ((other.slot_ != null) ? other.slot_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006C5E RID: 27742 RVA: 0x001A5258 File Offset: 0x001A3458
		[DebuggerNonUserCode]
		public SendInvitationOptions Clone()
		{
			return new SendInvitationOptions(this);
		}

		// Token: 0x170022B6 RID: 8886
		// (get) Token: 0x06006C5F RID: 27743 RVA: 0x001A5270 File Offset: 0x001A3470
		// (set) Token: 0x06006C60 RID: 27744 RVA: 0x001A5288 File Offset: 0x001A3488
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

		// Token: 0x170022B7 RID: 8887
		// (get) Token: 0x06006C61 RID: 27745 RVA: 0x001A5294 File Offset: 0x001A3494
		// (set) Token: 0x06006C62 RID: 27746 RVA: 0x001A52AC File Offset: 0x001A34AC
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

		// Token: 0x170022B8 RID: 8888
		// (get) Token: 0x06006C63 RID: 27747 RVA: 0x001A52B8 File Offset: 0x001A34B8
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x06006C64 RID: 27748 RVA: 0x001A52D0 File Offset: 0x001A34D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendInvitationOptions);
		}

		// Token: 0x06006C65 RID: 27749 RVA: 0x001A52F0 File Offset: 0x001A34F0
		[DebuggerNonUserCode]
		public bool Equals(SendInvitationOptions other)
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
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006C66 RID: 27750 RVA: 0x001A5388 File Offset: 0x001A3588
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
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006C67 RID: 27751 RVA: 0x001A5400 File Offset: 0x001A3600
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006C68 RID: 27752 RVA: 0x001A5418 File Offset: 0x001A3618
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006C69 RID: 27753 RVA: 0x001A5424 File Offset: 0x001A3624
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
			this.attribute_.WriteTo(ref output, SendInvitationOptions._repeated_attribute_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006C6A RID: 27754 RVA: 0x001A54AC File Offset: 0x001A36AC
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
			num += this.attribute_.CalculateSize(SendInvitationOptions._repeated_attribute_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006C6B RID: 27755 RVA: 0x001A5534 File Offset: 0x001A3734
		[DebuggerNonUserCode]
		public void MergeFrom(SendInvitationOptions other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006C6C RID: 27756 RVA: 0x001A55F3 File Offset: 0x001A37F3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006C6D RID: 27757 RVA: 0x001A5600 File Offset: 0x001A3800
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.attribute_.AddEntriesFrom(ref input, SendInvitationOptions._repeated_attribute_codec);
						}
					}
					else
					{
						bool flag = this.slot_ == null;
						if (flag)
						{
							this.Slot = new ClubSlot();
						}
						input.ReadMessage(this.Slot);
					}
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
		}

		// Token: 0x040031C0 RID: 12736
		private static readonly MessageParser<SendInvitationOptions> _parser = new MessageParser<SendInvitationOptions>(() => new SendInvitationOptions());

		// Token: 0x040031C1 RID: 12737
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031C2 RID: 12738
		public const int TargetIdFieldNumber = 1;

		// Token: 0x040031C3 RID: 12739
		private MemberId targetId_;

		// Token: 0x040031C4 RID: 12740
		public const int SlotFieldNumber = 2;

		// Token: 0x040031C5 RID: 12741
		private ClubSlot slot_;

		// Token: 0x040031C6 RID: 12742
		public const int AttributeFieldNumber = 3;

		// Token: 0x040031C7 RID: 12743
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(26U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040031C8 RID: 12744
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();
	}
}
