using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006BE RID: 1726
	public sealed class RevokeInvitationRequest : IMessage<RevokeInvitationRequest>, IMessage, IEquatable<RevokeInvitationRequest>, IDeepCloneable<RevokeInvitationRequest>, IBufferMessage
	{
		// Token: 0x17003180 RID: 12672
		// (get) Token: 0x06009F8D RID: 40845 RVA: 0x0026CE00 File Offset: 0x0026B000
		[DebuggerNonUserCode]
		public static MessageParser<RevokeInvitationRequest> Parser
		{
			get
			{
				return RevokeInvitationRequest._parser;
			}
		}

		// Token: 0x17003181 RID: 12673
		// (get) Token: 0x06009F8E RID: 40846 RVA: 0x0026CE18 File Offset: 0x0026B018
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17003182 RID: 12674
		// (get) Token: 0x06009F8F RID: 40847 RVA: 0x0026CE3C File Offset: 0x0026B03C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RevokeInvitationRequest.Descriptor;
			}
		}

		// Token: 0x06009F90 RID: 40848 RVA: 0x0026CE53 File Offset: 0x0026B053
		[DebuggerNonUserCode]
		public RevokeInvitationRequest()
		{
		}

		// Token: 0x06009F91 RID: 40849 RVA: 0x0026CE60 File Offset: 0x0026B060
		[DebuggerNonUserCode]
		public RevokeInvitationRequest(RevokeInvitationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.invitationId_ = other.invitationId_;
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F92 RID: 40850 RVA: 0x0026CEBC File Offset: 0x0026B0BC
		[DebuggerNonUserCode]
		public RevokeInvitationRequest Clone()
		{
			return new RevokeInvitationRequest(this);
		}

		// Token: 0x17003183 RID: 12675
		// (get) Token: 0x06009F93 RID: 40851 RVA: 0x0026CED4 File Offset: 0x0026B0D4
		// (set) Token: 0x06009F94 RID: 40852 RVA: 0x0026CF05 File Offset: 0x0026B105
		[DebuggerNonUserCode]
		public ulong InvitationId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong invitationIdDefaultValue;
				if (flag)
				{
					invitationIdDefaultValue = this.invitationId_;
				}
				else
				{
					invitationIdDefaultValue = RevokeInvitationRequest.InvitationIdDefaultValue;
				}
				return invitationIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.invitationId_ = value;
			}
		}

		// Token: 0x17003184 RID: 12676
		// (get) Token: 0x06009F95 RID: 40853 RVA: 0x0026CF20 File Offset: 0x0026B120
		[DebuggerNonUserCode]
		public bool HasInvitationId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009F96 RID: 40854 RVA: 0x0026CF3D File Offset: 0x0026B13D
		[DebuggerNonUserCode]
		public void ClearInvitationId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003185 RID: 12677
		// (get) Token: 0x06009F97 RID: 40855 RVA: 0x0026CF50 File Offset: 0x0026B150
		// (set) Token: 0x06009F98 RID: 40856 RVA: 0x0026CF68 File Offset: 0x0026B168
		[DebuggerNonUserCode]
		public EntityId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x06009F99 RID: 40857 RVA: 0x0026CF74 File Offset: 0x0026B174
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RevokeInvitationRequest);
		}

		// Token: 0x06009F9A RID: 40858 RVA: 0x0026CF94 File Offset: 0x0026B194
		[DebuggerNonUserCode]
		public bool Equals(RevokeInvitationRequest other)
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
					bool flag4 = this.InvitationId != other.InvitationId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.ChannelId, other.ChannelId);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009F9B RID: 40859 RVA: 0x0026D008 File Offset: 0x0026B208
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				num ^= this.InvitationId.GetHashCode();
			}
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F9C RID: 40860 RVA: 0x0026D074 File Offset: 0x0026B274
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009F9D RID: 40861 RVA: 0x0026D08C File Offset: 0x0026B28C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F9E RID: 40862 RVA: 0x0026D098 File Offset: 0x0026B298
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				output.WriteRawTag(25);
				output.WriteFixed64(this.InvitationId);
			}
			bool flag = this.channelId_ != null;
			if (flag)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ChannelId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F9F RID: 40863 RVA: 0x0026D10C File Offset: 0x0026B30C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				num += 9;
			}
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009FA0 RID: 40864 RVA: 0x0026D170 File Offset: 0x0026B370
		[DebuggerNonUserCode]
		public void MergeFrom(RevokeInvitationRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasInvitationId = other.HasInvitationId;
				if (hasInvitationId)
				{
					this.InvitationId = other.InvitationId;
				}
				bool flag2 = other.channelId_ != null;
				if (flag2)
				{
					bool flag3 = this.channelId_ == null;
					if (flag3)
					{
						this.ChannelId = new EntityId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009FA1 RID: 40865 RVA: 0x0026D1F5 File Offset: 0x0026B3F5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009FA2 RID: 40866 RVA: 0x0026D200 File Offset: 0x0026B400
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 25U)
				{
					if (num3 != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.channelId_ == null;
						if (flag)
						{
							this.ChannelId = new EntityId();
						}
						input.ReadMessage(this.ChannelId);
					}
				}
				else
				{
					this.InvitationId = input.ReadFixed64();
				}
			}
		}

		// Token: 0x040047EA RID: 18410
		private static readonly MessageParser<RevokeInvitationRequest> _parser = new MessageParser<RevokeInvitationRequest>(() => new RevokeInvitationRequest());

		// Token: 0x040047EB RID: 18411
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047EC RID: 18412
		private int _hasBits0;

		// Token: 0x040047ED RID: 18413
		public const int InvitationIdFieldNumber = 3;

		// Token: 0x040047EE RID: 18414
		private static readonly ulong InvitationIdDefaultValue = 0UL;

		// Token: 0x040047EF RID: 18415
		private ulong invitationId_;

		// Token: 0x040047F0 RID: 18416
		public const int ChannelIdFieldNumber = 4;

		// Token: 0x040047F1 RID: 18417
		private EntityId channelId_;
	}
}
