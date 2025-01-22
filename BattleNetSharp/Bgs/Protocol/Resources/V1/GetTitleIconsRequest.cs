using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Resources.V1
{
	// Token: 0x020003DB RID: 987
	public sealed class GetTitleIconsRequest : IMessage<GetTitleIconsRequest>, IMessage, IEquatable<GetTitleIconsRequest>, IDeepCloneable<GetTitleIconsRequest>, IBufferMessage
	{
		// Token: 0x17001FCB RID: 8139
		// (get) Token: 0x0600629C RID: 25244 RVA: 0x0017DAAC File Offset: 0x0017BCAC
		[DebuggerNonUserCode]
		public static MessageParser<GetTitleIconsRequest> Parser
		{
			get
			{
				return GetTitleIconsRequest._parser;
			}
		}

		// Token: 0x17001FCC RID: 8140
		// (get) Token: 0x0600629D RID: 25245 RVA: 0x0017DAC4 File Offset: 0x0017BCC4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ResourceServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001FCD RID: 8141
		// (get) Token: 0x0600629E RID: 25246 RVA: 0x0017DAE8 File Offset: 0x0017BCE8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTitleIconsRequest.Descriptor;
			}
		}

		// Token: 0x0600629F RID: 25247 RVA: 0x0017DAFF File Offset: 0x0017BCFF
		[DebuggerNonUserCode]
		public GetTitleIconsRequest()
		{
		}

		// Token: 0x060062A0 RID: 25248 RVA: 0x0017DB14 File Offset: 0x0017BD14
		[DebuggerNonUserCode]
		public GetTitleIconsRequest(GetTitleIconsRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.titleIds_ = other.titleIds_.Clone();
			this.usage_ = other.usage_;
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060062A1 RID: 25249 RVA: 0x0017DB70 File Offset: 0x0017BD70
		[DebuggerNonUserCode]
		public GetTitleIconsRequest Clone()
		{
			return new GetTitleIconsRequest(this);
		}

		// Token: 0x17001FCE RID: 8142
		// (get) Token: 0x060062A2 RID: 25250 RVA: 0x0017DB88 File Offset: 0x0017BD88
		[DebuggerNonUserCode]
		public RepeatedField<uint> TitleIds
		{
			get
			{
				return this.titleIds_;
			}
		}

		// Token: 0x17001FCF RID: 8143
		// (get) Token: 0x060062A3 RID: 25251 RVA: 0x0017DBA0 File Offset: 0x0017BDA0
		// (set) Token: 0x060062A4 RID: 25252 RVA: 0x0017DBD1 File Offset: 0x0017BDD1
		[DebuggerNonUserCode]
		public uint Usage
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint usageDefaultValue;
				if (flag)
				{
					usageDefaultValue = this.usage_;
				}
				else
				{
					usageDefaultValue = GetTitleIconsRequest.UsageDefaultValue;
				}
				return usageDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.usage_ = value;
			}
		}

		// Token: 0x17001FD0 RID: 8144
		// (get) Token: 0x060062A5 RID: 25253 RVA: 0x0017DBEC File Offset: 0x0017BDEC
		[DebuggerNonUserCode]
		public bool HasUsage
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060062A6 RID: 25254 RVA: 0x0017DC09 File Offset: 0x0017BE09
		[DebuggerNonUserCode]
		public void ClearUsage()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001FD1 RID: 8145
		// (get) Token: 0x060062A7 RID: 25255 RVA: 0x0017DC1C File Offset: 0x0017BE1C
		// (set) Token: 0x060062A8 RID: 25256 RVA: 0x0017DC4D File Offset: 0x0017BE4D
		[DebuggerNonUserCode]
		public uint Version
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint versionDefaultValue;
				if (flag)
				{
					versionDefaultValue = this.version_;
				}
				else
				{
					versionDefaultValue = GetTitleIconsRequest.VersionDefaultValue;
				}
				return versionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.version_ = value;
			}
		}

		// Token: 0x17001FD2 RID: 8146
		// (get) Token: 0x060062A9 RID: 25257 RVA: 0x0017DC68 File Offset: 0x0017BE68
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060062AA RID: 25258 RVA: 0x0017DC85 File Offset: 0x0017BE85
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060062AB RID: 25259 RVA: 0x0017DC98 File Offset: 0x0017BE98
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTitleIconsRequest);
		}

		// Token: 0x060062AC RID: 25260 RVA: 0x0017DCB8 File Offset: 0x0017BEB8
		[DebuggerNonUserCode]
		public bool Equals(GetTitleIconsRequest other)
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
					bool flag4 = !this.titleIds_.Equals(other.titleIds_);
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
							bool flag6 = this.Version != other.Version;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060062AD RID: 25261 RVA: 0x0017DD48 File Offset: 0x0017BF48
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.titleIds_.GetHashCode();
			bool hasUsage = this.HasUsage;
			if (hasUsage)
			{
				num ^= this.Usage.GetHashCode();
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060062AE RID: 25262 RVA: 0x0017DDC4 File Offset: 0x0017BFC4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060062AF RID: 25263 RVA: 0x0017DDDC File Offset: 0x0017BFDC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060062B0 RID: 25264 RVA: 0x0017DDE8 File Offset: 0x0017BFE8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.titleIds_.WriteTo(ref output, GetTitleIconsRequest._repeated_titleIds_codec);
			bool hasUsage = this.HasUsage;
			if (hasUsage)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Usage);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Version);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060062B1 RID: 25265 RVA: 0x0017DE68 File Offset: 0x0017C068
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.titleIds_.CalculateSize(GetTitleIconsRequest._repeated_titleIds_codec);
			bool hasUsage = this.HasUsage;
			if (hasUsage)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Usage);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Version);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060062B2 RID: 25266 RVA: 0x0017DEE8 File Offset: 0x0017C0E8
		[DebuggerNonUserCode]
		public void MergeFrom(GetTitleIconsRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.titleIds_.Add(other.titleIds_);
				bool hasUsage = other.HasUsage;
				if (hasUsage)
				{
					this.Usage = other.Usage;
				}
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060062B3 RID: 25267 RVA: 0x0017DF5C File Offset: 0x0017C15C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060062B4 RID: 25268 RVA: 0x0017DF68 File Offset: 0x0017C168
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 10U)
				{
					if (num3 != 8U && num3 != 10U)
					{
						goto IL_0028;
					}
					this.titleIds_.AddEntriesFrom(ref input, GetTitleIconsRequest._repeated_titleIds_codec);
				}
				else if (num3 != 16U)
				{
					if (num3 != 24U)
					{
						goto IL_0028;
					}
					this.Version = input.ReadUInt32();
				}
				else
				{
					this.Usage = input.ReadUInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002D0D RID: 11533
		private static readonly MessageParser<GetTitleIconsRequest> _parser = new MessageParser<GetTitleIconsRequest>(() => new GetTitleIconsRequest());

		// Token: 0x04002D0E RID: 11534
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D0F RID: 11535
		private int _hasBits0;

		// Token: 0x04002D10 RID: 11536
		public const int TitleIdsFieldNumber = 1;

		// Token: 0x04002D11 RID: 11537
		private static readonly FieldCodec<uint> _repeated_titleIds_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04002D12 RID: 11538
		private readonly RepeatedField<uint> titleIds_ = new RepeatedField<uint>();

		// Token: 0x04002D13 RID: 11539
		public const int UsageFieldNumber = 2;

		// Token: 0x04002D14 RID: 11540
		private static readonly uint UsageDefaultValue = 0U;

		// Token: 0x04002D15 RID: 11541
		private uint usage_;

		// Token: 0x04002D16 RID: 11542
		public const int VersionFieldNumber = 3;

		// Token: 0x04002D17 RID: 11543
		private static readonly uint VersionDefaultValue = 0U;

		// Token: 0x04002D18 RID: 11544
		private uint version_;
	}
}
