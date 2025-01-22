using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000047 RID: 71
	public sealed class HoudiniSimInformationRequest : IMessage<HoudiniSimInformationRequest>, IMessage, IEquatable<HoudiniSimInformationRequest>, IDeepCloneable<HoudiniSimInformationRequest>, IBufferMessage
	{
		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0001A68C File Offset: 0x0001888C
		[DebuggerNonUserCode]
		public static MessageParser<HoudiniSimInformationRequest> Parser
		{
			get
			{
				return HoudiniSimInformationRequest._parser;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0001A6A4 File Offset: 0x000188A4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[48];
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x0001A6C8 File Offset: 0x000188C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HoudiniSimInformationRequest.Descriptor;
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0001A6DF File Offset: 0x000188DF
		[DebuggerNonUserCode]
		public HoudiniSimInformationRequest()
		{
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0001A6E9 File Offset: 0x000188E9
		[DebuggerNonUserCode]
		public HoudiniSimInformationRequest(HoudiniSimInformationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoHandle_ = other.snoHandle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0001A71C File Offset: 0x0001891C
		[DebuggerNonUserCode]
		public HoudiniSimInformationRequest Clone()
		{
			return new HoudiniSimInformationRequest(this);
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x0001A734 File Offset: 0x00018934
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x0001A765 File Offset: 0x00018965
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
					snoHandleDefaultValue = HoudiniSimInformationRequest.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x0001A780 File Offset: 0x00018980
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0001A79D File Offset: 0x0001899D
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0001A7B0 File Offset: 0x000189B0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HoudiniSimInformationRequest);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0001A7D0 File Offset: 0x000189D0
		[DebuggerNonUserCode]
		public bool Equals(HoudiniSimInformationRequest other)
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

		// Token: 0x060005D0 RID: 1488 RVA: 0x0001A828 File Offset: 0x00018A28
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

		// Token: 0x060005D1 RID: 1489 RVA: 0x0001A878 File Offset: 0x00018A78
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0001A890 File Offset: 0x00018A90
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0001A89C File Offset: 0x00018A9C
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

		// Token: 0x060005D4 RID: 1492 RVA: 0x0001A8E8 File Offset: 0x00018AE8
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

		// Token: 0x060005D5 RID: 1493 RVA: 0x0001A938 File Offset: 0x00018B38
		[DebuggerNonUserCode]
		public void MergeFrom(HoudiniSimInformationRequest other)
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

		// Token: 0x060005D6 RID: 1494 RVA: 0x0001A981 File Offset: 0x00018B81
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0001A98C File Offset: 0x00018B8C
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

		// Token: 0x0400026D RID: 621
		private static readonly MessageParser<HoudiniSimInformationRequest> _parser = new MessageParser<HoudiniSimInformationRequest>(() => new HoudiniSimInformationRequest());

		// Token: 0x0400026E RID: 622
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400026F RID: 623
		private int _hasBits0;

		// Token: 0x04000270 RID: 624
		public const int SnoHandleFieldNumber = 1;

		// Token: 0x04000271 RID: 625
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x04000272 RID: 626
		private int snoHandle_;
	}
}
