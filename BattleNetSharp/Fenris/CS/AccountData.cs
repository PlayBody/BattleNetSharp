using System;
using System.Diagnostics;
using Fenris.Account;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.CS
{
	// Token: 0x02000209 RID: 521
	public sealed class AccountData : IMessage<AccountData>, IMessage, IEquatable<AccountData>, IDeepCloneable<AccountData>, IBufferMessage
	{
		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x06003910 RID: 14608 RVA: 0x000E1A80 File Offset: 0x000DFC80
		[DebuggerNonUserCode]
		public static MessageParser<AccountData> Parser
		{
			get
			{
				return AccountData._parser;
			}
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x06003911 RID: 14609 RVA: 0x000E1A98 File Offset: 0x000DFC98
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CSReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x06003912 RID: 14610 RVA: 0x000E1ABC File Offset: 0x000DFCBC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountData.Descriptor;
			}
		}

		// Token: 0x06003913 RID: 14611 RVA: 0x000E1AD3 File Offset: 0x000DFCD3
		[DebuggerNonUserCode]
		public AccountData()
		{
		}

		// Token: 0x06003914 RID: 14612 RVA: 0x000E1AE8 File Offset: 0x000DFCE8
		[DebuggerNonUserCode]
		public AccountData(AccountData other)
			: this()
		{
			this.digest_ = ((other.digest_ != null) ? other.digest_.Clone() : null);
			this.partitions_ = other.partitions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x000E1B3C File Offset: 0x000DFD3C
		[DebuggerNonUserCode]
		public AccountData Clone()
		{
			return new AccountData(this);
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06003916 RID: 14614 RVA: 0x000E1B54 File Offset: 0x000DFD54
		// (set) Token: 0x06003917 RID: 14615 RVA: 0x000E1B6C File Offset: 0x000DFD6C
		[DebuggerNonUserCode]
		public Digest Digest
		{
			get
			{
				return this.digest_;
			}
			set
			{
				this.digest_ = value;
			}
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x06003918 RID: 14616 RVA: 0x000E1B78 File Offset: 0x000DFD78
		[DebuggerNonUserCode]
		public RepeatedField<AccountPartition> Partitions
		{
			get
			{
				return this.partitions_;
			}
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x000E1B90 File Offset: 0x000DFD90
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccountData);
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x000E1BB0 File Offset: 0x000DFDB0
		[DebuggerNonUserCode]
		public bool Equals(AccountData other)
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
					bool flag4 = !object.Equals(this.Digest, other.Digest);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.partitions_.Equals(other.partitions_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x000E1C28 File Offset: 0x000DFE28
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.digest_ != null;
			if (flag)
			{
				num ^= this.Digest.GetHashCode();
			}
			num ^= this.partitions_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600391C RID: 14620 RVA: 0x000E1C84 File Offset: 0x000DFE84
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600391D RID: 14621 RVA: 0x000E1C9C File Offset: 0x000DFE9C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x000E1CA8 File Offset: 0x000DFEA8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.digest_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Digest);
			}
			this.partitions_.WriteTo(ref output, AccountData._repeated_partitions_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600391F RID: 14623 RVA: 0x000E1D0C File Offset: 0x000DFF0C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.digest_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Digest);
			}
			num += this.partitions_.CalculateSize(AccountData._repeated_partitions_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x000E1D70 File Offset: 0x000DFF70
		[DebuggerNonUserCode]
		public void MergeFrom(AccountData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.digest_ != null;
				if (flag2)
				{
					bool flag3 = this.digest_ == null;
					if (flag3)
					{
						this.Digest = new Digest();
					}
					this.Digest.MergeFrom(other.Digest);
				}
				this.partitions_.Add(other.partitions_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x000E1DEE File Offset: 0x000DFFEE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003922 RID: 14626 RVA: 0x000E1DFC File Offset: 0x000DFFFC
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.partitions_.AddEntriesFrom(ref input, AccountData._repeated_partitions_codec);
					}
				}
				else
				{
					bool flag = this.digest_ == null;
					if (flag)
					{
						this.Digest = new Digest();
					}
					input.ReadMessage(this.Digest);
				}
			}
		}

		// Token: 0x04001A9E RID: 6814
		private static readonly MessageParser<AccountData> _parser = new MessageParser<AccountData>(() => new AccountData());

		// Token: 0x04001A9F RID: 6815
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001AA0 RID: 6816
		public const int DigestFieldNumber = 1;

		// Token: 0x04001AA1 RID: 6817
		private Digest digest_;

		// Token: 0x04001AA2 RID: 6818
		public const int PartitionsFieldNumber = 2;

		// Token: 0x04001AA3 RID: 6819
		private static readonly FieldCodec<AccountPartition> _repeated_partitions_codec = FieldCodec.ForMessage<AccountPartition>(18U, AccountPartition.Parser);

		// Token: 0x04001AA4 RID: 6820
		private readonly RepeatedField<AccountPartition> partitions_ = new RepeatedField<AccountPartition>();
	}
}
