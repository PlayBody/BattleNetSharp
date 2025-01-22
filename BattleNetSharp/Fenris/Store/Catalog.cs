using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Store
{
	// Token: 0x02000112 RID: 274
	public sealed class Catalog : IMessage<Catalog>, IMessage, IEquatable<Catalog>, IDeepCloneable<Catalog>, IBufferMessage
	{
		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x0005CD00 File Offset: 0x0005AF00
		[DebuggerNonUserCode]
		public static MessageParser<Catalog> Parser
		{
			get
			{
				return Catalog._parser;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x0005CD18 File Offset: 0x0005AF18
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StoreReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001A0A RID: 6666 RVA: 0x0005CD3C File Offset: 0x0005AF3C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Catalog.Descriptor;
			}
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x0005CD53 File Offset: 0x0005AF53
		[DebuggerNonUserCode]
		public Catalog()
		{
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x0005CD68 File Offset: 0x0005AF68
		[DebuggerNonUserCode]
		public Catalog(Catalog other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.protoVersion_ = other.protoVersion_;
			this.licenses_ = other.licenses_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x0005CDB8 File Offset: 0x0005AFB8
		[DebuggerNonUserCode]
		public Catalog Clone()
		{
			return new Catalog(this);
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001A0E RID: 6670 RVA: 0x0005CDD0 File Offset: 0x0005AFD0
		// (set) Token: 0x06001A0F RID: 6671 RVA: 0x0005CE01 File Offset: 0x0005B001
		[DebuggerNonUserCode]
		public uint ProtoVersion
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint protoVersionDefaultValue;
				if (flag)
				{
					protoVersionDefaultValue = this.protoVersion_;
				}
				else
				{
					protoVersionDefaultValue = Catalog.ProtoVersionDefaultValue;
				}
				return protoVersionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.protoVersion_ = value;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x0005CE1C File Offset: 0x0005B01C
		[DebuggerNonUserCode]
		public bool HasProtoVersion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x0005CE39 File Offset: 0x0005B039
		[DebuggerNonUserCode]
		public void ClearProtoVersion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001A12 RID: 6674 RVA: 0x0005CE4C File Offset: 0x0005B04C
		[DebuggerNonUserCode]
		public RepeatedField<License> Licenses
		{
			get
			{
				return this.licenses_;
			}
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0005CE64 File Offset: 0x0005B064
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Catalog);
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0005CE84 File Offset: 0x0005B084
		[DebuggerNonUserCode]
		public bool Equals(Catalog other)
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
					bool flag4 = this.ProtoVersion != other.ProtoVersion;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.licenses_.Equals(other.licenses_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x0005CEF8 File Offset: 0x0005B0F8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasProtoVersion = this.HasProtoVersion;
			if (hasProtoVersion)
			{
				num ^= this.ProtoVersion.GetHashCode();
			}
			num ^= this.licenses_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x0005CF58 File Offset: 0x0005B158
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x0005CF70 File Offset: 0x0005B170
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x0005CF7C File Offset: 0x0005B17C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasProtoVersion = this.HasProtoVersion;
			if (hasProtoVersion)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ProtoVersion);
			}
			this.licenses_.WriteTo(ref output, Catalog._repeated_licenses_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x0005CFDC File Offset: 0x0005B1DC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasProtoVersion = this.HasProtoVersion;
			if (hasProtoVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ProtoVersion);
			}
			num += this.licenses_.CalculateSize(Catalog._repeated_licenses_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x0005D040 File Offset: 0x0005B240
		[DebuggerNonUserCode]
		public void MergeFrom(Catalog other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasProtoVersion = other.HasProtoVersion;
				if (hasProtoVersion)
				{
					this.ProtoVersion = other.ProtoVersion;
				}
				this.licenses_.Add(other.licenses_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x0005D09B File Offset: 0x0005B29B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x0005D0A8 File Offset: 0x0005B2A8
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
					if (num3 != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.licenses_.AddEntriesFrom(ref input, Catalog._repeated_licenses_codec);
					}
				}
				else
				{
					this.ProtoVersion = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000A67 RID: 2663
		private static readonly MessageParser<Catalog> _parser = new MessageParser<Catalog>(() => new Catalog());

		// Token: 0x04000A68 RID: 2664
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A69 RID: 2665
		private int _hasBits0;

		// Token: 0x04000A6A RID: 2666
		public const int ProtoVersionFieldNumber = 1;

		// Token: 0x04000A6B RID: 2667
		private static readonly uint ProtoVersionDefaultValue = 0U;

		// Token: 0x04000A6C RID: 2668
		private uint protoVersion_;

		// Token: 0x04000A6D RID: 2669
		public const int LicensesFieldNumber = 3;

		// Token: 0x04000A6E RID: 2670
		private static readonly FieldCodec<License> _repeated_licenses_codec = FieldCodec.ForMessage<License>(26U, License.Parser);

		// Token: 0x04000A6F RID: 2671
		private readonly RepeatedField<License> licenses_ = new RepeatedField<License>();
	}
}
