using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000B4 RID: 180
	public sealed class StoryboardInstance : IMessage<StoryboardInstance>, IMessage, IEquatable<StoryboardInstance>, IDeepCloneable<StoryboardInstance>, IBufferMessage
	{
		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x0003D9DC File Offset: 0x0003BBDC
		[DebuggerNonUserCode]
		public static MessageParser<StoryboardInstance> Parser
		{
			get
			{
				return StoryboardInstance._parser;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x0003D9F4 File Offset: 0x0003BBF4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[157];
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x0003DA1C File Offset: 0x0003BC1C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StoryboardInstance.Descriptor;
			}
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x0003DA33 File Offset: 0x0003BC33
		[DebuggerNonUserCode]
		public StoryboardInstance()
		{
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x0003DA3D File Offset: 0x0003BC3D
		[DebuggerNonUserCode]
		public StoryboardInstance(StoryboardInstance other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.description_ = other.description_;
			this.sno_ = other.sno_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x0003DA7C File Offset: 0x0003BC7C
		[DebuggerNonUserCode]
		public StoryboardInstance Clone()
		{
			return new StoryboardInstance(this);
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x0003DA94 File Offset: 0x0003BC94
		// (set) Token: 0x060010CA RID: 4298 RVA: 0x0003DAB5 File Offset: 0x0003BCB5
		[DebuggerNonUserCode]
		public string Description
		{
			get
			{
				return this.description_ ?? StoryboardInstance.DescriptionDefaultValue;
			}
			set
			{
				this.description_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x0003DACC File Offset: 0x0003BCCC
		[DebuggerNonUserCode]
		public bool HasDescription
		{
			get
			{
				return this.description_ != null;
			}
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0003DAE7 File Offset: 0x0003BCE7
		[DebuggerNonUserCode]
		public void ClearDescription()
		{
			this.description_ = null;
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x0003DAF4 File Offset: 0x0003BCF4
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x0003DB25 File Offset: 0x0003BD25
		[DebuggerNonUserCode]
		public int Sno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoDefaultValue;
				if (flag)
				{
					snoDefaultValue = this.sno_;
				}
				else
				{
					snoDefaultValue = StoryboardInstance.SnoDefaultValue;
				}
				return snoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.sno_ = value;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x0003DB40 File Offset: 0x0003BD40
		[DebuggerNonUserCode]
		public bool HasSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0003DB5D File Offset: 0x0003BD5D
		[DebuggerNonUserCode]
		public void ClearSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0003DB70 File Offset: 0x0003BD70
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StoryboardInstance);
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x0003DB90 File Offset: 0x0003BD90
		[DebuggerNonUserCode]
		public bool Equals(StoryboardInstance other)
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
					bool flag4 = this.Description != other.Description;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Sno != other.Sno;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x0003DC04 File Offset: 0x0003BE04
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num ^= this.Description.GetHashCode();
			}
			bool hasSno = this.HasSno;
			if (hasSno)
			{
				num ^= this.Sno.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0003DC70 File Offset: 0x0003BE70
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0003DC88 File Offset: 0x0003BE88
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x0003DC94 File Offset: 0x0003BE94
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Description);
			}
			bool hasSno = this.HasSno;
			if (hasSno)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Sno);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x0003DD04 File Offset: 0x0003BF04
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Description);
			}
			bool hasSno = this.HasSno;
			if (hasSno)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Sno);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0003DD70 File Offset: 0x0003BF70
		[DebuggerNonUserCode]
		public void MergeFrom(StoryboardInstance other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasDescription = other.HasDescription;
				if (hasDescription)
				{
					this.Description = other.Description;
				}
				bool hasSno = other.HasSno;
				if (hasSno)
				{
					this.Sno = other.Sno;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0003DDD2 File Offset: 0x0003BFD2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0003DDE0 File Offset: 0x0003BFE0
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
						this.Sno = input.ReadInt32();
					}
				}
				else
				{
					this.Description = input.ReadString();
				}
			}
		}

		// Token: 0x040006B2 RID: 1714
		private static readonly MessageParser<StoryboardInstance> _parser = new MessageParser<StoryboardInstance>(() => new StoryboardInstance());

		// Token: 0x040006B3 RID: 1715
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006B4 RID: 1716
		private int _hasBits0;

		// Token: 0x040006B5 RID: 1717
		public const int DescriptionFieldNumber = 1;

		// Token: 0x040006B6 RID: 1718
		private static readonly string DescriptionDefaultValue = "";

		// Token: 0x040006B7 RID: 1719
		private string description_;

		// Token: 0x040006B8 RID: 1720
		public const int SnoFieldNumber = 2;

		// Token: 0x040006B9 RID: 1721
		private static readonly int SnoDefaultValue = 0;

		// Token: 0x040006BA RID: 1722
		private int sno_;
	}
}
