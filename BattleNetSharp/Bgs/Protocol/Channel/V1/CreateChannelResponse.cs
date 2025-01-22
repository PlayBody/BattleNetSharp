using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006CD RID: 1741
	public sealed class CreateChannelResponse : IMessage<CreateChannelResponse>, IMessage, IEquatable<CreateChannelResponse>, IDeepCloneable<CreateChannelResponse>, IBufferMessage
	{
		// Token: 0x170031D3 RID: 12755
		// (get) Token: 0x0600A0B3 RID: 41139 RVA: 0x00271AD4 File Offset: 0x0026FCD4
		[DebuggerNonUserCode]
		public static MessageParser<CreateChannelResponse> Parser
		{
			get
			{
				return CreateChannelResponse._parser;
			}
		}

		// Token: 0x170031D4 RID: 12756
		// (get) Token: 0x0600A0B4 RID: 41140 RVA: 0x00271AEC File Offset: 0x0026FCEC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelOwnerServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170031D5 RID: 12757
		// (get) Token: 0x0600A0B5 RID: 41141 RVA: 0x00271B10 File Offset: 0x0026FD10
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateChannelResponse.Descriptor;
			}
		}

		// Token: 0x0600A0B6 RID: 41142 RVA: 0x00271B27 File Offset: 0x0026FD27
		[DebuggerNonUserCode]
		public CreateChannelResponse()
		{
		}

		// Token: 0x0600A0B7 RID: 41143 RVA: 0x00271B34 File Offset: 0x0026FD34
		[DebuggerNonUserCode]
		public CreateChannelResponse(CreateChannelResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.objectId_ = other.objectId_;
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A0B8 RID: 41144 RVA: 0x00271B90 File Offset: 0x0026FD90
		[DebuggerNonUserCode]
		public CreateChannelResponse Clone()
		{
			return new CreateChannelResponse(this);
		}

		// Token: 0x170031D6 RID: 12758
		// (get) Token: 0x0600A0B9 RID: 41145 RVA: 0x00271BA8 File Offset: 0x0026FDA8
		// (set) Token: 0x0600A0BA RID: 41146 RVA: 0x00271BD9 File Offset: 0x0026FDD9
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
					objectIdDefaultValue = CreateChannelResponse.ObjectIdDefaultValue;
				}
				return objectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.objectId_ = value;
			}
		}

		// Token: 0x170031D7 RID: 12759
		// (get) Token: 0x0600A0BB RID: 41147 RVA: 0x00271BF4 File Offset: 0x0026FDF4
		[DebuggerNonUserCode]
		public bool HasObjectId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A0BC RID: 41148 RVA: 0x00271C11 File Offset: 0x0026FE11
		[DebuggerNonUserCode]
		public void ClearObjectId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170031D8 RID: 12760
		// (get) Token: 0x0600A0BD RID: 41149 RVA: 0x00271C24 File Offset: 0x0026FE24
		// (set) Token: 0x0600A0BE RID: 41150 RVA: 0x00271C3C File Offset: 0x0026FE3C
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

		// Token: 0x0600A0BF RID: 41151 RVA: 0x00271C48 File Offset: 0x0026FE48
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateChannelResponse);
		}

		// Token: 0x0600A0C0 RID: 41152 RVA: 0x00271C68 File Offset: 0x0026FE68
		[DebuggerNonUserCode]
		public bool Equals(CreateChannelResponse other)
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

		// Token: 0x0600A0C1 RID: 41153 RVA: 0x00271CDC File Offset: 0x0026FEDC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num ^= this.ObjectId.GetHashCode();
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

		// Token: 0x0600A0C2 RID: 41154 RVA: 0x00271D48 File Offset: 0x0026FF48
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A0C3 RID: 41155 RVA: 0x00271D60 File Offset: 0x0026FF60
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A0C4 RID: 41156 RVA: 0x00271D6C File Offset: 0x0026FF6C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.ObjectId);
			}
			bool flag = this.channelId_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ChannelId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A0C5 RID: 41157 RVA: 0x00271DDC File Offset: 0x0026FFDC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
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

		// Token: 0x0600A0C6 RID: 41158 RVA: 0x00271E4C File Offset: 0x0027004C
		[DebuggerNonUserCode]
		public void MergeFrom(CreateChannelResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasObjectId = other.HasObjectId;
				if (hasObjectId)
				{
					this.ObjectId = other.ObjectId;
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

		// Token: 0x0600A0C7 RID: 41159 RVA: 0x00271ED1 File Offset: 0x002700D1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A0C8 RID: 41160 RVA: 0x00271EDC File Offset: 0x002700DC
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
					if (num3 != 18U)
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
					this.ObjectId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04004871 RID: 18545
		private static readonly MessageParser<CreateChannelResponse> _parser = new MessageParser<CreateChannelResponse>(() => new CreateChannelResponse());

		// Token: 0x04004872 RID: 18546
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004873 RID: 18547
		private int _hasBits0;

		// Token: 0x04004874 RID: 18548
		public const int ObjectIdFieldNumber = 1;

		// Token: 0x04004875 RID: 18549
		private static readonly ulong ObjectIdDefaultValue = 0UL;

		// Token: 0x04004876 RID: 18550
		private ulong objectId_;

		// Token: 0x04004877 RID: 18551
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x04004878 RID: 18552
		private EntityId channelId_;
	}
}
