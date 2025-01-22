using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200038D RID: 909
	public sealed class ObjectAddress : IMessage<ObjectAddress>, IMessage, IEquatable<ObjectAddress>, IDeepCloneable<ObjectAddress>, IBufferMessage
	{
		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x06005C39 RID: 23609 RVA: 0x00164D68 File Offset: 0x00162F68
		[DebuggerNonUserCode]
		public static MessageParser<ObjectAddress> Parser
		{
			get
			{
				return ObjectAddress._parser;
			}
		}

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x06005C3A RID: 23610 RVA: 0x00164D80 File Offset: 0x00162F80
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x06005C3B RID: 23611 RVA: 0x00164DA4 File Offset: 0x00162FA4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ObjectAddress.Descriptor;
			}
		}

		// Token: 0x06005C3C RID: 23612 RVA: 0x00164DBB File Offset: 0x00162FBB
		[DebuggerNonUserCode]
		public ObjectAddress()
		{
		}

		// Token: 0x06005C3D RID: 23613 RVA: 0x00164DC8 File Offset: 0x00162FC8
		[DebuggerNonUserCode]
		public ObjectAddress(ObjectAddress other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.host_ = ((other.host_ != null) ? other.host_.Clone() : null);
			this.objectId_ = other.objectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C3E RID: 23614 RVA: 0x00164E24 File Offset: 0x00163024
		[DebuggerNonUserCode]
		public ObjectAddress Clone()
		{
			return new ObjectAddress(this);
		}

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x06005C3F RID: 23615 RVA: 0x00164E3C File Offset: 0x0016303C
		// (set) Token: 0x06005C40 RID: 23616 RVA: 0x00164E54 File Offset: 0x00163054
		[DebuggerNonUserCode]
		public ProcessId Host
		{
			get
			{
				return this.host_;
			}
			set
			{
				this.host_ = value;
			}
		}

		// Token: 0x17001DE5 RID: 7653
		// (get) Token: 0x06005C41 RID: 23617 RVA: 0x00164E60 File Offset: 0x00163060
		// (set) Token: 0x06005C42 RID: 23618 RVA: 0x00164E91 File Offset: 0x00163091
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
					objectIdDefaultValue = ObjectAddress.ObjectIdDefaultValue;
				}
				return objectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.objectId_ = value;
			}
		}

		// Token: 0x17001DE6 RID: 7654
		// (get) Token: 0x06005C43 RID: 23619 RVA: 0x00164EAC File Offset: 0x001630AC
		[DebuggerNonUserCode]
		public bool HasObjectId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005C44 RID: 23620 RVA: 0x00164EC9 File Offset: 0x001630C9
		[DebuggerNonUserCode]
		public void ClearObjectId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06005C45 RID: 23621 RVA: 0x00164EDC File Offset: 0x001630DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ObjectAddress);
		}

		// Token: 0x06005C46 RID: 23622 RVA: 0x00164EFC File Offset: 0x001630FC
		[DebuggerNonUserCode]
		public bool Equals(ObjectAddress other)
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
					bool flag4 = !object.Equals(this.Host, other.Host);
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

		// Token: 0x06005C47 RID: 23623 RVA: 0x00164F70 File Offset: 0x00163170
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.host_ != null;
			if (flag)
			{
				num ^= this.Host.GetHashCode();
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num ^= this.ObjectId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005C48 RID: 23624 RVA: 0x00164FDC File Offset: 0x001631DC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005C49 RID: 23625 RVA: 0x00164FF4 File Offset: 0x001631F4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C4A RID: 23626 RVA: 0x00165000 File Offset: 0x00163200
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.host_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Host);
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.ObjectId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C4B RID: 23627 RVA: 0x00165074 File Offset: 0x00163274
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.host_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Host);
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005C4C RID: 23628 RVA: 0x001650E4 File Offset: 0x001632E4
		[DebuggerNonUserCode]
		public void MergeFrom(ObjectAddress other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.host_ != null;
				if (flag2)
				{
					bool flag3 = this.host_ == null;
					if (flag3)
					{
						this.Host = new ProcessId();
					}
					this.Host.MergeFrom(other.Host);
				}
				bool hasObjectId = other.HasObjectId;
				if (hasObjectId)
				{
					this.ObjectId = other.ObjectId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005C4D RID: 23629 RVA: 0x00165169 File Offset: 0x00163369
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C4E RID: 23630 RVA: 0x00165174 File Offset: 0x00163374
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
					if (num3 != 16U)
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
					bool flag = this.host_ == null;
					if (flag)
					{
						this.Host = new ProcessId();
					}
					input.ReadMessage(this.Host);
				}
			}
		}

		// Token: 0x04002A20 RID: 10784
		private static readonly MessageParser<ObjectAddress> _parser = new MessageParser<ObjectAddress>(() => new ObjectAddress());

		// Token: 0x04002A21 RID: 10785
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A22 RID: 10786
		private int _hasBits0;

		// Token: 0x04002A23 RID: 10787
		public const int HostFieldNumber = 1;

		// Token: 0x04002A24 RID: 10788
		private ProcessId host_;

		// Token: 0x04002A25 RID: 10789
		public const int ObjectIdFieldNumber = 2;

		// Token: 0x04002A26 RID: 10790
		private static readonly ulong ObjectIdDefaultValue = 0UL;

		// Token: 0x04002A27 RID: 10791
		private ulong objectId_;
	}
}
