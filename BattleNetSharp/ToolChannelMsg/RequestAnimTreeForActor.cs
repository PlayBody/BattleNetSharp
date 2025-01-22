using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000E6 RID: 230
	public sealed class RequestAnimTreeForActor : IMessage<RequestAnimTreeForActor>, IMessage, IEquatable<RequestAnimTreeForActor>, IDeepCloneable<RequestAnimTreeForActor>, IBufferMessage
	{
		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x00050ED0 File Offset: 0x0004F0D0
		[DebuggerNonUserCode]
		public static MessageParser<RequestAnimTreeForActor> Parser
		{
			get
			{
				return RequestAnimTreeForActor._parser;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x00050EE8 File Offset: 0x0004F0E8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[207];
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x00050F10 File Offset: 0x0004F110
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RequestAnimTreeForActor.Descriptor;
			}
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x00050F27 File Offset: 0x0004F127
		[DebuggerNonUserCode]
		public RequestAnimTreeForActor()
		{
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00050F31 File Offset: 0x0004F131
		[DebuggerNonUserCode]
		public RequestAnimTreeForActor(RequestAnimTreeForActor other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.ractorId_ = other.ractorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00050F64 File Offset: 0x0004F164
		[DebuggerNonUserCode]
		public RequestAnimTreeForActor Clone()
		{
			return new RequestAnimTreeForActor(this);
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x00050F7C File Offset: 0x0004F17C
		// (set) Token: 0x0600164F RID: 5711 RVA: 0x00050FAD File Offset: 0x0004F1AD
		[DebuggerNonUserCode]
		public int RactorId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int ractorIdDefaultValue;
				if (flag)
				{
					ractorIdDefaultValue = this.ractorId_;
				}
				else
				{
					ractorIdDefaultValue = RequestAnimTreeForActor.RactorIdDefaultValue;
				}
				return ractorIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.ractorId_ = value;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x00050FC8 File Offset: 0x0004F1C8
		[DebuggerNonUserCode]
		public bool HasRactorId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00050FE5 File Offset: 0x0004F1E5
		[DebuggerNonUserCode]
		public void ClearRactorId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00050FF8 File Offset: 0x0004F1F8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RequestAnimTreeForActor);
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00051018 File Offset: 0x0004F218
		[DebuggerNonUserCode]
		public bool Equals(RequestAnimTreeForActor other)
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
					bool flag4 = this.RactorId != other.RactorId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00051070 File Offset: 0x0004F270
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRactorId = this.HasRactorId;
			if (hasRactorId)
			{
				num ^= this.RactorId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x000510C0 File Offset: 0x0004F2C0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x000510D8 File Offset: 0x0004F2D8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x000510E4 File Offset: 0x0004F2E4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRactorId = this.HasRactorId;
			if (hasRactorId)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RactorId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00051130 File Offset: 0x0004F330
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRactorId = this.HasRactorId;
			if (hasRactorId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RactorId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00051180 File Offset: 0x0004F380
		[DebuggerNonUserCode]
		public void MergeFrom(RequestAnimTreeForActor other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRactorId = other.HasRactorId;
				if (hasRactorId)
				{
					this.RactorId = other.RactorId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x000511C9 File Offset: 0x0004F3C9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x000511D4 File Offset: 0x0004F3D4
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
					this.RactorId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400090F RID: 2319
		private static readonly MessageParser<RequestAnimTreeForActor> _parser = new MessageParser<RequestAnimTreeForActor>(() => new RequestAnimTreeForActor());

		// Token: 0x04000910 RID: 2320
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000911 RID: 2321
		private int _hasBits0;

		// Token: 0x04000912 RID: 2322
		public const int RactorIdFieldNumber = 1;

		// Token: 0x04000913 RID: 2323
		private static readonly int RactorIdDefaultValue = 0;

		// Token: 0x04000914 RID: 2324
		private int ractorId_;
	}
}
