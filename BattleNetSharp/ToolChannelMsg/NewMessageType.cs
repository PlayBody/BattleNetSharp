using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000012 RID: 18
	public sealed class NewMessageType : IMessage<NewMessageType>, IMessage, IEquatable<NewMessageType>, IDeepCloneable<NewMessageType>, IBufferMessage
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00005210 File Offset: 0x00003410
		[DebuggerNonUserCode]
		public static MessageParser<NewMessageType> Parser
		{
			get
			{
				return NewMessageType._parser;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00005228 File Offset: 0x00003428
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return InternalReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000524C File Offset: 0x0000344C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewMessageType.Descriptor;
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00005263 File Offset: 0x00003463
		[DebuggerNonUserCode]
		public NewMessageType()
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000526D File Offset: 0x0000346D
		[DebuggerNonUserCode]
		public NewMessageType(NewMessageType other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.name_ = other.name_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000052AC File Offset: 0x000034AC
		[DebuggerNonUserCode]
		public NewMessageType Clone()
		{
			return new NewMessageType(this);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000052C4 File Offset: 0x000034C4
		// (set) Token: 0x060000BC RID: 188 RVA: 0x000052E5 File Offset: 0x000034E5
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? NewMessageType.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000BD RID: 189 RVA: 0x000052FC File Offset: 0x000034FC
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005317 File Offset: 0x00003517
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00005324 File Offset: 0x00003524
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00005355 File Offset: 0x00003555
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
					idDefaultValue = NewMessageType.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00005370 File Offset: 0x00003570
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000538D File Offset: 0x0000358D
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000053A0 File Offset: 0x000035A0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewMessageType);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000053C0 File Offset: 0x000035C0
		[DebuggerNonUserCode]
		public bool Equals(NewMessageType other)
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
					bool flag4 = this.Name != other.Name;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Id != other.Id;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005434 File Offset: 0x00003634
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000054A0 File Offset: 0x000036A0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000054B8 File Offset: 0x000036B8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000054C4 File Offset: 0x000036C4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Id);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00005534 File Offset: 0x00003734
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000055A0 File Offset: 0x000037A0
		[DebuggerNonUserCode]
		public void MergeFrom(NewMessageType other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00005602 File Offset: 0x00003802
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00005610 File Offset: 0x00003810
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
						this.Id = input.ReadUInt32();
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x0400006B RID: 107
		private static readonly MessageParser<NewMessageType> _parser = new MessageParser<NewMessageType>(() => new NewMessageType());

		// Token: 0x0400006C RID: 108
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400006D RID: 109
		private int _hasBits0;

		// Token: 0x0400006E RID: 110
		public const int NameFieldNumber = 1;

		// Token: 0x0400006F RID: 111
		private static readonly string NameDefaultValue = "";

		// Token: 0x04000070 RID: 112
		private string name_;

		// Token: 0x04000071 RID: 113
		public const int IdFieldNumber = 2;

		// Token: 0x04000072 RID: 114
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04000073 RID: 115
		private uint id_;
	}
}
