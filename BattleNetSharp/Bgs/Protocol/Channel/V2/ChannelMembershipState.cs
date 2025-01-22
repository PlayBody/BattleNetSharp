using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000694 RID: 1684
	public sealed class ChannelMembershipState : IMessage<ChannelMembershipState>, IMessage, IEquatable<ChannelMembershipState>, IDeepCloneable<ChannelMembershipState>, IBufferMessage
	{
		// Token: 0x1700309D RID: 12445
		// (get) Token: 0x06009C52 RID: 40018 RVA: 0x0025FDE4 File Offset: 0x0025DFE4
		[DebuggerNonUserCode]
		public static MessageParser<ChannelMembershipState> Parser
		{
			get
			{
				return ChannelMembershipState._parser;
			}
		}

		// Token: 0x1700309E RID: 12446
		// (get) Token: 0x06009C53 RID: 40019 RVA: 0x0025FDFC File Offset: 0x0025DFFC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x1700309F RID: 12447
		// (get) Token: 0x06009C54 RID: 40020 RVA: 0x0025FE20 File Offset: 0x0025E020
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelMembershipState.Descriptor;
			}
		}

		// Token: 0x06009C55 RID: 40021 RVA: 0x0025FE37 File Offset: 0x0025E037
		[DebuggerNonUserCode]
		public ChannelMembershipState()
		{
		}

		// Token: 0x06009C56 RID: 40022 RVA: 0x0025FE57 File Offset: 0x0025E057
		[DebuggerNonUserCode]
		public ChannelMembershipState(ChannelMembershipState other)
			: this()
		{
			this.description_ = other.description_.Clone();
			this.invitation_ = other.invitation_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C57 RID: 40023 RVA: 0x0025FE94 File Offset: 0x0025E094
		[DebuggerNonUserCode]
		public ChannelMembershipState Clone()
		{
			return new ChannelMembershipState(this);
		}

		// Token: 0x170030A0 RID: 12448
		// (get) Token: 0x06009C58 RID: 40024 RVA: 0x0025FEAC File Offset: 0x0025E0AC
		[DebuggerNonUserCode]
		public RepeatedField<ChannelDescription> Description
		{
			get
			{
				return this.description_;
			}
		}

		// Token: 0x170030A1 RID: 12449
		// (get) Token: 0x06009C59 RID: 40025 RVA: 0x0025FEC4 File Offset: 0x0025E0C4
		[DebuggerNonUserCode]
		public RepeatedField<ChannelInvitation> Invitation
		{
			get
			{
				return this.invitation_;
			}
		}

		// Token: 0x06009C5A RID: 40026 RVA: 0x0025FEDC File Offset: 0x0025E0DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelMembershipState);
		}

		// Token: 0x06009C5B RID: 40027 RVA: 0x0025FEFC File Offset: 0x0025E0FC
		[DebuggerNonUserCode]
		public bool Equals(ChannelMembershipState other)
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
					bool flag4 = !this.description_.Equals(other.description_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.invitation_.Equals(other.invitation_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009C5C RID: 40028 RVA: 0x0025FF74 File Offset: 0x0025E174
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.description_.GetHashCode();
			num ^= this.invitation_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009C5D RID: 40029 RVA: 0x0025FFC4 File Offset: 0x0025E1C4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009C5E RID: 40030 RVA: 0x0025FFDC File Offset: 0x0025E1DC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C5F RID: 40031 RVA: 0x0025FFE8 File Offset: 0x0025E1E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.description_.WriteTo(ref output, ChannelMembershipState._repeated_description_codec);
			this.invitation_.WriteTo(ref output, ChannelMembershipState._repeated_invitation_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C60 RID: 40032 RVA: 0x00260038 File Offset: 0x0025E238
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.description_.CalculateSize(ChannelMembershipState._repeated_description_codec);
			num += this.invitation_.CalculateSize(ChannelMembershipState._repeated_invitation_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C61 RID: 40033 RVA: 0x00260090 File Offset: 0x0025E290
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelMembershipState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.description_.Add(other.description_);
				this.invitation_.Add(other.invitation_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009C62 RID: 40034 RVA: 0x002600E4 File Offset: 0x0025E2E4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C63 RID: 40035 RVA: 0x002600F0 File Offset: 0x0025E2F0
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
						this.invitation_.AddEntriesFrom(ref input, ChannelMembershipState._repeated_invitation_codec);
					}
				}
				else
				{
					this.description_.AddEntriesFrom(ref input, ChannelMembershipState._repeated_description_codec);
				}
			}
		}

		// Token: 0x04004695 RID: 18069
		private static readonly MessageParser<ChannelMembershipState> _parser = new MessageParser<ChannelMembershipState>(() => new ChannelMembershipState());

		// Token: 0x04004696 RID: 18070
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004697 RID: 18071
		public const int DescriptionFieldNumber = 1;

		// Token: 0x04004698 RID: 18072
		private static readonly FieldCodec<ChannelDescription> _repeated_description_codec = FieldCodec.ForMessage<ChannelDescription>(10U, ChannelDescription.Parser);

		// Token: 0x04004699 RID: 18073
		private readonly RepeatedField<ChannelDescription> description_ = new RepeatedField<ChannelDescription>();

		// Token: 0x0400469A RID: 18074
		public const int InvitationFieldNumber = 2;

		// Token: 0x0400469B RID: 18075
		private static readonly FieldCodec<ChannelInvitation> _repeated_invitation_codec = FieldCodec.ForMessage<ChannelInvitation>(18U, ChannelInvitation.Parser);

		// Token: 0x0400469C RID: 18076
		private readonly RepeatedField<ChannelInvitation> invitation_ = new RepeatedField<ChannelInvitation>();
	}
}
