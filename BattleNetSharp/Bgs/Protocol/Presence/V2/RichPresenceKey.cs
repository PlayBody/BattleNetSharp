using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2
{
	// Token: 0x020005BA RID: 1466
	public sealed class RichPresenceKey : IMessage<RichPresenceKey>, IMessage, IEquatable<RichPresenceKey>, IDeepCloneable<RichPresenceKey>, IBufferMessage
	{
		// Token: 0x17002B9E RID: 11166
		// (get) Token: 0x06008AE1 RID: 35553 RVA: 0x0021B8F8 File Offset: 0x00219AF8
		[DebuggerNonUserCode]
		public static MessageParser<RichPresenceKey> Parser
		{
			get
			{
				return RichPresenceKey._parser;
			}
		}

		// Token: 0x17002B9F RID: 11167
		// (get) Token: 0x06008AE2 RID: 35554 RVA: 0x0021B910 File Offset: 0x00219B10
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BA0 RID: 11168
		// (get) Token: 0x06008AE3 RID: 35555 RVA: 0x0021B934 File Offset: 0x00219B34
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RichPresenceKey.Descriptor;
			}
		}

		// Token: 0x06008AE4 RID: 35556 RVA: 0x0021B94B File Offset: 0x00219B4B
		[DebuggerNonUserCode]
		public RichPresenceKey()
		{
		}

		// Token: 0x06008AE5 RID: 35557 RVA: 0x0021B958 File Offset: 0x00219B58
		[DebuggerNonUserCode]
		public RichPresenceKey(RichPresenceKey other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.titleId_ = other.titleId_;
			this.stream_ = other.stream_;
			this.localizationId_ = other.localizationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008AE6 RID: 35558 RVA: 0x0021B9B0 File Offset: 0x00219BB0
		[DebuggerNonUserCode]
		public RichPresenceKey Clone()
		{
			return new RichPresenceKey(this);
		}

		// Token: 0x17002BA1 RID: 11169
		// (get) Token: 0x06008AE7 RID: 35559 RVA: 0x0021B9C8 File Offset: 0x00219BC8
		// (set) Token: 0x06008AE8 RID: 35560 RVA: 0x0021B9F9 File Offset: 0x00219BF9
		[DebuggerNonUserCode]
		public uint TitleId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint titleIdDefaultValue;
				if (flag)
				{
					titleIdDefaultValue = this.titleId_;
				}
				else
				{
					titleIdDefaultValue = RichPresenceKey.TitleIdDefaultValue;
				}
				return titleIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.titleId_ = value;
			}
		}

		// Token: 0x17002BA2 RID: 11170
		// (get) Token: 0x06008AE9 RID: 35561 RVA: 0x0021BA14 File Offset: 0x00219C14
		[DebuggerNonUserCode]
		public bool HasTitleId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008AEA RID: 35562 RVA: 0x0021BA31 File Offset: 0x00219C31
		[DebuggerNonUserCode]
		public void ClearTitleId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002BA3 RID: 11171
		// (get) Token: 0x06008AEB RID: 35563 RVA: 0x0021BA44 File Offset: 0x00219C44
		// (set) Token: 0x06008AEC RID: 35564 RVA: 0x0021BA75 File Offset: 0x00219C75
		[DebuggerNonUserCode]
		public uint Stream
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint streamDefaultValue;
				if (flag)
				{
					streamDefaultValue = this.stream_;
				}
				else
				{
					streamDefaultValue = RichPresenceKey.StreamDefaultValue;
				}
				return streamDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.stream_ = value;
			}
		}

		// Token: 0x17002BA4 RID: 11172
		// (get) Token: 0x06008AED RID: 35565 RVA: 0x0021BA90 File Offset: 0x00219C90
		[DebuggerNonUserCode]
		public bool HasStream
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06008AEE RID: 35566 RVA: 0x0021BAAD File Offset: 0x00219CAD
		[DebuggerNonUserCode]
		public void ClearStream()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002BA5 RID: 11173
		// (get) Token: 0x06008AEF RID: 35567 RVA: 0x0021BAC0 File Offset: 0x00219CC0
		// (set) Token: 0x06008AF0 RID: 35568 RVA: 0x0021BAF1 File Offset: 0x00219CF1
		[DebuggerNonUserCode]
		public uint LocalizationId
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint localizationIdDefaultValue;
				if (flag)
				{
					localizationIdDefaultValue = this.localizationId_;
				}
				else
				{
					localizationIdDefaultValue = RichPresenceKey.LocalizationIdDefaultValue;
				}
				return localizationIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.localizationId_ = value;
			}
		}

		// Token: 0x17002BA6 RID: 11174
		// (get) Token: 0x06008AF1 RID: 35569 RVA: 0x0021BB0C File Offset: 0x00219D0C
		[DebuggerNonUserCode]
		public bool HasLocalizationId
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06008AF2 RID: 35570 RVA: 0x0021BB29 File Offset: 0x00219D29
		[DebuggerNonUserCode]
		public void ClearLocalizationId()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06008AF3 RID: 35571 RVA: 0x0021BB3C File Offset: 0x00219D3C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RichPresenceKey);
		}

		// Token: 0x06008AF4 RID: 35572 RVA: 0x0021BB5C File Offset: 0x00219D5C
		[DebuggerNonUserCode]
		public bool Equals(RichPresenceKey other)
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
					bool flag4 = this.TitleId != other.TitleId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Stream != other.Stream;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.LocalizationId != other.LocalizationId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008AF5 RID: 35573 RVA: 0x0021BBE8 File Offset: 0x00219DE8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				num ^= this.TitleId.GetHashCode();
			}
			bool hasStream = this.HasStream;
			if (hasStream)
			{
				num ^= this.Stream.GetHashCode();
			}
			bool hasLocalizationId = this.HasLocalizationId;
			if (hasLocalizationId)
			{
				num ^= this.LocalizationId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008AF6 RID: 35574 RVA: 0x0021BC74 File Offset: 0x00219E74
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008AF7 RID: 35575 RVA: 0x0021BC8C File Offset: 0x00219E8C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008AF8 RID: 35576 RVA: 0x0021BC98 File Offset: 0x00219E98
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.TitleId);
			}
			bool hasStream = this.HasStream;
			if (hasStream)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.Stream);
			}
			bool hasLocalizationId = this.HasLocalizationId;
			if (hasLocalizationId)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.LocalizationId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008AF9 RID: 35577 RVA: 0x0021BD28 File Offset: 0x00219F28
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TitleId);
			}
			bool hasStream = this.HasStream;
			if (hasStream)
			{
				num += 5;
			}
			bool hasLocalizationId = this.HasLocalizationId;
			if (hasLocalizationId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LocalizationId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008AFA RID: 35578 RVA: 0x0021BDA8 File Offset: 0x00219FA8
		[DebuggerNonUserCode]
		public void MergeFrom(RichPresenceKey other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTitleId = other.HasTitleId;
				if (hasTitleId)
				{
					this.TitleId = other.TitleId;
				}
				bool hasStream = other.HasStream;
				if (hasStream)
				{
					this.Stream = other.Stream;
				}
				bool hasLocalizationId = other.HasLocalizationId;
				if (hasLocalizationId)
				{
					this.LocalizationId = other.LocalizationId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008AFB RID: 35579 RVA: 0x0021BE23 File Offset: 0x0021A023
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008AFC RID: 35580 RVA: 0x0021BE30 File Offset: 0x0021A030
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
					if (num3 != 21U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LocalizationId = input.ReadUInt32();
						}
					}
					else
					{
						this.Stream = input.ReadFixed32();
					}
				}
				else
				{
					this.TitleId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003EE2 RID: 16098
		private static readonly MessageParser<RichPresenceKey> _parser = new MessageParser<RichPresenceKey>(() => new RichPresenceKey());

		// Token: 0x04003EE3 RID: 16099
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EE4 RID: 16100
		private int _hasBits0;

		// Token: 0x04003EE5 RID: 16101
		public const int TitleIdFieldNumber = 1;

		// Token: 0x04003EE6 RID: 16102
		private static readonly uint TitleIdDefaultValue = 0U;

		// Token: 0x04003EE7 RID: 16103
		private uint titleId_;

		// Token: 0x04003EE8 RID: 16104
		public const int StreamFieldNumber = 2;

		// Token: 0x04003EE9 RID: 16105
		private static readonly uint StreamDefaultValue = 0U;

		// Token: 0x04003EEA RID: 16106
		private uint stream_;

		// Token: 0x04003EEB RID: 16107
		public const int LocalizationIdFieldNumber = 3;

		// Token: 0x04003EEC RID: 16108
		private static readonly uint LocalizationIdDefaultValue = 0U;

		// Token: 0x04003EED RID: 16109
		private uint localizationId_;
	}
}
