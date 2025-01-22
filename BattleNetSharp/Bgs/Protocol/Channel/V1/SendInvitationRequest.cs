using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006B8 RID: 1720
	public sealed class SendInvitationRequest : IMessage<SendInvitationRequest>, IMessage, IEquatable<SendInvitationRequest>, IDeepCloneable<SendInvitationRequest>, IBufferMessage
	{
		// Token: 0x1700315D RID: 12637
		// (get) Token: 0x06009F05 RID: 40709 RVA: 0x0026B1F0 File Offset: 0x002693F0
		[DebuggerNonUserCode]
		public static MessageParser<SendInvitationRequest> Parser
		{
			get
			{
				return SendInvitationRequest._parser;
			}
		}

		// Token: 0x1700315E RID: 12638
		// (get) Token: 0x06009F06 RID: 40710 RVA: 0x0026B208 File Offset: 0x00269408
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700315F RID: 12639
		// (get) Token: 0x06009F07 RID: 40711 RVA: 0x0026B22C File Offset: 0x0026942C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendInvitationRequest.Descriptor;
			}
		}

		// Token: 0x06009F08 RID: 40712 RVA: 0x0026B243 File Offset: 0x00269443
		[DebuggerNonUserCode]
		public SendInvitationRequest()
		{
		}

		// Token: 0x06009F09 RID: 40713 RVA: 0x0026B250 File Offset: 0x00269450
		[DebuggerNonUserCode]
		public SendInvitationRequest(SendInvitationRequest other)
			: this()
		{
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this.params_ = ((other.params_ != null) ? other.params_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F0A RID: 40714 RVA: 0x0026B2B0 File Offset: 0x002694B0
		[DebuggerNonUserCode]
		public SendInvitationRequest Clone()
		{
			return new SendInvitationRequest(this);
		}

		// Token: 0x17003160 RID: 12640
		// (get) Token: 0x06009F0B RID: 40715 RVA: 0x0026B2C8 File Offset: 0x002694C8
		// (set) Token: 0x06009F0C RID: 40716 RVA: 0x0026B2E0 File Offset: 0x002694E0
		[DebuggerNonUserCode]
		public EntityId TargetId
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

		// Token: 0x17003161 RID: 12641
		// (get) Token: 0x06009F0D RID: 40717 RVA: 0x0026B2EC File Offset: 0x002694EC
		// (set) Token: 0x06009F0E RID: 40718 RVA: 0x0026B304 File Offset: 0x00269504
		[DebuggerNonUserCode]
		public InvitationParams Params
		{
			get
			{
				return this.params_;
			}
			set
			{
				this.params_ = value;
			}
		}

		// Token: 0x06009F0F RID: 40719 RVA: 0x0026B310 File Offset: 0x00269510
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendInvitationRequest);
		}

		// Token: 0x06009F10 RID: 40720 RVA: 0x0026B330 File Offset: 0x00269530
		[DebuggerNonUserCode]
		public bool Equals(SendInvitationRequest other)
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
						bool flag5 = !object.Equals(this.Params, other.Params);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009F11 RID: 40721 RVA: 0x0026B3A8 File Offset: 0x002695A8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.targetId_ != null;
			if (flag)
			{
				num ^= this.TargetId.GetHashCode();
			}
			bool flag2 = this.params_ != null;
			if (flag2)
			{
				num ^= this.Params.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F12 RID: 40722 RVA: 0x0026B414 File Offset: 0x00269614
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009F13 RID: 40723 RVA: 0x0026B42C File Offset: 0x0026962C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F14 RID: 40724 RVA: 0x0026B438 File Offset: 0x00269638
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.targetId_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TargetId);
			}
			bool flag2 = this.params_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Params);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F15 RID: 40725 RVA: 0x0026B4AC File Offset: 0x002696AC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.targetId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			}
			bool flag2 = this.params_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Params);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F16 RID: 40726 RVA: 0x0026B520 File Offset: 0x00269720
		[DebuggerNonUserCode]
		public void MergeFrom(SendInvitationRequest other)
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
						this.TargetId = new EntityId();
					}
					this.TargetId.MergeFrom(other.TargetId);
				}
				bool flag4 = other.params_ != null;
				if (flag4)
				{
					bool flag5 = this.params_ == null;
					if (flag5)
					{
						this.Params = new InvitationParams();
					}
					this.Params.MergeFrom(other.Params);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009F17 RID: 40727 RVA: 0x0026B5CD File Offset: 0x002697CD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F18 RID: 40728 RVA: 0x0026B5D8 File Offset: 0x002697D8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 18U)
				{
					if (num3 != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.params_ == null;
						if (flag)
						{
							this.Params = new InvitationParams();
						}
						input.ReadMessage(this.Params);
					}
				}
				else
				{
					bool flag2 = this.targetId_ == null;
					if (flag2)
					{
						this.TargetId = new EntityId();
					}
					input.ReadMessage(this.TargetId);
				}
			}
		}

		// Token: 0x040047BD RID: 18365
		private static readonly MessageParser<SendInvitationRequest> _parser = new MessageParser<SendInvitationRequest>(() => new SendInvitationRequest());

		// Token: 0x040047BE RID: 18366
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047BF RID: 18367
		public const int TargetIdFieldNumber = 2;

		// Token: 0x040047C0 RID: 18368
		private EntityId targetId_;

		// Token: 0x040047C1 RID: 18369
		public const int ParamsFieldNumber = 3;

		// Token: 0x040047C2 RID: 18370
		private InvitationParams params_;
	}
}
