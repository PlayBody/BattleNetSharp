using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x0200051E RID: 1310
	public sealed class UpdateClubSharedSettingsRequest : IMessage<UpdateClubSharedSettingsRequest>, IMessage, IEquatable<UpdateClubSharedSettingsRequest>, IDeepCloneable<UpdateClubSharedSettingsRequest>, IBufferMessage
	{
		// Token: 0x1700285B RID: 10331
		// (get) Token: 0x06007F5A RID: 32602 RVA: 0x001EFF7C File Offset: 0x001EE17C
		[DebuggerNonUserCode]
		public static MessageParser<UpdateClubSharedSettingsRequest> Parser
		{
			get
			{
				return UpdateClubSharedSettingsRequest._parser;
			}
		}

		// Token: 0x1700285C RID: 10332
		// (get) Token: 0x06007F5B RID: 32603 RVA: 0x001EFF94 File Offset: 0x001EE194
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x1700285D RID: 10333
		// (get) Token: 0x06007F5C RID: 32604 RVA: 0x001EFFB8 File Offset: 0x001EE1B8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateClubSharedSettingsRequest.Descriptor;
			}
		}

		// Token: 0x06007F5D RID: 32605 RVA: 0x001EFFCF File Offset: 0x001EE1CF
		[DebuggerNonUserCode]
		public UpdateClubSharedSettingsRequest()
		{
		}

		// Token: 0x06007F5E RID: 32606 RVA: 0x001EFFDC File Offset: 0x001EE1DC
		[DebuggerNonUserCode]
		public UpdateClubSharedSettingsRequest(UpdateClubSharedSettingsRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F5F RID: 32607 RVA: 0x001F003C File Offset: 0x001EE23C
		[DebuggerNonUserCode]
		public UpdateClubSharedSettingsRequest Clone()
		{
			return new UpdateClubSharedSettingsRequest(this);
		}

		// Token: 0x1700285E RID: 10334
		// (get) Token: 0x06007F60 RID: 32608 RVA: 0x001F0054 File Offset: 0x001EE254
		// (set) Token: 0x06007F61 RID: 32609 RVA: 0x001F006C File Offset: 0x001EE26C
		[DebuggerNonUserCode]
		public AccountId AgentId
		{
			get
			{
				return this.agentId_;
			}
			set
			{
				this.agentId_ = value;
			}
		}

		// Token: 0x1700285F RID: 10335
		// (get) Token: 0x06007F62 RID: 32610 RVA: 0x001F0078 File Offset: 0x001EE278
		// (set) Token: 0x06007F63 RID: 32611 RVA: 0x001F0090 File Offset: 0x001EE290
		[DebuggerNonUserCode]
		public ClubSharedSettingsOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x06007F64 RID: 32612 RVA: 0x001F009C File Offset: 0x001EE29C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateClubSharedSettingsRequest);
		}

		// Token: 0x06007F65 RID: 32613 RVA: 0x001F00BC File Offset: 0x001EE2BC
		[DebuggerNonUserCode]
		public bool Equals(UpdateClubSharedSettingsRequest other)
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
					bool flag4 = !object.Equals(this.AgentId, other.AgentId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Options, other.Options);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007F66 RID: 32614 RVA: 0x001F0134 File Offset: 0x001EE334
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F67 RID: 32615 RVA: 0x001F01A0 File Offset: 0x001EE3A0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007F68 RID: 32616 RVA: 0x001F01B8 File Offset: 0x001EE3B8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F69 RID: 32617 RVA: 0x001F01C4 File Offset: 0x001EE3C4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F6A RID: 32618 RVA: 0x001F0238 File Offset: 0x001EE438
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F6B RID: 32619 RVA: 0x001F02AC File Offset: 0x001EE4AC
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateClubSharedSettingsRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.agentId_ != null;
				if (flag2)
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new AccountId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new ClubSharedSettingsOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007F6C RID: 32620 RVA: 0x001F0359 File Offset: 0x001EE559
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F6D RID: 32621 RVA: 0x001F0364 File Offset: 0x001EE564
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
						bool flag = this.options_ == null;
						if (flag)
						{
							this.Options = new ClubSharedSettingsOptions();
						}
						input.ReadMessage(this.Options);
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new AccountId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040039D4 RID: 14804
		private static readonly MessageParser<UpdateClubSharedSettingsRequest> _parser = new MessageParser<UpdateClubSharedSettingsRequest>(() => new UpdateClubSharedSettingsRequest());

		// Token: 0x040039D5 RID: 14805
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039D6 RID: 14806
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040039D7 RID: 14807
		private AccountId agentId_;

		// Token: 0x040039D8 RID: 14808
		public const int OptionsFieldNumber = 2;

		// Token: 0x040039D9 RID: 14809
		private ClubSharedSettingsOptions options_;
	}
}
