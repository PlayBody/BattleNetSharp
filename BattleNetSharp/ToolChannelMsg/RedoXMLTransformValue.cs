using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000CD RID: 205
	public sealed class RedoXMLTransformValue : IMessage<RedoXMLTransformValue>, IMessage, IEquatable<RedoXMLTransformValue>, IDeepCloneable<RedoXMLTransformValue>, IBufferMessage
	{
		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x00047848 File Offset: 0x00045A48
		[DebuggerNonUserCode]
		public static MessageParser<RedoXMLTransformValue> Parser
		{
			get
			{
				return RedoXMLTransformValue._parser;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x00047860 File Offset: 0x00045A60
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[182];
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x00047888 File Offset: 0x00045A88
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RedoXMLTransformValue.Descriptor;
			}
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x0004789F File Offset: 0x00045A9F
		[DebuggerNonUserCode]
		public RedoXMLTransformValue()
		{
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x000478A9 File Offset: 0x00045AA9
		[DebuggerNonUserCode]
		public RedoXMLTransformValue(RedoXMLTransformValue other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoGroup_ = other.snoGroup_;
			this.snoHandle_ = other.snoHandle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x000478E8 File Offset: 0x00045AE8
		[DebuggerNonUserCode]
		public RedoXMLTransformValue Clone()
		{
			return new RedoXMLTransformValue(this);
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x00047900 File Offset: 0x00045B00
		// (set) Token: 0x0600139B RID: 5019 RVA: 0x00047931 File Offset: 0x00045B31
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
					snoGroupDefaultValue = RedoXMLTransformValue.SnoGroupDefaultValue;
				}
				return snoGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoGroup_ = value;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x0004794C File Offset: 0x00045B4C
		[DebuggerNonUserCode]
		public bool HasSnoGroup
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x00047969 File Offset: 0x00045B69
		[DebuggerNonUserCode]
		public void ClearSnoGroup()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x0004797C File Offset: 0x00045B7C
		// (set) Token: 0x0600139F RID: 5023 RVA: 0x000479AD File Offset: 0x00045BAD
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
					snoHandleDefaultValue = RedoXMLTransformValue.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x000479C8 File Offset: 0x00045BC8
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x000479E5 File Offset: 0x00045BE5
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x000479F8 File Offset: 0x00045BF8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RedoXMLTransformValue);
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x00047A18 File Offset: 0x00045C18
		[DebuggerNonUserCode]
		public bool Equals(RedoXMLTransformValue other)
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

		// Token: 0x060013A4 RID: 5028 RVA: 0x00047A8C File Offset: 0x00045C8C
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

		// Token: 0x060013A5 RID: 5029 RVA: 0x00047AF8 File Offset: 0x00045CF8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00047B10 File Offset: 0x00045D10
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00047B1C File Offset: 0x00045D1C
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

		// Token: 0x060013A8 RID: 5032 RVA: 0x00047B8C File Offset: 0x00045D8C
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

		// Token: 0x060013A9 RID: 5033 RVA: 0x00047BF8 File Offset: 0x00045DF8
		[DebuggerNonUserCode]
		public void MergeFrom(RedoXMLTransformValue other)
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

		// Token: 0x060013AA RID: 5034 RVA: 0x00047C5A File Offset: 0x00045E5A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00047C68 File Offset: 0x00045E68
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

		// Token: 0x040007ED RID: 2029
		private static readonly MessageParser<RedoXMLTransformValue> _parser = new MessageParser<RedoXMLTransformValue>(() => new RedoXMLTransformValue());

		// Token: 0x040007EE RID: 2030
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007EF RID: 2031
		private int _hasBits0;

		// Token: 0x040007F0 RID: 2032
		public const int SnoGroupFieldNumber = 1;

		// Token: 0x040007F1 RID: 2033
		private static readonly int SnoGroupDefaultValue = 0;

		// Token: 0x040007F2 RID: 2034
		private int snoGroup_;

		// Token: 0x040007F3 RID: 2035
		public const int SnoHandleFieldNumber = 2;

		// Token: 0x040007F4 RID: 2036
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x040007F5 RID: 2037
		private int snoHandle_;
	}
}
