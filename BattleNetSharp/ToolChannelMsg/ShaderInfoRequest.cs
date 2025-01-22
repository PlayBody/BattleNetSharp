using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000083 RID: 131
	public sealed class ShaderInfoRequest : IMessage<ShaderInfoRequest>, IMessage, IEquatable<ShaderInfoRequest>, IDeepCloneable<ShaderInfoRequest>, IBufferMessage
	{
		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x0002D14C File Offset: 0x0002B34C
		[DebuggerNonUserCode]
		public static MessageParser<ShaderInfoRequest> Parser
		{
			get
			{
				return ShaderInfoRequest._parser;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x0002D164 File Offset: 0x0002B364
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[108];
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x0002D188 File Offset: 0x0002B388
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShaderInfoRequest.Descriptor;
			}
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0002D19F File Offset: 0x0002B39F
		[DebuggerNonUserCode]
		public ShaderInfoRequest()
		{
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0002D1A9 File Offset: 0x0002B3A9
		[DebuggerNonUserCode]
		public ShaderInfoRequest(ShaderInfoRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoHandle_ = other.snoHandle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0002D1DC File Offset: 0x0002B3DC
		[DebuggerNonUserCode]
		public ShaderInfoRequest Clone()
		{
			return new ShaderInfoRequest(this);
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x0002D1F4 File Offset: 0x0002B3F4
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x0002D225 File Offset: 0x0002B425
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
					snoHandleDefaultValue = ShaderInfoRequest.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x0002D240 File Offset: 0x0002B440
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0002D25D File Offset: 0x0002B45D
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0002D270 File Offset: 0x0002B470
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShaderInfoRequest);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0002D290 File Offset: 0x0002B490
		[DebuggerNonUserCode]
		public bool Equals(ShaderInfoRequest other)
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

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0002D2E8 File Offset: 0x0002B4E8
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

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0002D338 File Offset: 0x0002B538
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0002D350 File Offset: 0x0002B550
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x0002D35C File Offset: 0x0002B55C
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

		// Token: 0x06000BBB RID: 3003 RVA: 0x0002D3A8 File Offset: 0x0002B5A8
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

		// Token: 0x06000BBC RID: 3004 RVA: 0x0002D3F8 File Offset: 0x0002B5F8
		[DebuggerNonUserCode]
		public void MergeFrom(ShaderInfoRequest other)
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

		// Token: 0x06000BBD RID: 3005 RVA: 0x0002D441 File Offset: 0x0002B641
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0002D44C File Offset: 0x0002B64C
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

		// Token: 0x040004B0 RID: 1200
		private static readonly MessageParser<ShaderInfoRequest> _parser = new MessageParser<ShaderInfoRequest>(() => new ShaderInfoRequest());

		// Token: 0x040004B1 RID: 1201
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004B2 RID: 1202
		private int _hasBits0;

		// Token: 0x040004B3 RID: 1203
		public const int SnoHandleFieldNumber = 1;

		// Token: 0x040004B4 RID: 1204
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x040004B5 RID: 1205
		private int snoHandle_;
	}
}
