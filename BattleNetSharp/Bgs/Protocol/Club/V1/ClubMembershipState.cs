using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000470 RID: 1136
	public sealed class ClubMembershipState : IMessage<ClubMembershipState>, IMessage, IEquatable<ClubMembershipState>, IDeepCloneable<ClubMembershipState>, IBufferMessage
	{
		// Token: 0x1700238E RID: 9102
		// (get) Token: 0x06006F12 RID: 28434 RVA: 0x001B0204 File Offset: 0x001AE404
		[DebuggerNonUserCode]
		public static MessageParser<ClubMembershipState> Parser
		{
			get
			{
				return ClubMembershipState._parser;
			}
		}

		// Token: 0x1700238F RID: 9103
		// (get) Token: 0x06006F13 RID: 28435 RVA: 0x001B021C File Offset: 0x001AE41C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002390 RID: 9104
		// (get) Token: 0x06006F14 RID: 28436 RVA: 0x001B0240 File Offset: 0x001AE440
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubMembershipState.Descriptor;
			}
		}

		// Token: 0x06006F15 RID: 28437 RVA: 0x001B0257 File Offset: 0x001AE457
		[DebuggerNonUserCode]
		public ClubMembershipState()
		{
		}

		// Token: 0x06006F16 RID: 28438 RVA: 0x001B0278 File Offset: 0x001AE478
		[DebuggerNonUserCode]
		public ClubMembershipState(ClubMembershipState other)
			: this()
		{
			this.description_ = other.description_.Clone();
			this.invitation_ = other.invitation_.Clone();
			this.setting_ = ((other.setting_ != null) ? other.setting_.Clone() : null);
			this.mentionView_ = ((other.mentionView_ != null) ? other.mentionView_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F17 RID: 28439 RVA: 0x001B02F8 File Offset: 0x001AE4F8
		[DebuggerNonUserCode]
		public ClubMembershipState Clone()
		{
			return new ClubMembershipState(this);
		}

		// Token: 0x17002391 RID: 9105
		// (get) Token: 0x06006F18 RID: 28440 RVA: 0x001B0310 File Offset: 0x001AE510
		[DebuggerNonUserCode]
		public RepeatedField<ClubMembershipDescription> Description
		{
			get
			{
				return this.description_;
			}
		}

		// Token: 0x17002392 RID: 9106
		// (get) Token: 0x06006F19 RID: 28441 RVA: 0x001B0328 File Offset: 0x001AE528
		[DebuggerNonUserCode]
		public RepeatedField<ClubInvitation> Invitation
		{
			get
			{
				return this.invitation_;
			}
		}

		// Token: 0x17002393 RID: 9107
		// (get) Token: 0x06006F1A RID: 28442 RVA: 0x001B0340 File Offset: 0x001AE540
		// (set) Token: 0x06006F1B RID: 28443 RVA: 0x001B0358 File Offset: 0x001AE558
		[DebuggerNonUserCode]
		public ClubSharedSettings Setting
		{
			get
			{
				return this.setting_;
			}
			set
			{
				this.setting_ = value;
			}
		}

		// Token: 0x17002394 RID: 9108
		// (get) Token: 0x06006F1C RID: 28444 RVA: 0x001B0364 File Offset: 0x001AE564
		// (set) Token: 0x06006F1D RID: 28445 RVA: 0x001B037C File Offset: 0x001AE57C
		[DebuggerNonUserCode]
		public ViewMarker MentionView
		{
			get
			{
				return this.mentionView_;
			}
			set
			{
				this.mentionView_ = value;
			}
		}

		// Token: 0x06006F1E RID: 28446 RVA: 0x001B0388 File Offset: 0x001AE588
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubMembershipState);
		}

		// Token: 0x06006F1F RID: 28447 RVA: 0x001B03A8 File Offset: 0x001AE5A8
		[DebuggerNonUserCode]
		public bool Equals(ClubMembershipState other)
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
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Setting, other.Setting);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.MentionView, other.MentionView);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006F20 RID: 28448 RVA: 0x001B0464 File Offset: 0x001AE664
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.description_.GetHashCode();
			num ^= this.invitation_.GetHashCode();
			bool flag = this.setting_ != null;
			if (flag)
			{
				num ^= this.Setting.GetHashCode();
			}
			bool flag2 = this.mentionView_ != null;
			if (flag2)
			{
				num ^= this.MentionView.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F21 RID: 28449 RVA: 0x001B04EC File Offset: 0x001AE6EC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006F22 RID: 28450 RVA: 0x001B0504 File Offset: 0x001AE704
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F23 RID: 28451 RVA: 0x001B0510 File Offset: 0x001AE710
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.description_.WriteTo(ref output, ClubMembershipState._repeated_description_codec);
			this.invitation_.WriteTo(ref output, ClubMembershipState._repeated_invitation_codec);
			bool flag = this.setting_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Setting);
			}
			bool flag2 = this.mentionView_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.MentionView);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F24 RID: 28452 RVA: 0x001B05A8 File Offset: 0x001AE7A8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.description_.CalculateSize(ClubMembershipState._repeated_description_codec);
			num += this.invitation_.CalculateSize(ClubMembershipState._repeated_invitation_codec);
			bool flag = this.setting_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Setting);
			}
			bool flag2 = this.mentionView_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MentionView);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F25 RID: 28453 RVA: 0x001B0640 File Offset: 0x001AE840
		[DebuggerNonUserCode]
		public void MergeFrom(ClubMembershipState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.description_.Add(other.description_);
				this.invitation_.Add(other.invitation_);
				bool flag2 = other.setting_ != null;
				if (flag2)
				{
					bool flag3 = this.setting_ == null;
					if (flag3)
					{
						this.Setting = new ClubSharedSettings();
					}
					this.Setting.MergeFrom(other.Setting);
				}
				bool flag4 = other.mentionView_ != null;
				if (flag4)
				{
					bool flag5 = this.mentionView_ == null;
					if (flag5)
					{
						this.MentionView = new ViewMarker();
					}
					this.MentionView.MergeFrom(other.MentionView);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006F26 RID: 28454 RVA: 0x001B0711 File Offset: 0x001AE911
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F27 RID: 28455 RVA: 0x001B071C File Offset: 0x001AE91C
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
							goto IL_002C;
						}
						this.invitation_.AddEntriesFrom(ref input, ClubMembershipState._repeated_invitation_codec);
					}
					else
					{
						this.description_.AddEntriesFrom(ref input, ClubMembershipState._repeated_description_codec);
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						goto IL_002C;
					}
					bool flag = this.mentionView_ == null;
					if (flag)
					{
						this.MentionView = new ViewMarker();
					}
					input.ReadMessage(this.MentionView);
				}
				else
				{
					bool flag2 = this.setting_ == null;
					if (flag2)
					{
						this.Setting = new ClubSharedSettings();
					}
					input.ReadMessage(this.Setting);
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003301 RID: 13057
		private static readonly MessageParser<ClubMembershipState> _parser = new MessageParser<ClubMembershipState>(() => new ClubMembershipState());

		// Token: 0x04003302 RID: 13058
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003303 RID: 13059
		public const int DescriptionFieldNumber = 1;

		// Token: 0x04003304 RID: 13060
		private static readonly FieldCodec<ClubMembershipDescription> _repeated_description_codec = FieldCodec.ForMessage<ClubMembershipDescription>(10U, ClubMembershipDescription.Parser);

		// Token: 0x04003305 RID: 13061
		private readonly RepeatedField<ClubMembershipDescription> description_ = new RepeatedField<ClubMembershipDescription>();

		// Token: 0x04003306 RID: 13062
		public const int InvitationFieldNumber = 2;

		// Token: 0x04003307 RID: 13063
		private static readonly FieldCodec<ClubInvitation> _repeated_invitation_codec = FieldCodec.ForMessage<ClubInvitation>(18U, ClubInvitation.Parser);

		// Token: 0x04003308 RID: 13064
		private readonly RepeatedField<ClubInvitation> invitation_ = new RepeatedField<ClubInvitation>();

		// Token: 0x04003309 RID: 13065
		public const int SettingFieldNumber = 3;

		// Token: 0x0400330A RID: 13066
		private ClubSharedSettings setting_;

		// Token: 0x0400330B RID: 13067
		public const int MentionViewFieldNumber = 4;

		// Token: 0x0400330C RID: 13068
		private ViewMarker mentionView_;
	}
}
