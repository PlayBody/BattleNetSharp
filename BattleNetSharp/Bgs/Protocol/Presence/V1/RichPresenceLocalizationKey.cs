using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x020005AC RID: 1452
	public sealed class RichPresenceLocalizationKey : IMessage<RichPresenceLocalizationKey>, IMessage, IEquatable<RichPresenceLocalizationKey>, IDeepCloneable<RichPresenceLocalizationKey>, IBufferMessage
	{
		// Token: 0x17002B5F RID: 11103
		// (get) Token: 0x06008A00 RID: 35328 RVA: 0x00218608 File Offset: 0x00216808
		[DebuggerNonUserCode]
		public static MessageParser<RichPresenceLocalizationKey> Parser
		{
			get
			{
				return RichPresenceLocalizationKey._parser;
			}
		}

		// Token: 0x17002B60 RID: 11104
		// (get) Token: 0x06008A01 RID: 35329 RVA: 0x00218620 File Offset: 0x00216820
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B61 RID: 11105
		// (get) Token: 0x06008A02 RID: 35330 RVA: 0x00218644 File Offset: 0x00216844
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RichPresenceLocalizationKey.Descriptor;
			}
		}

		// Token: 0x06008A03 RID: 35331 RVA: 0x0021865B File Offset: 0x0021685B
		[DebuggerNonUserCode]
		public RichPresenceLocalizationKey()
		{
		}

		// Token: 0x06008A04 RID: 35332 RVA: 0x00218668 File Offset: 0x00216868
		[DebuggerNonUserCode]
		public RichPresenceLocalizationKey(RichPresenceLocalizationKey other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.program_ = other.program_;
			this.stream_ = other.stream_;
			this.localizationId_ = other.localizationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A05 RID: 35333 RVA: 0x002186C0 File Offset: 0x002168C0
		[DebuggerNonUserCode]
		public RichPresenceLocalizationKey Clone()
		{
			return new RichPresenceLocalizationKey(this);
		}

		// Token: 0x17002B62 RID: 11106
		// (get) Token: 0x06008A06 RID: 35334 RVA: 0x002186D8 File Offset: 0x002168D8
		// (set) Token: 0x06008A07 RID: 35335 RVA: 0x00218709 File Offset: 0x00216909
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = RichPresenceLocalizationKey.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x17002B63 RID: 11107
		// (get) Token: 0x06008A08 RID: 35336 RVA: 0x00218724 File Offset: 0x00216924
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008A09 RID: 35337 RVA: 0x00218741 File Offset: 0x00216941
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002B64 RID: 11108
		// (get) Token: 0x06008A0A RID: 35338 RVA: 0x00218754 File Offset: 0x00216954
		// (set) Token: 0x06008A0B RID: 35339 RVA: 0x00218785 File Offset: 0x00216985
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
					streamDefaultValue = RichPresenceLocalizationKey.StreamDefaultValue;
				}
				return streamDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.stream_ = value;
			}
		}

		// Token: 0x17002B65 RID: 11109
		// (get) Token: 0x06008A0C RID: 35340 RVA: 0x002187A0 File Offset: 0x002169A0
		[DebuggerNonUserCode]
		public bool HasStream
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06008A0D RID: 35341 RVA: 0x002187BD File Offset: 0x002169BD
		[DebuggerNonUserCode]
		public void ClearStream()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002B66 RID: 11110
		// (get) Token: 0x06008A0E RID: 35342 RVA: 0x002187D0 File Offset: 0x002169D0
		// (set) Token: 0x06008A0F RID: 35343 RVA: 0x00218801 File Offset: 0x00216A01
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
					localizationIdDefaultValue = RichPresenceLocalizationKey.LocalizationIdDefaultValue;
				}
				return localizationIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.localizationId_ = value;
			}
		}

		// Token: 0x17002B67 RID: 11111
		// (get) Token: 0x06008A10 RID: 35344 RVA: 0x0021881C File Offset: 0x00216A1C
		[DebuggerNonUserCode]
		public bool HasLocalizationId
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06008A11 RID: 35345 RVA: 0x00218839 File Offset: 0x00216A39
		[DebuggerNonUserCode]
		public void ClearLocalizationId()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06008A12 RID: 35346 RVA: 0x0021884C File Offset: 0x00216A4C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RichPresenceLocalizationKey);
		}

		// Token: 0x06008A13 RID: 35347 RVA: 0x0021886C File Offset: 0x00216A6C
		[DebuggerNonUserCode]
		public bool Equals(RichPresenceLocalizationKey other)
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
					bool flag4 = this.Program != other.Program;
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

		// Token: 0x06008A14 RID: 35348 RVA: 0x002188F8 File Offset: 0x00216AF8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
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

		// Token: 0x06008A15 RID: 35349 RVA: 0x00218984 File Offset: 0x00216B84
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008A16 RID: 35350 RVA: 0x0021899C File Offset: 0x00216B9C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A17 RID: 35351 RVA: 0x002189A8 File Offset: 0x00216BA8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(13);
				output.WriteFixed32(this.Program);
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

		// Token: 0x06008A18 RID: 35352 RVA: 0x00218A38 File Offset: 0x00216C38
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
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

		// Token: 0x06008A19 RID: 35353 RVA: 0x00218AAC File Offset: 0x00216CAC
		[DebuggerNonUserCode]
		public void MergeFrom(RichPresenceLocalizationKey other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
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

		// Token: 0x06008A1A RID: 35354 RVA: 0x00218B27 File Offset: 0x00216D27
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A1B RID: 35355 RVA: 0x00218B34 File Offset: 0x00216D34
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
					this.Program = input.ReadFixed32();
				}
			}
		}

		// Token: 0x04003E7F RID: 15999
		private static readonly MessageParser<RichPresenceLocalizationKey> _parser = new MessageParser<RichPresenceLocalizationKey>(() => new RichPresenceLocalizationKey());

		// Token: 0x04003E80 RID: 16000
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E81 RID: 16001
		private int _hasBits0;

		// Token: 0x04003E82 RID: 16002
		public const int ProgramFieldNumber = 1;

		// Token: 0x04003E83 RID: 16003
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04003E84 RID: 16004
		private uint program_;

		// Token: 0x04003E85 RID: 16005
		public const int StreamFieldNumber = 2;

		// Token: 0x04003E86 RID: 16006
		private static readonly uint StreamDefaultValue = 0U;

		// Token: 0x04003E87 RID: 16007
		private uint stream_;

		// Token: 0x04003E88 RID: 16008
		public const int LocalizationIdFieldNumber = 3;

		// Token: 0x04003E89 RID: 16009
		private static readonly uint LocalizationIdDefaultValue = 0U;

		// Token: 0x04003E8A RID: 16010
		private uint localizationId_;
	}
}
