using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.AccountMigration
{
	// Token: 0x020002CF RID: 719
	public sealed class MigrationData : IMessage<MigrationData>, IMessage, IEquatable<MigrationData>, IDeepCloneable<MigrationData>, IBufferMessage
	{
		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x06004C39 RID: 19513 RVA: 0x00123818 File Offset: 0x00121A18
		[DebuggerNonUserCode]
		public static MessageParser<MigrationData> Parser
		{
			get
			{
				return MigrationData._parser;
			}
		}

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x06004C3A RID: 19514 RVA: 0x00123830 File Offset: 0x00121A30
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountMigrationReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x06004C3B RID: 19515 RVA: 0x00123854 File Offset: 0x00121A54
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MigrationData.Descriptor;
			}
		}

		// Token: 0x06004C3C RID: 19516 RVA: 0x0012386B File Offset: 0x00121A6B
		[DebuggerNonUserCode]
		public MigrationData()
		{
		}

		// Token: 0x06004C3D RID: 19517 RVA: 0x0012387C File Offset: 0x00121A7C
		[DebuggerNonUserCode]
		public MigrationData(MigrationData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.version_ = other.version_;
			MigrationData.MessageOneofCase messageCase = other.MessageCase;
			MigrationData.MessageOneofCase messageOneofCase = messageCase;
			if (messageOneofCase == MigrationData.MessageOneofCase.WriteDataV2)
			{
				this.WriteDataV2 = other.WriteDataV2.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C3E RID: 19518 RVA: 0x001238E0 File Offset: 0x00121AE0
		[DebuggerNonUserCode]
		public MigrationData Clone()
		{
			return new MigrationData(this);
		}

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x06004C3F RID: 19519 RVA: 0x001238F8 File Offset: 0x00121AF8
		// (set) Token: 0x06004C40 RID: 19520 RVA: 0x00123929 File Offset: 0x00121B29
		[DebuggerNonUserCode]
		public uint Version
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint versionDefaultValue;
				if (flag)
				{
					versionDefaultValue = this.version_;
				}
				else
				{
					versionDefaultValue = MigrationData.VersionDefaultValue;
				}
				return versionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.version_ = value;
			}
		}

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x06004C41 RID: 19521 RVA: 0x00123944 File Offset: 0x00121B44
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004C42 RID: 19522 RVA: 0x00123961 File Offset: 0x00121B61
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x06004C43 RID: 19523 RVA: 0x00123974 File Offset: 0x00121B74
		// (set) Token: 0x06004C44 RID: 19524 RVA: 0x0012399D File Offset: 0x00121B9D
		[DebuggerNonUserCode]
		public WriteDataV2 WriteDataV2
		{
			get
			{
				return (this.messageCase_ == MigrationData.MessageOneofCase.WriteDataV2) ? ((WriteDataV2)this.message_) : null;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? MigrationData.MessageOneofCase.None : MigrationData.MessageOneofCase.WriteDataV2);
			}
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x06004C45 RID: 19525 RVA: 0x001239B4 File Offset: 0x00121BB4
		[DebuggerNonUserCode]
		public MigrationData.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x06004C46 RID: 19526 RVA: 0x001239CC File Offset: 0x00121BCC
		[DebuggerNonUserCode]
		public void ClearMessage()
		{
			this.messageCase_ = MigrationData.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x06004C47 RID: 19527 RVA: 0x001239E0 File Offset: 0x00121BE0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MigrationData);
		}

		// Token: 0x06004C48 RID: 19528 RVA: 0x00123A00 File Offset: 0x00121C00
		[DebuggerNonUserCode]
		public bool Equals(MigrationData other)
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
					bool flag4 = this.Version != other.Version;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.WriteDataV2, other.WriteDataV2);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.MessageCase != other.MessageCase;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004C49 RID: 19529 RVA: 0x00123A90 File Offset: 0x00121C90
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool flag = this.messageCase_ == MigrationData.MessageOneofCase.WriteDataV2;
			if (flag)
			{
				num ^= this.WriteDataV2.GetHashCode();
			}
			num ^= (int)this.messageCase_;
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004C4A RID: 19530 RVA: 0x00123B08 File Offset: 0x00121D08
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004C4B RID: 19531 RVA: 0x00123B20 File Offset: 0x00121D20
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x00123B2C File Offset: 0x00121D2C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Version);
			}
			bool flag = this.messageCase_ == MigrationData.MessageOneofCase.WriteDataV2;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.WriteDataV2);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C4D RID: 19533 RVA: 0x00123B9C File Offset: 0x00121D9C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Version);
			}
			bool flag = this.messageCase_ == MigrationData.MessageOneofCase.WriteDataV2;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WriteDataV2);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004C4E RID: 19534 RVA: 0x00123C0C File Offset: 0x00121E0C
		[DebuggerNonUserCode]
		public void MergeFrom(MigrationData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				MigrationData.MessageOneofCase messageCase = other.MessageCase;
				MigrationData.MessageOneofCase messageOneofCase = messageCase;
				if (messageOneofCase == MigrationData.MessageOneofCase.WriteDataV2)
				{
					bool flag2 = this.WriteDataV2 == null;
					if (flag2)
					{
						this.WriteDataV2 = new WriteDataV2();
					}
					this.WriteDataV2.MergeFrom(other.WriteDataV2);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004C4F RID: 19535 RVA: 0x00123C95 File Offset: 0x00121E95
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C50 RID: 19536 RVA: 0x00123CA0 File Offset: 0x00121EA0
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						WriteDataV2 writeDataV = new WriteDataV2();
						bool flag = this.messageCase_ == MigrationData.MessageOneofCase.WriteDataV2;
						if (flag)
						{
							writeDataV.MergeFrom(this.WriteDataV2);
						}
						input.ReadMessage(writeDataV);
						this.WriteDataV2 = writeDataV;
					}
				}
				else
				{
					this.Version = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040021FE RID: 8702
		private static readonly MessageParser<MigrationData> _parser = new MessageParser<MigrationData>(() => new MigrationData());

		// Token: 0x040021FF RID: 8703
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002200 RID: 8704
		private int _hasBits0;

		// Token: 0x04002201 RID: 8705
		public const int VersionFieldNumber = 1;

		// Token: 0x04002202 RID: 8706
		private static readonly uint VersionDefaultValue = 0U;

		// Token: 0x04002203 RID: 8707
		private uint version_;

		// Token: 0x04002204 RID: 8708
		public const int WriteDataV2FieldNumber = 2;

		// Token: 0x04002205 RID: 8709
		private object message_;

		// Token: 0x04002206 RID: 8710
		private MigrationData.MessageOneofCase messageCase_ = MigrationData.MessageOneofCase.None;

		// Token: 0x02000DE2 RID: 3554
		public enum MessageOneofCase
		{
			// Token: 0x0400954C RID: 38220
			None,
			// Token: 0x0400954D RID: 38221
			WriteDataV2 = 2
		}
	}
}
