using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200034F RID: 847
	public sealed class ContentHandle : IMessage<ContentHandle>, IMessage, IEquatable<ContentHandle>, IDeepCloneable<ContentHandle>, IBufferMessage
	{
		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x060057FA RID: 22522 RVA: 0x00154850 File Offset: 0x00152A50
		[DebuggerNonUserCode]
		public static MessageParser<ContentHandle> Parser
		{
			get
			{
				return ContentHandle._parser;
			}
		}

		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x060057FB RID: 22523 RVA: 0x00154868 File Offset: 0x00152A68
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ContentHandleTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C8B RID: 7307
		// (get) Token: 0x060057FC RID: 22524 RVA: 0x0015488C File Offset: 0x00152A8C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ContentHandle.Descriptor;
			}
		}

		// Token: 0x060057FD RID: 22525 RVA: 0x001548A3 File Offset: 0x00152AA3
		[DebuggerNonUserCode]
		public ContentHandle()
		{
		}

		// Token: 0x060057FE RID: 22526 RVA: 0x001548B0 File Offset: 0x00152AB0
		[DebuggerNonUserCode]
		public ContentHandle(ContentHandle other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.region_ = other.region_;
			this.usage_ = other.usage_;
			this.hash_ = other.hash_;
			this.protoUrl_ = other.protoUrl_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060057FF RID: 22527 RVA: 0x00154914 File Offset: 0x00152B14
		[DebuggerNonUserCode]
		public ContentHandle Clone()
		{
			return new ContentHandle(this);
		}

		// Token: 0x17001C8C RID: 7308
		// (get) Token: 0x06005800 RID: 22528 RVA: 0x0015492C File Offset: 0x00152B2C
		// (set) Token: 0x06005801 RID: 22529 RVA: 0x0015495D File Offset: 0x00152B5D
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
					regionDefaultValue = ContentHandle.RegionDefaultValue;
				}
				return regionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.region_ = value;
			}
		}

		// Token: 0x17001C8D RID: 7309
		// (get) Token: 0x06005802 RID: 22530 RVA: 0x00154978 File Offset: 0x00152B78
		[DebuggerNonUserCode]
		public bool HasRegion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005803 RID: 22531 RVA: 0x00154995 File Offset: 0x00152B95
		[DebuggerNonUserCode]
		public void ClearRegion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001C8E RID: 7310
		// (get) Token: 0x06005804 RID: 22532 RVA: 0x001549A8 File Offset: 0x00152BA8
		// (set) Token: 0x06005805 RID: 22533 RVA: 0x001549D9 File Offset: 0x00152BD9
		[DebuggerNonUserCode]
		public uint Usage
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint usageDefaultValue;
				if (flag)
				{
					usageDefaultValue = this.usage_;
				}
				else
				{
					usageDefaultValue = ContentHandle.UsageDefaultValue;
				}
				return usageDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.usage_ = value;
			}
		}

		// Token: 0x17001C8F RID: 7311
		// (get) Token: 0x06005806 RID: 22534 RVA: 0x001549F4 File Offset: 0x00152BF4
		[DebuggerNonUserCode]
		public bool HasUsage
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005807 RID: 22535 RVA: 0x00154A11 File Offset: 0x00152C11
		[DebuggerNonUserCode]
		public void ClearUsage()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x06005808 RID: 22536 RVA: 0x00154A24 File Offset: 0x00152C24
		// (set) Token: 0x06005809 RID: 22537 RVA: 0x00154A45 File Offset: 0x00152C45
		[DebuggerNonUserCode]
		public ByteString Hash
		{
			get
			{
				return this.hash_ ?? ContentHandle.HashDefaultValue;
			}
			set
			{
				this.hash_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x0600580A RID: 22538 RVA: 0x00154A5C File Offset: 0x00152C5C
		[DebuggerNonUserCode]
		public bool HasHash
		{
			get
			{
				return this.hash_ != null;
			}
		}

		// Token: 0x0600580B RID: 22539 RVA: 0x00154A7A File Offset: 0x00152C7A
		[DebuggerNonUserCode]
		public void ClearHash()
		{
			this.hash_ = null;
		}

		// Token: 0x17001C92 RID: 7314
		// (get) Token: 0x0600580C RID: 22540 RVA: 0x00154A84 File Offset: 0x00152C84
		// (set) Token: 0x0600580D RID: 22541 RVA: 0x00154AA5 File Offset: 0x00152CA5
		[DebuggerNonUserCode]
		public string ProtoUrl
		{
			get
			{
				return this.protoUrl_ ?? ContentHandle.ProtoUrlDefaultValue;
			}
			set
			{
				this.protoUrl_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001C93 RID: 7315
		// (get) Token: 0x0600580E RID: 22542 RVA: 0x00154ABC File Offset: 0x00152CBC
		[DebuggerNonUserCode]
		public bool HasProtoUrl
		{
			get
			{
				return this.protoUrl_ != null;
			}
		}

		// Token: 0x0600580F RID: 22543 RVA: 0x00154AD7 File Offset: 0x00152CD7
		[DebuggerNonUserCode]
		public void ClearProtoUrl()
		{
			this.protoUrl_ = null;
		}

		// Token: 0x06005810 RID: 22544 RVA: 0x00154AE4 File Offset: 0x00152CE4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ContentHandle);
		}

		// Token: 0x06005811 RID: 22545 RVA: 0x00154B04 File Offset: 0x00152D04
		[DebuggerNonUserCode]
		public bool Equals(ContentHandle other)
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
						bool flag5 = this.Usage != other.Usage;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Hash != other.Hash;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ProtoUrl != other.ProtoUrl;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005812 RID: 22546 RVA: 0x00154BB0 File Offset: 0x00152DB0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num ^= this.Region.GetHashCode();
			}
			bool hasUsage = this.HasUsage;
			if (hasUsage)
			{
				num ^= this.Usage.GetHashCode();
			}
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				num ^= this.Hash.GetHashCode();
			}
			bool hasProtoUrl = this.HasProtoUrl;
			if (hasProtoUrl)
			{
				num ^= this.ProtoUrl.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005813 RID: 22547 RVA: 0x00154C50 File Offset: 0x00152E50
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005814 RID: 22548 RVA: 0x00154C68 File Offset: 0x00152E68
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005815 RID: 22549 RVA: 0x00154C74 File Offset: 0x00152E74
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				output.WriteRawTag(13);
				output.WriteFixed32(this.Region);
			}
			bool hasUsage = this.HasUsage;
			if (hasUsage)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.Usage);
			}
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Hash);
			}
			bool hasProtoUrl = this.HasProtoUrl;
			if (hasProtoUrl)
			{
				output.WriteRawTag(34);
				output.WriteString(this.ProtoUrl);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005816 RID: 22550 RVA: 0x00154D28 File Offset: 0x00152F28
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num += 5;
			}
			bool hasUsage = this.HasUsage;
			if (hasUsage)
			{
				num += 5;
			}
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Hash);
			}
			bool hasProtoUrl = this.HasProtoUrl;
			if (hasProtoUrl)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ProtoUrl);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005817 RID: 22551 RVA: 0x00154DB8 File Offset: 0x00152FB8
		[DebuggerNonUserCode]
		public void MergeFrom(ContentHandle other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRegion = other.HasRegion;
				if (hasRegion)
				{
					this.Region = other.Region;
				}
				bool hasUsage = other.HasUsage;
				if (hasUsage)
				{
					this.Usage = other.Usage;
				}
				bool hasHash = other.HasHash;
				if (hasHash)
				{
					this.Hash = other.Hash;
				}
				bool hasProtoUrl = other.HasProtoUrl;
				if (hasProtoUrl)
				{
					this.ProtoUrl = other.ProtoUrl;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005818 RID: 22552 RVA: 0x00154E4E File Offset: 0x0015304E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005819 RID: 22553 RVA: 0x00154E5C File Offset: 0x0015305C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 21U)
				{
					if (num3 != 13U)
					{
						if (num3 != 21U)
						{
							goto IL_0029;
						}
						this.Usage = input.ReadFixed32();
					}
					else
					{
						this.Region = input.ReadFixed32();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						goto IL_0029;
					}
					this.ProtoUrl = input.ReadString();
				}
				else
				{
					this.Hash = input.ReadBytes();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400282B RID: 10283
		private static readonly MessageParser<ContentHandle> _parser = new MessageParser<ContentHandle>(() => new ContentHandle());

		// Token: 0x0400282C RID: 10284
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400282D RID: 10285
		private int _hasBits0;

		// Token: 0x0400282E RID: 10286
		public const int RegionFieldNumber = 1;

		// Token: 0x0400282F RID: 10287
		private static readonly uint RegionDefaultValue = 0U;

		// Token: 0x04002830 RID: 10288
		private uint region_;

		// Token: 0x04002831 RID: 10289
		public const int UsageFieldNumber = 2;

		// Token: 0x04002832 RID: 10290
		private static readonly uint UsageDefaultValue = 0U;

		// Token: 0x04002833 RID: 10291
		private uint usage_;

		// Token: 0x04002834 RID: 10292
		public const int HashFieldNumber = 3;

		// Token: 0x04002835 RID: 10293
		private static readonly ByteString HashDefaultValue = ByteString.Empty;

		// Token: 0x04002836 RID: 10294
		private ByteString hash_;

		// Token: 0x04002837 RID: 10295
		public const int ProtoUrlFieldNumber = 4;

		// Token: 0x04002838 RID: 10296
		private static readonly string ProtoUrlDefaultValue = "";

		// Token: 0x04002839 RID: 10297
		private string protoUrl_;
	}
}
