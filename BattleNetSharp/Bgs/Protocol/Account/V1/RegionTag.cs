using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000736 RID: 1846
	public sealed class RegionTag : IMessage<RegionTag>, IMessage, IEquatable<RegionTag>, IDeepCloneable<RegionTag>, IBufferMessage
	{
		// Token: 0x1700340F RID: 13327
		// (get) Token: 0x0600A8DF RID: 43231 RVA: 0x0029223C File Offset: 0x0029043C
		[DebuggerNonUserCode]
		public static MessageParser<RegionTag> Parser
		{
			get
			{
				return RegionTag._parser;
			}
		}

		// Token: 0x17003410 RID: 13328
		// (get) Token: 0x0600A8E0 RID: 43232 RVA: 0x00292254 File Offset: 0x00290454
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17003411 RID: 13329
		// (get) Token: 0x0600A8E1 RID: 43233 RVA: 0x00292278 File Offset: 0x00290478
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegionTag.Descriptor;
			}
		}

		// Token: 0x0600A8E2 RID: 43234 RVA: 0x0029228F File Offset: 0x0029048F
		[DebuggerNonUserCode]
		public RegionTag()
		{
		}

		// Token: 0x0600A8E3 RID: 43235 RVA: 0x00292299 File Offset: 0x00290499
		[DebuggerNonUserCode]
		public RegionTag(RegionTag other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.region_ = other.region_;
			this.tag_ = other.tag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A8E4 RID: 43236 RVA: 0x002922D8 File Offset: 0x002904D8
		[DebuggerNonUserCode]
		public RegionTag Clone()
		{
			return new RegionTag(this);
		}

		// Token: 0x17003412 RID: 13330
		// (get) Token: 0x0600A8E5 RID: 43237 RVA: 0x002922F0 File Offset: 0x002904F0
		// (set) Token: 0x0600A8E6 RID: 43238 RVA: 0x00292321 File Offset: 0x00290521
		[DebuggerNonUserCode]
		public uint Region
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint regionDefaultValue;
				if (flag)
				{
					regionDefaultValue = this.region_;
				}
				else
				{
					regionDefaultValue = RegionTag.RegionDefaultValue;
				}
				return regionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.region_ = value;
			}
		}

		// Token: 0x17003413 RID: 13331
		// (get) Token: 0x0600A8E7 RID: 43239 RVA: 0x0029233C File Offset: 0x0029053C
		[DebuggerNonUserCode]
		public bool HasRegion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A8E8 RID: 43240 RVA: 0x00292359 File Offset: 0x00290559
		[DebuggerNonUserCode]
		public void ClearRegion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003414 RID: 13332
		// (get) Token: 0x0600A8E9 RID: 43241 RVA: 0x0029236C File Offset: 0x0029056C
		// (set) Token: 0x0600A8EA RID: 43242 RVA: 0x0029239D File Offset: 0x0029059D
		[DebuggerNonUserCode]
		public uint Tag
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint tagDefaultValue;
				if (flag)
				{
					tagDefaultValue = this.tag_;
				}
				else
				{
					tagDefaultValue = RegionTag.TagDefaultValue;
				}
				return tagDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.tag_ = value;
			}
		}

		// Token: 0x17003415 RID: 13333
		// (get) Token: 0x0600A8EB RID: 43243 RVA: 0x002923B8 File Offset: 0x002905B8
		[DebuggerNonUserCode]
		public bool HasTag
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A8EC RID: 43244 RVA: 0x002923D5 File Offset: 0x002905D5
		[DebuggerNonUserCode]
		public void ClearTag()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600A8ED RID: 43245 RVA: 0x002923E8 File Offset: 0x002905E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegionTag);
		}

		// Token: 0x0600A8EE RID: 43246 RVA: 0x00292408 File Offset: 0x00290608
		[DebuggerNonUserCode]
		public bool Equals(RegionTag other)
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
					bool flag4 = this.Region != other.Region;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Tag != other.Tag;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A8EF RID: 43247 RVA: 0x0029247C File Offset: 0x0029067C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num ^= this.Region.GetHashCode();
			}
			bool hasTag = this.HasTag;
			if (hasTag)
			{
				num ^= this.Tag.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A8F0 RID: 43248 RVA: 0x002924E8 File Offset: 0x002906E8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A8F1 RID: 43249 RVA: 0x00292500 File Offset: 0x00290700
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A8F2 RID: 43250 RVA: 0x0029250C File Offset: 0x0029070C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				output.WriteRawTag(13);
				output.WriteFixed32(this.Region);
			}
			bool hasTag = this.HasTag;
			if (hasTag)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.Tag);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A8F3 RID: 43251 RVA: 0x0029257C File Offset: 0x0029077C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num += 5;
			}
			bool hasTag = this.HasTag;
			if (hasTag)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A8F4 RID: 43252 RVA: 0x002925D0 File Offset: 0x002907D0
		[DebuggerNonUserCode]
		public void MergeFrom(RegionTag other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRegion = other.HasRegion;
				if (hasRegion)
				{
					this.Region = other.Region;
				}
				bool hasTag = other.HasTag;
				if (hasTag)
				{
					this.Tag = other.Tag;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A8F5 RID: 43253 RVA: 0x00292632 File Offset: 0x00290832
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A8F6 RID: 43254 RVA: 0x00292640 File Offset: 0x00290840
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					if (num3 != 21U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Tag = input.ReadFixed32();
					}
				}
				else
				{
					this.Region = input.ReadFixed32();
				}
			}
		}

		// Token: 0x04004BE4 RID: 19428
		private static readonly MessageParser<RegionTag> _parser = new MessageParser<RegionTag>(() => new RegionTag());

		// Token: 0x04004BE5 RID: 19429
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BE6 RID: 19430
		private int _hasBits0;

		// Token: 0x04004BE7 RID: 19431
		public const int RegionFieldNumber = 1;

		// Token: 0x04004BE8 RID: 19432
		private static readonly uint RegionDefaultValue = 0U;

		// Token: 0x04004BE9 RID: 19433
		private uint region_;

		// Token: 0x04004BEA RID: 19434
		public const int TagFieldNumber = 2;

		// Token: 0x04004BEB RID: 19435
		private static readonly uint TagDefaultValue = 0U;

		// Token: 0x04004BEC RID: 19436
		private uint tag_;
	}
}
