using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000103 RID: 259
	public sealed class TACTKeyInternal : IMessage<TACTKeyInternal>, IMessage, IEquatable<TACTKeyInternal>, IDeepCloneable<TACTKeyInternal>, IBufferMessage
	{
		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060018B8 RID: 6328 RVA: 0x00057F98 File Offset: 0x00056198
		[DebuggerNonUserCode]
		public static MessageParser<TACTKeyInternal> Parser
		{
			get
			{
				return TACTKeyInternal._parser;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x00057FB0 File Offset: 0x000561B0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[236];
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060018BA RID: 6330 RVA: 0x00057FD8 File Offset: 0x000561D8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TACTKeyInternal.Descriptor;
			}
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x00057FEF File Offset: 0x000561EF
		[DebuggerNonUserCode]
		public TACTKeyInternal()
		{
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00057FFC File Offset: 0x000561FC
		[DebuggerNonUserCode]
		public TACTKeyInternal(TACTKeyInternal other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.value_ = other.value_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00058054 File Offset: 0x00056254
		[DebuggerNonUserCode]
		public TACTKeyInternal Clone()
		{
			return new TACTKeyInternal(this);
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060018BE RID: 6334 RVA: 0x0005806C File Offset: 0x0005626C
		// (set) Token: 0x060018BF RID: 6335 RVA: 0x0005809D File Offset: 0x0005629D
		[DebuggerNonUserCode]
		public ulong Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = TACTKeyInternal.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060018C0 RID: 6336 RVA: 0x000580B8 File Offset: 0x000562B8
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x000580D5 File Offset: 0x000562D5
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060018C2 RID: 6338 RVA: 0x000580E8 File Offset: 0x000562E8
		// (set) Token: 0x060018C3 RID: 6339 RVA: 0x00058109 File Offset: 0x00056309
		[DebuggerNonUserCode]
		public string Value
		{
			get
			{
				return this.value_ ?? TACTKeyInternal.ValueDefaultValue;
			}
			set
			{
				this.value_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060018C4 RID: 6340 RVA: 0x00058120 File Offset: 0x00056320
		[DebuggerNonUserCode]
		public bool HasValue
		{
			get
			{
				return this.value_ != null;
			}
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x0005813B File Offset: 0x0005633B
		[DebuggerNonUserCode]
		public void ClearValue()
		{
			this.value_ = null;
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060018C6 RID: 6342 RVA: 0x00058148 File Offset: 0x00056348
		// (set) Token: 0x060018C7 RID: 6343 RVA: 0x00058169 File Offset: 0x00056369
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? TACTKeyInternal.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060018C8 RID: 6344 RVA: 0x00058180 File Offset: 0x00056380
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x0005819B File Offset: 0x0005639B
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x000581A8 File Offset: 0x000563A8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TACTKeyInternal);
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x000581C8 File Offset: 0x000563C8
		[DebuggerNonUserCode]
		public bool Equals(TACTKeyInternal other)
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
						bool flag5 = this.Value != other.Value;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Name != other.Name;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x00058254 File Offset: 0x00056454
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num ^= this.Value.GetHashCode();
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

		// Token: 0x060018CD RID: 6349 RVA: 0x000582D8 File Offset: 0x000564D8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x000582F0 File Offset: 0x000564F0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x000582FC File Offset: 0x000564FC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Id);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Value);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Name);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x0005838C File Offset: 0x0005658C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Id);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Value);
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

		// Token: 0x060018D1 RID: 6353 RVA: 0x00058418 File Offset: 0x00056618
		[DebuggerNonUserCode]
		public void MergeFrom(TACTKeyInternal other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasValue = other.HasValue;
				if (hasValue)
				{
					this.Value = other.Value;
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00058493 File Offset: 0x00056693
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x000584A0 File Offset: 0x000566A0
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
							this.Name = input.ReadString();
						}
					}
					else
					{
						this.Value = input.ReadString();
					}
				}
				else
				{
					this.Id = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040009D5 RID: 2517
		private static readonly MessageParser<TACTKeyInternal> _parser = new MessageParser<TACTKeyInternal>(() => new TACTKeyInternal());

		// Token: 0x040009D6 RID: 2518
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009D7 RID: 2519
		private int _hasBits0;

		// Token: 0x040009D8 RID: 2520
		public const int IdFieldNumber = 1;

		// Token: 0x040009D9 RID: 2521
		private static readonly ulong IdDefaultValue = 0UL;

		// Token: 0x040009DA RID: 2522
		private ulong id_;

		// Token: 0x040009DB RID: 2523
		public const int ValueFieldNumber = 2;

		// Token: 0x040009DC RID: 2524
		private static readonly string ValueDefaultValue = "";

		// Token: 0x040009DD RID: 2525
		private string value_;

		// Token: 0x040009DE RID: 2526
		public const int NameFieldNumber = 3;

		// Token: 0x040009DF RID: 2527
		private static readonly string NameDefaultValue = "";

		// Token: 0x040009E0 RID: 2528
		private string name_;
	}
}
