using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000CC RID: 204
	public sealed class UndoXMLTransformValue : IMessage<UndoXMLTransformValue>, IMessage, IEquatable<UndoXMLTransformValue>, IDeepCloneable<UndoXMLTransformValue>, IBufferMessage
	{
		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x00047398 File Offset: 0x00045598
		[DebuggerNonUserCode]
		public static MessageParser<UndoXMLTransformValue> Parser
		{
			get
			{
				return UndoXMLTransformValue._parser;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x000473B0 File Offset: 0x000455B0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[181];
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x000473D8 File Offset: 0x000455D8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UndoXMLTransformValue.Descriptor;
			}
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x000473EF File Offset: 0x000455EF
		[DebuggerNonUserCode]
		public UndoXMLTransformValue()
		{
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x000473F9 File Offset: 0x000455F9
		[DebuggerNonUserCode]
		public UndoXMLTransformValue(UndoXMLTransformValue other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoGroup_ = other.snoGroup_;
			this.snoHandle_ = other.snoHandle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x00047438 File Offset: 0x00045638
		[DebuggerNonUserCode]
		public UndoXMLTransformValue Clone()
		{
			return new UndoXMLTransformValue(this);
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x00047450 File Offset: 0x00045650
		// (set) Token: 0x06001382 RID: 4994 RVA: 0x00047481 File Offset: 0x00045681
		[DebuggerNonUserCode]
		public int SnoGroup
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoGroupDefaultValue;
				if (flag)
				{
					snoGroupDefaultValue = this.snoGroup_;
				}
				else
				{
					snoGroupDefaultValue = UndoXMLTransformValue.SnoGroupDefaultValue;
				}
				return snoGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoGroup_ = value;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x0004749C File Offset: 0x0004569C
		[DebuggerNonUserCode]
		public bool HasSnoGroup
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x000474B9 File Offset: 0x000456B9
		[DebuggerNonUserCode]
		public void ClearSnoGroup()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x000474CC File Offset: 0x000456CC
		// (set) Token: 0x06001386 RID: 4998 RVA: 0x000474FD File Offset: 0x000456FD
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = UndoXMLTransformValue.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x00047518 File Offset: 0x00045718
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00047535 File Offset: 0x00045735
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x00047548 File Offset: 0x00045748
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UndoXMLTransformValue);
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00047568 File Offset: 0x00045768
		[DebuggerNonUserCode]
		public bool Equals(UndoXMLTransformValue other)
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
					bool flag4 = this.SnoGroup != other.SnoGroup;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoHandle != other.SnoHandle;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x000475DC File Offset: 0x000457DC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				num ^= this.SnoGroup.GetHashCode();
			}
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

		// Token: 0x0600138C RID: 5004 RVA: 0x00047648 File Offset: 0x00045848
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x00047660 File Offset: 0x00045860
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x0004766C File Offset: 0x0004586C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoHandle);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x000476DC File Offset: 0x000458DC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoGroup);
			}
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

		// Token: 0x06001390 RID: 5008 RVA: 0x00047748 File Offset: 0x00045948
		[DebuggerNonUserCode]
		public void MergeFrom(UndoXMLTransformValue other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoGroup = other.HasSnoGroup;
				if (hasSnoGroup)
				{
					this.SnoGroup = other.SnoGroup;
				}
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x000477AA File Offset: 0x000459AA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x000477B8 File Offset: 0x000459B8
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SnoHandle = input.ReadInt32();
					}
				}
				else
				{
					this.SnoGroup = input.ReadInt32();
				}
			}
		}

		// Token: 0x040007E4 RID: 2020
		private static readonly MessageParser<UndoXMLTransformValue> _parser = new MessageParser<UndoXMLTransformValue>(() => new UndoXMLTransformValue());

		// Token: 0x040007E5 RID: 2021
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007E6 RID: 2022
		private int _hasBits0;

		// Token: 0x040007E7 RID: 2023
		public const int SnoGroupFieldNumber = 1;

		// Token: 0x040007E8 RID: 2024
		private static readonly int SnoGroupDefaultValue = 0;

		// Token: 0x040007E9 RID: 2025
		private int snoGroup_;

		// Token: 0x040007EA RID: 2026
		public const int SnoHandleFieldNumber = 2;

		// Token: 0x040007EB RID: 2027
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x040007EC RID: 2028
		private int snoHandle_;
	}
}
