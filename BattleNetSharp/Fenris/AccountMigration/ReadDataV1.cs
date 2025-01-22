using System;
using System.Diagnostics;
using Fenris.Account;
using Fenris.Profile;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.AccountMigration
{
	// Token: 0x020002CD RID: 717
	public sealed class ReadDataV1 : IMessage<ReadDataV1>, IMessage, IEquatable<ReadDataV1>, IDeepCloneable<ReadDataV1>, IBufferMessage
	{
		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x06004C0B RID: 19467 RVA: 0x00122D78 File Offset: 0x00120F78
		[DebuggerNonUserCode]
		public static MessageParser<ReadDataV1> Parser
		{
			get
			{
				return ReadDataV1._parser;
			}
		}

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x06004C0C RID: 19468 RVA: 0x00122D90 File Offset: 0x00120F90
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountMigrationReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x06004C0D RID: 19469 RVA: 0x00122DB4 File Offset: 0x00120FB4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReadDataV1.Descriptor;
			}
		}

		// Token: 0x06004C0E RID: 19470 RVA: 0x00122DCB File Offset: 0x00120FCB
		[DebuggerNonUserCode]
		public ReadDataV1()
		{
		}

		// Token: 0x06004C0F RID: 19471 RVA: 0x00122DD8 File Offset: 0x00120FD8
		[DebuggerNonUserCode]
		public ReadDataV1(ReadDataV1 other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.version_ = other.version_;
			this.readSavedDefinition_ = ((other.readSavedDefinition_ != null) ? other.readSavedDefinition_.Clone() : null);
			this.readAccountProfile_ = ((other.readAccountProfile_ != null) ? other.readAccountProfile_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x00122E50 File Offset: 0x00121050
		[DebuggerNonUserCode]
		public ReadDataV1 Clone()
		{
			return new ReadDataV1(this);
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x06004C11 RID: 19473 RVA: 0x00122E68 File Offset: 0x00121068
		// (set) Token: 0x06004C12 RID: 19474 RVA: 0x00122E99 File Offset: 0x00121099
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
					versionDefaultValue = ReadDataV1.VersionDefaultValue;
				}
				return versionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.version_ = value;
			}
		}

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x06004C13 RID: 19475 RVA: 0x00122EB4 File Offset: 0x001210B4
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004C14 RID: 19476 RVA: 0x00122ED1 File Offset: 0x001210D1
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x06004C15 RID: 19477 RVA: 0x00122EE4 File Offset: 0x001210E4
		// (set) Token: 0x06004C16 RID: 19478 RVA: 0x00122EFC File Offset: 0x001210FC
		[DebuggerNonUserCode]
		public SavedDefinition ReadSavedDefinition
		{
			get
			{
				return this.readSavedDefinition_;
			}
			set
			{
				this.readSavedDefinition_ = value;
			}
		}

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x06004C17 RID: 19479 RVA: 0x00122F08 File Offset: 0x00121108
		// (set) Token: 0x06004C18 RID: 19480 RVA: 0x00122F20 File Offset: 0x00121120
		[DebuggerNonUserCode]
		public AccountProfile ReadAccountProfile
		{
			get
			{
				return this.readAccountProfile_;
			}
			set
			{
				this.readAccountProfile_ = value;
			}
		}

		// Token: 0x06004C19 RID: 19481 RVA: 0x00122F2C File Offset: 0x0012112C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReadDataV1);
		}

		// Token: 0x06004C1A RID: 19482 RVA: 0x00122F4C File Offset: 0x0012114C
		[DebuggerNonUserCode]
		public bool Equals(ReadDataV1 other)
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
						bool flag5 = !object.Equals(this.ReadSavedDefinition, other.ReadSavedDefinition);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.ReadAccountProfile, other.ReadAccountProfile);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004C1B RID: 19483 RVA: 0x00122FE0 File Offset: 0x001211E0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool flag = this.readSavedDefinition_ != null;
			if (flag)
			{
				num ^= this.ReadSavedDefinition.GetHashCode();
			}
			bool flag2 = this.readAccountProfile_ != null;
			if (flag2)
			{
				num ^= this.ReadAccountProfile.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x0012306C File Offset: 0x0012126C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004C1D RID: 19485 RVA: 0x00123084 File Offset: 0x00121284
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C1E RID: 19486 RVA: 0x00123090 File Offset: 0x00121290
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Version);
			}
			bool flag = this.readSavedDefinition_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ReadSavedDefinition);
			}
			bool flag2 = this.readAccountProfile_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ReadAccountProfile);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C1F RID: 19487 RVA: 0x00123128 File Offset: 0x00121328
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Version);
			}
			bool flag = this.readSavedDefinition_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReadSavedDefinition);
			}
			bool flag2 = this.readAccountProfile_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReadAccountProfile);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004C20 RID: 19488 RVA: 0x001231B8 File Offset: 0x001213B8
		[DebuggerNonUserCode]
		public void MergeFrom(ReadDataV1 other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				bool flag2 = other.readSavedDefinition_ != null;
				if (flag2)
				{
					bool flag3 = this.readSavedDefinition_ == null;
					if (flag3)
					{
						this.ReadSavedDefinition = new SavedDefinition();
					}
					this.ReadSavedDefinition.MergeFrom(other.ReadSavedDefinition);
				}
				bool flag4 = other.readAccountProfile_ != null;
				if (flag4)
				{
					bool flag5 = this.readAccountProfile_ == null;
					if (flag5)
					{
						this.ReadAccountProfile = new AccountProfile();
					}
					this.ReadAccountProfile.MergeFrom(other.ReadAccountProfile);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004C21 RID: 19489 RVA: 0x00123280 File Offset: 0x00121480
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C22 RID: 19490 RVA: 0x0012328C File Offset: 0x0012148C
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.readAccountProfile_ == null;
							if (flag)
							{
								this.ReadAccountProfile = new AccountProfile();
							}
							input.ReadMessage(this.ReadAccountProfile);
						}
					}
					else
					{
						bool flag2 = this.readSavedDefinition_ == null;
						if (flag2)
						{
							this.ReadSavedDefinition = new SavedDefinition();
						}
						input.ReadMessage(this.ReadSavedDefinition);
					}
				}
				else
				{
					this.Version = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040021EE RID: 8686
		private static readonly MessageParser<ReadDataV1> _parser = new MessageParser<ReadDataV1>(() => new ReadDataV1());

		// Token: 0x040021EF RID: 8687
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021F0 RID: 8688
		private int _hasBits0;

		// Token: 0x040021F1 RID: 8689
		public const int VersionFieldNumber = 1;

		// Token: 0x040021F2 RID: 8690
		private static readonly uint VersionDefaultValue = 0U;

		// Token: 0x040021F3 RID: 8691
		private uint version_;

		// Token: 0x040021F4 RID: 8692
		public const int ReadSavedDefinitionFieldNumber = 2;

		// Token: 0x040021F5 RID: 8693
		private SavedDefinition readSavedDefinition_;

		// Token: 0x040021F6 RID: 8694
		public const int ReadAccountProfileFieldNumber = 3;

		// Token: 0x040021F7 RID: 8695
		private AccountProfile readAccountProfile_;
	}
}
