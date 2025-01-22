using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006D1 RID: 1745
	public sealed class SubscribeChannelResponse : IMessage<SubscribeChannelResponse>, IMessage, IEquatable<SubscribeChannelResponse>, IDeepCloneable<SubscribeChannelResponse>, IBufferMessage
	{
		// Token: 0x170031F0 RID: 12784
		// (get) Token: 0x0600A119 RID: 41241 RVA: 0x002732A4 File Offset: 0x002714A4
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeChannelResponse> Parser
		{
			get
			{
				return SubscribeChannelResponse._parser;
			}
		}

		// Token: 0x170031F1 RID: 12785
		// (get) Token: 0x0600A11A RID: 41242 RVA: 0x002732BC File Offset: 0x002714BC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelOwnerServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x170031F2 RID: 12786
		// (get) Token: 0x0600A11B RID: 41243 RVA: 0x002732E0 File Offset: 0x002714E0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeChannelResponse.Descriptor;
			}
		}

		// Token: 0x0600A11C RID: 41244 RVA: 0x002732F7 File Offset: 0x002714F7
		[DebuggerNonUserCode]
		public SubscribeChannelResponse()
		{
		}

		// Token: 0x0600A11D RID: 41245 RVA: 0x00273301 File Offset: 0x00271501
		[DebuggerNonUserCode]
		public SubscribeChannelResponse(SubscribeChannelResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.objectId_ = other.objectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A11E RID: 41246 RVA: 0x00273334 File Offset: 0x00271534
		[DebuggerNonUserCode]
		public SubscribeChannelResponse Clone()
		{
			return new SubscribeChannelResponse(this);
		}

		// Token: 0x170031F3 RID: 12787
		// (get) Token: 0x0600A11F RID: 41247 RVA: 0x0027334C File Offset: 0x0027154C
		// (set) Token: 0x0600A120 RID: 41248 RVA: 0x0027337D File Offset: 0x0027157D
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
					objectIdDefaultValue = SubscribeChannelResponse.ObjectIdDefaultValue;
				}
				return objectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.objectId_ = value;
			}
		}

		// Token: 0x170031F4 RID: 12788
		// (get) Token: 0x0600A121 RID: 41249 RVA: 0x00273398 File Offset: 0x00271598
		[DebuggerNonUserCode]
		public bool HasObjectId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A122 RID: 41250 RVA: 0x002733B5 File Offset: 0x002715B5
		[DebuggerNonUserCode]
		public void ClearObjectId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600A123 RID: 41251 RVA: 0x002733C8 File Offset: 0x002715C8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeChannelResponse);
		}

		// Token: 0x0600A124 RID: 41252 RVA: 0x002733E8 File Offset: 0x002715E8
		[DebuggerNonUserCode]
		public bool Equals(SubscribeChannelResponse other)
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

		// Token: 0x0600A125 RID: 41253 RVA: 0x00273440 File Offset: 0x00271640
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

		// Token: 0x0600A126 RID: 41254 RVA: 0x00273490 File Offset: 0x00271690
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A127 RID: 41255 RVA: 0x002734A8 File Offset: 0x002716A8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A128 RID: 41256 RVA: 0x002734B4 File Offset: 0x002716B4
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

		// Token: 0x0600A129 RID: 41257 RVA: 0x00273500 File Offset: 0x00271700
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

		// Token: 0x0600A12A RID: 41258 RVA: 0x00273550 File Offset: 0x00271750
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeChannelResponse other)
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

		// Token: 0x0600A12B RID: 41259 RVA: 0x00273599 File Offset: 0x00271799
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A12C RID: 41260 RVA: 0x002735A4 File Offset: 0x002717A4
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

		// Token: 0x0400489A RID: 18586
		private static readonly MessageParser<SubscribeChannelResponse> _parser = new MessageParser<SubscribeChannelResponse>(() => new SubscribeChannelResponse());

		// Token: 0x0400489B RID: 18587
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400489C RID: 18588
		private int _hasBits0;

		// Token: 0x0400489D RID: 18589
		public const int ObjectIdFieldNumber = 1;

		// Token: 0x0400489E RID: 18590
		private static readonly ulong ObjectIdDefaultValue = 0UL;

		// Token: 0x0400489F RID: 18591
		private ulong objectId_;
	}
}
