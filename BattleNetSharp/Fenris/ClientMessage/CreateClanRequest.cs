using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000264 RID: 612
	public sealed class CreateClanRequest : IMessage<CreateClanRequest>, IMessage, IEquatable<CreateClanRequest>, IDeepCloneable<CreateClanRequest>, IBufferMessage
	{
		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x060041C3 RID: 16835 RVA: 0x001001B0 File Offset: 0x000FE3B0
		[DebuggerNonUserCode]
		public static MessageParser<CreateClanRequest> Parser
		{
			get
			{
				return CreateClanRequest._parser;
			}
		}

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x060041C4 RID: 16836 RVA: 0x001001C8 File Offset: 0x000FE3C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[84];
			}
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x060041C5 RID: 16837 RVA: 0x001001EC File Offset: 0x000FE3EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateClanRequest.Descriptor;
			}
		}

		// Token: 0x060041C6 RID: 16838 RVA: 0x00100203 File Offset: 0x000FE403
		[DebuggerNonUserCode]
		public CreateClanRequest()
		{
		}

		// Token: 0x060041C7 RID: 16839 RVA: 0x00100218 File Offset: 0x000FE418
		[DebuggerNonUserCode]
		public CreateClanRequest(CreateClanRequest other)
			: this()
		{
			this.name_ = other.name_;
			this.tag_ = other.tag_;
			this.description_ = other.description_;
			this.label_ = other.label_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060041C8 RID: 16840 RVA: 0x00100274 File Offset: 0x000FE474
		[DebuggerNonUserCode]
		public CreateClanRequest Clone()
		{
			return new CreateClanRequest(this);
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x060041C9 RID: 16841 RVA: 0x0010028C File Offset: 0x000FE48C
		// (set) Token: 0x060041CA RID: 16842 RVA: 0x001002AD File Offset: 0x000FE4AD
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? CreateClanRequest.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x060041CB RID: 16843 RVA: 0x001002C4 File Offset: 0x000FE4C4
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x060041CC RID: 16844 RVA: 0x001002DF File Offset: 0x000FE4DF
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x060041CD RID: 16845 RVA: 0x001002EC File Offset: 0x000FE4EC
		// (set) Token: 0x060041CE RID: 16846 RVA: 0x0010030D File Offset: 0x000FE50D
		[DebuggerNonUserCode]
		public string Tag
		{
			get
			{
				return this.tag_ ?? CreateClanRequest.TagDefaultValue;
			}
			set
			{
				this.tag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x060041CF RID: 16847 RVA: 0x00100324 File Offset: 0x000FE524
		[DebuggerNonUserCode]
		public bool HasTag
		{
			get
			{
				return this.tag_ != null;
			}
		}

		// Token: 0x060041D0 RID: 16848 RVA: 0x0010033F File Offset: 0x000FE53F
		[DebuggerNonUserCode]
		public void ClearTag()
		{
			this.tag_ = null;
		}

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x060041D1 RID: 16849 RVA: 0x0010034C File Offset: 0x000FE54C
		// (set) Token: 0x060041D2 RID: 16850 RVA: 0x0010036D File Offset: 0x000FE56D
		[DebuggerNonUserCode]
		public string Description
		{
			get
			{
				return this.description_ ?? CreateClanRequest.DescriptionDefaultValue;
			}
			set
			{
				this.description_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x060041D3 RID: 16851 RVA: 0x00100384 File Offset: 0x000FE584
		[DebuggerNonUserCode]
		public bool HasDescription
		{
			get
			{
				return this.description_ != null;
			}
		}

		// Token: 0x060041D4 RID: 16852 RVA: 0x0010039F File Offset: 0x000FE59F
		[DebuggerNonUserCode]
		public void ClearDescription()
		{
			this.description_ = null;
		}

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x060041D5 RID: 16853 RVA: 0x001003AC File Offset: 0x000FE5AC
		[DebuggerNonUserCode]
		public RepeatedField<uint> Label
		{
			get
			{
				return this.label_;
			}
		}

		// Token: 0x060041D6 RID: 16854 RVA: 0x001003C4 File Offset: 0x000FE5C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateClanRequest);
		}

		// Token: 0x060041D7 RID: 16855 RVA: 0x001003E4 File Offset: 0x000FE5E4
		[DebuggerNonUserCode]
		public bool Equals(CreateClanRequest other)
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
						bool flag5 = this.Tag != other.Tag;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Description != other.Description;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.label_.Equals(other.label_);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060041D8 RID: 16856 RVA: 0x00100494 File Offset: 0x000FE694
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasTag = this.HasTag;
			if (hasTag)
			{
				num ^= this.Tag.GetHashCode();
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num ^= this.Description.GetHashCode();
			}
			num ^= this.label_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060041D9 RID: 16857 RVA: 0x00100520 File Offset: 0x000FE720
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060041DA RID: 16858 RVA: 0x00100538 File Offset: 0x000FE738
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x00100544 File Offset: 0x000FE744
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool hasTag = this.HasTag;
			if (hasTag)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Tag);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Description);
			}
			this.label_.WriteTo(ref output, CreateClanRequest._repeated_label_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060041DC RID: 16860 RVA: 0x001005E8 File Offset: 0x000FE7E8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasTag = this.HasTag;
			if (hasTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Tag);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Description);
			}
			num += this.label_.CalculateSize(CreateClanRequest._repeated_label_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x00100688 File Offset: 0x000FE888
		[DebuggerNonUserCode]
		public void MergeFrom(CreateClanRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasTag = other.HasTag;
				if (hasTag)
				{
					this.Tag = other.Tag;
				}
				bool hasDescription = other.HasDescription;
				if (hasDescription)
				{
					this.Description = other.Description;
				}
				this.label_.Add(other.label_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x00100715 File Offset: 0x000FE915
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x00100720 File Offset: 0x000FE920
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_0033;
						}
						this.Tag = input.ReadString();
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U && num3 != 34U)
					{
						goto IL_0033;
					}
					this.label_.AddEntriesFrom(ref input, CreateClanRequest._repeated_label_codec);
				}
				else
				{
					this.Description = input.ReadString();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001DD3 RID: 7635
		private static readonly MessageParser<CreateClanRequest> _parser = new MessageParser<CreateClanRequest>(() => new CreateClanRequest());

		// Token: 0x04001DD4 RID: 7636
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DD5 RID: 7637
		public const int NameFieldNumber = 1;

		// Token: 0x04001DD6 RID: 7638
		private static readonly string NameDefaultValue = "";

		// Token: 0x04001DD7 RID: 7639
		private string name_;

		// Token: 0x04001DD8 RID: 7640
		public const int TagFieldNumber = 2;

		// Token: 0x04001DD9 RID: 7641
		private static readonly string TagDefaultValue = "";

		// Token: 0x04001DDA RID: 7642
		private string tag_;

		// Token: 0x04001DDB RID: 7643
		public const int DescriptionFieldNumber = 3;

		// Token: 0x04001DDC RID: 7644
		private static readonly string DescriptionDefaultValue = "";

		// Token: 0x04001DDD RID: 7645
		private string description_;

		// Token: 0x04001DDE RID: 7646
		public const int LabelFieldNumber = 4;

		// Token: 0x04001DDF RID: 7647
		private static readonly FieldCodec<uint> _repeated_label_codec = FieldCodec.ForUInt32(32U);

		// Token: 0x04001DE0 RID: 7648
		private readonly RepeatedField<uint> label_ = new RepeatedField<uint>();
	}
}
