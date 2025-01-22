using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.Character
{
	// Token: 0x020007A8 RID: 1960
	public sealed class CharData : IMessage<CharData>, IMessage, IEquatable<CharData>, IDeepCloneable<CharData>, IBufferMessage
	{
		// Token: 0x170037B1 RID: 14257
		// (get) Token: 0x0600B3DE RID: 46046 RVA: 0x002BC164 File Offset: 0x002BA364
		[DebuggerNonUserCode]
		public static MessageParser<CharData> Parser
		{
			get
			{
				return CharData._parser;
			}
		}

		// Token: 0x170037B2 RID: 14258
		// (get) Token: 0x0600B3DF RID: 46047 RVA: 0x002BC17C File Offset: 0x002BA37C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CharacterReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170037B3 RID: 14259
		// (get) Token: 0x0600B3E0 RID: 46048 RVA: 0x002BC1A0 File Offset: 0x002BA3A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharData.Descriptor;
			}
		}

		// Token: 0x0600B3E1 RID: 46049 RVA: 0x002BC1B7 File Offset: 0x002BA3B7
		[DebuggerNonUserCode]
		public CharData()
		{
		}

		// Token: 0x0600B3E2 RID: 46050 RVA: 0x002BC1C4 File Offset: 0x002BA3C4
		[DebuggerNonUserCode]
		public CharData(CharData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.name_ = other.name_;
			this.d2S_ = other.d2S_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B3E3 RID: 46051 RVA: 0x002BC21C File Offset: 0x002BA41C
		[DebuggerNonUserCode]
		public CharData Clone()
		{
			return new CharData(this);
		}

		// Token: 0x170037B4 RID: 14260
		// (get) Token: 0x0600B3E4 RID: 46052 RVA: 0x002BC234 File Offset: 0x002BA434
		// (set) Token: 0x0600B3E5 RID: 46053 RVA: 0x002BC265 File Offset: 0x002BA465
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
					idDefaultValue = CharData.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x170037B5 RID: 14261
		// (get) Token: 0x0600B3E6 RID: 46054 RVA: 0x002BC280 File Offset: 0x002BA480
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B3E7 RID: 46055 RVA: 0x002BC29D File Offset: 0x002BA49D
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170037B6 RID: 14262
		// (get) Token: 0x0600B3E8 RID: 46056 RVA: 0x002BC2B0 File Offset: 0x002BA4B0
		// (set) Token: 0x0600B3E9 RID: 46057 RVA: 0x002BC2D1 File Offset: 0x002BA4D1
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? CharData.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170037B7 RID: 14263
		// (get) Token: 0x0600B3EA RID: 46058 RVA: 0x002BC2E8 File Offset: 0x002BA4E8
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x0600B3EB RID: 46059 RVA: 0x002BC303 File Offset: 0x002BA503
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x170037B8 RID: 14264
		// (get) Token: 0x0600B3EC RID: 46060 RVA: 0x002BC310 File Offset: 0x002BA510
		// (set) Token: 0x0600B3ED RID: 46061 RVA: 0x002BC331 File Offset: 0x002BA531
		[DebuggerNonUserCode]
		public ByteString D2S
		{
			get
			{
				return this.d2S_ ?? CharData.D2SDefaultValue;
			}
			set
			{
				this.d2S_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170037B9 RID: 14265
		// (get) Token: 0x0600B3EE RID: 46062 RVA: 0x002BC348 File Offset: 0x002BA548
		[DebuggerNonUserCode]
		public bool HasD2S
		{
			get
			{
				return this.d2S_ != null;
			}
		}

		// Token: 0x0600B3EF RID: 46063 RVA: 0x002BC366 File Offset: 0x002BA566
		[DebuggerNonUserCode]
		public void ClearD2S()
		{
			this.d2S_ = null;
		}

		// Token: 0x0600B3F0 RID: 46064 RVA: 0x002BC370 File Offset: 0x002BA570
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharData);
		}

		// Token: 0x0600B3F1 RID: 46065 RVA: 0x002BC390 File Offset: 0x002BA590
		[DebuggerNonUserCode]
		public bool Equals(CharData other)
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
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.D2S != other.D2S;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600B3F2 RID: 46066 RVA: 0x002BC41C File Offset: 0x002BA61C
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
			bool hasD2S = this.HasD2S;
			if (hasD2S)
			{
				num ^= this.D2S.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B3F3 RID: 46067 RVA: 0x002BC4A0 File Offset: 0x002BA6A0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B3F4 RID: 46068 RVA: 0x002BC4B8 File Offset: 0x002BA6B8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3F5 RID: 46069 RVA: 0x002BC4C4 File Offset: 0x002BA6C4
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
			bool hasD2S = this.HasD2S;
			if (hasD2S)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.D2S);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B3F6 RID: 46070 RVA: 0x002BC554 File Offset: 0x002BA754
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
			bool hasD2S = this.HasD2S;
			if (hasD2S)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.D2S);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B3F7 RID: 46071 RVA: 0x002BC5E0 File Offset: 0x002BA7E0
		[DebuggerNonUserCode]
		public void MergeFrom(CharData other)
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
				bool hasD2S = other.HasD2S;
				if (hasD2S)
				{
					this.D2S = other.D2S;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B3F8 RID: 46072 RVA: 0x002BC65B File Offset: 0x002BA85B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B3F9 RID: 46073 RVA: 0x002BC668 File Offset: 0x002BA868
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.D2S = input.ReadBytes();
						}
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

		// Token: 0x04005151 RID: 20817
		private static readonly MessageParser<CharData> _parser = new MessageParser<CharData>(() => new CharData());

		// Token: 0x04005152 RID: 20818
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005153 RID: 20819
		private int _hasBits0;

		// Token: 0x04005154 RID: 20820
		public const int IdFieldNumber = 1;

		// Token: 0x04005155 RID: 20821
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04005156 RID: 20822
		private uint id_;

		// Token: 0x04005157 RID: 20823
		public const int NameFieldNumber = 2;

		// Token: 0x04005158 RID: 20824
		private static readonly string NameDefaultValue = "";

		// Token: 0x04005159 RID: 20825
		private string name_;

		// Token: 0x0400515A RID: 20826
		public const int D2SFieldNumber = 3;

		// Token: 0x0400515B RID: 20827
		private static readonly ByteString D2SDefaultValue = ByteString.Empty;

		// Token: 0x0400515C RID: 20828
		private ByteString d2S_;
	}
}
