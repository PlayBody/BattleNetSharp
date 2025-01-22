using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006B9 RID: 1721
	public sealed class AcceptInvitationRequest : IMessage<AcceptInvitationRequest>, IMessage, IEquatable<AcceptInvitationRequest>, IDeepCloneable<AcceptInvitationRequest>, IBufferMessage
	{
		// Token: 0x17003162 RID: 12642
		// (get) Token: 0x06009F1A RID: 40730 RVA: 0x0026B69C File Offset: 0x0026989C
		[DebuggerNonUserCode]
		public static MessageParser<AcceptInvitationRequest> Parser
		{
			get
			{
				return AcceptInvitationRequest._parser;
			}
		}

		// Token: 0x17003163 RID: 12643
		// (get) Token: 0x06009F1B RID: 40731 RVA: 0x0026B6B4 File Offset: 0x002698B4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17003164 RID: 12644
		// (get) Token: 0x06009F1C RID: 40732 RVA: 0x0026B6D8 File Offset: 0x002698D8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptInvitationRequest.Descriptor;
			}
		}

		// Token: 0x06009F1D RID: 40733 RVA: 0x0026B6EF File Offset: 0x002698EF
		[DebuggerNonUserCode]
		public AcceptInvitationRequest()
		{
		}

		// Token: 0x06009F1E RID: 40734 RVA: 0x0026B6F9 File Offset: 0x002698F9
		[DebuggerNonUserCode]
		public AcceptInvitationRequest(AcceptInvitationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.invitationId_ = other.invitationId_;
			this.objectId_ = other.objectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F1F RID: 40735 RVA: 0x0026B738 File Offset: 0x00269938
		[DebuggerNonUserCode]
		public AcceptInvitationRequest Clone()
		{
			return new AcceptInvitationRequest(this);
		}

		// Token: 0x17003165 RID: 12645
		// (get) Token: 0x06009F20 RID: 40736 RVA: 0x0026B750 File Offset: 0x00269950
		// (set) Token: 0x06009F21 RID: 40737 RVA: 0x0026B781 File Offset: 0x00269981
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
					invitationIdDefaultValue = AcceptInvitationRequest.InvitationIdDefaultValue;
				}
				return invitationIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.invitationId_ = value;
			}
		}

		// Token: 0x17003166 RID: 12646
		// (get) Token: 0x06009F22 RID: 40738 RVA: 0x0026B79C File Offset: 0x0026999C
		[DebuggerNonUserCode]
		public bool HasInvitationId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009F23 RID: 40739 RVA: 0x0026B7B9 File Offset: 0x002699B9
		[DebuggerNonUserCode]
		public void ClearInvitationId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003167 RID: 12647
		// (get) Token: 0x06009F24 RID: 40740 RVA: 0x0026B7CC File Offset: 0x002699CC
		// (set) Token: 0x06009F25 RID: 40741 RVA: 0x0026B7FD File Offset: 0x002699FD
		[DebuggerNonUserCode]
		public ulong ObjectId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong objectIdDefaultValue;
				if (flag)
				{
					objectIdDefaultValue = this.objectId_;
				}
				else
				{
					objectIdDefaultValue = AcceptInvitationRequest.ObjectIdDefaultValue;
				}
				return objectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.objectId_ = value;
			}
		}

		// Token: 0x17003168 RID: 12648
		// (get) Token: 0x06009F26 RID: 40742 RVA: 0x0026B818 File Offset: 0x00269A18
		[DebuggerNonUserCode]
		public bool HasObjectId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06009F27 RID: 40743 RVA: 0x0026B835 File Offset: 0x00269A35
		[DebuggerNonUserCode]
		public void ClearObjectId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06009F28 RID: 40744 RVA: 0x0026B848 File Offset: 0x00269A48
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptInvitationRequest);
		}

		// Token: 0x06009F29 RID: 40745 RVA: 0x0026B868 File Offset: 0x00269A68
		[DebuggerNonUserCode]
		public bool Equals(AcceptInvitationRequest other)
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
						bool flag5 = this.ObjectId != other.ObjectId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009F2A RID: 40746 RVA: 0x0026B8DC File Offset: 0x00269ADC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				num ^= this.InvitationId.GetHashCode();
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num ^= this.ObjectId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F2B RID: 40747 RVA: 0x0026B948 File Offset: 0x00269B48
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009F2C RID: 40748 RVA: 0x0026B960 File Offset: 0x00269B60
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F2D RID: 40749 RVA: 0x0026B96C File Offset: 0x00269B6C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				output.WriteRawTag(25);
				output.WriteFixed64(this.InvitationId);
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.ObjectId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F2E RID: 40750 RVA: 0x0026B9DC File Offset: 0x00269BDC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				num += 9;
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F2F RID: 40751 RVA: 0x0026BA40 File Offset: 0x00269C40
		[DebuggerNonUserCode]
		public void MergeFrom(AcceptInvitationRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasInvitationId = other.HasInvitationId;
				if (hasInvitationId)
				{
					this.InvitationId = other.InvitationId;
				}
				bool hasObjectId = other.HasObjectId;
				if (hasObjectId)
				{
					this.ObjectId = other.ObjectId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009F30 RID: 40752 RVA: 0x0026BAA2 File Offset: 0x00269CA2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F31 RID: 40753 RVA: 0x0026BAB0 File Offset: 0x00269CB0
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
					if (num3 != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ObjectId = input.ReadUInt64();
					}
				}
				else
				{
					this.InvitationId = input.ReadFixed64();
				}
			}
		}

		// Token: 0x040047C3 RID: 18371
		private static readonly MessageParser<AcceptInvitationRequest> _parser = new MessageParser<AcceptInvitationRequest>(() => new AcceptInvitationRequest());

		// Token: 0x040047C4 RID: 18372
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047C5 RID: 18373
		private int _hasBits0;

		// Token: 0x040047C6 RID: 18374
		public const int InvitationIdFieldNumber = 3;

		// Token: 0x040047C7 RID: 18375
		private static readonly ulong InvitationIdDefaultValue = 0UL;

		// Token: 0x040047C8 RID: 18376
		private ulong invitationId_;

		// Token: 0x040047C9 RID: 18377
		public const int ObjectIdFieldNumber = 4;

		// Token: 0x040047CA RID: 18378
		private static readonly ulong ObjectIdDefaultValue = 0UL;

		// Token: 0x040047CB RID: 18379
		private ulong objectId_;
	}
}
