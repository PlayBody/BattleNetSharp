using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006BA RID: 1722
	public sealed class AcceptInvitationResponse : IMessage<AcceptInvitationResponse>, IMessage, IEquatable<AcceptInvitationResponse>, IDeepCloneable<AcceptInvitationResponse>, IBufferMessage
	{
		// Token: 0x17003169 RID: 12649
		// (get) Token: 0x06009F33 RID: 40755 RVA: 0x0026BB44 File Offset: 0x00269D44
		[DebuggerNonUserCode]
		public static MessageParser<AcceptInvitationResponse> Parser
		{
			get
			{
				return AcceptInvitationResponse._parser;
			}
		}

		// Token: 0x1700316A RID: 12650
		// (get) Token: 0x06009F34 RID: 40756 RVA: 0x0026BB5C File Offset: 0x00269D5C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x1700316B RID: 12651
		// (get) Token: 0x06009F35 RID: 40757 RVA: 0x0026BB80 File Offset: 0x00269D80
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptInvitationResponse.Descriptor;
			}
		}

		// Token: 0x06009F36 RID: 40758 RVA: 0x0026BB97 File Offset: 0x00269D97
		[DebuggerNonUserCode]
		public AcceptInvitationResponse()
		{
		}

		// Token: 0x06009F37 RID: 40759 RVA: 0x0026BBA1 File Offset: 0x00269DA1
		[DebuggerNonUserCode]
		public AcceptInvitationResponse(AcceptInvitationResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.objectId_ = other.objectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F38 RID: 40760 RVA: 0x0026BBD4 File Offset: 0x00269DD4
		[DebuggerNonUserCode]
		public AcceptInvitationResponse Clone()
		{
			return new AcceptInvitationResponse(this);
		}

		// Token: 0x1700316C RID: 12652
		// (get) Token: 0x06009F39 RID: 40761 RVA: 0x0026BBEC File Offset: 0x00269DEC
		// (set) Token: 0x06009F3A RID: 40762 RVA: 0x0026BC1D File Offset: 0x00269E1D
		[DebuggerNonUserCode]
		public ulong ObjectId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong objectIdDefaultValue;
				if (flag)
				{
					objectIdDefaultValue = this.objectId_;
				}
				else
				{
					objectIdDefaultValue = AcceptInvitationResponse.ObjectIdDefaultValue;
				}
				return objectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.objectId_ = value;
			}
		}

		// Token: 0x1700316D RID: 12653
		// (get) Token: 0x06009F3B RID: 40763 RVA: 0x0026BC38 File Offset: 0x00269E38
		[DebuggerNonUserCode]
		public bool HasObjectId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009F3C RID: 40764 RVA: 0x0026BC55 File Offset: 0x00269E55
		[DebuggerNonUserCode]
		public void ClearObjectId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06009F3D RID: 40765 RVA: 0x0026BC68 File Offset: 0x00269E68
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptInvitationResponse);
		}

		// Token: 0x06009F3E RID: 40766 RVA: 0x0026BC88 File Offset: 0x00269E88
		[DebuggerNonUserCode]
		public bool Equals(AcceptInvitationResponse other)
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
					bool flag4 = this.ObjectId != other.ObjectId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06009F3F RID: 40767 RVA: 0x0026BCE0 File Offset: 0x00269EE0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06009F40 RID: 40768 RVA: 0x0026BD30 File Offset: 0x00269F30
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009F41 RID: 40769 RVA: 0x0026BD48 File Offset: 0x00269F48
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F42 RID: 40770 RVA: 0x0026BD54 File Offset: 0x00269F54
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.ObjectId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F43 RID: 40771 RVA: 0x0026BDA0 File Offset: 0x00269FA0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06009F44 RID: 40772 RVA: 0x0026BDF0 File Offset: 0x00269FF0
		[DebuggerNonUserCode]
		public void MergeFrom(AcceptInvitationResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasObjectId = other.HasObjectId;
				if (hasObjectId)
				{
					this.ObjectId = other.ObjectId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009F45 RID: 40773 RVA: 0x0026BE39 File Offset: 0x0026A039
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F46 RID: 40774 RVA: 0x0026BE44 File Offset: 0x0026A044
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ObjectId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040047CC RID: 18380
		private static readonly MessageParser<AcceptInvitationResponse> _parser = new MessageParser<AcceptInvitationResponse>(() => new AcceptInvitationResponse());

		// Token: 0x040047CD RID: 18381
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047CE RID: 18382
		private int _hasBits0;

		// Token: 0x040047CF RID: 18383
		public const int ObjectIdFieldNumber = 1;

		// Token: 0x040047D0 RID: 18384
		private static readonly ulong ObjectIdDefaultValue = 0UL;

		// Token: 0x040047D1 RID: 18385
		private ulong objectId_;
	}
}
