using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200001A RID: 26
	public sealed class WwiseSoundBankIDToName : IMessage<WwiseSoundBankIDToName>, IMessage, IEquatable<WwiseSoundBankIDToName>, IDeepCloneable<WwiseSoundBankIDToName>, IBufferMessage
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000B4B0 File Offset: 0x000096B0
		[DebuggerNonUserCode]
		public static MessageParser<WwiseSoundBankIDToName> Parser
		{
			get
			{
				return WwiseSoundBankIDToName._parser;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000B4C8 File Offset: 0x000096C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000B4EC File Offset: 0x000096EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WwiseSoundBankIDToName.Descriptor;
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000B503 File Offset: 0x00009703
		[DebuggerNonUserCode]
		public WwiseSoundBankIDToName()
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000B50D File Offset: 0x0000970D
		[DebuggerNonUserCode]
		public WwiseSoundBankIDToName(WwiseSoundBankIDToName other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000B54C File Offset: 0x0000974C
		[DebuggerNonUserCode]
		public WwiseSoundBankIDToName Clone()
		{
			return new WwiseSoundBankIDToName(this);
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0000B564 File Offset: 0x00009764
		// (set) Token: 0x0600011E RID: 286 RVA: 0x0000B595 File Offset: 0x00009795
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = WwiseSoundBankIDToName.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0000B5B0 File Offset: 0x000097B0
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000B5CD File Offset: 0x000097CD
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0000B5E0 File Offset: 0x000097E0
		// (set) Token: 0x06000122 RID: 290 RVA: 0x0000B601 File Offset: 0x00009801
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? WwiseSoundBankIDToName.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000B618 File Offset: 0x00009818
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000B633 File Offset: 0x00009833
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000B640 File Offset: 0x00009840
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as WwiseSoundBankIDToName);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000B660 File Offset: 0x00009860
		[DebuggerNonUserCode]
		public bool Equals(WwiseSoundBankIDToName other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Name != other.Name;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000B6D4 File Offset: 0x000098D4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000B740 File Offset: 0x00009940
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000B758 File Offset: 0x00009958
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000B764 File Offset: 0x00009964
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000B7D4 File Offset: 0x000099D4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000B840 File Offset: 0x00009A40
		[DebuggerNonUserCode]
		public void MergeFrom(WwiseSoundBankIDToName other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000B8A2 File Offset: 0x00009AA2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000B8B0 File Offset: 0x00009AB0
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
						this.Name = input.ReadString();
					}
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000098 RID: 152
		private static readonly MessageParser<WwiseSoundBankIDToName> _parser = new MessageParser<WwiseSoundBankIDToName>(() => new WwiseSoundBankIDToName());

		// Token: 0x04000099 RID: 153
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400009A RID: 154
		private int _hasBits0;

		// Token: 0x0400009B RID: 155
		public const int IdFieldNumber = 1;

		// Token: 0x0400009C RID: 156
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x0400009D RID: 157
		private uint id_;

		// Token: 0x0400009E RID: 158
		public const int NameFieldNumber = 2;

		// Token: 0x0400009F RID: 159
		private static readonly string NameDefaultValue = "";

		// Token: 0x040000A0 RID: 160
		private string name_;
	}
}
