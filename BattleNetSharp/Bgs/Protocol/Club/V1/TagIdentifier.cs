using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000509 RID: 1289
	public sealed class TagIdentifier : IMessage<TagIdentifier>, IMessage, IEquatable<TagIdentifier>, IDeepCloneable<TagIdentifier>, IBufferMessage
	{
		// Token: 0x170027FA RID: 10234
		// (get) Token: 0x06007DE4 RID: 32228 RVA: 0x001EA4B4 File Offset: 0x001E86B4
		[DebuggerNonUserCode]
		public static MessageParser<TagIdentifier> Parser
		{
			get
			{
				return TagIdentifier._parser;
			}
		}

		// Token: 0x170027FB RID: 10235
		// (get) Token: 0x06007DE5 RID: 32229 RVA: 0x001EA4CC File Offset: 0x001E86CC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubTagReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170027FC RID: 10236
		// (get) Token: 0x06007DE6 RID: 32230 RVA: 0x001EA4F0 File Offset: 0x001E86F0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TagIdentifier.Descriptor;
			}
		}

		// Token: 0x06007DE7 RID: 32231 RVA: 0x001EA507 File Offset: 0x001E8707
		[DebuggerNonUserCode]
		public TagIdentifier()
		{
		}

		// Token: 0x06007DE8 RID: 32232 RVA: 0x001EA511 File Offset: 0x001E8711
		[DebuggerNonUserCode]
		public TagIdentifier(TagIdentifier other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007DE9 RID: 32233 RVA: 0x001EA550 File Offset: 0x001E8750
		[DebuggerNonUserCode]
		public TagIdentifier Clone()
		{
			return new TagIdentifier(this);
		}

		// Token: 0x170027FD RID: 10237
		// (get) Token: 0x06007DEA RID: 32234 RVA: 0x001EA568 File Offset: 0x001E8768
		// (set) Token: 0x06007DEB RID: 32235 RVA: 0x001EA599 File Offset: 0x001E8799
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
					idDefaultValue = TagIdentifier.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x170027FE RID: 10238
		// (get) Token: 0x06007DEC RID: 32236 RVA: 0x001EA5B4 File Offset: 0x001E87B4
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007DED RID: 32237 RVA: 0x001EA5D1 File Offset: 0x001E87D1
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170027FF RID: 10239
		// (get) Token: 0x06007DEE RID: 32238 RVA: 0x001EA5E4 File Offset: 0x001E87E4
		// (set) Token: 0x06007DEF RID: 32239 RVA: 0x001EA615 File Offset: 0x001E8815
		[DebuggerNonUserCode]
		public uint Type
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint typeDefaultValue;
				if (flag)
				{
					typeDefaultValue = this.type_;
				}
				else
				{
					typeDefaultValue = TagIdentifier.TypeDefaultValue;
				}
				return typeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.type_ = value;
			}
		}

		// Token: 0x17002800 RID: 10240
		// (get) Token: 0x06007DF0 RID: 32240 RVA: 0x001EA630 File Offset: 0x001E8830
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007DF1 RID: 32241 RVA: 0x001EA64D File Offset: 0x001E884D
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007DF2 RID: 32242 RVA: 0x001EA660 File Offset: 0x001E8860
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TagIdentifier);
		}

		// Token: 0x06007DF3 RID: 32243 RVA: 0x001EA680 File Offset: 0x001E8880
		[DebuggerNonUserCode]
		public bool Equals(TagIdentifier other)
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
						bool flag5 = this.Type != other.Type;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007DF4 RID: 32244 RVA: 0x001EA6F4 File Offset: 0x001E88F4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007DF5 RID: 32245 RVA: 0x001EA760 File Offset: 0x001E8960
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007DF6 RID: 32246 RVA: 0x001EA778 File Offset: 0x001E8978
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007DF7 RID: 32247 RVA: 0x001EA784 File Offset: 0x001E8984
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Type);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007DF8 RID: 32248 RVA: 0x001EA7F4 File Offset: 0x001E89F4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Type);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007DF9 RID: 32249 RVA: 0x001EA860 File Offset: 0x001E8A60
		[DebuggerNonUserCode]
		public void MergeFrom(TagIdentifier other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007DFA RID: 32250 RVA: 0x001EA8C2 File Offset: 0x001E8AC2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007DFB RID: 32251 RVA: 0x001EA8D0 File Offset: 0x001E8AD0
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
						this.Type = input.ReadUInt32();
					}
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400394C RID: 14668
		private static readonly MessageParser<TagIdentifier> _parser = new MessageParser<TagIdentifier>(() => new TagIdentifier());

		// Token: 0x0400394D RID: 14669
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400394E RID: 14670
		private int _hasBits0;

		// Token: 0x0400394F RID: 14671
		public const int IdFieldNumber = 1;

		// Token: 0x04003950 RID: 14672
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04003951 RID: 14673
		private uint id_;

		// Token: 0x04003952 RID: 14674
		public const int TypeFieldNumber = 2;

		// Token: 0x04003953 RID: 14675
		private static readonly uint TypeDefaultValue = 0U;

		// Token: 0x04003954 RID: 14676
		private uint type_;
	}
}
