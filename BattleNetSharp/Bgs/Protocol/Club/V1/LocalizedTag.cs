using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200050A RID: 1290
	public sealed class LocalizedTag : IMessage<LocalizedTag>, IMessage, IEquatable<LocalizedTag>, IDeepCloneable<LocalizedTag>, IBufferMessage
	{
		// Token: 0x17002801 RID: 10241
		// (get) Token: 0x06007DFD RID: 32253 RVA: 0x001EA960 File Offset: 0x001E8B60
		[DebuggerNonUserCode]
		public static MessageParser<LocalizedTag> Parser
		{
			get
			{
				return LocalizedTag._parser;
			}
		}

		// Token: 0x17002802 RID: 10242
		// (get) Token: 0x06007DFE RID: 32254 RVA: 0x001EA978 File Offset: 0x001E8B78
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubTagReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002803 RID: 10243
		// (get) Token: 0x06007DFF RID: 32255 RVA: 0x001EA99C File Offset: 0x001E8B9C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LocalizedTag.Descriptor;
			}
		}

		// Token: 0x06007E00 RID: 32256 RVA: 0x001EA9B3 File Offset: 0x001E8BB3
		[DebuggerNonUserCode]
		public LocalizedTag()
		{
		}

		// Token: 0x06007E01 RID: 32257 RVA: 0x001EA9C0 File Offset: 0x001E8BC0
		[DebuggerNonUserCode]
		public LocalizedTag(LocalizedTag other)
			: this()
		{
			this.tagId_ = ((other.tagId_ != null) ? other.tagId_.Clone() : null);
			this.name_ = other.name_;
			this.description_ = other.description_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E02 RID: 32258 RVA: 0x001EAA1C File Offset: 0x001E8C1C
		[DebuggerNonUserCode]
		public LocalizedTag Clone()
		{
			return new LocalizedTag(this);
		}

		// Token: 0x17002804 RID: 10244
		// (get) Token: 0x06007E03 RID: 32259 RVA: 0x001EAA34 File Offset: 0x001E8C34
		// (set) Token: 0x06007E04 RID: 32260 RVA: 0x001EAA4C File Offset: 0x001E8C4C
		[DebuggerNonUserCode]
		public TagIdentifier TagId
		{
			get
			{
				return this.tagId_;
			}
			set
			{
				this.tagId_ = value;
			}
		}

		// Token: 0x17002805 RID: 10245
		// (get) Token: 0x06007E05 RID: 32261 RVA: 0x001EAA58 File Offset: 0x001E8C58
		// (set) Token: 0x06007E06 RID: 32262 RVA: 0x001EAA79 File Offset: 0x001E8C79
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? LocalizedTag.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002806 RID: 10246
		// (get) Token: 0x06007E07 RID: 32263 RVA: 0x001EAA90 File Offset: 0x001E8C90
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06007E08 RID: 32264 RVA: 0x001EAAAB File Offset: 0x001E8CAB
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17002807 RID: 10247
		// (get) Token: 0x06007E09 RID: 32265 RVA: 0x001EAAB8 File Offset: 0x001E8CB8
		// (set) Token: 0x06007E0A RID: 32266 RVA: 0x001EAAD9 File Offset: 0x001E8CD9
		[DebuggerNonUserCode]
		public string Description
		{
			get
			{
				return this.description_ ?? LocalizedTag.DescriptionDefaultValue;
			}
			set
			{
				this.description_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002808 RID: 10248
		// (get) Token: 0x06007E0B RID: 32267 RVA: 0x001EAAF0 File Offset: 0x001E8CF0
		[DebuggerNonUserCode]
		public bool HasDescription
		{
			get
			{
				return this.description_ != null;
			}
		}

		// Token: 0x06007E0C RID: 32268 RVA: 0x001EAB0B File Offset: 0x001E8D0B
		[DebuggerNonUserCode]
		public void ClearDescription()
		{
			this.description_ = null;
		}

		// Token: 0x06007E0D RID: 32269 RVA: 0x001EAB18 File Offset: 0x001E8D18
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LocalizedTag);
		}

		// Token: 0x06007E0E RID: 32270 RVA: 0x001EAB38 File Offset: 0x001E8D38
		[DebuggerNonUserCode]
		public bool Equals(LocalizedTag other)
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
					bool flag4 = !object.Equals(this.TagId, other.TagId);
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
							bool flag6 = this.Description != other.Description;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007E0F RID: 32271 RVA: 0x001EABC8 File Offset: 0x001E8DC8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.tagId_ != null;
			if (flag)
			{
				num ^= this.TagId.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num ^= this.Description.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007E10 RID: 32272 RVA: 0x001EAC4C File Offset: 0x001E8E4C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007E11 RID: 32273 RVA: 0x001EAC64 File Offset: 0x001E8E64
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E12 RID: 32274 RVA: 0x001EAC70 File Offset: 0x001E8E70
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.tagId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.TagId);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Description);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E13 RID: 32275 RVA: 0x001EAD04 File Offset: 0x001E8F04
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.tagId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TagId);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Description);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007E14 RID: 32276 RVA: 0x001EAD94 File Offset: 0x001E8F94
		[DebuggerNonUserCode]
		public void MergeFrom(LocalizedTag other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.tagId_ != null;
				if (flag2)
				{
					bool flag3 = this.tagId_ == null;
					if (flag3)
					{
						this.TagId = new TagIdentifier();
					}
					this.TagId.MergeFrom(other.TagId);
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasDescription = other.HasDescription;
				if (hasDescription)
				{
					this.Description = other.Description;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007E15 RID: 32277 RVA: 0x001EAE37 File Offset: 0x001E9037
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E16 RID: 32278 RVA: 0x001EAE44 File Offset: 0x001E9044
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
					if (num3 != 18U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Description = input.ReadString();
						}
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else
				{
					bool flag = this.tagId_ == null;
					if (flag)
					{
						this.TagId = new TagIdentifier();
					}
					input.ReadMessage(this.TagId);
				}
			}
		}

		// Token: 0x04003955 RID: 14677
		private static readonly MessageParser<LocalizedTag> _parser = new MessageParser<LocalizedTag>(() => new LocalizedTag());

		// Token: 0x04003956 RID: 14678
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003957 RID: 14679
		public const int TagIdFieldNumber = 1;

		// Token: 0x04003958 RID: 14680
		private TagIdentifier tagId_;

		// Token: 0x04003959 RID: 14681
		public const int NameFieldNumber = 2;

		// Token: 0x0400395A RID: 14682
		private static readonly string NameDefaultValue = "";

		// Token: 0x0400395B RID: 14683
		private string name_;

		// Token: 0x0400395C RID: 14684
		public const int DescriptionFieldNumber = 3;

		// Token: 0x0400395D RID: 14685
		private static readonly string DescriptionDefaultValue = "";

		// Token: 0x0400395E RID: 14686
		private string description_;
	}
}
