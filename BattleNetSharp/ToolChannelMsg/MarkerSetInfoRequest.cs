using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000087 RID: 135
	public sealed class MarkerSetInfoRequest : IMessage<MarkerSetInfoRequest>, IMessage, IEquatable<MarkerSetInfoRequest>, IDeepCloneable<MarkerSetInfoRequest>, IBufferMessage
	{
		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x0002E970 File Offset: 0x0002CB70
		[DebuggerNonUserCode]
		public static MessageParser<MarkerSetInfoRequest> Parser
		{
			get
			{
				return MarkerSetInfoRequest._parser;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x0002E988 File Offset: 0x0002CB88
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[112];
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x0002E9AC File Offset: 0x0002CBAC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkerSetInfoRequest.Descriptor;
			}
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0002E9C3 File Offset: 0x0002CBC3
		[DebuggerNonUserCode]
		public MarkerSetInfoRequest()
		{
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0002E9CD File Offset: 0x0002CBCD
		[DebuggerNonUserCode]
		public MarkerSetInfoRequest(MarkerSetInfoRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoHandle_ = other.snoHandle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0002EA00 File Offset: 0x0002CC00
		[DebuggerNonUserCode]
		public MarkerSetInfoRequest Clone()
		{
			return new MarkerSetInfoRequest(this);
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x0002EA18 File Offset: 0x0002CC18
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x0002EA49 File Offset: 0x0002CC49
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = MarkerSetInfoRequest.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x0002EA64 File Offset: 0x0002CC64
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x0002EA81 File Offset: 0x0002CC81
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x0002EA94 File Offset: 0x0002CC94
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkerSetInfoRequest);
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x0002EAB4 File Offset: 0x0002CCB4
		[DebuggerNonUserCode]
		public bool Equals(MarkerSetInfoRequest other)
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
					bool flag4 = this.SnoHandle != other.SnoHandle;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x0002EB0C File Offset: 0x0002CD0C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x0002EB5C File Offset: 0x0002CD5C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0002EB74 File Offset: 0x0002CD74
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x0002EB80 File Offset: 0x0002CD80
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoHandle);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x0002EBCC File Offset: 0x0002CDCC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0002EC1C File Offset: 0x0002CE1C
		[DebuggerNonUserCode]
		public void MergeFrom(MarkerSetInfoRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x0002EC65 File Offset: 0x0002CE65
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x0002EC70 File Offset: 0x0002CE70
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
					this.SnoHandle = input.ReadInt32();
				}
			}
		}

		// Token: 0x040004E3 RID: 1251
		private static readonly MessageParser<MarkerSetInfoRequest> _parser = new MessageParser<MarkerSetInfoRequest>(() => new MarkerSetInfoRequest());

		// Token: 0x040004E4 RID: 1252
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004E5 RID: 1253
		private int _hasBits0;

		// Token: 0x040004E6 RID: 1254
		public const int SnoHandleFieldNumber = 1;

		// Token: 0x040004E7 RID: 1255
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x040004E8 RID: 1256
		private int snoHandle_;
	}
}
